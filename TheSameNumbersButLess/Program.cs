using TheSameNumbersButLess.ToLessNimbersConverter;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Programm 
{
    static void Main(string[] args) 
    {
        Console.WriteLine(ToLessNumbersCoverter.NumbersConverter(21));
        Console.WriteLine(ToLessNumbersCoverter.NumbersConverter(531));
        Console.WriteLine(ToLessNumbersCoverter.NumbersConverter(2071));

        Console.WriteLine(ToLessNumbersCoverter.NumbersConverter(9));
        Console.WriteLine(ToLessNumbersCoverter.NumbersConverter(111));
        Console.WriteLine(ToLessNumbersCoverter.NumbersConverter(135));
        Console.WriteLine(ToLessNumbersCoverter.NumbersConverter(1027));

    }
}