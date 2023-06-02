

public class PalindromeShould
{
    [Theory]
    [InlineData("casa",false)]
    [InlineData("Átale, demoníaco Caín, o me_delata",true)]
    [InlineData("Ana lava lana.",true)]
    [InlineData("Mercado Libre",false)]
    public void ReturnsBool_WhenCheckPalindrome(string word, bool expectedResult)
    {
        // arrange
        var sut = new Palindrome();

        // act 
        var result = sut.IsPalindrome(word);

        // assert 
        Assert.Equal(expectedResult,result);
    }
}