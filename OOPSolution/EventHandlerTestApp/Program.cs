using System;

namespace EventHandlerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3,6,9 3,6,9");
            MyNotifier notifier = new MyNotifier();
            notifier.SometingHappened += new EventHandler(MyHanmdler);

            for (int i = 1; i < 100; i++)
            {
                notifier.DoSometing(i);
            }
        }

        private static void MyHanmdler(string message)
        {
            Console.Write(message);
        }
    }
}
