using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象工厂模式
{
    // 模拟数据库Department表
    class Department
    {
        private int _id;
        private string _deptName;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
    }
    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }
    class SqlserverDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在 SQL Server 中根据ID得到Department表一条记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在 SQL Server 中给Department表增加一条记录");
        }
    }
    class AccessDepartment : IDepartment
    {
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在 Access 中根据ID得到Department表一条记录");
            return null;
        }

        public void Insert(Department department)
        {
            Console.WriteLine("在 Access 中给Department表增加一条记录");
        }
    }
}
