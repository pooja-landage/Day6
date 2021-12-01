using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Day6Program
{
    public class StopwatchTime
    {
        public void IterateOverloop()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i+" ");
            }

        }
        public void Time()
        {
            Stopwatch stopWat = new Stopwatch();
            stopWat.Start();
            IterateOverloop();
            stopWat.Stop();
            Console.WriteLine("Time elapsd :{0} ",stopWat.ElapsedMilliseconds);
        }
    }
}
