using System;
namespace InterfaceTestApp
{
    class ClimateLogger : ILogger // ver 1.1
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(string weather)
        {
            Console.WriteLine($"날씨로그[{DateTime.Now.ToShortDateString()}] : 현재날씨{weather}");
        }
    }
}
