using ATMClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleATM
{
    internal class Program
    {
        private static List<User> users = new List<User>
        {
            new User("1111222233334444", 5678),
            new User("9876543210123456", 4321),
            new User("5555666677778888", 8765),
            new User("1234987650123456", 9876),
            new User("9876123498765432", 3456),
        };

        private static List<AutomatedTellerMachine_> atmsList = new List<AutomatedTellerMachine_>
        {
            new AutomatedTellerMachine_(50000, "qweiqw123", "street1"),
            new AutomatedTellerMachine_(75000, "asdasd456", "street2"),
            new AutomatedTellerMachine_(100000, "zxczxc789", "street3"),
            new AutomatedTellerMachine_(30000, "rtyrty321", "street4"),
            new AutomatedTellerMachine_(90000, "fghfgh654", "street5"),
        };

        private static Bank bank1 = new Bank("PrivatBank", atmsList);

        private delegate bool TransferMoneyDelegate(float amount, string recipientCardNumber, Account senderAccount, User[] users, int senderIndex);
        private delegate void AddMoneyToAccountDelegate(float amount, Account userAccount);



        private static void Main()
        {
            Console.WriteLine("Welcome to the ATM system!");

            User authorizedUser = AuthorizeUser();

            if (authorizedUser != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Authorization successful!");
                Console.ResetColor();

                Account userAccount = authorizedUser.GetAccount();
                Console.WriteLine($"Current account balance: {userAccount.GetAccountInfo()}");

                DisplayMainMenu(authorizedUser);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Authorization failed. Exiting...");
                Console.ResetColor();
            }
        }

        private static User AuthorizeUser()
        {
            Console.WriteLine("Enter card number:");
            string cardNumber = Console.ReadLine();

            Console.WriteLine("Enter PIN:");
            int pin;
            if (int.TryParse(Console.ReadLine(), out pin))
            {
                foreach (var user in users)
                {
                    if (user.IsCardNumberCorrect(cardNumber) && user.IsPinCorrect(pin))
                    {
                        return user;
                    }
                }
            }

            return null;
        }

        private static void DisplayMainMenu(User user)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nMain Menu:");
                Console.ResetColor();
                Console.WriteLine("1. Transfer Money");
                Console.WriteLine("2. Add Money to Account");
                Console.WriteLine("3. Current Balance");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice (1-3): ");
                string choice = Console.ReadLine();

                TransferMoneyDelegate transferMoneyDelegate = TransferMoney;
                AddMoneyToAccountDelegate addMoneyToAccountDelegate = AddMoneyToAccount;

                switch (choice)
                {
                    case "1":
                        if (TransferMoneyAction(user, transferMoneyDelegate))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Transfer successful!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Transfer failed. Insufficient funds or invalid recipient.");
                            Console.ResetColor();
                        }
                        break;
                    case "2":
                        AddMoneyToAccountAction(user, addMoneyToAccountDelegate);
                        break;
                    case "3":
                        GetCurrentBalance(user);
                        break;
                    case "0":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Exiting program. Goodbye!");
                        Console.ResetColor();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please enter a number from 0 to 3.");
                        Console.ResetColor();
                        break;
                }
            }
        }

        private static bool TransferMoneyAction(User sender, TransferMoneyDelegate transferMoneyDelegate)
        {
            Console.WriteLine("Enter recipient's card number:");
            string recipientCardNumber = Console.ReadLine();

            Console.WriteLine("Enter amount to transfer:");
            float amount;
            if (float.TryParse(Console.ReadLine(), out amount))
            {
                return transferMoneyDelegate.Invoke(amount, recipientCardNumber, sender.GetAccount(), users.ToArray(), users.IndexOf(sender));
            }

            return false;
        }


        private static void AddMoneyToAccountAction(User user, AddMoneyToAccountDelegate addMoneyToAccountDelegate)
        {
            Console.WriteLine("Enter amount to add to your account:");
            float amount;
            if (float.TryParse(Console.ReadLine(), out amount))
            {
                addMoneyToAccountDelegate.Invoke(amount, user.GetAccount());
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid amount. Failed to add money to your account.");
                Console.ResetColor();
            }
        }

        private static bool TransferMoney(float amount, string recipientCardNumber, Account senderAccount, User[] users, int senderIndex)
        {
            return senderAccount.TransferCard(amount, recipientCardNumber, senderAccount, users, senderIndex);
        }


        private static void AddMoneyToAccount(float amount, Account userAccount)
        {
            userAccount.AddMoneyToAcc(amount);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Added {amount} to your account.");
            Console.ResetColor();
        }

        private static void GetCurrentBalance(User user)
        {
            float balance = user.GetAccount().GetAccountInfo();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Your Current Balance Is: {balance}");
            Console.ResetColor();
        }
    }
}


