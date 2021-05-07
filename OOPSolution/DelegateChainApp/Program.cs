using System;

namespace DelegateChainApp
{
    class Program
    {
        delegate int Calculate(int a, int b); // 계산 대리자 선언
        static void Main(string[] args)
        {
            FireStation station = new FireStation();
            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShotOut);
            fireHouse += new ThereIsAFire(station.Escape);
            fireHouse("우리집");  // 대리자 실행
            Console.WriteLine();
            
            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);
            fireWoorim("우림라이온밸리A");  // 대리자 실행
            Console.WriteLine();
            
            Calculate calc;   
            calc = delegate (int a, int b)   //익명 메서드
            {
                return a + b;
            };
            Console.WriteLine($"a + b = {calc(3, 5)}");
        }
    }
}
