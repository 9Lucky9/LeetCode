using System.Text;

namespace LeetCode.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class PalindromeNumber
    {
        /// <summary>
        /// Inbuilt methods.
        /// </summary>
        public bool IsPalindrome(int x)
        {
            if (x.ToString() == string.Concat(x.ToString().Reverse()))
                return true;
            return false;
        }

        /// <summary>
        /// Using String Builder.
        /// </summary>
        public bool IsPalindromeStringBuilder(int x)
        {
            var originalString = x.ToString();
            var stringBuilder = new StringBuilder();
            for(int i = originalString.Length-1; i >= 0; i--)
            {
                stringBuilder.Append(originalString[i]);
            }
            return originalString.Equals(stringBuilder.ToString());
        }
    }
}
