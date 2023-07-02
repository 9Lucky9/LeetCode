using BenchmarkDotNet.Attributes;
using LeetCode.Easy;

namespace LeetCode.Benchmarks.Easy
{
    [MemoryDiagnoser]
    public class PalindromeNumberBenchmark
    {
        private static readonly PalindromeNumber _palindromeNumber = new PalindromeNumber();

        private int _number = 164461;

        [Benchmark]
        public void IsPalindromeBenchmark()
        {
            _palindromeNumber.IsPalindrome(_number);
        }

        [Benchmark]
        public void IsPalindromeStringBuilderBenchmark()
        {
            _palindromeNumber.IsPalindromeStringBuilder(_number);
        }

        [Benchmark]
        public void IsPalindromeOneWayBenchmark()
        {
            _palindromeNumber.IsPalindromeImprovedComplexetyTime(_number);
        }
    }
}
