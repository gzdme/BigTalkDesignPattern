using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace 建造者模式
{
    abstract class PersonBuilder
    {
        private Panel _panel;
        private SolidColorBrush _brush;
        private double _thickness;

        public PersonBuilder(Panel panel, SolidColorBrush brush, double thickness)
        {
            this._panel = panel;
            this._brush = brush;
            this._thickness = thickness;
        }

        public abstract void BuildHead();
        public abstract void BuildBody();
        public abstract void BuildArmLeft();
        public abstract void BuildArmRight();
        public abstract void BuildLegLeft();
        public abstract void BuildLegRight();
    }
    class PersonThinBuilderB : PersonBuilder
    {
        private Panel _panel;
        private SolidColorBrush _brush;
        private double _thickness;

        public PersonThinBuilderB(Panel panel, SolidColorBrush brush, double thickness) : base(panel, brush, thickness)
        {
            this._panel = panel;
            this._brush = brush;
            this._thickness = thickness;
        }

        public override void BuildArmLeft()
        {
            Drawing.Line1(this._panel, _brush, _thickness, new Point(60, 50), new Point(40, 100));
        }

        public override void BuildArmRight()
        {
            Drawing.Line1(this._panel, _brush, _thickness, new Point(70, 50), new Point(90, 100));
        }

        public override void BuildBody()
        {
            Drawing.Rectangle(this._panel, _brush, _thickness, new Point(60, 50), 10, 50);
        }

        public override void BuildHead()
        {
            Drawing.Ellipse(this._panel, _brush, _thickness, new Point(65, 25), 20, 20);
        }

        public override void BuildLegLeft()
        {
            Drawing.Line2(this._panel, _brush, _thickness, new Point(60, 100), new Point(45, 150), new Point(35, 150));
        }

        public override void BuildLegRight()
        {
            Drawing.Line2(this._panel, _brush, _thickness, new Point(70, 100), new Point(85, 150), new Point(95, 150));
        }
    }
    class PersonFatBuilderB : PersonBuilder
    {
        private Panel _panel;
        private SolidColorBrush _brush;
        private double _thickness;

        public PersonFatBuilderB(Panel panel, SolidColorBrush brush, double thickness) : base(panel, brush, thickness)
        {
            this._panel = panel;
            this._brush = brush;
            this._thickness = thickness;
        }

        public override void BuildArmLeft()
        {
            Drawing.Line1(this._panel, _brush, _thickness, new Point(50, 50), new Point(30, 100));
        }

        public override void BuildArmRight()
        {
            Drawing.Line1(this._panel, _brush, _thickness, new Point(80, 50), new Point(100, 100));
        }

        public override void BuildBody()
        {
            Drawing.Rectangle(this._panel, _brush, _thickness, new Point(45, 50), 40, 50);
        }

        public override void BuildHead()
        {
            Drawing.Ellipse(this._panel, _brush, _thickness, new Point(65, 25), 20, 20);
        }

        public override void BuildLegLeft()
        {
            Drawing.Line2(this._panel, _brush, _thickness, new Point(60, 100), new Point(45, 150), new Point(35, 150));
        }

        public override void BuildLegRight()
        {
            Drawing.Line2(this._panel, _brush, _thickness, new Point(70, 100), new Point(85, 150), new Point(95, 150));
        }
    }
    class PersonDirector
    {
        private PersonBuilder personBuilder;
        public PersonDirector(PersonBuilder personBuilder)
        {
            this.personBuilder = personBuilder;
        }

        public void CreatePerson()
        {
            personBuilder.BuildHead();
            personBuilder.BuildBody();
            personBuilder.BuildArmLeft();
            personBuilder.BuildArmRight();
            personBuilder.BuildLegLeft();
            personBuilder.BuildLegRight();
        }
    }
}
