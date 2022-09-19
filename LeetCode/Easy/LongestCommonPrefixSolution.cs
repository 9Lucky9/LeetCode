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
            var strsList = strs.ToList();
            var maxPrefix = strsList.MinBy(x => x.Length);
            var maxPrefixCount = maxPrefix.Length;
            strsList.Remove(maxPrefix);
            for(int i = 0; i < maxPrefixCount; i++)
            {
                var matchCount = strsList.Select(x => x.StartsWith(maxPrefix));
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
