using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Program
    {
        #region 过程式的客户端实现
        //static void Main(string[] args)
        //{
        //    Resume a = new Resume("大鸟");
        //    a.SetPersonalInfo("男", "29");
        //    a.SetWorkExperience("1998-2000", "XX公司");

        //    #region 多次新建实例，相当于复印
        //    //Resume b = new Resume("大鸟");
        //    //b.SetPersonalInfo("男", "29");
        //    //b.SetWorkExperience("1998-2000", "XX公司");

        //    //Resume c = new Resume("大鸟");
        //    //c.SetPersonalInfo("男", "29");
        //    //c.SetWorkExperience("1998-2000", "XX公司");
        //    #endregion

        //    #region 引用复制，一个改全都改
        //    Resume b = a;
        //    Resume c = a;
        //    c.SetPersonalInfo("男", "24");
        //    #endregion

        //    a.Display();
        //    b.Display();
        //    c.Display();

        //    Console.Read();
        //}
        #endregion


        #region 原型模式的客户端实现
        static void Main(string[] args)
        {
            Resume a = new Resume("大鸟");
            a.SetPersonalInfo("男", "29");
            a.SetWorkExperience("1998-2000", "XX公司");

            Resume b = (Resume)a.Clone();
            b.SetWorkExperience("1998-2006", "YY企业");

            Resume c = (Resume)a.Clone();
            c.SetPersonalInfo("男", "24");

            a.Display();
            b.Display();
            c.Display();

            Console.Read();
        }
        #endregion
    }
}
