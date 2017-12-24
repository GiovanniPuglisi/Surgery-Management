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
    /// Interaction logic for Create_prescription.xaml
    /// </summary>
    public partial class Create_prescription : Window
    {
        string patientId;
        string patientName;
        public Create_prescription(string id, string name)
        {
            patientId = id;
            patientName = name;
            InitializeComponent();
            tb_patient_name.Text = "Prescription for " + name;
        }

        private void bt_add_prescription_Click(object sender, RoutedEventArgs e)
        {
            string[] dateValidation = tb_start.Text.Split('/');
            string[] dateValidationb = tb_end.Text.Split('/');
            if (dateValidation.Length == 3 && dateValidationb.Length == 3)
            {
                int month;
                int monthb;
                int day;
                int dayb;
                int year;
                int yearb;
                bool monthValid = Int32.TryParse(dateValidation[0], out month);
                bool monthValidb = Int32.TryParse(dateValidationb[0], out monthb);
                bool dayValid = Int32.TryParse(dateValidation[1], out day);
                bool dayValidb = Int32.TryParse(dateValidationb[1], out dayb);
                bool yearValid = Int32.TryParse(dateValidation[2], out year);
                bool yearValidb = Int32.TryParse(dateValidationb[2], out yearb);
                if (monthValid && (month < 13) && dayValid && (day < 32) && yearValid
                    && monthValidb && (monthb < 13) && dayValidb && (dayb < 32) && yearValidb)
                {
                    if (tb_name.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && tb_start.Text.Any(c => Char.IsNumber(c) || Char.IsPunctuation(c))
                    && tb_end.Text.Any(c => Char.IsNumber(c) || Char.IsPunctuation(c)))
                        try
                        {
                            Patient.newPrescription(patientId, tb_name.Text, tb_start.Text, tb_end.Text);
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
    }
    
}
