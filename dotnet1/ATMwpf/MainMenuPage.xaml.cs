using ATMClassLibrary;
using System;
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

namespace ATMwpf.View
{
    public partial class MainMenuPage : Page
    {
        private User currentUser;
        public MainMenuPage(User user)
        {
            InitializeComponent();
            currentUser = user;
        }


        private void addMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentUser != null && currentUser.IsAuthenticated())
            {
                NavigationService.Navigate(new addFundsPage(currentUser));
                addMoneyButton.Visibility = Visibility.Hidden;
                transferMoneyButton.Visibility = Visibility.Hidden;
                checkBalanceButton.Visibility = Visibility.Hidden;
                goBackButton.Visibility = Visibility.Hidden;
            }
            else
            {
                MessageBox.Show("User not authenticated.");
            }
        }


        private void MainContentFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void transferMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new TransferMoneyPage(currentUser));
        }

        private void checkBalanceButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentUser != null && currentUser.IsAuthenticated())
            {
                MessageBox.Show($"Your current balance is: {currentUser.GetAccount().GetAccountInfo():C}");
            }
            else
            {
                MessageBox.Show("User not authenticated.");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MainContentFrame.Navigate(new Uri("AuthorizationPage.xaml"), UriKind.Relative);
            this.NavigationService.Navigate(new AutorizationPage());
        }
    }
}
