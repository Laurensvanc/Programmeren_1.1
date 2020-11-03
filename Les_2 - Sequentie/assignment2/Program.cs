using System;

namespace assignment2
{
    class Program
    {

        static double calculateAvarage(double i1, double i2, double i3)
        {
            double result = (i1 + i2 + i3) / 3;

            return result;
        }

        static void Main(string[] args)
        {

            Console.Write("Enter 1st number: ");
            double i1 = double.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            double i2 = double.Parse(Console.ReadLine());

            Console.Write("Enter 3rd number: ");
            double i3 = double.Parse(Console.ReadLine());

            double result = calculateAvarage(i1, i2, i3);
            Console.Write("The average is: " + result);

            Console.ReadKey();
        }
    }
}
