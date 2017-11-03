using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    // 使用工厂方法模式
    interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }
    class SqlServerFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new SqlserverDepartment();
        }

        public IUser CreateUser()
        {
            return new SqlserverUser();
        }
    }
    class AccessFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }

        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}
