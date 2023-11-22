public static class SearchInsert
{
    public static int Calculate(int[] nums, int target)
    {
        for (var counter = 0; counter < nums.Length; counter++)
        {
            if (nums[counter] == target || nums[counter] > target)
                return counter;
        }

        return nums.Length;
    }
}

