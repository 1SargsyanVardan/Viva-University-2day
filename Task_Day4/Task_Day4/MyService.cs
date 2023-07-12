using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Day4
{
    public class MyService
    {
        string name;
        double price;
        int minDutartionFromActiveService;
        bool hasInRouming;
        public MyService(string name, double price, int duration, bool hasInRoaming)
        {
            this.name = name;
            this.price = price;
            minDutartionFromActiveService = duration;
            this.hasInRouming = hasInRoaming;
        }

        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return price; }
        }
        public int MinDutartionFromActiveService
        {
            get { return minDutartionFromActiveService; }
        }
        public bool HasInRouming
        {
            get { return hasInRouming; }
        }
    }
}
