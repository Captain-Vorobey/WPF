using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = "Информация о вашей строке", FontSize = 16 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Её изменения" });
            toolTip.Content = toolTipPanel;
            button1.ToolTip = toolTip;

            PasswordWindow passwordWindow = new PasswordWindow("hey guys", "guys", "girls");

            if (passwordWindow.ShowDialog() == true)
            {
                if (passwordWindow.Password == passwordWindow.Text)
                {
                    System.Windows.MessageBox.Show(passwordWindow.NewString());
                }
                else
                    MessageBox.Show("Неверная строка");

            }
                else
                {
                    MessageBox.Show("Хз чё случилось"); ;
                }
        }

        private void Login_Click1(object sender, RoutedEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = "Информация о вашей строке", FontSize = 16 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Её изменения" });
            toolTip.Content = toolTipPanel;
            button1.ToolTip = toolTip;
            Console.ReadLine();
            //int.Parse(Console.ReadLine());
            //Console.ReadLine();
            //DateTime.Parse(Console.ReadLine());
            MessageBox.Show("NoteBook");
        }

        private void Login_Click2(object sender, RoutedEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = "Информация о вашей строке", FontSize = 16 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Её изменения" });
            toolTip.Content = toolTipPanel;
            button2.ToolTip = toolTip;
            MessageBox.Show("Test");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = "Информация о вашей графике", FontSize = 16 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Её изменения" });
            toolTip.Content = toolTipPanel;
            button3.ToolTip = toolTip;

            PathGeometry pathGeom = new PathGeometry();
            //Path p = new Path();

            LineSegment vertLS = new LineSegment();
            PathFigure vertPF = new PathFigure();
            vertPF.StartPoint = new Point(10, 150);
            vertLS.Point = new Point(10, 10);
            vertPF.Segments.Add(vertLS);
            pathGeom.Figures.Add(vertPF);

            LineSegment horLS = new LineSegment();
            PathFigure horPF = new PathFigure();
            horPF.StartPoint = new Point(10, 150);
            horLS.Point = new Point(150, 150);
            horPF.Segments.Add(horLS);
            pathGeom.Figures.Add(horPF);

            for (byte i = 2; i < 14; i++)
            {
                PathFigure pf = new PathFigure();
                pf.StartPoint = new Point(i * 10, 155);
                LineSegment a = new LineSegment();
                a.Point = new Point(i * 10, 145);
                pf.Segments.Add(a);
                pathGeom.Figures.Add(pf);
            }

            for (byte i = 3; i < 15; i++)
            {
                PathFigure pf = new PathFigure();
                pf.StartPoint = new Point(5, i * 10);
                LineSegment a = new LineSegment();
                a.Point = new Point(15, i * 10);
                pf.Segments.Add(a);
                pathGeom.Figures.Add(pf);
            }

            PolyLineSegment vertArr = new PolyLineSegment();
            vertArr.Points = new PointCollection();
            vertArr.Points.Add(new Point(10, 10));
            vertArr.Points.Add(new Point(15, 15));
            PathFigure vertArrF = new PathFigure();
            vertArrF.StartPoint = new Point(5, 15);
            vertArrF.Segments.Add(vertArr);
            pathGeom.Figures.Add(vertArrF);

            PolyLineSegment horArr = new PolyLineSegment();
            horArr.Points = new PointCollection();
            horArr.Points.Add(new Point(150, 150));
            horArr.Points.Add(new Point(145, 155));
            PathFigure horArrF = new PathFigure();
            horArrF.StartPoint = new Point(145, 145);
            horArrF.Segments.Add(horArr);
            pathGeom.Figures.Add(horArrF);
            MessageBox.Show(vertArr.ToString());
            //p.Data = pathGeom;
            //p.Stroke = Brushes.Black;

            //grid.Children.Add(p);
        }

        private void Login_Click4(object sender, RoutedEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = "Информация о вашей бд", FontSize = 16 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Её изменения" });
            toolTip.Content = toolTipPanel;
            button4.ToolTip = toolTip;
            MessageBox.Show("BD");
        }

        private void Login_Click5(object sender, RoutedEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = "Информация об объекте", FontSize = 16 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Его поля: имя, тип, время выхода" });
            toolTip.Content = toolTipPanel;
            button5.ToolTip = toolTip;
            MessageBox.Show("Created obj");
        }
    }
}
