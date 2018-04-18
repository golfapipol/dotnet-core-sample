using System;

namespace dotnet_sample
{
    class ProgramNumber
    {
        static void Main(string[] args)
        {
            int a = 18;
            int b = 6;
            int c = a + b * 2;
            Console.WriteLine($"Sum: {c}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"Range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"What {what}");
        }
    }
}
