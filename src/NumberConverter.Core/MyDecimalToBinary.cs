using Imp = NumberConverter.Core.DecimalToBinary;

namespace NumberConverter.Core
{
    public class MyDecimalToBinary : IDecimalToBinary
    {
        public string ConvertToString(uint decNumber) =>
            Imp.ConvertToString(decNumber);
    }
}
