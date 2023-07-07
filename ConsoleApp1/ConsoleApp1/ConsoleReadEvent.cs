using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConsoleReadEvent
    {
        public ConsoleReadEvent(string str)
        {
            buttonClicked b = print;
            b(str);
            OnButtonClicked?.Invoke("Button is Clicked");
        }
        public void print(string str) => Console.WriteLine(str);
        public delegate void buttonClicked(string str);
        public event buttonClicked OnButtonClicked;
    }
   
    
}
