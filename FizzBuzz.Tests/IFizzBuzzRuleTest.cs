namespace FizzBuzz.Tests
{
    public interface IFizzBuzzRuleTest
    {
        bool ShouldMatch(int number);
        bool ShouldMatchDivisor(int divisor);
    }
}