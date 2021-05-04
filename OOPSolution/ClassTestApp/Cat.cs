using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        /*public string Name { get; set; }*/
        public string Color { get; set; }
        public int Age { get; set; }

        public Cat() { }

        public Cat(string name, string color, int age)
        {
            //Initalization
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        public Cat(string name,string color)
        {
            this.Name = name;
            this.Color = color;
            
        }
        public Cat(string color, int age)
        {
           
            this.Color = color;
            this.Age = age;

        }


        public void Meow() { Console.WriteLine($"{this.Color} {this.Name}, 야옹!"); }

        public override void Sleep()
        {
            base.Sleep();
            //부모의 Sleep() 실행
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) zz잡니다."); 
            //이후 자식 클래스의 Sleep  내용 실행 (재정의:부모일하고 나머지 더 플러스 알파 느낌)
        }
    }
}
