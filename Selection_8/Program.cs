using Selection_8.Stacks;
using Selection_8.Stopwatchs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Selection_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Example Stopwatch");
            //var stopWatch = new Stopwatch();

            //for (var i = 0; i < 2; i++)
            //{
            //    stopWatch.Start();

            //    Thread.Sleep(1000);

            //    //for (var j = 0; j < 1000; j++)
            //    //    Thread.Sleep(1);
            //}

            ////stopWatch.StartTime = DateTime.Today.Add(1);
            ////stopWatch.EndTime = DateTime.Today.AddYears(-1);
            ////stopWatch.Start(DateTime.Now);
            ////stopWatch.Stop(DateTime.Now.AddYears(-1));

            //stopWatch.Stop();

            //Console.WriteLine("Duration : ", stopWatch.GetInterval());
            //Console.WriteLine("Press Enter to run the stopwatch one more time.");

            Console.WriteLine("=======================");
            Console.WriteLine("Example stack");

            Stak _stack = new Stak();

            int ini = 0;
            int max = 5;

            for (int i = ini; i <= max; i++)
                _stack.Push(i);
            
            for(int i = ini; i <= max; i++)
                Console.WriteLine(_stack.Pop());
            Console.ReadLine();


            Console.ReadLine();

        }
    }
}
