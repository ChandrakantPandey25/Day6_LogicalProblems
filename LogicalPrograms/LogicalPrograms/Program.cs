using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Problems");
            Console.WriteLine("Enter 1 for Fibonacci Series");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    break;
                default:
                    Console.WriteLine("Enter Valid Number");
                    break;
            }
                
        }
    }
}
