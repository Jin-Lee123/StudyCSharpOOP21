using System;
using System.Threading;

namespace ThreadLockTestApp
{
    class Counter
    {
        private int counter = 1000;
        private object thisLock = new object();
        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread th = new Thread(UnsafeCalc); //10개 스레드 생성
                th.Start();
            }
        }
        public void UnsafeCalc()
        {
            lock(thisLock)  //lock을 통해서 동기화(다른 스래드가 접근 못하도록)
            {
                counter++;
                Thread.Sleep(1);
                Console.WriteLine(counter);
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Console.WriteLine();
        }
    }
}
