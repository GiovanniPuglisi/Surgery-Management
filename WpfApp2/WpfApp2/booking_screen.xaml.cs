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
    /// Interaction logic for booking_screen.xaml
    /// </summary>
    public partial class booking_screen : Window
    {
        public booking_screen()
        {
            InitializeComponent();
            DataTable dt = Booking.showBookingsGrid();
            bookingsGrid.ItemsSource = dt.DefaultView;
        }
        private void bt_home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            main_screen frm = new main_screen();
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

        private void bt_new_booking_Click(object sender, RoutedEventArgs e)
        {
            Booking_new frm = new Booking_new();
            frm.Show();
        }

        private void bTsearch_Click(object sender, RoutedEventArgs e)
        {
            if (booking_search.Text.Any(c => Char.IsDigit(c)))
            {
                //stores what's in the Searchbox in a variable
                string id = booking_search.Text;
                //call viewBooking method
                Booking.viewBooking(id);
            }
            else
            {
                MessageBox.Show("No booking found.");
            }
        }
        //J
        private void bTsearchDate_Click(object sender, RoutedEventArgs e)
        {
            if (dp1.Text == "")
            {
                MessageBox.Show("Pick a date please.");
            }
            else
            {
                string date = dp1.Text;
                DataTable dn = Booking.showBookingsGridDate(date);
                bookingsGrid.ItemsSource = dn.DefaultView;
            }
        }
    }
}
