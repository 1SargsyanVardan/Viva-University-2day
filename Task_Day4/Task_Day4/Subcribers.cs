using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Day4
{
    public class Subcriber
    {
        string? phoneNum;
        double balance;
        bool isInRoaming;
        bool isServiceActive;
        public DateTime expirationDate;
        MyService service;
        public Subcriber(string phoneNum, double balance, bool isInRoaming, bool isServiceActive, DateTime expirationDate, MyService service)
        {
            this.phoneNum = phoneNum;
            this.balance = balance;
            this.isInRoaming = isInRoaming;
            this.isServiceActive = isServiceActive;
            this.expirationDate = expirationDate;
            this.service = service;
        }
        public void Check()
        {
            if (EndDay(expirationDate) < service.MinDutartionFromActiveService)
                throw new DateTimeException($"Hargeli {phoneNum} bajanord: Time exception");
            if (IsInRoaming)
                if (!service.HasInRouming)
                    throw new IsInRoamingException($"Hargeli {phoneNum} bajanord: The service isn`t acvtive in roaming");
            if (IsServiceActive)
                throw new IsServiceActiveException($"Hargeli {phoneNum} bajanord: This Service is active now");
            if (Balance < service.Price)
                throw new BalanceException($"Hargeli {phoneNum} bajanord: The balance in the account is not enough to activate the Service");      
        }  
        
            /*catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;

            }
            myDate(DateTime.Now.AddDays(30));
            isServiceActive = true;
            */

        
        
        int EndDay(DateTime date)
        {
            TimeSpan duration = date - DateTime.Now;
            return duration.Days;
        }
        
        
        public string PhoneNum { get { return phoneNum; } }
        public double Balance { get { return balance; } set { balance = value; } }
        public bool IsServiceActive { get { return isServiceActive; } set { isServiceActive = value; } }
        public bool IsInRoaming { get { return isInRoaming; } }
    }

}
