namespace LeetCode.Easy
{
    public static class TwoSum
    {
        public static int[] SumOfTwo(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        if (i == j)
                            continue;
                        result[1] = i;
                        result[0] = j;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}
