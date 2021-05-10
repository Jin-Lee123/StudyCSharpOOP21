using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        private string name;
        public string Name { get; set; } = "멍멍이";  //초기값 설정
        public string Color { get; set; } = "누런색"; //초기값 설정
        public int Age
        {
            get // => this.age;  (람다식)
            {
                return age;
            }
            set  // => this.age;
            {
                if (value<0)
                {
                    this.age = 1;
                }
                else if (value>15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
                age = value;
            }
        }

        /*public string Getname() { return this.name; }
        public void Setname(string name) { this.name=name; }
       
        public string GetAge() { return $"{this.age}"; }  //값을 사용
        public void SetAge(int age)
        {
            if (age < 0)
            {
                this.age = 1;
            }
            else if (age > 15)
            {
                this.age = 15;
            }
            else
            {
                this.age = age;
            }
        } //값을 설정*/



    }
}
