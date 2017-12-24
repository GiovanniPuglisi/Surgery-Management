using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp2
{
    public static class Patient
    {
        //G
        public static void searchPatient(string id, bool main)
        {
            //creates the SQL query
            string query = @"SELECT * FROM Patients WHERE Patient_Id = @ID;";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet patientData = connection.getDataById(query, id);
            //checks that the query returned exactly one result
            int count = patientData.Tables[0].Rows.Count;

            if (count == 1)
            {
                individual_patient patient = new individual_patient(id, patientData);
                patient.Show();
            }
            else
            {
                MessageBox.Show("No patient found.");
                if (main)
                {
                    main_screen frm = new main_screen();
                    frm.Show();
                }
                else
                {
                    Patients frm = new Patients();
                    frm.Show();
                }
            }
        }
        //G
        public static void searchPatientName(string[] name, bool main)
         {
 
             //create sql statement
             DBConnection connection = DBConnection.getDBConnectionInstance();
             if (name[2].Contains('/'))
             {
                 string sqlQuery = @"SELECT * FROM Patients WHERE Patient_name = @Name AND 
                                   Patient_surname = @Surname AND Patient_date_of_birth = @DobOrAddress;";
                 DataSet patientData = connection.searchPatientByName(sqlQuery, name[0], name[1], name[2]);
                 //checks that the query returned exactly one result
                 int count = patientData.Tables[0].Rows.Count;
 
                 if (count == 1)
                 {
                     individual_patient patient = new individual_patient(patientData.Tables[0].Rows[0].Field<int>("Patient_Id").ToString(), patientData);
                     patient.Show();
                 }
                 else
                 {
                     MessageBox.Show("No patient found.");
                     if (main)
                    {
                        main_screen frm = new main_screen();
                        frm.Show();
                    }
                     else
                    {
                        Patients frm = new Patients();
                        frm.Show();
                    }
                 }
             }
             else
             {
 
 
                 string query = @"SELECT * FROM Patients WHERE Patient_name = @Name AND Patient_surname = @Surname AND Patient_postcode = @DobOrAddress;";
                 DataSet patientDataPostcode = connection.searchPatientByName(query, name[0], name[1], name[2]);
                 //checks that the query returned exactly one result
                 int count = patientDataPostcode.Tables[0].Rows.Count;
 
               if (count == 1)
                 {
                     individual_patient patient = new individual_patient(patientDataPostcode.Tables[0].Rows[0].Field<int>("Patient_Id").ToString(), patientDataPostcode);
                     patient.Show();
                 }
                else
                 {
                     MessageBox.Show("No patient found.");
                    if (main)
                    { 
                        main_screen frm = new main_screen();
                        frm.Show();
                    }
                    else
                    {
                        Patients frm = new Patients();
                        frm.Show();
                    }
                }
            }
             
             
             
         }
        //G
        public static void updatePatient(string name, string surname, string date, string street, 
                                        string city, string postcode, string phone, string emergency_phone, 
                                        string mail, string id)
        {
            //creates the query
            string sqlQuery;
            //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
            sqlQuery = @"UPDATE Patients SET Patient_name = @Name, Patient_surname = @Surname, Patient_date_of_birth = @Date_of_birth, 
                        Patient_street = @Street, Patient_city = @City, Patient_postcode = @Postcode, Patient_phone_number = @Phone, 
                        Emergency_contact = @Emergency_phone, Patient_email = @Email WHERE Patient_Id = @PatientID";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //calls the registration method with all the data passed as parameters
            connection.updatePatient(sqlQuery, name, surname, date, street, city, postcode, phone, emergency_phone, mail, id);
            MessageBox.Show("Patient information updated.");
        }
        //G
        public static int registerPatient(string name, string surname, string date, string street, 
                                          string city, string postcode, string phone, string emergency_phone, string mail)
        {
            //creates the query
            string sqlQuery;
            //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
            sqlQuery = @"INSERT INTO Patients (Patient_name, Patient_surname, Patient_date_of_birth, 
                        Patient_street, Patient_city, Patient_postcode, Patient_phone_number, Emergency_contact, Patient_email) 
                        VALUES (@Name, @Surname, @Date_of_birth, @Street, @City, @Postcode, @Phone, @Emergency_phone, @Email);";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //calls the registration method with all the data passed as parameters
            int count = connection.register(sqlQuery, name, surname, date, street, city, postcode, phone, emergency_phone, mail);
            MessageBox.Show("Patient registered.");
            return count;
        }
        //J
        public static DataTable patientsGrid()
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Patients.Patient_ID AS ID, Patients.Patient_name AS Name, Patients.Patient_surname AS Surname, Patients.Patient_phone_number AS Number, Staff.Staff_surname AS Doctor FROM Patients INNER JOIN Bookings ON Patients.Patient_ID = Bookings.Patient_ID INNER JOIN Staff ON Bookings.Staff_ID = Staff.Staff_ID WHERE Bookings.Booking_date = '" + date + "'";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayPatients = connection.getDataSet(sqlQuery);
            DataTable dt = todayPatients.Tables[0];
            return dt;
        }
        //J
        public static DataTable individualPatientsGrid(string id)
        {
            string sqlQuery = @"SELECT Booking_Id AS 'Booking ID', Patient_Id AS 'ID', Staff_Id AS 'Staff ID', Booking_Date AS 'Date', Time, Room, Description from Bookings WHERE Patient_Id = @ID ORDER BY Booking_Date DESC;";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayPatients = connection.getDataById(sqlQuery, id);
            DataTable dt = todayPatients.Tables[0];
            return dt;
        }

        public static DataTable prescriptionsDataGrid(string id)
        {
            string sqlQuery = @"SELECT Prescription_Id AS 'ID', Prescription_name AS 'Name', Prescription_start AS 'Start date', Prescription_end AS 'End date'
                                FROM Prescriptions WHERE Patient_Id = @ID AND GETDATE() BETWEEN Prescription_start AND Prescription_end";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayPatients = connection.getDataById(sqlQuery, id);
            DataTable dt = todayPatients.Tables[0];
            return dt;
        }

        public static void newPrescription(string patientId, string name, string start, string end)
        {
            //creates the query
            string sqlQuery;
            //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
            sqlQuery = @"INSERT INTO Prescriptions (Patient_Id, Prescription_name, Prescription_start, Prescription_end) 
                        VALUES (@ID, @Name, @Start, @End);";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //calls the prescription creation method with all the data passed as parameters
            connection.createPrescription(sqlQuery, patientId, name, start, end);
            MessageBox.Show("Prescription added.");
        }
        public static bool findPrescription(string id)
        {
            string sqlQuery;
            sqlQuery = @"SELECT Prescription_Id FROM Prescriptions WHERE Prescription_Id = @ID;";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet dt = connection.getDataById(sqlQuery, id);
            if (dt.Tables[0].Rows[0].Field<int>("Prescription_Id").ToString() == id)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void updatePrescription(string prescriptionId, string end)
        {
            //creates the query
            string sqlQuery;
            //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
            sqlQuery = @"UPDATE Prescriptions SET Prescription_end = @End WHERE Prescription_Id = @ID";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //calls the prescription update method with all the data passed as parameters
            connection.extendPrescription(sqlQuery, prescriptionId, end);
            MessageBox.Show("Prescription updated.");
        }

        public static void deletePrescription(string id)
        {
            string sqlQuery;
            //creates the query with parameters 
            sqlQuery = @"DELETE FROM Prescriptions where Prescription_Id = @ID;";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //this method uses the booking deletion method as it needs to substitute the same parameters
            connection.deleteBooking(sqlQuery, id);
            MessageBox.Show("Prescription deleted.");
        }
    }
}
