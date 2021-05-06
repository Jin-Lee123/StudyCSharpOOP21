using System;

namespace PropertyTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("강아지 객체 생성");
            Dog baekgoo = new Dog();
            baekgoo.Name = "백구";
            //baekgoo.SetAge(1000);  //5살

            //Console.WriteLine($"백구의 나이는 {baekgoo.GetAge()}살");
            baekgoo.Age = 25000;
            Console.WriteLine($"{baekgoo.Name}의 나이는 {baekgoo.Age}살 ");

            Dog streetDog = new Dog();
            Console.WriteLine($"{streetDog.Name}는  {streetDog.Color} 입니다.");

            Dog dog1 = new Dog();
            dog1.Name = "황구";
            dog1.Color = "노랑";
            dog1.Age = 10;

            Dog dog2 = new()
            {
                Name = "깜장이",
                Color = "검정",
                Age = 5
            };

            var myInstance = new { Name = "성명권", Age = 44 };
            Console.WriteLine(myInstance.Name);
            Console.WriteLine(myInstance.Age);
        }
    }
}
