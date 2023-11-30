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

namespace ATMwpf
{
    /// <summary>
    /// Interaction logic for TransferMoneyPage.xaml
    /// </summary>
    public partial class TransferMoneyPage : Page
    {
        private User currentUser;

        public TransferMoneyPage(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void TransferMoney_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void cancelBttn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void transferBttn_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(amountToTransfer.Text) || string.IsNullOrWhiteSpace(cardNumberInput.Text))
            {
                MessageBox.Show("Please enter both amount and card number.");
                return;
            }

            if (!float.TryParse(amountToTransfer.Text, out float amount))
            {
                MessageBox.Show("Invalid amount. Please enter a valid numeric value.");
                return;
            }

            currentUser.GetAccount().WithdrawMoney(amount);
            MessageBox.Show($"Successfully deducted {amount:C} from your account. Your updated balance is {currentUser.GetAccount().GetAccountInfo():C}.");
        }


    }
}
