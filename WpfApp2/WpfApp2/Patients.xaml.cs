using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
    /// Interaction logic for Patients.xaml
    /// </summary>
    public partial class Patients : Window
    {
        public Patients()
        {
            InitializeComponent();
            DataTable dt = Patient.patientsGrid();
            dataGrid.ItemsSource = dt.DefaultView;
        }

        private void bt_register_patient_Click(object sender, RoutedEventArgs e)
        {
            Patient_registration frm = new Patient_registration();
            frm.Show();
        }

        private void bt_booking_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            booking_screen frm = new booking_screen();
            frm.Show();
            this.Close();
        }

        private void search_bt_click(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
            {
                //stores what's in the Searchbox in a variable
                string id = SearchBox.Text;
                //if the searchbox contains a space, the program will search by name rather than by ID
                if (SearchBox.Text.Contains(' '))
                {
                    string[] data = SearchBox.Text.Split(' ');
                    //the user must input name, surname and date of birth or address separated by spaces
                    if (data.Length == 3)
                    {
                        this.Hide();
                        Patient.searchPatientName(data, false);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data entered is invalid. Please only enter name, surname and either postcode or date of birth.");
                    }

                }
                else
                {
                    //the program checks if the ID input is really a number
                    int number;
                    bool isNumber = Int32.TryParse(id, out number);
                    if (isNumber)
                    {
                        this.Hide();
                        Patient.searchPatient(id, false);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data entered is invalid. Please check for errors and try again.");
                    }
                }



            }
            else
            {
                MessageBox.Show("No patient found.");
            }
        }

        private void bt_home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            main_screen frm = new main_screen();
            frm.Show();
            this.Close();
        }

        private void bt_staff_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            staff_menu frm = new staff_menu();
            frm.Show();
            this.Close();
        }
    }
}
