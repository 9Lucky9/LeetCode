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
        /// More eficient.
        /// Complexity time - (On)
        /// </summary>
        public bool IsPalindromeStringBuilder(int x)
        {
            var originalString = x.ToString();
            var stringBuilder = new StringBuilder();
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(originalString[i]);
            }
            return originalString.Equals(stringBuilder.ToString());
        }

        /// <summary>
        /// Complexity time - On/2
        /// </summary>
        public bool IsPalindromeImprovedComplexetyTime(int x)
        {
            if(x < 0)
                return false;
            var stringNumber = x.ToString();
            var j = stringNumber.Length - 1;
            if(j % 2 == 0)
            {
                for(int i = 0; i < j/2; i++)
                {
                    if (stringNumber[i] != stringNumber[j])
                        return false;
                    j--;
                }
            }
            else
            {
                for(int i = 0; i < j/2-1; i++)
                {
                    if (stringNumber[i] != stringNumber[j])
                        return false;
                    j--;
                }
            }
            return true;
        }

        /// <summary>
        /// Use of the Span structure.
        /// Complexity time - On/2
        /// </summary>
        public bool IsPalindromeSpan(int x)
        {
            if (x < 0)
                return false;
            
            var stringNumber = x.ToString().AsSpan();
            var j = stringNumber.Length - 1;
            if (j % 2 == 0)
            {
                for (int i = 0; i < j / 2; i++)
                {
                    if (stringNumber[i] != stringNumber[j])
                        return false;
                    j--;
                }
            }
            else
            {
                for (int i = 0; i < j / 2 - 1; i++)
                {
                    if (stringNumber[i] != stringNumber[j])
                        return false;
                    j--;
                }
            }
            return true;
        }
    }
}
