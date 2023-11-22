public class PalindromeIntegerTests
{
    [Theory]
    [InlineData(100, false)]
    public void IntToRomanTests_Method_Returns_Valid_Results(int number, bool expectedResult)
    {
        bool result;

        result = PalindromeInteger.IsPalindrome(number);

        Assert.Equal(result, expectedResult);
    }
}
