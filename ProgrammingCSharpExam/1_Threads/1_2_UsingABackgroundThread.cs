using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProgrammingCSharpExam
{
    public class _1_2_UsingABackgroundThread
    {
        public static void Execute()
        {
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.IsBackground = true;
            thread.Start();

            Console.ReadKey();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}
