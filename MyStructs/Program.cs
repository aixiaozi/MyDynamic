using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStructs
{
    public class MyReferenceType
    {
        public int State { get; set; }
    }

    public struct MyValueType
    {
        public int State { get; set; }
    }

    public struct structA
    {
        //public int A = 90; //错误:“structA.A”: 结构中不能有实例字段初始值
        public int A;

    }


    class Program
    {
        static void Main(string[] args)
        {
            MyReferenceType myReferenceType = new MyReferenceType(); // 错误
            myReferenceType.State = 1234; // Ok
            Console.WriteLine(myReferenceType.State);

            MyValueType myValueType = new MyValueType(); // 错误
            myValueType.State = 01200; //  错误 but all correct except format
            Console.WriteLine(myValueType.State);
        }
    }
}
