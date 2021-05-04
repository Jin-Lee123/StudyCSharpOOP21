namespace InterfaceTestApp
{
    //약속이다. 이 ILogger를 구현(상속)하게 되면 아래의 액션을 무조건!!!! 구현 해야 한다.
    interface ILogger
    {
        void WriteLog(string message); //하나의 메세지를 받아서 처리할 것
        void WriteError(string error); //메서드 추가
    }
}
