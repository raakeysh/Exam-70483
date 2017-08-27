using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_70483_Threads
{
    class Program
    {
        public static void ThreadMethod()
        {
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine("Inside main {0}", i );
                Thread.Sleep(TimeSpan.FromSeconds(2));
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread Do some work {0}", i);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }

        
    }
}
