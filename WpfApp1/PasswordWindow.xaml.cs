using System.Windows;

namespace WpfApp1
{
    public partial class PasswordWindow : Window
    {
        public string Text { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }

        public PasswordWindow(string text, string oldValue, string newValue)
        {
            Text = text;
            OldValue = oldValue;
            NewValue = newValue;
            InitializeComponent();
        }

        public string NewString()
        {
            Text = Text.Replace(OldValue, NewValue);
            return Text;
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        public string Password
        {
            get { return passwordBox.Text; }
        }
    }
}