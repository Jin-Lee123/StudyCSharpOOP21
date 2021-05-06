using System;
using System.Collections;

namespace CollectionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//박싱 언박싱
            int a = 123;
            object obj = a;
            int b = (int)obj;
            
            Console.WriteLine("a의 값 : "+a);
            Console.WriteLine("obj의 갑 : " + obj);
            Console.WriteLine("b의 값 : " + b);

            string str = "문자열임";
            obj = str;
            
            Console.WriteLine("str의 값 : " +str);
            Console.WriteLine("obj의 갑 : " + obj);*/


            //-----
            Console.WriteLine("ArrayList 예제");

            ArrayList list = new ArrayList();    //사이즈 지정 안함!
            list.Add(3);
            list.Add(67);
            list.Add(1);
            list.Add(30);
            list.Add(14);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            list.Sort();
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            
            list.Reverse();
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(100);    //추가 간편하죵?
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Insert(2,88);  //[2]에 88 츄가
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.RemoveAt(5);   //위치 삭제
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index100 = list.IndexOf(100);
            Console.WriteLine($"100의 위치 : {index100}");

            list.Remove(88);    //88 요소 삭제!
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(14);   //있던 숫자 또 추가 또 들감 ㅎㅎ
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Add(135);
            list.Add(14);

            int index14 = list.IndexOf(14);
            Console.WriteLine($"14의 위치값 : {index14}");

            int lstindex14 = list.LastIndexOf(14);
            Console.WriteLine($"14의 위치값 : {lstindex14}");

            Console.WriteLine($"총 갯수 : {list.Count}");
            Console.WriteLine($"리스트 마지막 값 {list[list.Count - 1]}");
        }
    }
}
