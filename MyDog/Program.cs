using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDog
{
    /// <summary>
    /// 事件触发的过程，其实就是调用一系列 订阅者注册函数的过程
    /// </summary>
    public class Dog
    {
        static int num;

        //事件的声明     委托可以持有一系列相同签名的函数
        public delegate void EventHandler();
        public static event EventHandler NewDog;//声明，当发生变化的时候去通知那些注册的

        static Dog()
        {
            num = 0;
        }

        public Dog(String name)
        {
            ++num;
            if(NewDog != null)//不为空，代表有注册者，有注册方法的地址，调用它实现通知
            {
                NewDog();
            }
        }
    }

    class Client{
        public void wangAdog()
        {
            Console.WriteLine("Great!I want to see the new dog!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client();
            Client c2 = new Client();

            Dog.NewDog += c1.wangAdog;
            Dog.NewDog += c2.wangAdog;

            Dog dog = new Dog("Q");
        }
    }
}
