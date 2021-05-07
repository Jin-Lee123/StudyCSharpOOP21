using System;

namespace GenericTestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic 사용 배열카피!");
            //int 배열을 int배열로 복사!!!!!!!!!!!!!!
            int[] sourecInt = { 1, 2, 3, 4, 5 };
            int[] targetInt = new int[sourecInt.Length];  //5개짜리 int 배열  //{0,0,0,0,0}

            Console.WriteLine("복사전 targetInt값---------");  //복사전
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<int>(sourecInt, targetInt);
            Console.WriteLine("복사후 targetInt값---------");   //복사후
            foreach (var item in targetInt)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();


            //float 배열을 float배열로 복사!!!!!!!!!!!!!!
            float[] sourceFloat = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
            float[] targetFloat = new float[sourceFloat.Length];

            Console.WriteLine("복사전 targetFloat값---------");  //복사전
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<float>(sourceFloat, targetFloat);
            Console.WriteLine("복사후 targetFloat값---------");   //복사후
            foreach (var item in targetFloat)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            //string 배열을 string배열로 복사!!!!!!!!!!!!!!
            string[] sourceString = { "하나", "둘", "셋", "넷", "다섯" };
            string[] targetString = new string[sourceString.Length];

            Console.WriteLine("복사전 targetString값---------");  //복사전
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            CopyArray<string>(sourceString, targetString);
            Console.WriteLine("복사후 targetString값---------");   //복사후
            foreach (var item in targetString)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
        }

        private static void CopyArray<T>(T[] source, T[] target)  //일반화 메서드 통일
        {
            for (int i = 0; i < source.Length; i++)
                target[i] = source[i];
        }
    }
}
