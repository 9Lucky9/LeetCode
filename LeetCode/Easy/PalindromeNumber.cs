namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public static class PalindromeNumber
    {
        public static bool IsPalindrome(int x)
        {
            if (x.ToString() == string.Concat(x.ToString().Reverse()))
                return true;
            return false;
        }
    }
}
