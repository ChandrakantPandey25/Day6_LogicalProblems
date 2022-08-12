using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumber
    {
        
        public  CouponNumber()
        {
            Console.WriteLine("Enter n coupon  numbers");

           
            int num = Convert.ToInt32(Console.ReadLine());

            bool[] collection = new bool[num];
            int count = 0;
            int distinct = 0;
            Random random = new Random();
            while (distinct < num)
            {
                int i = Convert.ToInt32((random.Next(num)));
                count++;

                
                if (!collection[i])
                {
                    distinct++;
                    Console.WriteLine("total distinct numbers are" + distinct);
                    collection[i] = true;
                }
            }
            Console.WriteLine("total random  numbers needed to make all distinct");
            Console.WriteLine(count);
        }
    }
}
