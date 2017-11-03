using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
    #region 简单工厂实现学雷锋
    //// 雷锋
    // class LeiFeng
    // {
    //     public void Sweep()
    //     {
    //         Console.WriteLine("扫地");
    //     }
    //     public void Wash()
    //     {
    //         Console.WriteLine("洗衣");
    //     }
    //     public void BuyRice()
    //     {
    //         Console.WriteLine("买米");
    //     }
    // }
    // // 学雷锋的大学生
    // class Undergraduate : LeiFeng
    // {

    // }
    // // 社区志愿者
    // class Volunteer : LeiFeng
    // {

    // }
    // // 雷锋简单工厂
    // class SimpleFactory
    // {
    //     public static LeiFeng CreateLeiFeng(string type)
    //     {
    //         LeiFeng result = null;
    //         switch (type)
    //         {
    //             case "学雷锋的大学生":
    //                 result = new Undergraduate();
    //                 break;
    //             case "社区志愿者":
    //                 result = new Volunteer();
    //                 break;
    //             default:
    //                 break;
    //         }
    //         return result;
    //     }
    // }
    #endregion

    // 雷锋
    class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }
        public void Wash()
        {
            Console.WriteLine("洗衣");
        }
        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }
    // 学雷锋的大学生
    class Undergraduate : LeiFeng
    {
    }
    // 社区志愿者
    class Volunteer : LeiFeng
    {
    }
    // 雷锋工厂
    interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }
    class UndergraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }
    class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}
