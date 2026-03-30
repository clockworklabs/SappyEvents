using System;
using UnityEngine.Scripting;

namespace Sappy
{
    /// <summary>
    /// Make Sappy recommendations. Requires SAPPY_ERRORS or SAPPY_WARNINGS.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class SappyAttribute : PreserveAttribute { }
}