using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace 建造者模式
{
    class Drawing
    {
        /// <summary>  
        /// 使用LineGeometry绘制线段  
        /// </summary>  
        public static void Line1(Panel canvas, SolidColorBrush colorBrush, double thickness, Point startPt, Point endPt)
        {
            LineGeometry lineGeometry = new LineGeometry();
            lineGeometry.StartPoint = startPt;
            lineGeometry.EndPoint = endPt;

            Path path = new Path();
            path.Stroke = colorBrush;
            path.StrokeThickness = thickness;
            path.Data = lineGeometry;

            canvas.Children.Add(path);
        }
        /// <summary>  
        /// 使用LineSegment绘制线段  
        /// </summary>  
        public static void Line2(Panel canvas, SolidColorBrush colorBrush, double thickness, Point startPt, params Point[] points)
        {
            PathFigure pathFigure = new PathFigure();
            pathFigure.StartPoint = startPt;
            foreach (Point pt in points)
            {
                PathSegment pathSegment = new LineSegment(pt, true);
                pathFigure.Segments.Add(pathSegment);
            }

            /// Create a PathGeometry to contain the figure.  
            PathGeometry pathGeometry = new PathGeometry();
            pathGeometry.Figures.Add(pathFigure);

            // Display the PathGeometry.   
            Path path = new Path();
            path.Stroke = colorBrush;
            path.StrokeThickness = thickness;
            path.Data = pathGeometry;

            canvas.Children.Add(path);
        }
        /// <summary>
        /// 绘制矩形
        /// </summary>
        public static void Rectangle(Panel canvas, SolidColorBrush colorBrush, double thickness, Point startPt, double width, double height)
        {
            RectangleGeometry rectangleGeometry = new RectangleGeometry(new Rect(startPt.X, startPt.Y, width, height));

            /// Create a PathGeometry to contain the figure.  
            PathGeometry pathGeometry = new PathGeometry();
            pathGeometry.AddGeometry(rectangleGeometry);

            // Display the PathGeometry.
            Path path = new Path();
            path.Stroke = colorBrush;
            path.StrokeThickness = thickness;
            path.Data = pathGeometry;

            canvas.Children.Add(path);
        }
        /// <summary>
        /// 绘制椭圆
        /// </summary>
        public static void Ellipse(Panel canvas, SolidColorBrush colorBrush, double thickness, Point center, double radiusX, double radiusY)
        {
            EllipseGeometry ellipseGeometry = new EllipseGeometry(center, radiusX, radiusY);

            /// Create a PathGeometry to contain the figure.  
            PathGeometry pathGeometry = new PathGeometry();
            pathGeometry.AddGeometry(ellipseGeometry);

            // Display the PathGeometry.
            Path path = new Path();
            path.Stroke = colorBrush;
            path.StrokeThickness = thickness;
            path.Data = pathGeometry;

            canvas.Children.Add(path);
        }

    }
    class PersonThinBuilder
    {
        private Panel _panel;
        private SolidColorBrush _brush;
        private double _thickness;

        public PersonThinBuilder(Panel panel)
        {
            this._panel = panel;
            this._brush = new SolidColorBrush(Brushes.Yellow.Color);
            this._thickness = 5;
        }

        public void Build()
        {
            Drawing.Ellipse(this._panel, _brush, _thickness, new Point(65, 25), 20, 20);
            Drawing.Rectangle(this._panel, _brush, _thickness, new Point(60, 50), 10, 50);
            Drawing.Line1(this._panel, _brush, _thickness, new Point(60, 50), new Point(40, 100));
            Drawing.Line1(this._panel, _brush, _thickness, new Point(70, 50), new Point(90, 100));
            Drawing.Line2(this._panel, _brush, _thickness, new Point(60, 100), new Point(45, 150), new Point(35, 150));
            Drawing.Line2(this._panel, _brush, _thickness, new Point(70, 100), new Point(85, 150), new Point(95, 150));
        }
    }
    class PersonFatBuilder
    {
        private Panel _panel;
        private SolidColorBrush _brush;
        private double _thickness;

        public PersonFatBuilder(Panel panel)
        {
            this._panel = panel;
            this._brush = new SolidColorBrush(Brushes.Cyan.Color);
            this._thickness = 5;
        }

        public void Build()
        {
            Drawing.Ellipse(this._panel, _brush, _thickness, new Point(65, 25), 20, 20);
            Drawing.Rectangle(this._panel, _brush, _thickness, new Point(45, 50), 40, 50);
            Drawing.Line1(this._panel, _brush, _thickness, new Point(50, 50), new Point(30, 100));
            Drawing.Line1(this._panel, _brush, _thickness, new Point(80, 50), new Point(100, 100));
            Drawing.Line2(this._panel, _brush, _thickness, new Point(60, 100), new Point(45, 150), new Point(35, 150));
            Drawing.Line2(this._panel, _brush, _thickness, new Point(70, 100), new Point(85, 150), new Point(95, 150));
        }
    }
}
