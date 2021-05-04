using System;

namespace ClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat("키티",3);
            //kitty.Name = "키티"; 
            kitty.Age = 3;
            kitty.Color = "햐얀색";
            kitty.Meow();

            /*Cat nero = new Cat
            {
                Name = "네로",
                Age = 12,
                Color = "검정색"
            };*/
            Cat nero = new Cat("네로", "검은", 12);
            nero.Meow();

            Cat mimi = new Cat("미미", "노랑색", 3);
            mimi.Meow();

            Cat coco = new Cat("코코", "얼룩이");
            coco.Age = 2;
            coco.Meow();

            Cat noname = new Cat("야옹이","은색", 10);
            //noname.Name = "야옹이";
            noname.Meow();
            noname.Sleep();

            var list = (First : "Cat", Second : "Dog", Third : "Pig",55);
            Console.WriteLine($"튜플 첫번째 : {list.First}");
            Console.WriteLine($"튜플 두번째 : {list.Second}");
            Console.WriteLine($"튜플 세번째 : {list.Third}");
            Console.WriteLine($"튜플 네번째 : {list.Item4}");
        }
    }
}
