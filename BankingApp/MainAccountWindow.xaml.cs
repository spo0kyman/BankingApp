using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace BankingApp
{
    /// <summary>
    /// Interaction logic for MainAccountWindow.xaml
    /// </summary>
    public partial class MainAccountWindow : Window
    {
        public MainAccountWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnMakeDeposit_Click(object sender, RoutedEventArgs e)
        {
            MakeDepositWindow makeDepositWindow = new MakeDepositWindow();
            makeDepositWindow.Show();
            
        }

        private void btnMakeWithdrawl_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTransferFunds_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMakePurchase_Click(object sender, RoutedEventArgs e)
        {
            MakePurchaseWindow makePurchaseWindow = new MakePurchaseWindow();
            makePurchaseWindow.Show();
        }

        private void btnViewTransactionHistory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
