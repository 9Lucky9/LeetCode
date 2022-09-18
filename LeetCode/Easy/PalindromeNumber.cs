namespace LeetCode.Easy
{
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
