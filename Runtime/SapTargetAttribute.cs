using System;
using UnityEngine.Scripting;

namespace Sappy
{
    /// <summary>
    /// Create a cached delegate.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class SapTargetAttribute : PreserveAttribute
    {
        public readonly Type delegateType;
        public readonly string groupName;
        public readonly bool nested;

        public SapTargetAttribute(Type delegateType = null, string groupName = "Sappy", bool nested = true)
        {
            this.delegateType = delegateType;
            this.groupName = groupName;
            this.nested = nested;
        }
    }
}