using System;

namespace Exercise_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.WriteLine("Enter the 5 numbers");
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
                double num = Convert.ToDouble(Console.ReadLine());
                sum += num;
            }
            double average = sum / 5;
            Console.WriteLine( $"The Average is:{average}");
        }
    }
}
