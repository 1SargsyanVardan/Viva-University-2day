using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApp1
{

    public class ConsoleReadEvent
    {
        public string str { get; set; }
        public ConsoleReadEvent(string str)
        {
            this.str = str;
        }
        public delegate void buttonClicked(string str);
        public event buttonClicked OnButtonClicked;

        public void isButtonClicked()
        {
            while(true)
            {
                if(Console.KeyAvailable)
                {
                    OnButtonClicked("Button is Clicked");
                    break;
                }
            }
        }
        
    }
   
    
}
