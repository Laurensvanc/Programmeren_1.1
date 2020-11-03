using System;

namespace assignment1
{
    class Program
    {
        const double VAT = 0.21;

        static Tuple<double, double> VATCalculator(double UserInput)
        {
            double result = 0;

            double VATCosts = UserInput * VAT;

            result = VATCosts + UserInput;
            return Tuple.Create(result, VATCosts);
        }

        static void Main()
        {
            Console.Write("Enter a price: ");
            double PriceValue = double.Parse(Console.ReadLine());

            var values = VATCalculator(PriceValue);
            Console.WriteLine($"price: {Math.Round(PriceValue * 100) / 100}, VAT: {Math.Round(values.Item2 * 100) / 100}, total: {Math.Round(values.Item1 * 100) / 100}");

            Console.ReadKey();
        }
    }
}
