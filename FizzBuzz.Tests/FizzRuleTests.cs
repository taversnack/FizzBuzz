namespace FizzBuzz.Tests
{
    public class FizzRuleTests : IFizzBuzzRuleTest
    {
        readonly FizzRule _fizzRule;
        public FizzRuleTests()
        {
            _fizzRule = new FizzRule();
        }

        [Fact]
        public void FizzRule_ShouldMatchDivisor()
        {
            Assert.True(ShouldMatchDivisor(3));
        }

        [Fact]
        public void FizzRule_ShouldNotMatchDivisor()
        {
            Assert.False(ShouldMatchDivisor(9));
        }

        [Fact]
        public void FizzRule_ShouldMatch()
        {
            Assert.True(ShouldMatch(9));
        }

        [Fact]
        public void FizzRule_ShouldNotMatch()
        {
            Assert.False(ShouldMatch(10));
        }

        public bool ShouldMatch(int number)
        {
            return _fizzRule.IsMatch(number);
        }

        public bool ShouldMatchDivisor(int divisor)
        {
            return divisor == Constants.FizzDivisor;
        }
    }
}