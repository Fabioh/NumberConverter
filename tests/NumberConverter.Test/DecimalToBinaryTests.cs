using FluentAssertions;
using NumberConverter.Core;
using System;
using Xunit;

namespace NumberConverter.Test
{
    public class DecimalToBinaryTests
    {
        private static readonly IDecimalToBinary _myConverter = new MyDecimalToBinary();
        private static readonly IDecimalToBinary _systemConverter = new SystemDecimalToBinary();

        [InlineData(1, "1")]
        [InlineData(2, "10")]
        [InlineData(3, "11")]
        [InlineData(5, "101")]
        [InlineData(7, "111")]
        [InlineData(33, "100001")]
        [InlineData(50, "110010")]
        [InlineData(72, "1001000")]
        [InlineData(1024, "10000000000")]
        [InlineData(2000, "11111010000")]
        [Theory]
        public void My_Convert_Integer_To_Binary_String(uint decNumber, string exppected) =>
            _myConverter.ConvertToString(decNumber)
                .Should()
                .Be(exppected);

        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        [InlineData(33)]
        [InlineData(50)]
        [InlineData(72)]
        [InlineData(1024)]
        [InlineData(2000)]
        [Theory]
        public void Convert_Integer_To_Binary_String_Equals_System_Conversion(uint decNumber)
        {
            _myConverter.ConvertToString(decNumber)
                .Should()
                .Be(Convert.ToString(decNumber, 2));
        }

        [InlineData(1, "1")]
        [InlineData(2, "10")]
        [InlineData(3, "11")]
        [InlineData(5, "101")]
        [InlineData(7, "111")]
        [InlineData(33, "100001")]
        [InlineData(50, "110010")]
        [InlineData(72, "1001000")]
        [InlineData(1024, "10000000000")]
        [InlineData(2000, "11111010000")]
        [Theory]
        public void System_Convert_Integer_To_Binary_String(uint decNumber, string exppected) =>
            _systemConverter.ConvertToString(decNumber)
                .Should()
                .Be(exppected);
    }
}
