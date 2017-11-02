using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂方法模式
{
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
    interface IFactoryS
    {
        Operation CreateOperation();
    }
    class AddFactory : IFactoryS
    {
        public Operation CreateOperation()
        {
            return new OperationAdd();
        }
    }
    class SubFactory : IFactoryS
    {
        public Operation CreateOperation()
        {
            return new OperationSub();
        }
    }
    class MulFactory : IFactoryS
    {
        public Operation CreateOperation()
        {
            return new OperationMul();
        }
    }
    class DivFactory : IFactoryS
    {
        public Operation CreateOperation()
        {
            return new OperationDiv();
        }
    }
    // 工厂方法的客户端实现
    class Client
    {
        //static void Main(string[] args)
        //{
        //    IFactory operFactory = new AddFactory();
        //    Operation oper = operFactory.CreateOperation();
        //    oper.NumberA = 1;
        //    oper.NumberB = 2;
        //    double result = oper.GetResult();
        //}
    }
}
