using System;
using System.Collections.Generic;
using System.Text;

namespace ForLeetCode
{
    class Problem1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                for (int k = i - 1; k >= 0; k--)
                {
                    if (nums[i] + nums[k] == target)
                    {
                        return new int[] { i, k };
                    }
                }
            }

            return null;
        }
    }
}
