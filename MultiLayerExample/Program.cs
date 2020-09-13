using System;
using PL;
using SomeExample;

namespace MultiLayerExample
{
    class Program
    {
        public static void POlExample(IClass class1)
        {
            class1.Method2();
        }
        static void Main(string[] args)
        {
            PlClass.Run();
            Class1 class1 = new Class1();
            class1.Method2();

            Class2 class2 = new Class2();
            class2.Method2();

            Class3 class3 = new Class3();
            class3.Method2();

            class1 = class2;
            class1.Method2();

            class1 = class3;
            class1.Method2();

            class1 = new Class1();
            class1.Method2();

            // class3 = class1;

            POlExample(class2);
        }
    }
}
