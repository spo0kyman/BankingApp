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

namespace BankingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DataSetTableAdapters.UserTableAdapter tableAdapter = new DataSetTableAdapters.UserTableAdapter();
        private DataSet dataSet = new DataSet();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            tableAdapter.Fill(dataSet.User);
            DataContext = dataSet.User.DefaultView;

        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            var query = from user in dataSet.User
                        where (user.Username == txtName.Text)
                        where (user.Password == txtPassword.Text)
                        select user;

            // check if there is a match, query will have entry
            if (query.Count() > 0)
            {
                // create instance of the MainWindow (new)
  
                MainAccountWindow mainAccountWindow = new MainAccountWindow();
                // show window
                mainAccountWindow.Show();
                // Close() this window
                this.Close();
            }
            else
            {

                // show message box that states the user does not exist


                MessageBoxResult result = MessageBox.Show("User does not exist", "Submit", MessageBoxButton.OK, MessageBoxImage.Error);
                // on the message box show an error icon and “Submit” caption
                // look at resources section below for message box information
                txtName.Clear();
                txtPassword.Clear();
                // clear text boxes
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            DataSet.UserRow  row = (DataSet.UserRow)dataSet.User.NewRow();
            // set row Name to name textbox Text
            // set row Password to password textbox Text

            row.Username = txtName.Text;
            row.Password = txtPassword.Text;

            dataSet.User.AddUserRow(row);
            tableAdapter.Update(dataSet);

            // show message box that states the user was registered
            MessageBoxResult result = MessageBox.Show("User has been created", "Register", MessageBoxButton.OK, MessageBoxImage.Information);
            // on the message box show an information icon and “Register” caption
            // look at resources section below for message box information

            // clear text boxes
            txtName.Clear();
            txtPassword.Clear();
        }
    }
}
