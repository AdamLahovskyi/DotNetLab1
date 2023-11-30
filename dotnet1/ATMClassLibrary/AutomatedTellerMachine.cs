using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClassLibrary
{
    public class AutomatedTellerMachine_
    {
        private int moneyAmount;
        private string ATMid;
        private string ATMaddress;

        public int _moneyAmount
        {
            get { return moneyAmount; }
        }

        public string _ATMid
        {
            get { return ATMid; }
        }

        public string _ATMaddress
        {
            get { return ATMaddress; }
        }

        public AutomatedTellerMachine_(int moneyAmount, string ATMid, string ATMaddress)
        {
            this.moneyAmount = moneyAmount;
            this.ATMid = ATMid;
            this.ATMaddress = ATMaddress;
        }

        public void AddMoney(int value)
        {
            moneyAmount += value;
        }

        public void WithdrawMoney(int value)
        {
            moneyAmount -= value;
        }
    }
}

