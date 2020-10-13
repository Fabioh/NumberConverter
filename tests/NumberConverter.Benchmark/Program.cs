using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using NumberConverter.Core;

namespace NumberConverter.Benchmark
{
    public class Program
    {
        public class MyVsSystem
        {
            private readonly IDecimalToBinary _myConverter = new MyDecimalToBinary();
            private readonly IDecimalToBinary _systemConverter = new SystemDecimalToBinary();

            private readonly uint numberDec;

            public MyVsSystem()
            {
                numberDec = (uint)new Random(42).Next();
            }

            [Benchmark]
            public string MyConverter() => _myConverter.ConvertToString(numberDec);

            [Benchmark]
            public string SystemConverter() => _systemConverter.ConvertToString(numberDec);
        }

        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<MyVsSystem>();
        }
    }
}
