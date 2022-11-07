namespace FizzBuzz.Tests;

[UsesVerify]
public class FizzBuzzGeneratorTests
{
    [Fact]
    public async Task GenerateUntil()
    {
        var result = FizzBuzzGenerator.GenerateUntil(100);

        var formattedResult = string.Join(
            Environment.NewLine,
            result);

        await Verify(
            formattedResult,
            "txt");
    }
}