using System.Collections.Concurrent;
using System.Text;

namespace NumberConverter.Core
{
    internal static class DecimalToBinary
    {
        public static string ConvertToString(uint decNumber)
        {
            var stack = new ConcurrentStack<string>();
            var sb = new StringBuilder();
            var initialNumber = decNumber;

            while (initialNumber / 2 > 0)
            {
                stack.Push((initialNumber % 2).ToString());
                initialNumber /= 2;
            }

            stack.Push((initialNumber % 2).ToString());

            while (stack.TryPop(out var val))
            {
                sb.Append(val);
            }

            return sb.ToString();
        }
    }
}
