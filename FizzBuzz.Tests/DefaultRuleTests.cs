namespace FizzBuzz.Tests
{
    public class DefaultRuleTests : IFizzBuzzRuleTest
    {
        readonly DefaultRule _defaultDefaultRule;
        public DefaultRuleTests()
        {
            _defaultDefaultRule = new DefaultRule();
        }

        [Fact]
        public void DefaultRule_ShouldMatch()
        {
            Assert.True(ShouldMatch(8));
        }

        [Fact]
        public void DefaultRule_ShouldNotMatch()
        {
            Assert.False(ShouldMatch(9));
        }

        public bool ShouldMatch(int number)
        {
            return _defaultDefaultRule.IsMatch(number);
        }

        public bool ShouldMatchDivisor(int divisor)
        {
            return true;
        }
    }
}