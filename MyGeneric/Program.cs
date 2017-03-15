using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGeneric
{
    public class Generic<T>
    {
        public T Field;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Generic<string> g = new Generic<string>();
            g.Field = "A string";
            //...
            Console.WriteLine("Generic.Field           = \"{0}\"", g.Field);
            Console.WriteLine("Generic.Field.GetType() = {0}", g.Field.GetType().FullName);

        }
    }
}
