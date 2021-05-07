using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTestApp
{
    delegate void EventHandler(string message);  //대리자 선언
   class MyNotifier
    {
        public event EventHandler SometingHappened;

        public void DoSometing(int number)
        {
            int temp = number % 10;
            if (temp != 0 && temp % 3 == 0)  //3 6 9 틀렷음 ㅎㅎ
            {
                SometingHappened($"짝!\t");
            }
            else
            {
                SometingHappened($"{number}\t");
            }
        }
    }
}
