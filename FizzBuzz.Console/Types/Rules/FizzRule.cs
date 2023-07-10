using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz.Console.Interfaces;

namespace FizzBuzz.Console.Types.Rules
{
    public class FizzRule : IFizzBuzzRule
    {
        public bool IsMatch(int number)
        {
            return number % Constants.BuzzDivisor == 0;
        }

        public string GetOutput()
        {
            return "Fizz";
        }
    }
}
