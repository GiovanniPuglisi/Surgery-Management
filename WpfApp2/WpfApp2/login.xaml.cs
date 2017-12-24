using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;


namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }
        //J
        private void bt_login_Click(object sender, RoutedEventArgs e)
        {
            //variables for username and password input
            string user, pass;

            user = textBox.Text;
            pass = passwordBox.Password;

            //verification of empty fields
            if (textBox.Text.Length < 1 || passwordBox.Password.Length < 1)
            {
                MessageBox.Show("Credentials missing. Please enter a username and a password.");
                return;
            }
            //validation of username and password combination in DB

            try
            {
                Login.verifyLogin(user, pass);
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
