using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDynamic
{
    class Program
    {
        /// <summary>
        /// 类型转换
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //dynamic dynamicObject = GetDynamicObject();
            //Console.WriteLine(dynamicObject.Name);
            //Console.WriteLine(dynamicObject.SampleMethod());
            dynamic d1 = 7;
            dynamic d2 = "a string";
            dynamic d3 = System.DateTime.Today;
            dynamic d4 = System.Diagnostics.Process.GetProcesses();

            int i = d1;
            string str = d2;
            DateTime dt = d3;
            System.Diagnostics.Process[] procs = d4;

            DynamicSample dynamicSample = new DynamicSample(); //create instance为了简化演示，我没有使用反射
            var addMethod = typeof(DynamicSample).GetMethod("Add");
            int re = (int)addMethod.Invoke(dynamicSample, new object[] { 1, 2 });
            Console.WriteLine(re);

            dynamic dynamicSample2 = new DynamicSample();
            int re2 = dynamicSample2.Add(1, 2);
            Console.WriteLine("dynamic = "+re2);
        }
    }

    public class DynamicSample
    {
        public string Name { get; set; }

        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
