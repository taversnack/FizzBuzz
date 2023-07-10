using FizzBuzz.Console.Interfaces;

namespace FizzBuzz.Console.Types.Rules
{
    public class BuzzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number)
        {
            return number % Constants.BuzzDivisor == 0;
        }

        public string GetOutput()
        {
            return "Buzz";
        }
    }
}
