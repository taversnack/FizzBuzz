namespace FizzBuzz.Console.Interfaces
{
    public interface IFizzBuzzGame
    {
        int RangeStartNumber { get; set; }
        int RangeEndNumber { get; set; }
        IFizzBuzzRule[] Rules { get; set; }

        List<string> GetRangeOutput();
    }
}
