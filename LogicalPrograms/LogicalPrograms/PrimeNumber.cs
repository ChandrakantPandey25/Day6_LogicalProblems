using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public PrimeNumber()
        {
            int num, i;
            Console.Write("Enter the Number to check Prime: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    Console.Write("Number is not Prime.");

                }
                else
                {
                    Console.Write("Number is Prime.");
                }


            }
        }
    }
}
