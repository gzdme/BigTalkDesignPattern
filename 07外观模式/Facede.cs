using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 外观模式
{
    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine(" 子系统方法一");
        }
    }
    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine(" 子系统方法二");
        }
    }
    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine(" 子系统方法三");
        }
    }
    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine(" 子系统方法四");
        }
    }
    class Facede
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facede()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n 方法组A() --------");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }
        public void MethodB()
        {
            Console.WriteLine("\n 方法组B() --------");
            two.MethodTwo();
            three.MethodThree();
        }
    }
    // 使用外观模式客户端代码
    class Client
    {
        //static void Main(string[] args)
        //{
        //    Facede facede = new Facede();

        //    facede.MethodA();
        //    facede.MethodB();

        //    Console.Read();
        //}
    }
}
