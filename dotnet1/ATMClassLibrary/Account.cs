using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMClassLibrary
{
    public class Account
    {
        private float funds;

        public void AddMoneyToAcc(float value)
        {
            funds += value;
        }

        public bool WithdrawMoney(float value)
        {
            if (value > funds)
            {
                return false;
            }
            else
            {
                funds -= value;
                return true;
            }
        }

        public User Authorization(string cardNumber, int PIN, User[] users)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].IsCardNumberCorrect(cardNumber) && users[i].IsPinCorrect(PIN))
                {
                    return users[i];
                }
            }
            return null;
        }

        public bool TransferCard(float value, string cardNumber, Account account, User[] users, int userId)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].IsCardNumberCorrect(cardNumber) && i != userId)
                {
                    if (account.WithdrawMoney(value))
                    {
                        users[i].AddMoneyToAcc(value);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return false;
        }

        public float GetAccountInfo()
        {
            return funds;
        }

    }
}