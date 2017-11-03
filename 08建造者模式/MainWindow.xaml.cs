using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 建造者模式
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            #region 使用过程式创建
            //// 过程式绘制第一个小人
            //SolidColorBrush yellowBrush = new SolidColorBrush(Brushes.Yellow.Color);
            //double thickness = 5;
            ////DrawingEllipse(this.canvas, yellowBrush, thickness, new Point(65, 25), 20, 20);
            ////DrawingRectangle(this.canvas, yellowBrush, thickness, new Point(60, 50), 10, 50);
            ////DrawingLine1(this.canvas, yellowBrush, thickness, new Point(60, 50), new Point(40, 100));
            ////DrawingLine1(this.canvas, yellowBrush, thickness, new Point(70, 50), new Point(90, 100));
            ////DrawingLine2(this.canvas, yellowBrush, thickness, new Point(60, 100), new Point(45, 150), new Point(35, 150));
            ////DrawingLine2(this.canvas, yellowBrush, thickness, new Point(70, 100), new Point(85, 150), new Point(95, 150));

            //// 过程式绘制第二个小人
            //SolidColorBrush cyanBrush = new SolidColorBrush(Brushes.Cyan.Color);
            //DrawingEllipse(this.canvas, cyanBrush, thickness, new Point(65, 25), 20, 20);
            //DrawingRectangle(this.canvas, cyanBrush, thickness, new Point(45, 50), 40, 50);
            //DrawingLine1(this.canvas, cyanBrush, thickness, new Point(50, 50), new Point(30, 100));
            //DrawingLine1(this.canvas, cyanBrush, thickness, new Point(80, 50), new Point(100, 100));
            //DrawingLine2(this.canvas, cyanBrush, thickness, new Point(60, 100), new Point(45, 150), new Point(35, 150));
            //DrawingLine2(this.canvas, cyanBrush, thickness, new Point(70, 100), new Point(85, 150), new Point(95, 150));
            #endregion

            #region 使用面向对象方式创建
            //PersonThinBuilder thinBuilder = new PersonThinBuilder(this.canvas);
            //thinBuilder.Build();

            //PersonFatBuilder fatBuilder = new PersonFatBuilder(this.canvas);
            //fatBuilder.Build();
            #endregion

            #region 使用建造者模式创建
            SolidColorBrush brush = new SolidColorBrush(Brushes.Yellow.Color);
            double thickness = 5;
            PersonThinBuilderB thinBuilderB = new PersonThinBuilderB(this.canvas, brush, thickness);
            PersonDirector thinPd = new PersonDirector(thinBuilderB);
            thinPd.CreatePerson();

            brush = new SolidColorBrush(Brushes.Cyan.Color);
            thickness = 5;
            PersonFatBuilderB fatBuilderB = new PersonFatBuilderB(this.canvas, brush, thickness);
            PersonDirector fatPd = new PersonDirector(fatBuilderB);
            fatPd.CreatePerson();
            #endregion
        }
        /// <summary>  
        /// 使用LineGeometry绘制线段  
        /// </summary>  
        protected void DrawingLine1(Panel canvas, SolidColorBrush colorBrush, double thickness, Point startPt, Point endPt)
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
        protected void DrawingLine2(Panel canvas, SolidColorBrush colorBrush, double thickness, Point startPt, params Point[] points)
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
        protected void DrawingRectangle(Panel canvas, SolidColorBrush colorBrush, double thickness, Point startPt, double width, double height)
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
        protected void DrawingEllipse(Panel canvas, SolidColorBrush colorBrush, double thickness, Point center, double radiusX, double radiusY)
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
        /// <summary>
        /// 鼠标按下拖放
        /// </summary>
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        /// <summary>
        /// 鼠标抬起关闭窗口
        /// </summary>
        private void Window_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
