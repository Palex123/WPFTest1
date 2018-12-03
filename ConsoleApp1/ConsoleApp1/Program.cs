using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            B obj1 = (new A()) as B;
            obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();
            Console.ReadKey();
        }
    }

    public class A
    {
        public A()
        {
        }
        public virtual void Foo()
        {
            Console.Write("Class A");
        }
    }
    class B : A
    {
        public B() 
        { }
        public override void Foo()
        {
            Console.Write("Class B");
        }
    }
}
