using System;

namespace AbstractClassTestApp
{
    class Derived : AbstractBase
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived.AbstractMethod() 실행!");
            base.ProtectedMethod();
        }
    }
}
