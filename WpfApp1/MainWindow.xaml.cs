using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        List<Computer> computers;
        public MainWindow()
        {
            InitializeComponent();
            computers = new List<Computer>(new[] { new Computer("HP", 123, "HP", new DateTime(2000-12-12-00-00-00)),
            new Computer("HP pavilion", 435, "HP", new DateTime(2000-12-12-00-00-00))});
            //computersList.ItemsSource = computers;
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

        private void Login_Click3(object sender, RoutedEventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            StackPanel toolTipPanel = new StackPanel();
            toolTipPanel.Children.Add(new TextBlock { Text = "Информация о вашей графике", FontSize = 16 });
            toolTipPanel.Children.Add(new TextBlock { Text = "Её изменения" });
            toolTip.Content = toolTipPanel;
            button3.ToolTip = toolTip;
            MessageBox.Show("Graphic");
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
