using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Day4
{
    public class DateTimeException: Exception
    {
        public DateTimeException(string message): base(message)
        {

        }
    }
    public class IsInRoamingException : Exception
    {
        public IsInRoamingException(string message) : base(message)
        {

        }
    }
    public class IsServiceActiveException : Exception
    {
        public IsServiceActiveException(string message) : base(message)
        {

        }
    }
    public class BalanceException : Exception
    {
        public BalanceException(string message) : base(message)
        {

        }
    }

}
