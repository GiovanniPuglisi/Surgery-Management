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
    /// Interaction logic for Update_prescription.xaml
    /// </summary>
    public partial class Update_prescription : Window
    {
        public Update_prescription()
        {
            InitializeComponent();
        }

        private void bt_update_prescription_Click(object sender, RoutedEventArgs e)
        {
            
                string[] dateValidation = tb_end.Text.Split('/');
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
                    if (tb_id.Text.Any(c => Char.IsNumber(c)) && tb_end.Text.Any(c => Char.IsNumber(c) || Char.IsPunctuation(c)))
                    {
                        try
                        {
                            if (Patient.findPrescription(tb_id.Text))
                            {
                                if (System.Windows.MessageBox.Show("Are you sure want to save changes", "Save Prescription Changes",
                                    MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                                {
                                    Patient.updatePrescription(tb_id.Text, tb_end.Text);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Invalid ID entered. Please try again with an existing ID.");
                            }
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
