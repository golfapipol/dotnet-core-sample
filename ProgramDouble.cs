using System;

namespace dotnet_sample
{
    class ProgramDouble
    {
        static void Main(string[] args)
        {
            double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            Console.WriteLine(d);

            double max = double.MaxValue;
            double min = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);

            decimal minDec = decimal.MinValue;
            decimal maxDec = decimal.MaxValue;
            Console.WriteLine($"The range of decimal is {minDec} to {maxDec}");

            decimal aDec = 1.0M;
            decimal bDec = 3.0M;
            Console.WriteLine(aDec / bDec);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine(area);
        }
    }
}
