using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.DelegateTimer
{
    public delegate void TimerDelegate();

    public class Timer
    {
        private int timeSeconds { get; set; }
        private int duration { get; set; }
        private TimerDelegate method { get; set; }

        public Timer(int duration, int timeSeconds, TimerDelegate method)
        {
            this.duration = duration;
            this.timeSeconds = timeSeconds;
            this.method = method;
        }

        public void Run()
        {
            for (int i = 0; i < timeSeconds; i++)
            {

                System.Threading.Thread.Sleep(duration * 1000);
                method();
            }
        }
    }

    class Program
    {
        

        static void Main(string[] args)
        {
            var timer = new Timer(1, 5, test);
            timer.Run();

        }

        static void test()
        {
            Console.WriteLine("test");
        }
    }
}
