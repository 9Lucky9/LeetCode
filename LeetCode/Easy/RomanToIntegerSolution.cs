namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public static class RomanToIntegerSolution
    {
        private static readonly Dictionary<char, int> _romanianToInteger = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500},
            { 'M', 1000}
        };

        public static int RomanToInteger(string s)
        {
            var rawIntegerNumbers = s.Select(x => _romanianToInteger.GetValueOrDefault(x)).ToList();
            rawIntegerNumbers.Reverse();
            var combinations = new List<int>();
            for(int i = 0; i < rawIntegerNumbers.Count;)
            {
                var combination = rawIntegerNumbers.Skip(i).TakeWhile(x => x == rawIntegerNumbers[i]);
                if(combination.Count() == 1)
                {
                    combinations.Add(combination.First());
                }
                else
                {
                    combinations.Add(combination.Sum());
                }
                i += combination.Count();
            }

            var result = combinations.First();
            if(combinations.Count > 1)
            {
                for (int j = 1; j < combinations.Count; j++)
                {
                    if (result > combinations[j])
                    {
                        result -= combinations[j];
                    }
                    else
                    {
                        result += combinations[j];
                    }
                }
            }
            return result;
        }

    }
}
