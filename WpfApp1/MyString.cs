using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MyString
    {
        public string Text { get; set; }
        public string SubString { get; set; }
        public MyString(string text, string subString)
        {
            Text = text;
            SubString = subString;
        }

        public string NewString()
        {
            Text = Text.Insert(8, SubString);
            return Text;
        }
    }
}
