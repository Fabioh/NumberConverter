using System;

namespace NumberConverter.Core
{
    public class SystemDecimalToBinary : IDecimalToBinary
    {
        public string ConvertToString(uint decNumber) =>
            Convert.ToString(decNumber, 2);
    }
}
