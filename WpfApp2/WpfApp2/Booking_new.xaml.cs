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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Booking_new.xaml
    /// </summary>
    public partial class Booking_new : Window
    {
        public Booking_new()
        {
            InitializeComponent();
        }
        //G
        private void bt_confirm_booking_Click(object sender, RoutedEventArgs e)
        {
            //code taken from https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
            //makes sure the characters in text boxes are letters, digits or spaces
            if (ID.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                && Doctor.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Date.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                && Time.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Room.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
            {
                try
                {
                    Booking.createBooking(ID.Text, Doctor.Text, Date.Text, Time.Text, Room.Text, Description.Text);
                    MessageBox.Show("Booking created.");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Some or all of the data fields have invalid content. Please check the data entered.");
                }
            }
            else
                MessageBox.Show("Some or all of the data fields have invalid content. Please check the data entered.");
        }
    }
}
