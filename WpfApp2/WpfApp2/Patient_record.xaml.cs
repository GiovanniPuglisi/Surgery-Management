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
    /// Interaction logic for Patient_record.xaml
    /// </summary>
    public partial class Patient_record : Window
    {
        string id;
        DataSet patientData;
        //G
        public Patient_record(string patientID, DataSet data)
        {
            //the constructor gets passed the ID of the patient this information belongs to and the actual dataset
            id = patientID;
            patientData = data;
            InitializeComponent();
            //the data from the database is put into the corresponding text boxes (or blocks)
            Name.Text = patientData.Tables[0].Rows[0].Field<string>("Patient_name");
            Surname.Text = patientData.Tables[0].Rows[0].Field<string>("Patient_surname");
            Date_of_birth.Text = patientData.Tables[0].Rows[0].Field<DateTime>("Patient_date_of_birth").ToString();
            Address_street.Text = patientData.Tables[0].Rows[0].Field<string>("Patient_street");
            Address_city.Text = patientData.Tables[0].Rows[0].Field<string>("Patient_city");
            Address_postcode.Text = patientData.Tables[0].Rows[0].Field<string>("Patient_postcode");
            Phone.Text = patientData.Tables[0].Rows[0].Field<string>("Patient_phone_number");
            Phone_emergency.Text = patientData.Tables[0].Rows[0].Field<string>("Emergency_contact");
            Mail.Text = patientData.Tables[0].Rows[0].Field<string>("Patient_email");
            IDBlock.Text = id;
        }

        
        //G
        private void bt_save_changes_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Are you sure want to save changes", "Save Patient Changes",
            MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //code taken from https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
                //makes sure the characters in text boxes are letters, digits or spaces
                if (Name.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Surname.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                && Date_of_birth.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c) || c == '/') && Address_street.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                && Address_city.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Address_postcode.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                && Phone.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Phone_emergency.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
                {
                    try
                    {
                        Patient.updatePatient(Name.Text, Surname.Text, Date_of_birth.Text, Address_street.Text, Address_city.Text, Address_postcode.Text, Phone.Text, Phone_emergency.Text, Mail.Text, id);
                    }
                    catch
                    {
                        MessageBox.Show("Some or all of the data fields have invalid content. Please check the data entered.");
                    }
                }
                else
                {
                    MessageBox.Show("Some or all of the data fields have invalid content. Please check the data entered.");
                }
            }
        }
    }
}

