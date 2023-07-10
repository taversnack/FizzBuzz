using FizzBuzz.Console.Interfaces;

namespace FizzBuzz.Console.Types.Rules
{
    public class FizzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number)
        {
            return number % Constants.FizzDivisor == 0;
        }

        public string GetOutput()
        {
            return "Fizz";
        }
    }
}
