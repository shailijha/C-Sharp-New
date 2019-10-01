using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExercise
{
    public class Stopwatch
    {
        private DateTime startTime;
        private DateTime endTime;
        //private TimeSpan startTime = new TimeSpan(0,0,0);
        //private TimeSpan endTime;
        //private bool stopFlag = true;

        public Stopwatch()
        {
            //this.endTime = new TimeSpan(1);
            
        }
        
        public void Start()
        {
            startTime = DateTime.Now;

            //while (this.stopFlag)
            //{
            //    endTime = endTime.Add(TimeSpan.FromTicks(1));
            //    //Console.WriteLine(this.endTime);
            //}
        } 

        public TimeSpan Stop()
        {
            endTime = DateTime.Now;
            TimeSpan interval = endTime - startTime;
            return interval.Duration();
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();

            Console.WriteLine(sw.Stop());

            //Console.WriteLine(sw.Duration());
        }
    }
}
