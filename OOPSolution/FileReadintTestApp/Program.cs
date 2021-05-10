using System;
using System.IO;

namespace FileReadintTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));
            while (sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            //텍스트 파일 읽어오는 부분


            string writePath = @"C:\Test\Help\LJ.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));
            
            sw.Write("Hello, world\n");
            sw.Write("안녕하세요\n");
            sw.Write(3.1415952);
            sw.Close(); //필수

            Console.WriteLine("텍스트 파일 작성완료!");
        }
    }
}
