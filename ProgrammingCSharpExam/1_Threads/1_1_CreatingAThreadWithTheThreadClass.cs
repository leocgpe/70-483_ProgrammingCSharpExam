﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProgrammingCSharpExam
{
    public class _1_1_CreatingAThreadWithTheThreadClass
    {
        public static void Execute()
        {
            Thread thread = new Thread(new ThreadStart(ThreadMethod));
            thread.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(0);
            }

            thread.Join();

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
