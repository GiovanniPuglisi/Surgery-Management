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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class staff_menu : Window
    {
        public staff_menu()
        {
            InitializeComponent();
            DataTable shifts = Staff.shiftsGrid();
            dataGrid.ItemsSource = shifts.DefaultView;
        }

        private void btn_bookings_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            booking_screen frm = new booking_screen();
            frm.Show();
            this.Close();
        }

        private void btn_patients_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Patients frm = new Patients();
            frm.Show();
            this.Close();

        }

       

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            main_screen frm = new main_screen();
            frm.Show();
            this.Close();
        }
        //A
        private void Search_Staff(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Any(c => Char.IsDigit(c) || Char.IsWhiteSpace(c)))
            {
                //stores what's in the Searchbox in a variable
                string id = SearchBox.Text;             
                Staff.viewStaff(id);
                
                //checks that the query returned exactly one result
                              
            }
            else
            {
                MessageBox.Show("No staff member found.");
            }
        }
        //J
        private void gettodayshifts(object sender, RoutedEventArgs e)
        {
            if (dp2.Text == "")
            {
                MessageBox.Show("Pick a date please.");
            }
            else
            { 
            string date = dp2.Text;
            DataTable dn = Staff.showShiftsGridDate(date);
            dataGrid.ItemsSource = dn.DefaultView;
            }
        }

        private void bt_new_staff(object sender, RoutedEventArgs e)
        {
            Staff_registration frm = new Staff_registration();
            frm.Show();
        }
    }
 }

