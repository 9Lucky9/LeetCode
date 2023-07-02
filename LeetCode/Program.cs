using BenchmarkDotNet.Running;
using LeetCode.Benchmarks.Easy;
using LeetCode.Easy;

//Random Random = new Random();

//string romanian1 = "III";
//string romanian2 = "LVIII";
//string romanian3 = "MCMXCIV";

//Console.WriteLine((RomanToIntegerSolution.RomanToInteger(romanian3)).ToString());

//var strs = new string[] { "flower", "flow", "flight" };

//Console.WriteLine(LongestCommonPrefixSolution.LongestCommonPrefix(strs));

//Console.ReadLine();

//var pl = new PalindromeNumber();
//var number = 16461;
//var number2 = 164461;
//var number2 = 10;

var result = BenchmarkRunner.Run<PalindromeNumberBenchmark>();

//Console.WriteLine(pl.IsPalindrome(number2));
//Console.WriteLine(pl.IsPalindromeStringBuilder(number2));
//Console.WriteLine(pl.IsPalindromeOneWay(number2));