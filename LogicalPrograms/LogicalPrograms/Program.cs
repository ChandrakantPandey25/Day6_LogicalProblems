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
            Console.WriteLine("Enter 3 for Prime Number");
            Console.WriteLine("Enter 4 to reverse Number");
            Console.WriteLine("Enter 5 to coupon Number");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    break;
                case 2:
                    PerfectNumber perfectNum = new PerfectNumber();
                    break;
                case 3:
                    PrimeNumber primeNum = new PrimeNumber();
                    break;
                case 4:
                    ReverseNumber revNum = new ReverseNumber();
                    break;
                case 5:
                    CouponNumber coupon = new CouponNumber();
                    break;
                default:
                    Console.WriteLine("Enter Valid Number");
                    break;
            }
                
        }
    }
}
