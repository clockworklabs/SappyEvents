using System.Text;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;

public class SappyBenchmarkRunner : MonoBehaviour
{
    [SerializeField]
    [UnityEngine.Range(1, 2000)]
    private int _benchamarksCount = 500;
    private int BenchmarksCount => _benchamarksCount;
    [SerializeField]
    [UnityEngine.Range(2, 100)]
    private int _loopsCount = 20;
    private int LoopsCount => _loopsCount;
    [SerializeField]
    [UnityEngine.Range(1, 100)]
    private int _invocationsCount = 30;
    private int InvocationsCount => _invocationsCount;

    [SerializeField]
    private Text _text;
    private Text Text => _text;
    
    private void Start()
    {
        double oldSubscriptionResults = 0;
        double oldResubscriptionResults = 0;
        double oldInvocationResults = 0;
        double oldUnsubscriptionResults = 0;
        double newSubscriptionResults = 0;
        double newResubscriptionResults = 0;
        double newInvocationResults = 0;
        double newUnsubscriptionResults = 0;
        for (var i = 0; i < BenchmarksCount; i++)
        {
            var benchmark = new SappyBenchmark();
            benchmark.GetResults(LoopsCount, InvocationsCount, out var oldSubscription, out var oldResubscription, out var oldInvocation, out var oldUnsubscription, out var newSubscription, out var newResubscription, out var newInvocation, out var newUnsubscription);
            oldSubscriptionResults += oldSubscription;
            oldResubscriptionResults += oldResubscription;
            oldInvocationResults += oldInvocation;
            oldUnsubscriptionResults += oldUnsubscription;
            newSubscriptionResults += newSubscription;
            newResubscriptionResults += newResubscription;
            newInvocationResults += newInvocation;
            newUnsubscriptionResults += newUnsubscription;
        }

        oldSubscriptionResults = oldSubscriptionResults / BenchmarksCount * 1000;
        oldResubscriptionResults = oldResubscriptionResults / BenchmarksCount * 1000;
        oldInvocationResults = oldInvocationResults / BenchmarksCount * 1000;
        oldUnsubscriptionResults = oldUnsubscriptionResults / BenchmarksCount * 1000;
        newSubscriptionResults = newSubscriptionResults / BenchmarksCount * 1000;
        newResubscriptionResults = newResubscriptionResults / BenchmarksCount * 1000;
        newInvocationResults = newInvocationResults / BenchmarksCount * 1000;
        newUnsubscriptionResults = newUnsubscriptionResults / BenchmarksCount * 1000;

        var text = $@"Results (old vs new)
Subscription = {oldSubscriptionResults:0.00}ms vs {newSubscriptionResults:0.00}ms
Resubscription = {oldResubscriptionResults:0.00}ms vs {newResubscriptionResults:0.00}ms
Invocation = {oldInvocationResults:0.00}ms vs {newInvocationResults:0.00}ms
Unsubscription = {oldUnsubscriptionResults:0.00}ms vs {newUnsubscriptionResults:0.00}ms";

        Text.text = text;
        
        Debug.Log(text);
    }
}
