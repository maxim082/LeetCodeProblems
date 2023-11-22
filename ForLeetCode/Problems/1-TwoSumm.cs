using System;
using System.Collections.Generic;
using System.Linq;

namespace ForLeetCode
{
    public static class TwoSumm
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (seen.ContainsKey(target - nums[i]))
                {
                    return new int[] { seen[target - nums[i]], i };
                }

                if (!seen.ContainsKey(nums[i]))
                {
                    seen.Add(nums[i], i);
                }

            }
            return null;
        }
    }
}
