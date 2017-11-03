using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 备忘录模式
{
    // 发起人
    class Originator
    {
        private string _state;

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public Memento CreateMemento()
        {
            return (new Memento(_state));
        }
        public void SetMemento(Memento memento)
        {
            _state = memento.State;
        }
        public void Show()
        {
            Console.WriteLine("State=" + _state);
        }
    }
    // 备忘录
    class Memento
    {
        private string _state;

        public string State
        {
            get { return _state; }
        }
        public Memento(string state)
        {
            this._state = state;
        }
    }
    // 管理者
    class Caretaker
    {
        private Memento _memento;

        public Memento Memento
        {
            get { return _memento; }
            set { _memento = value; }
        }
    }
    class Client
    {
        //static void Main(string[] args)
        //{
        //    Originator originator = new Originator();
        //    originator.State = "On";
        //    originator.Show();

        //    Caretaker caretaker = new Caretaker();
        //    caretaker.Memento = originator.CreateMemento();

        //    originator.State = "Off";
        //    originator.Show();

        //    originator.SetMemento(caretaker.Memento);
        //    originator.Show();

        //    Console.Read();
        //}
    }
}
