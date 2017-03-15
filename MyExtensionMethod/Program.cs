using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExtensionMethod
{
    public static class TestClass
    {
        public static void Print(this int i)
        {
            Console.WriteLine(i);
        }

        public static int Times(this int i)
        {
            return i * 2;
        }

        public static int Add(this int i, int d)
        {
            return i + d;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = 4;
            number.Print();
            Console.WriteLine(number.Times());
            Console.WriteLine(number.Add(5));
        }
    }
}
