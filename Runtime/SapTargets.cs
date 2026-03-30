using System;
using System.Collections.Generic;

namespace Sappy
{
    public class SapTargets : SapDelegate<Action>
    {
        public SapTargets(int? capacity = null) : base(capacity ?? 4) { }
        public SapTargets(int capacity) : base(capacity) { }
    }
    public class SapTargets<T> : SapDelegate<Action<T>>
    {
        public SapTargets(int? capacity = null) : base(capacity ?? 4) { }
        public SapTargets(int capacity) : base(capacity) { }
    }
    public class SapTargets<T1, T2> : SapDelegate<Action<T1, T2>>
    {
        public SapTargets(int? capacity = null) : base(capacity ?? 4) { }
        public SapTargets(int capacity) : base(capacity) { }
    }
    public class SapTargets<T1, T2, T3> : SapDelegate<Action<T1, T2, T3>>
    {
        public SapTargets(int? capacity = null) : base(capacity ?? 4) { }
        public SapTargets(int capacity) : base(capacity) { }
    }
    public class SapTargets<T1, T2, T3, T4> : SapDelegate<Action<T1, T2, T3, T4>>
    {
        public SapTargets(int? capacity = null) : base(capacity ?? 4) { }
        public SapTargets(int capacity) : base(capacity) { }
    }
    public class SapTargets<T1, T2, T3, T4, T5> : SapDelegate<Action<T1, T2, T3, T4, T5>>
    {
        public SapTargets(int? capacity = null) : base(capacity ?? 4) { }
        public SapTargets(int capacity) : base(capacity) { }
    }
    
    public class SapDelegate<T> where T : Delegate
    {
        private int[] _hashes;
        private T[] _delegates;
        private readonly Dictionary<int, int> _indices;

        private int _capacity;
        private int _count;
        
        private bool _dirty;

        private T _resolved;
        public T Resolved
        {
            get
            {
                if (_dirty)
                {
                    T value;
                    if(_count > 0)
                    {
                        var newResolved = new Delegate[_count];
                        Array.Copy(_delegates, newResolved, _count);
                        value = (T)Delegate.Combine(newResolved);
                    }
                    else
                    {
                        value = null;
                    }
                    _resolved = value;
                    _dirty = false;
                }

                return _resolved;
            }
        }

        public int Count => _count;
        
        public T this[int index] => _delegates[index];

        public SapDelegate(int? capacity = null) : this(capacity ?? 4) { }
        public SapDelegate(int capacity)
        {
            _capacity = capacity;
            _hashes = new int[capacity];
            _delegates = new T[capacity];
            _indices = new Dictionary<int, int>(capacity);
            _dirty = true;
        }

        public void Add(SapTarget<T> target)
        {
            if (target == null || !_indices.TryAdd(target.HashCode, _count)) return;
            // if (target == null || !_indices.TryAdd(target.HashCode, _hashes.Count)) return;

            Add(target.HashCode, target.Callback);
        }
        
        public void Remove(SapTarget<T> target)
        {
            if (target == null || _count <= 0 || !_indices.Remove(target.HashCode, out var index)) return;
            var lastTargetIndex = _count - 1;
            if (lastTargetIndex != index)
            {
                var lastTarget = _hashes[lastTargetIndex];
                _indices[lastTarget] = index;
            }
        
            RemoveAtSwapBack(index);
        }

        private void Add(int hashCode, T callback)
        {
            if (_count >= _capacity)
            {
                var newCapacity = _capacity * 2;
                var newHashes = new int[newCapacity];
                Array.Copy(_hashes, newHashes, _capacity);
                _hashes = newHashes;
                var newDelegates = new T[newCapacity];
                Array.Copy(_delegates, newDelegates, _capacity);
                _delegates = newDelegates;
                _capacity = newCapacity;
            }
            
            _hashes[_count] = hashCode;
            _delegates[_count] = callback;
        
            _count = _count + 1;
            
            _dirty = true;
        }
        private void RemoveAtSwapBack(int index)
        {
            var lastIndex = _count - 1;
            if (index < lastIndex)
            {
                _hashes[index] = _hashes[lastIndex];
                _delegates[index] = _delegates[lastIndex];
            }
        
            _count = lastIndex;
            
            _dirty = true;
        }
    }
}