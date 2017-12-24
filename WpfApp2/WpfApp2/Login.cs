using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    public class Login
    {
        //J
        public static void verifyLogin(string u, string p)
        {     
                string user = u;
                string pass = hash(p);
                string query = "SELECT username FROM staff WHERE username=@User and password=@Password";

                DBConnection connection = DBConnection.getDBConnectionInstance();
                DataSet DataLogin = connection.login(query, user, pass);

                int count = DataLogin.Tables[0].Rows.Count;

                //open main window
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");                   
                    main_screen ms = new main_screen();
                    ms.Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials, please enter registered username and passsword!");
                    login lg = new login();
                    lg.Show();
                }

            }
        //G
        public static DataTable mainScreenData()
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Patients.Patient_ID AS ID, Patients.Patient_name AS Name, Patients.Patient_surname AS Surname, Bookings.Booking_ID AS Booking, Bookings.Time, Bookings.Room FROM Patients INNER JOIN Bookings ON Patients.Patient_ID = Bookings.Patient_ID WHERE Bookings.Booking_date = '" + date + "'";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayPatients = connection.getDataSet(sqlQuery);
            DataTable dt = todayPatients.Tables[0];
            return dt;
        }

        public static string hash(string message)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(message);
            SHA256Managed shaHash = new SHA256Managed();
            byte[] hash = shaHash.ComputeHash(bytes);
            System.Text.StringBuilder hashedString = new System.Text.StringBuilder();
            foreach (byte currentByte in hash)
            {
                hashedString.Append(currentByte.ToString("x2"));
            }
            return hashedString.ToString();
        }

    }
}

