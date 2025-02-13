using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class CalculateTimeOfExecution
    {
        public void StopWatchTime()
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            CalculateTimeOfExecution.CalculateTime();

            stopwatch.Stop();
            Console.WriteLine($" Execution time = {stopwatch.ElapsedMilliseconds}ms"); 
        }
        public static void CalculateTime()
        {
            for (int i = 0; i < 100000000; i++)
            {
                Math.Sqrt(i);
            }
        }
    }
}
