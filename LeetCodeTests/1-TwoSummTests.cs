using System;

public class TwoSummTests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 3, 1, 1, 2 }, 9, null)]
    public void Calculate_TwoSumm_Method_Returns_Valid_Results(int[] numbers, int target, int[] expectedResult)
    {
        int[] result;

        result = TwoSumm.Calculate(numbers, target);

        Assert.Equal(result, expectedResult);
    }
}


