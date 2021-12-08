using System;

namespace _11321
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logarithm calculation");
            Console.Write("Enter x:");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter base of logarithm:");
            double baze = double.Parse(Console.ReadLine());

            double result = Math.Log(x, baze);
            Console.WriteLine(result);

        }
    }
}
