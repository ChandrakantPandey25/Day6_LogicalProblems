using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Problems");
            Console.WriteLine("Enter 1 for Fibonacci Series");
            Console.WriteLine("Enter 2 for Perfect Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfectNum = new PerfectNumber();
                    break;
                default:
                    Console.WriteLine("Enter Valid Number");
                    break;
            }
                
        }
    }
}
