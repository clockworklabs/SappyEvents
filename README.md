# Sappy
Event driven programming should be fast. Especially in video games, where every CPU cycle and byte of memory counts. **Sappy** helps you achieve this.

## The problem
There are actually two problems with regular C# events in Unity.

1. Every time you pass a method group as a lambda, a new delegate instance is allocated. This creates garbage.
2. Under the hood, C# holds an array for each event. Every time you subscribe or unsubscribe (`OnEvent += Callback;`), a new array is created and the previous content is copied. This not only creates garbage but it's also really slow.

## Sappy to the Rescue!
In **Sappy**, we apply a tree analogy to event handling: we have Sap (event data) delivered to Sap Targets (event listeners) by Sap Stems (event handlers).

### `SapTarget`
**Sappy** generates cached delegates for your methods so that you can use them instead of passing a method group directly as a lambda (and avoid creating garbage). To achieve this, you just need to add the `[SapTarget]` attribute to your method.

```csharp
[SapTarget]
private void MyMethod() 
{
    // ...
}

private void OtherMethod(Action callback) 
{
    // ...
}

// ↓↓↓ Before Sappy 😞☔ ↓↓↓
private void SadInit() 
{
    InterestingObject.OnInterestingEvent += MyMethod;
    OtherMethod(MyMethod);
}
// ↑↑↑ Before Sappy 😞☔ ↑↑↑

// ↓↓↓ After Sappy 😀☀️ ↓↓↓
private void HappyInit() 
{
    InterestingObject.OnInterestingEvent += Sappy.MyMethod; // Garbage avoided! ✅
    OtherMethod(Sappy.MyMethod); // Garbage avoided! ✅
}
// ↑↑↑ After Sappy 😀☀️ ↑↑↑
```

But what is `Sappy.MyMethod`? We haven't defined it anywhere in our class. No, **Sappy** did. **Sappy** requires the enclosing class to be `partial` so it can generate a new source file for the same class, adding the cached delegate.

```csharp
// ↓↓↓ User Code ↓↓↓
public partial class MyClass 
{
    public MyClass() 
    {
        InterestingObject.OnInterestingEvent += Sappy.MyMethod;
    }
    
    [SapTarget]
    private void MyMethod() {
        // ...
    }
}
// ↑↑↑ User Code ↑↑↑

// ↓↓↓ Sappy Generated ↓↓↓
// (Simplified for illustrative purposes, real generated code defines a SapTarget<Action>)
public partial class MyClass 
{
    private SappyGroup _sappyGroup;
    private SappyGroup SappyGroup => _sappyGroup ??= new SappyGroup(this);
    
    private class SappyGroup 
    {
        private MyClass Instance { get; }
        
        public SappyGroup(MyClass instance) 
        {
            Instance = instance;
        }
        
        private Action _MyMethod;
        public Action MyMethod => _MyMethod ??= Instance.MyMethod;
    }
}
// ↑↑↑ Sappy Generated ↑↑↑
```

By default, **Sappy** creates `Action` and `Func` delegates. You can define a different delegate type if necessary.

```csharp
[SapTarget(typeof(MyCustomDelegateType))]
private void MyMethod()
{
    // ...
}
```

`SapTargets` are generated as part of a group. You can override the default "Sappy" name.

```csharp
public partial class MyClass 
{
    public MyClass() 
    {
        InterestingObject.OnInterestingEvent += CachedDelegates.MyMethod;
    }
    
    [SapTarget(groupName: "CachedDelegates")]
    private void MyMethod() {
        // ...
    }
}
```

You can also avoid the nested class for your group and instead prefix the group name. This is useful if you want to have access to the `SapTarget` from outside the class (the generated delegate will have the same accessibility modifier as the method).

```csharp
public partial class MyClass 
{
    public MyClass() 
    {
        InterestingObject.OnInterestingEvent += SappyMyMethod;
    }
    
    [SapTarget(nested: false)]
    public void MyMethod() {
        // ...
    }
}
```

### `SapStem`
As we mentioned before, C# creates and copies arrays _every single time_ we subscribe to or unsubscribe from an event. This may sound like madness. Because it is.

Of course there are workarounds and things you can do when performance is critical (like creating a `MulticastDelegate` with `Delegate.Combine` to skip a lot of the `Array.Copy` calls). Well, with **Sappy**, none of that is necessary.

You can instead create a `SapStem` to handle your event, which internally uses a resizable list of delegates (and can also lazy initialize a `MulticastDelegate` if necessary).

```csharp
 // ↓↓↓ Before Sappy 😞☔ ↓↓↓
public partial class MySadClass 
{
    public event Action<int> OnInterestingEvent;
    
    // ...
    
    private void DoTheThing() 
    {
        // ...
        
        OnInterestingEvent?.Invoke(5);
    }
}

public partial class MyOtherSadClass 
{
    public MyOtherSadClass(MySadClass interestingObject) 
    {
        interestingObject.OnInterestingEvent += DoUpdate;
    }
    
    private void DoUpdate() 
    {
        // ...
    }
}
// ↑↑↑ Before Sappy 😞☔ ↑↑↑

 // ↓↓↓ After Sappy 😀☀️ ↓↓↓
public partial class MyHappyClass 
{
    private SapStem<int> OnInterestingEventStem { get; } = new();
    public SapTargets<int> OnInterestingEvent => OnInterestingEventStem.Targets;
    
    // ...
    
    private void DoTheThing() 
    {
        // ...
        
        OnInterestingEventStem.Send(5);
    }
}

public partial class MyOtherHappyClass 
{
    public MyOtherHappyClass(MyHappyClass interestingObject) 
    {
        interestingObject.OnInterestingEvent.Register(Sappy.DoUpdate); // Garbage and Array.Copy avoided! ✅
    }
    
    [SapTarget]
    private void DoUpdate() 
    {
        // ...
    } 
}
// ↑↑↑ After Sappy 😀☀️ ↑↑↑
```

> [!TIP]
> If you're using a third party library, you may have no control over the event handling but you can still create and use `SapTarget`s to avoid some garbage creation.

The result of using `SapStem` is much, _much_ faster subscriptions, virtually free unsubscriptions and resubscriptions and much less garbage created.

The trade off might be negligible slower event invocations. If you notice your event invocations to be underperforming in a meaningful way, you can opt to internally use a `MulticastDelegate` instead.

```csharp
private SapStem<int> OnEventStem { get; } = new(createMulticastDelegate: true);
```

When a `SapStem` creates a `MulticastDelegate`, the first invocation after the listeners have changed will always recompute the `MulticastDelegate` and take some extra time... but with all the time you saved in subscriptions and unsubscriptions, you have plenty to spare! Well, maybe not, but rest assure that all the following invocations (as long as the listeners don't change) will perform exactly the same as its native C# counterpart (because they're effectively doing the same).

## Why the name?
Sap is tacky and sticky and in **Sappy**, everything sticks around!

<sub>We also tried to pick a name that would cause no naming conflicts in your classes. We felt pretty safe about "Sappy".</sub>

## The Numbers
We created a benchmark that
1. Subscribes 1000 different listeners.
2. Triggers the event 50 times.
3. Unsubscribes all 1000 listeners.
4. Repeats steps 1-3 30 times.

We run this benchmark 500 times. These are the results:

|                   | Plain C# (Editor) | Sappy (Editor)           | Plain C# (IL2CPP Build) | Sappy (IL2CPP Build)    |
|-------------------|-------------------|--------------------------|-------------------------|-------------------------|
| 1. Subscription   | 1.50ms            | _0.27ms_ (5.5x faster)   | 1.41ms                  | _0.27ms_ (5.2x faster)  |
| 2. Resubscription | 1.46ms            | _0.05ms_ (29.2x faster)  | 1.40ms                  | _0.06ms_ (23.3x faster) |
| 3. Invocation     | 0.02ms            | 0.02ms                   | 0.01ms                  | 0.01ms                  |
| 4. Unsubscription | 10.62ms           | _0.04ms_ (265.5x faster) | 4.95ms                  | _0.07ms_ (70.7x faster) |

On top of this, plain C# created _a lot_ more garbage.

You can find the Benchmark Scene in Samples and play with it.

## Installation
Installing Sappy is simple. You can add the package via the Unity Package Manager using the Git URL, or by modifying your `manifest.json` file directly.

Add the following package URL: `https://github.com/clockworklabs/SappyEvents.git#[target-version]` (latest is `1.0.0`).

### Source Generator
1. Open the **Package Manager**.
2. Select the **Sappy** package.
3. Go to the **Samples** tab and import **Source Generator**.
4. In your project assets, locate the imported `SappyGenerator.dll`.
5. **Crucial Step:** In the Inspector for the DLL:
  - Ensure the **Select platforms for plugin** list is empty (no platforms selected).
  - Add (if not present already) the `RoslynAnalyzer` label.
