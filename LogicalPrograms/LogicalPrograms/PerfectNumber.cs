using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PerfectNumber
    {
        public PerfectNumber()
        {
            int number, sum = 0, n;
            Console.Write("enter the Number");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(" Entered number is a perfect number");
                
            }
            else
            {
                Console.WriteLine(" Entered number is not a perfect number");
                
            }
        }
    }
    
}
