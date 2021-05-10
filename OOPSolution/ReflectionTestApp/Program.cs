using System;
using System.Reflection;

namespace ReflectionTestApp
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public void PrintProfile() { Console.WriteLine($"{Age}, {Name}"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 0;
            Person a = new Person();
            Type type = a.GetType();
            Console.WriteLine("Field 타입 리스트 :");
            FieldInfo[] fields = type.GetFields();
            foreach (var item in fields)
            {
                Console.WriteLine($"Type : {item.FieldType.Name}, Name : {item.Name}");
            }
            Console.WriteLine("Property 타입 리스트 :");
            PropertyInfo[] properties = type.GetProperties();
            foreach (var item in properties)
            {
                Console.WriteLine($"Type : {item.PropertyType.Name}, Name : {item.Name}");
            }

            Console.WriteLine("Method 타입 리스트 :");
            var methods = type.GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine($"Type : {item.ReturnType.Name}, Name : {item.Name}");
            }


        }
    }
}
