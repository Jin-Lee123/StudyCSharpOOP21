using System;

namespace IndexerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");

            MyList list = new MyList();  //3개짜리 배열
            for (int i = 0; i < 5; i++)
            { 
                list[i] = (i + 1);  //1~5 this[index] set
            }
            Console.WriteLine("For 실행");
            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]); // this[index] get
            }
            Console.WriteLine("Forech 실행");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
