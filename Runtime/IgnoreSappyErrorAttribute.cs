using System;
using UnityEngine.Scripting;

namespace Sappy
{
    [AttributeUsage(AttributeTargets.Method)]
    public class IgnoreSappyErrorAttribute : PreserveAttribute { }
}