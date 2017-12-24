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
    /// Interaction logic for individual_patient.xaml
    /// </summary>
    public partial class individual_patient : Window
    {
        //the constructor gets passed the ID of the patient this information belongs to and the actual dataset
        string patientId;
        string patientName;
        DataSet patientData;
        //G
        public individual_patient(string id, DataSet data)
        {
            patientId = id;
            patientData = data;
            InitializeComponent();
            DataTable dt = Patient.individualPatientsGrid(patientId);
            dataGrid.ItemsSource = dt.DefaultView;
            patientName = patientData.Tables[0].Rows[0].Field<string>("Patient_name").Trim() + " " + patientData.Tables[0].Rows[0].Field<string>("Patient_surname").Trim();
            tb_name.Text = patientName;
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }
        //A
        private void bt_cancel_booking_Click(object sender, RoutedEventArgs e)
        {
            // confirmation pop up message
            System.Windows.Forms.MessageBox.Show("Are you sure want to cancel booking", "Cancel Booking",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

        }

        private void bt_home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            main_screen frm = new main_screen();
            frm.Show();
            this.Close();
        }

        private void bt_booking_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            booking_screen frm = new booking_screen();
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

        private void bt_patient_record_Click(object sender, RoutedEventArgs e)
        {
            Patient_record record = new Patient_record(patientId, patientData);
            record.Show();
        }

        private void bt_prescriptions_Click(object sender, RoutedEventArgs e)
        {
            Prescriptions frm = new Prescriptions(patientId, patientName);
            frm.Show();
        }
    }
}
