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
    /// Interaction logic for main_screen.xaml
    /// </summary>
    public partial class main_screen : Window
    {
        public main_screen()
        {
            InitializeComponent();
            DataTable dt = Login.mainScreenData();
            dataGrid.ItemsSource = dt.DefaultView;
            //int count = todayPatients.Tables[0].Rows.Count;
            
        }

        private void bt_bookings_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            booking_screen frm = new booking_screen();
            frm.Show();
            this.Close();
        }

        private void bt_patients_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Patients frm = new Patients();
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

        private void bt_register_patient_Click(object sender, RoutedEventArgs e)
        {
            Patient_registration frm = new Patient_registration();
            frm.Show();
        }
        //G
        private void button_searchPatient(object sender, RoutedEventArgs e)
         {
            
                  if (search_patient.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
                  {
                     //stores what's in the Searchbox in a variable
                     string id = search_patient.Text;
                  if (search_patient.Text.Contains(' '))
                  {
                     string[] data = search_patient.Text.Split(' ');
                    if (data.Length == 3)
                    {
                        this.Hide();
                        Patient.searchPatientName(data, true);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data entered is invalid. Please only enter name, surname and either postcode or date of birth.");
                    }
 
                  }
                  else
                  {
                    int number;
                    bool isNumber = Int32.TryParse(id, out number);
                    if (isNumber)
                    {
                        this.Hide();
                        Patient.searchPatient(id, true);
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
        //J
        private void button_searchBooking(object sender, RoutedEventArgs e)
        {
            if (search_booking.Text.Any(c => Char.IsDigit(c) || Char.IsWhiteSpace(c)))
            {
                //stores what's in the Searchbox in a variable
                string id = search_booking.Text;             
                Booking.viewBooking(id);
            }
            else
            {
                MessageBox.Show("No booking found.");
            }
        }

        private void bt_new_booking_Click(object sender, RoutedEventArgs e)
        {
            Booking_new frm = new Booking_new();
            frm.Show();
        }
    }
}
