using Playground.ClassLibrary.ProgrammingAdvancedCup;

namespace Playground.xUnit.ProgrammingAdvancedCup;

public class CandySharingTests
{
    private readonly CandySharing _candySharing;

    public CandySharingTests()
    {
        _candySharing = new CandySharing();
    }

    [Theory]
    [InlineData("5 5", "0")]
    [InlineData("6 5 4", "1")]
    [InlineData("3 6 9", "3")]
    [InlineData("3 4 4 4", "Infinite")]
    public void Should_Calculate_Ticks(string input, string output)
    {
        Assert.Equal(output, _candySharing.CalculateTicks(input));
    }
}
