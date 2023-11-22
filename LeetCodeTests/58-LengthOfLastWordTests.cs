public class LengthOfLastWordTests
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("luffy is still joyboy", 6)]
    public void LengthOfLastWord_Method_Returns_Valid_Results(string input, int output)
    {
        int result;

        result = LengthOfLastWord.Calculate(input);

        Assert.Equal(result, output);
    }
}
