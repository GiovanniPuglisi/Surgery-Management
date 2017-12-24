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
using System.Data;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Prescriptions.xaml
    /// </summary>
    public partial class Prescriptions : Window
    {
        string patientId;
        string patientName;
        public Prescriptions(string id, string name)
        {
            patientId = id;
            patientName = name;
            InitializeComponent();
            tb_patient_name.Text = "Prescriptions for " + patientName;
            DataTable dt = Patient.prescriptionsDataGrid(patientId);
            dataGrid.ItemsSource = dt.DefaultView;
        }

        private void bt_new_prescription_Click(object sender, RoutedEventArgs e)
        {
            Create_prescription frm = new Create_prescription(patientId, patientName);
            frm.Show();
        }


        private void bt_update_prescription_Click(object sender, RoutedEventArgs e)
        {
            Update_prescription frm = new Update_prescription();
            frm.Show();
        }

        private void bt_delete_prescription_Click(object sender, RoutedEventArgs e)
        {
            Delete_prescription frm = new Delete_prescription();
            frm.Show();
        }
    }
}
