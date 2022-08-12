using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class ReverseNumber
    {
        public ReverseNumber()
        {
            int num, reverse = 0, rem;
            Console.Write("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                rem = num % 10;
                reverse = reverse * 10 + rem;
                num /= 10;
            }
            Console.Write("Reversed Number: " + reverse);
        }
    }
}
