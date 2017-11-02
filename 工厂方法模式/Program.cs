using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
    class Program
    {
        #region 简单工厂学雷锋实现
        //static void Main(string[] args)
        //{
        //    LeiFeng studentA = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
        //    studentA.BuyRice();
        //    LeiFeng studentB = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
        //    studentA.Sweep();
        //    LeiFeng studentC = SimpleFactory.CreateLeiFeng("学雷锋的大学生");
        //    studentA.Wash();

        //    Console.Read();
        //}
        #endregion


        #region 工厂方法学雷锋实现
        static void Main(string[] args)
        {
            IFactory factory = new UndergraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();
            student.BuyRice();
            student.Sweep();
            student.Wash();
            Console.Read();
        }
        #endregion
    }
}
