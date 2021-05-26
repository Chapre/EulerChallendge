using System.Collections.Generic;

namespace ChapreEuler
{
    public static class Helpers
    {
        public static string Display<T>(this IEnumerable<T> list)
        {
            if (list == null)
                return string.Empty;
            return $"{string.Join(", ", list)}";
        }
    }
}
