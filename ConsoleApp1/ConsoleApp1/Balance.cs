using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Balance
    {
        string PhoneNumber { get; set; }
        int RefilAmount { get; set; }
        public Balance(string phoneNumber,int currentAmount)
        {
            PhoneNumber = phoneNumber;
            RefilAmount = currentAmount;
        }

        public void BalanceAdd(string phoneNumber,int refilAmount)
        {
            PhoneNumber = phoneNumber;
            RefilAmount += refilAmount;
            BalanceRefillEvent($"{PhoneNumber} hashvin veralicqavorvec - {refilAmount} dram____Yntacik hashiv: {RefilAmount}");
        }
        
        public delegate void BalanceRefill(string message);
        public event BalanceRefill? BalanceRefillEvent;
    }
}
