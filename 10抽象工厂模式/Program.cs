using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 过程实现
            //User user = new User();
            //SqlserverUser su = new SqlserverUser();  // 此处使得对象被框定在Sqlserver中，因此要将此处多态化
            //su.Insert(user);
            //su.GetUser(1);
            #endregion

            #region 增加工厂方法及增加Department表后，使用抽象工厂模式的客户端实现代码
            ////IFactory factory = new SqlServerFactory();
            //IFactory factory = new AccessFactory();
            //IUser iu = factory.CreateUser();

            //User user = new User();
            //iu.Insert(user);
            //iu.GetUser(1);

            //IDepartment idepartment = factory.CreateDepartment();
            //Department department = new Department();
            //idepartment.Insert(department);
            //idepartment.GetDepartment(1);
            #endregion

            #region 使用简单工厂，弃用抽象工厂的客户端实现
            //// 此种方式不能很方便的添加新的数据库类型，如需增加Oracle数据库
            //IUser iu = DataAccess.CreateUser();
            //IDepartment idepartment = DataAccess.CreateDepartment();

            //User user = new User();
            //iu.Insert(user);
            //iu.GetUser(1);

            //Department department = new Department();
            //idepartment.Insert(department);
            //idepartment.GetDepartment(1);
            #endregion

            #region 使用反射技术的客户端实现，与简单工厂相同
            // 好处在于容易扩展新的数据库类型，不需要去补充case项
            IUser iu = DataAccess.CreateUser();
            IDepartment idepartment = DataAccess.CreateDepartment();

            User user = new User();
            iu.Insert(user);
            iu.GetUser(1);

            Department department = new Department();
            idepartment.Insert(department);
            idepartment.GetDepartment(1);
            #endregion

            Console.Read();
        }
    }
}
