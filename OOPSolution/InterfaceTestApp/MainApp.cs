using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("콘솔로거 사용합니다.");

            ILogger logger = new ConsoleLogger();
            logger.WriteLog("기본 콘솔 로그입니다.");
            logger.WriteError("에러메세지!!!!!");
            
            ILogger logger2 = new ClimateLogger();
            logger2.WriteLog("흐림//");
            //logger2.WriteError("!!!!!"); // 실행오류(예외)발생

            ILogger clmLogger = new FileLogger();  //ver1.0 ClimateLogger -> FileLogger 변경
            clmLogger.WriteLog("맑음");
            clmLogger.WriteError("문제 발생!");

            
        }
    }
}
