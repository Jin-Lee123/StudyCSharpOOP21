using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class FileLogger : ILogger //ver 1.2에서 업데이트
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"file error : {error}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"파일 txt,log에 저장 : {message}");
        }
    }
}
