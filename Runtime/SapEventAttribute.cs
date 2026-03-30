using System;
using UnityEngine.Scripting;

namespace Sappy
{
    /// <summary>
    /// Sap event delivered by a SapStem. Subscriptions to it must be cached.
    /// </summary>
    [AttributeUsage(AttributeTargets.Event)]
    public class SapEventAttribute : PreserveAttribute { }
}