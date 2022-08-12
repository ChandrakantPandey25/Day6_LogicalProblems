using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class StopWatch
    {
        public StopWatch()
        {
            Console.WriteLine("Press enter to start the stopwatch");
            Console.ReadLine();
            DateTime start = DateTime.Now;
            Console.WriteLine("Press enter to stop the stopwatch");
            Console.ReadLine();
            DateTime stop = DateTime.Now;
            Console.WriteLine("Elapsed time=" + (stop - start));




        }
    }
}
