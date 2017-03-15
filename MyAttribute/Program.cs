#define NoBug
//C# 的宏定义必须出现在所有代码之前。当前只让 Buged 宏有效。
using System;
using System.Diagnostics; // 注意：这是为了使用包含在此名称空间中的ConditionalAttribute特性

namespace MyAttribute
{
    class Program
    {
        static void Main(string[] args)
        {
            // 虽然方法都被调用了，但只有符合条件的才会被执行！就是最上面的宏定义
            ToolKit.FunA();
            ToolKit.FunB();
            ToolKit.FunC();
            ToolKit.FunD();
        }
    }

    class ToolKit
    {
        [ConditionalAttribute("Li")] // Attribute名称的长记法
        [ConditionalAttribute("Buged")]
        public static void FunA()
        {
            Console.WriteLine("Created By Li, Buged.");
        }
        [Conditional("Li")] // Attribute名称的短记法
        [Conditional("NoBug")]
        public static void FunB()
        {
            Console.WriteLine("Created By Li, NoBug.");
        }
        [ConditionalAttribute("Zhang")]// Attribute名称的长记法
        [ConditionalAttribute("Buged")]
        public static void FunC()
        {
            Console.WriteLine("Created By Zhang, Buged.");
        }
        [Conditional("Zhang")] // Attribute名称的短记法
        [Conditional("NoBug")]
        public static void FunD()
        {
            Console.WriteLine("Created By Zhang, NoBug.");
        }
    }
}
