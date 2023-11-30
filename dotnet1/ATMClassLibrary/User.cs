using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClassLibrary
{
    public class User : Account
    {
        private string cardNumber;
        private int PIN;
        private Account account;
        private bool auth = false;
        public User(string cardNumber, int PIN)
        {
            this.cardNumber = cardNumber;
            this.PIN = PIN;
            account = new Account();
        }

        public bool IsCardNumberCorrect(string value)
        {
            if (value == cardNumber)
            {
                auth = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsPinCorrect(int value)
        {
            if (value == PIN)
            {
                auth = true;
                return true;
            }
            else
            {
                return false;
            }
        }

        public Account GetAccount()
        {
            if (auth)
            {
                return account;
            }
            else
            {
                return null;
            }
        }
        public bool IsAuthenticated()
        {
            return auth; 
        }

    }
}
