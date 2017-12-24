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
    /// Interaction logic for Delete_prescription.xaml
    /// </summary>
    public partial class Delete_prescription : Window
    {
        public Delete_prescription()
        {
            InitializeComponent();
        }

        private void bt_delete_prescription_Click(object sender, RoutedEventArgs e)
        {
                if (tb_id.Text.Any(c => Char.IsNumber(c)))
                    try
                    {
                        if (Patient.findPrescription(tb_id.Text))
                        {
                            if (System.Windows.MessageBox.Show("Are you sure you want to delete prescription number " + tb_id.Text + "?", "Delete prescription",
                                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                            {
                                Patient.deletePrescription(tb_id.Text);
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
                        MessageBox.Show("Invalid ID entered.");
                    }
                else
                {
                    MessageBox.Show("Invalid ID entered.");
                }
            
        }
    }
}