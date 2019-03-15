using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProgrammingCSharpExam
{
    public class _1_3_UsingtheParameterizedThreadStart
    {
        public static void Execute()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(ThreadMethod));
            thread.Start(5);

            Console.ReadKey();
        }

        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
    }
}
