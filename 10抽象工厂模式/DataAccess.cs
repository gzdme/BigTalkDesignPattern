using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace 抽象工厂模式
{
    #region 简单工厂模式
    //class DataAccess
    //{
    //    private static readonly string db = "Sqlserver";
    //    //private static readonly string db = "Access";

    //    public static IUser CreateUser()
    //    {
    //        IUser result = null;
    //        switch (db)
    //        {
    //            case "Sqlserver":
    //                result = new SqlserverUser();
    //                break;
    //            case "Access":
    //                result = new AccessUser();
    //                break;
    //            default:
    //                break;
    //        }
    //        return result;
    //    }

    //    public static IDepartment CreateDepartment()
    //    {
    //        IDepartment result = null;
    //        switch (db)
    //        {
    //            case "Sqlserver":
    //                result = new SqlserverDepartment();
    //                break;
    //            case "Access":
    //                result = new AccessDepartment();
    //                break;
    //            default:
    //                break;
    //        }
    //        return result;
    //    }
    //}
    #endregion

    #region 使用反射技术的DataAccess
    class DataAccess
    {
        //private static readonly string db = "Sqlserver";
        //private static readonly string db = "Access";

        // 使用配置文件在不改动源代码的前提下修改数据库类型
        private static readonly string db = ConfigurationManager.AppSettings["DB"];

        public static IUser CreateUser()
        {
            return (IUser)Assembly.Load("抽象工厂模式").CreateInstance("抽象工厂模式." + db + "User");
        }

        public static IDepartment CreateDepartment()
        {
            return (IDepartment)Assembly.Load("抽象工厂模式").CreateInstance("抽象工厂模式." + db + "Department");
        }
    }
    #endregion
}
