using System;

namespace Part56Generics
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            bool IsEqual = c.Equals(1,10);
            Console.WriteLine(IsEqual);
            Calculators<string> s = new Calculators<string>();
           bool stringE= s.StingEquality("Ram","Ram");
            Console.WriteLine(stringE);
        }
        class Calculator
        {
            public bool Equals<T>(T  a, T b)
            {
                return a.Equals(b);
            }
        }
        class Calculators<S>
        {
            public bool StingEquality(S a,S b )
            {
                return a.Equals(b);
            }
        }
    }
}
