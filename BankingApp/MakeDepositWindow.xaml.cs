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
    /// Interaction logic for MakeDepositWindow.xaml
    /// </summary>
    public partial class MakeDepositWindow : Window
    {
        public int number { get; set; }
        public MakeDepositWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            number = int.Parse(amountDeposit.Text);

            MainAccountWindow mainAccountWindow = new MainAccountWindow();

            if (btnSavingsAccount.IsEnabled)
            {
                mainAccountWindow.txtSavingsBalanceAmount.Text += number.ToString();
            }
            else
            {
                mainAccountWindow.txtCheckingBalanceAmount.Text += number.ToString();
            }

        }
    }
}
