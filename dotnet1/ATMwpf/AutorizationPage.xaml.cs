﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ATMClassLibrary;
using ATMwpf.View;

namespace ATMwpf
{
    /// <summary>
    /// Interaction logic for AutorizationPage.xaml
    /// </summary>
    /// 
    public partial class AutorizationPage : Page
    {
        private User authenticatedUser;
        public AutorizationPage()
        {
            InitializeComponent();
        }
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

        private User AuthorizeUser()
        {
            string cardNumber = cardNumInput.Text;

            if (int.TryParse(PINinput.Text, out int pin))
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

        private void tryAuthButton_Click(object sender, RoutedEventArgs e)
        {
            User authorizedUser = AuthorizeUser();
                
            if (authorizedUser != null)
            {
                authenticatedUser = authorizedUser;
                cardNumInput.Visibility = Visibility.Hidden;
                PINinput.Visibility = Visibility.Hidden;
                tryAuthButton.Visibility = Visibility.Hidden;
                PINlabel.Visibility = Visibility.Hidden;
                cardLabel.Visibility = Visibility.Hidden;

                MainMenuPage mainMenuPage = new MainMenuPage(authorizedUser);

                NavigationService.Navigate(mainMenuPage);
            }
            else
            {
                MessageBox.Show("Authorization failed. Exiting...");
                Application.Current.Shutdown();
            }
        }



        public User GetAuthenticatedUser()
        {
            return authenticatedUser;
        }

    }
}
