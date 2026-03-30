using System.Collections.Generic;

namespace Sappy
{
    public static class ListExtensions
    {
        public static void RemoveAtSwapBack<T>(this List<T> list, int index)
        {
            var lastIndex = list.Count - 1;
            list[index] = list[lastIndex];
            list.RemoveAt(lastIndex);
        }
    }
}