using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 过程式
            //Console.WriteLine("请输入数字A： ");
            //string A = Console.ReadLine();
            //Console.WriteLine("请选择运算符号（+、-、*、/）： ");
            //string B = Console.ReadLine();
            //Console.WriteLine("请输入数字B： ");
            //string C = Console.ReadLine();
            //string D = "";

            //if (B == "+")
            //{
            //    D = Convert.ToString(Convert.ToDouble(A) + Convert.ToDouble(C));
            //}
            //if (B == "-")
            //{
            //    D = Convert.ToString(Convert.ToDouble(A) - Convert.ToDouble(C));
            //}
            //if (B == "*")
            //{
            //    D = Convert.ToString(Convert.ToDouble(A) * Convert.ToDouble(C));
            //}
            //if (B == "/")
            //{
            //    D = Convert.ToString(Convert.ToDouble(A) / Convert.ToDouble(C));
            //}

            //Console.WriteLine("结果是： " + D);
            //Console.ReadKey();
            #endregion

            #region 修改后的过程式
            //try
            //{
            //    Console.WriteLine("请输入数字A： ");
            //    string strNumberA = Console.ReadLine();
            //    Console.WriteLine("请选择运算符号（+、-、*、/）： ");
            //    string strOperate = Console.ReadLine();
            //    Console.WriteLine("请输入数字B： ");
            //    string strNumberB = Console.ReadLine();
            //    string strResult = "";

            //    switch (strOperate)
            //    {
            //        case "+":
            //            strResult = Convert.ToString(Convert.ToDouble(strNumberA) + Convert.ToDouble(strNumberB));
            //            break;
            //        case "-":
            //            strResult = Convert.ToString(Convert.ToDouble(strNumberA) - Convert.ToDouble(strNumberB));
            //            break;
            //        case "*":
            //            strResult = Convert.ToString(Convert.ToDouble(strNumberA) * Convert.ToDouble(strNumberB));
            //            break;
            //        case "/":
            //            strResult = Convert.ToString(Convert.ToDouble(strNumberA) / Convert.ToDouble(strNumberB));
            //            break;
            //        default:
            //            break;
            //    }

            //    Console.WriteLine("结果是： " + strResult);
            //    Console.ReadKey();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("您的输入有错： " + ex.Message);
            //    throw;
            //}
            #endregion


            #region 使用面向对象类
            //try
            //{
            //    Console.WriteLine("请输入数字A： ");
            //    string strNumberA = Console.ReadLine();
            //    Console.WriteLine("请选择运算符号（+、-、*、/）： ");
            //    string strOperate = Console.ReadLine();
            //    Console.WriteLine("请输入数字B： ");
            //    string strNumberB = Console.ReadLine();
            //    string strResult = "";
            //    strResult = Convert.ToString(Operate.GetResult(Convert.ToDouble(strNumberA), Convert.ToDouble(strNumberB), strOperate));

            //    Console.WriteLine("结果是： " + strResult);
            //    Console.ReadKey();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("您的输入有错： " + ex.Message);
            //    throw;
            //}
            #endregion


            #region 使用松耦合类 + 简单工厂
            try
            {
                Console.WriteLine("请输入数字A： ");
                string strNumberA = Console.ReadLine();
                Console.WriteLine("请选择运算符号（+、-、*、/）： ");
                string strOperate = Console.ReadLine();
                Console.WriteLine("请输入数字B： ");
                string strNumberB = Console.ReadLine();

                Operation oper;
                oper = OperationFactory.createOperate(strOperate);
                oper.NumberA = Convert.ToDouble(strNumberA);
                oper.NumberB = Convert.ToDouble(strNumberB);
                string result = Convert.ToString(oper.GetResult());

                Console.WriteLine("结果是： " + result);
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("您的输入有错： " + ex.Message);
                Console.ReadKey();
            }
            #endregion
        }
    }
    #region 紧耦合的Operate
    //public class Operate
    //{
    //    public static double GetResult(double numberA, double numberB, string operate)
    //    {
    //        double result = 0;
    //        switch (operate)
    //        {
    //            case "+":
    //                result = numberA + numberB;
    //                break;
    //            case "-":
    //                result = numberA - numberB;
    //                break;
    //            case "*":
    //                result = numberA * numberB;
    //                break;
    //            case "/":
    //                result = numberA / numberB;
    //                break;
    //            default:
    //                break;
    //        }
    //        return result;
    //    }
    //}
    #endregion
    #region  松耦合的Operation...
    public class Operation
    {
        private double _numberA;
        private double _numberB;

        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
    class OperationAdd : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
            return result;
        }
    }
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
            return result;
        }
    }
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
            return result;
        }
    }
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA / NumberB;
            return result;
        }
    }
    #endregion
    #region 简单工厂模式
    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
                default:
                    break;
            }
            return oper;
        }
    }
    #endregion
}
