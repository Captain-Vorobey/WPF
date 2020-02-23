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
using System.Windows.Shapes;

namespace WpfApp1
{
    public partial class Computer 
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Manufacturer { get; set; }
        public DateTime YearRelease { get; set; }

        public Computer(string name, int price, 
            string manufacturer, DateTime yearRealese)
        {
            Name = name;
            Price = price;
            Manufacturer = manufacturer;
            YearRelease = yearRealese;
            InitializeComponent();
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public void createComputer()
        {
            Name = Console.ReadLine();
            Price = int.Parse(Console.ReadLine());
            Manufacturer = Console.ReadLine();
            YearRelease = DateTime.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return string.Format("Name is {0}, Price is {1}, Manufacturer is {2}, YearRelease is {3}",
                                 Name, Price, Manufacturer, YearRelease);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
