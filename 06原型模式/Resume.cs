using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 原型模式
{
    class Resume : ICloneable
    {
        private string name;
        private string sex;
        private string age;

        public Resume(string name)
        {
            this.name = name;
            this.work = new WorkExperience();
        }
        public Resume(WorkExperience work)
        {
            this.work = (WorkExperience)work.Clone();
        }

        // 设置个人信息
        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        #region 工作经历用值类型特点的string引用类型保存
        //private string timeArea;
        //private string company;
        //// 设置工作经历
        //public void SetWorkExperience(string timeArea, string company)
        //{
        //    this.timeArea = timeArea;
        //    this.company = company;
        //}
        #endregion

        #region 使用WorkExperience引用类型——测试浅拷贝
        private WorkExperience work;
        //// 设置工作经历
        public void SetWorkExperience(string timeArea, string company)
        {
            work.WorkDate = timeArea;
            work.Company = company;
        }
        #endregion

        // 显示
        public void Display()
        {
            Console.WriteLine("{0} {1} {2}", name, sex, age);
            //Console.WriteLine("工作经历： {0} {1}", timeArea, company);
            Console.WriteLine("工作经历： {0} {1}", work.WorkDate, work.Company);
        }

        public object Clone()
        {
            Resume obj = new Resume(this.work);
            obj.name = this.name;
            obj.sex = this.sex;
            obj.age = this.age;
            return obj;
        }
    }
    class WorkExperience : ICloneable
    {
        private string _workDate;
        private string _company;

        public string WorkDate
        {
            get { return _workDate; }
            set { _workDate = value; }
        }
        public string Company
        {
            get { return _company; }
            set { _company = value; }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
