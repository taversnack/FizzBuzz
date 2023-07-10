namespace FizzBuzz.Console.Interfaces
{
    public interface IFizzBuzzRule
    {
        bool IsMatch(int number);
        string GetOutput();
    }
}
