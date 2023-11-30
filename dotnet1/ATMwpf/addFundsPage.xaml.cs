using ATMClassLibrary;
using System.Windows;
using System.Windows.Controls;

namespace ATMwpf.View
{
    public partial class addFundsPage : Page
    {
        private User currentUser;

        public addFundsPage(User user)
        {
            InitializeComponent();
            currentUser = user;

            if (currentUser == null || !currentUser.IsAuthenticated())
            {
                MessageBox.Show("User not authenticated. Exiting...");
                Application.Current.Shutdown();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenuPage(currentUser));
        }

        private void addMoneyButton_Click(object sender, RoutedEventArgs e)
        {
            if (currentUser != null && currentUser.IsAuthenticated())
            {
                if (float.TryParse(amountTextBox.Text, out float amount))
                {
                    AddMoneyToUserBalance(amount);
                    MessageBox.Show($"Successfully added {amount:C} to your account.");
                }
                else
                {
                    MessageBox.Show("Invalid amount. Please enter a valid numeric value.");
                }
            }
            else
            {
                MessageBox.Show("User not authenticated. Exiting...");
                Application.Current.Shutdown();
            }
        }

        private void AddMoneyToUserBalance(float amount)
        {
            currentUser.GetAccount().AddMoneyToAcc(amount);
        }
    }
}
