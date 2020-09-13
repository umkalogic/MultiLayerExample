using System;

namespace SomeExample
{
    public interface IClass
    {
        void Method2();
    }
    public class Class1 : IClass
    {
        public void Method1() { }
        public void Method1(int a) { }

        public virtual void Method2()
        {
            Console.WriteLine("Method2 from Class 1");
        }
    }

    public class Class2 : Class1
    {
        public override void Method2()
        {
            Console.WriteLine("Method2 from Class 2");
        }

    }

    public class Class3 : Class1
    {
        public override void Method2()
        {
            Console.WriteLine("Method2 from Class 3");
        }
    }
}
