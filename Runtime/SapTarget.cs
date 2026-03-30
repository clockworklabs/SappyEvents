using System;

namespace Sappy
{
    /// <summary>
    /// 
    /// </summary>
    public class SapTarget<T> where T : Delegate
    {
        public T Callback { get; }
        internal int HashCode { get; }
        
        public SapTarget(T callback)
        {
            Callback = callback ?? throw new ArgumentNullException(nameof(callback));
            HashCode = callback.GetHashCode();
        }
        
        public static implicit operator T(SapTarget<T> sapTarget) => sapTarget.Callback;
    }
}