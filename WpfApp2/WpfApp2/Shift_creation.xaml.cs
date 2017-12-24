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
    /// Interaction logic for Shift_creation.xaml
    /// </summary>
    public partial class Shift_creation : Window
    {
        public Shift_creation(string id)
        {
            InitializeComponent();
            tb_id.Text = id;
        }

        private void bt_save_shift_Click(object sender, RoutedEventArgs e)
        {
            string[] dateValidation = tb_date.Text.Split('/');
            if (dateValidation.Length == 3)
            {
                int month;
                int day;
                int year;
                bool monthValid = Int32.TryParse(dateValidation[0], out month);
                bool dayValid = Int32.TryParse(dateValidation[1], out day);
                bool yearValid = Int32.TryParse(dateValidation[2], out year);
                if (monthValid && (month < 13) && dayValid && (day < 32) && yearValid)
                {

                    //code taken from https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
                    //makes sure the characters in text boxes are numbers or separators
                    if (tb_id.Text.Any(c => Char.IsNumber(c)) && tb_start.Text.Any(c => Char.IsNumber(c) || Char.IsPunctuation(c))
                        && tb_end.Text.Any(c => Char.IsNumber(c) || Char.IsPunctuation(c)) && tb_date.Text.Any(c => Char.IsNumber(c) || Char.IsPunctuation(c)))
                    {
                        try
                        {
                            Staff.createShift(tb_id.Text, tb_date.Text, tb_start.Text, tb_end.Text);
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Some or all of the data fields have invalid content. Please check the data entered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Some or all of the data fields have invalid content. Please check the data entered.");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid date entered. Please check for errors and try again");
                }
            }
            else
            {
                MessageBox.Show("Invalid date entered. Please check for errors and try again");
            }
        }
    }
}
