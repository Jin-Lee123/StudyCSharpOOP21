using System;
using System.Threading.Tasks;

namespace AsyncTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Caller();
            Console.WriteLine();
           
        }

        private static void Caller()
        {
            Console.WriteLine("Caller A");
            Console.WriteLine("Caller B");

            MyMethodAsync(3); //비동기처리

            Console.WriteLine("Caller E");
            Console.WriteLine("Caller F");
        }

        private async static void MyMethodAsync(int count)
        {
            Console.WriteLine("My C");
            Console.WriteLine("My D");

            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{i} / {count} ...");
                    await Task.Delay(10);
                }
            });

            Console.WriteLine("My G");
            Console.WriteLine("My H");
        }
    }
}
