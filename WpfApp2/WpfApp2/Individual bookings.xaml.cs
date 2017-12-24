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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Individual_bookings.xaml
    /// </summary>
    public partial class Individual_bookings : Window 
      

    {
        string bookingId;
        DataSet bookingData;
        //G
        public Individual_bookings(string id, DataSet data)
        {
            InitializeComponent();
            //the constructor gets passed the ID of the patient this information belongs to and the actual dataset
            bookingId = id;
            bookingData = data;
            InitializeComponent();
            //the data from the database is put into the corresponding text boxes (or blocks)
            
            tb_patientid.Text = bookingData.Tables[0].Rows[0].Field<int>("Patient_Id").ToString();
            tb_name.Text = bookingData.Tables[0].Rows[0].Field<string>("Patient_name").Trim() + " " + bookingData.Tables[0].Rows[0].Field<string>("Patient_surname").Trim();
            tb_doctor.Text = bookingData.Tables[0].Rows[0].Field<int>("Staff_Id").ToString();
            tb_date.Text = bookingData.Tables[0].Rows[0].Field<DateTime>("Booking_Date").ToString().Split(' ')[0];
            tb_time.Text = bookingData.Tables[0].Rows[0].Field<TimeSpan>("Time").ToString();
            tb_room.Text = bookingData.Tables[0].Rows[0].Field<string>("Room");
            tb_description.Text = bookingData.Tables[0].Rows[0].Field<string>("Description");
            tb_bookingid.Text = id;
            //Booking.viewBooking();
        }
        //A
        private void bt_cancel_booking_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Are you sure want to save changes", "Save Booking Changes",
       MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Booking.cancelBooking(tb_bookingid.Text);
            }
        }
       

        private void tb_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //G
        private void bt_save_changes_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Are you sure want to save changes", "Save Booking Changes",
      MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //code taken from https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
                //makes sure the characters in text boxes are letters, digits or spaces
                if (tb_patientid.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                    && tb_doctor.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && tb_date.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                    && tb_time.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && tb_room.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
                {
                    try
                    {
                        Booking.updateBooking(bookingId, tb_patientid.Text, tb_doctor.Text, tb_date.Text, tb_time.Text, tb_room.Text, tb_description.Text);
                    }
                    catch
                    {
                        System.Windows.Forms.MessageBox.Show("Data entered is invalid. Please check for errors and try again");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Data entered is invalid. Please check for errors and try again.");
                }

            }
        }

        private void tb_patient_id_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void bt_home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            main_screen arm = new main_screen();
            arm.Show();
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

        //Name of the class your method is in dot and the name of your method 
        
    }
}
