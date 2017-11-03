using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 组合模式
{
    abstract class Company
    {
        protected string name;
        public Company(string name)
        {
            this.name = name;
        }

        public abstract void Add(Company company);      //增加
        public abstract void Remove(Company company);   //移除
        public abstract void Display(int depth);        //显示
        public abstract void LineOfDuty();              //履行职责
    }
    class ConcreteCompany : Company
    {
        private List<Company> children = new List<Company>();
        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
            children.Add(company);
        }

        public override void Remove(Company company)
        {
            children.Remove(company);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (Company com in children)
            {
                com.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company com in children)
            {
                com.LineOfDuty();
            }
        }
    }
    // 人力资源部
    class HRDepartment : Company
    {
        public HRDepartment(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
        }
        public override void Remove(Company company)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 员工招聘培训管理", name);
        }
    }
    // 财务部
    class FinanceDepartment : Company
    {
        public FinanceDepartment(string name) : base(name)
        {
        }

        public override void Add(Company company)
        {
        }
        public override void Remove(Company company)
        {
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }

        public override void LineOfDuty()
        {
            Console.WriteLine("{0} 公司财务收支管理", name);
        }
    }
}
