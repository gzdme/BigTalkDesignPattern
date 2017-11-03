using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    // 模拟数据库User表
    class User
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
    #region 过程式实现
    //class SqlserverUser
    //{
    //    public void Insert(User user)
    //    {
    //        Console.WriteLine("在 SQL Server 中给User表增加一条记录");
    //    }
    //    public User GetUser(int id)
    //    {
    //        Console.WriteLine("在 SQL Server 中根据ID得到User表一条记录");
    //        return null;
    //    }
    //}
    #endregion


    #region 使用工厂方法模拟
    //IUser接口，用于客户端访问，解除与具体数据库访问的耦合
    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }
    // 用于访问SQL Server的User表
    class SqlserverUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在 SQL Server 中根据ID得到User表一条记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在 SQL Server 中给User表增加一条记录");
        }
    }
    // 用于访问Access的User表
    class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine("在 Access 中根据ID得到User表一条记录");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine("在 Access 中给User表增加一条记录");
        }
    }
    #endregion
}
