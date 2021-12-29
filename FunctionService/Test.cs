#define CONDITION1
#define CONDITION2
using System;
using System.Diagnostics;

namespace FunctionService
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Calling Method1");
            Method1(3);
            Console.WriteLine("Calling Method2");
            Method2();

            Console.WriteLine("Using the Debug class");
            Debug.WriteLine("DEBUG is defined");
        }

        [Conditional("CONDITION1")]
        public static void Method1(int x)
        {
            Console.WriteLine("CONDITION1 is defined");
        }

        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        public static void Method2()
        {
            Console.WriteLine("CONDITION1 or CONDITION2 is defined");
        }
    }
}