using System;
using System.Threading;

namespace BasicThreadTest.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoSometing();
            Thread th1 = new Thread(DoSometing);
            th1.Start();
            //th1.Join();  //스레드 종료대기
            DoOtherting();

            //th1.Abort();  //더이상 사용안함
            th1.Interrupt();
        }

        private static void DoOtherting()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherting : {i}");
                Thread.Sleep(10);  //10ms
            }
        }

        private static void DoSometing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoSomting : {i}");
                Thread.Sleep(10);  //10ms
            }
        }
    }
}
