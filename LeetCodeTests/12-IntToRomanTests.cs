public class IntToRomanTests
{
    [Theory]
    [InlineData(100, "C")]
    [InlineData(2495, "MMCDXCV")]
    public void IntToRoman_Method_Returns_Valid_Results(int number, string expectedResult)
    {
        string result;

        result = IntToRoman.Calculate(number);

        Assert.Equal(result, expectedResult);
    }
}
