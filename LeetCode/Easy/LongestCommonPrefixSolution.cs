namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public static class LongestCommonPrefixSolution
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            var result = "";
            var maxPrefix = strs.MinBy(x => x.Length);
            var maxPrefixCount = maxPrefix.Length;
            strs = strs.Where(x => x != maxPrefix).ToArray();
            for(int i = 0; i < maxPrefixCount; i++)
            {
                var matchCount = strs.Select(x => x.StartsWith(maxPrefix));
                if (matchCount.All(x => x is true))
                {
                    return maxPrefix;
                }
                maxPrefix = maxPrefix.Remove(maxPrefix.Length-1);
            }
            return result;
        }
    }
}
