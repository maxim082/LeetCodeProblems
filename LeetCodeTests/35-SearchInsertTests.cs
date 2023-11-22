public class SearchInsertTests
{
    [Theory]
    [InlineData(new int[] { 1, 3, 5, 6 }, 4, 2)]
    public void LengthOfLastWord_Method_Returns_Valid_Results(int[] nums, int target, int output)
    {
        int result;

        result = SearchInsert.Calculate(nums, target);

        Assert.Equal(result, output);
    }
}
