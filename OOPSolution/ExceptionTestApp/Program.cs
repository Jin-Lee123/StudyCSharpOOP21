using System;

namespace ExceptionTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작!");

            int[] array = new int[5];
            try
            {
                for (int i = 0; i <= 5; i++)
                {

                    array[i] = (i + 1);  //1,2,3,4,5

                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"문제발생 : {ex.Message} 관리자에게 문의 요망 : (Main:15~)");
            }
            
            Console.WriteLine("다른 로직 수행");
            //...

            int[] list = { 107, 108, 109 };
            try
            {
                string message = "Hello";
                Console.WriteLine(message.Length);

                var result = list[1] / 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            /*catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                // indexOutOfRange예외시 다른일 처리
                Console.WriteLine("indexOutOfRangeException 이후 처리!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("DivideByZeroException 이후처리!!");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("입력쫌 제발 제대로 햐야징!!!");
            }*/
            catch(Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");  // 위에는 너무 세밀하니 이거 하나로 퉁치기
            }
            finally
            {
                //14ㅅ이ㅔ
                Console.WriteLine("Finally, 언제든지 실행됨");
            }


            Console.WriteLine("프로그램 종료!");  
        }
    }
}
