using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using static NumberConverter.Core.DecimalToBinary;

namespace NumberConverter.Test
{
    public class DecimalToBinaryTests
    {
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
        public void ConvertUint(uint decNumber, string exppected) =>
            ConvertToString(decNumber)
                .Should()
                .Be(exppected);
        
    }
}
