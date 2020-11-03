using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 00;
            int minutes = 00;
            int seconds = 00;

            Console.Write("Enter number of seconds: ");
            seconds = int.Parse(Console.ReadLine());

            hours = seconds / 3600;
            seconds -= hours * 3600;

            minutes = seconds / 60;
            seconds -= minutes * 60;

            Console.Write(hours + ":" + minutes + ":" + seconds);

            Console.ReadKey();
        }
    }
}
