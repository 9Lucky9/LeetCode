using BenchmarkDotNet.Attributes;
using LeetCode.Easy;

namespace LeetCode.Benchmarks.Easy
{
    [MemoryDiagnoser]
    public class LongestCommonPrefixSolutionBenchmark
    {
        private static readonly LongestCommonPrefixSolution _longestCommonPrefix = new LongestCommonPrefixSolution();

        private string[] _strings = new string[3] { "flower", "flow", "flight" };

        [Benchmark]
        public void LongestCommonPrefixLinq() 
        {
            _longestCommonPrefix.LongestCommonPrefixLinq(_strings);
        }
    }
}
