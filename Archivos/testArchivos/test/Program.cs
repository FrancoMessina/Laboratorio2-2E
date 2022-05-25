using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new C();
            A a = b;
            Console.WriteLine(a.Informar());
        }
        public class A
        {
            public virtual string Informar()
            {
                return "Kept your waiting huh";
            }
        }
        public class B : A
        {
            public override string Informar()
            {
                return "Ocelots are ";
            }
        }
        public class C : B
        {
            public override string Informar()
            {
                return "You're pretty good";
            }
        }
    }
}
