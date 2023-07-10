using FizzBuzz.Console.Interfaces;

namespace FizzBuzz.Tests
{
    public class FizzBuzzGameTests
    {
        readonly FizzBuzzGame _fizzBuzzGame;
        public FizzBuzzGameTests()
        {
            int rangeStartNumber = 1; int rangeEndNumber = 15;
            IFizzBuzzRule[] fizzBuzzRules = new IFizzBuzzRule[] {
                new FizzBuzzRule(),
                new FizzRule(),
                new BuzzRule(),
                new DefaultRule()
            };
            _fizzBuzzGame = new FizzBuzzGame(
                rangeStartNumber,
                rangeEndNumber,
                fizzBuzzRules
            );
        }

        [Fact]
        public void FizzBuzzGame_ShouldOutput_CorrectList()
        {
            List<string> expected = new List<string>() {
                "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz",
                "11", "Fizz", "13", "14", "FizzBuzz"
            };
            var outputList = _fizzBuzzGame.GetRangeOutput();
            Assert.True(CompareLists<string>(expected, outputList));
        }

        private bool CompareLists<T>(List<string> list1, List<string> list2)
        {
            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].Equals(list2[i]))
                    return false;
            }

            return true;
        }
    }
}
