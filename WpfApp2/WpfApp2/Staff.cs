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
    static class Staff
    {
        //A
        public static void viewStaff(string id)
        {
            string query = @"SELECT * FROM Staff WHERE Staff_ID = @ID;";


            //connect to database
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet staffData = connection.getDataById(query, id);
            int count = staffData.Tables[0].Rows.Count;

            //makes sure exactly one result was found
            if (count == 1)
            {
                staff_individual staff = new staff_individual(id, staffData);
                staff.Show();
            }
            else
            {
                MessageBox.Show("No staff member found.");            
            }
        


        }
        //G

        public static DataTable shiftsGrid()
        {
            //gets today's date and formats it appropriately (removes the time)
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            //creates the query
            string sqlQuery = @"SELECT Staff.Staff_name AS Name, Staff.Staff_surname AS Surname, 
                                Shifts.Start_time AS 'Shift start', Shifts.End_time AS 'Shift end' FROM Shifts 
                                INNER JOIN Staff ON Shifts.Staff_Id = Staff.Staff_Id WHERE Shifts.Shift_date = '" + date + 
                                "' AND Staff.Role = 'GP';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //retrieves data
            DataSet todayStaff = connection.getDataSet(sqlQuery);
            //stores that data in a single table and returns it so it can be displayed in the datagrid
            DataTable dt = todayStaff.Tables[0];
            return dt;
        }
        //G
        public static DataTable individualShiftsGrid(string id, string d)
        {
            //gets today's date and formats it appropriately (removes the time)
            //string date = DateTime.Today.ToString("MM/dd/yyyy");
            //date = date.Split(' ')[0];
            string date = d;
            string[] dateCorrection = date.Split('/');
            date = dateCorrection[1];
            dateCorrection[1] = dateCorrection[0];
            dateCorrection[0] = date;
            date = dateCorrection[0] + "/" + dateCorrection[1] + "/" + dateCorrection[2];
            //creates the query
            string sqlQuery = @"SELECT Shifts.Start_time AS 'Shift start', Shifts.End_time AS 'Shift end' 
                                FROM Shifts WHERE Shifts.Staff_Id = @ID AND Shifts.Shift_date = '" + date + "';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //retrieves data
            DataSet dayShifts = connection.getDataById(sqlQuery, id);
            //stores that data in a single table and returns it so it can be displayed in the datagrid
            DataTable dt = dayShifts.Tables[0];
            return dt;
        }
        //G
        public static DataTable individualBookingGrid(string id, string d)
        {
            //gets today's date and formats it appropriately (removes the time)
            //string date = DateTime.Today.ToString("MM/dd/yyyy");
            //date = date.Split(' ')[0];
            string date = d;
            string[] dateCorrection = date.Split('/');
            date = dateCorrection[1];
            dateCorrection[1] = dateCorrection[0];
            dateCorrection[0] = date;
            date = dateCorrection[0] + "/" + dateCorrection[1] + "/" + dateCorrection[2];
            //creates the query
            string bookingsQuery = @"SELECT Time FROM Bookings WHERE Staff_Id = @ID AND Booking_Date = '" + date + "';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //retrieves data
            DataSet todayBookings = connection.getDataById(bookingsQuery, id);
            //stores that data in a single table and returns it so it can be displayed in the datagrid
            DataTable dt = todayBookings.Tables[0];
            return dt;
        }
        //J
        public static DataTable showShiftsGridDate(string d)
        {
            string date = d;
            string[] dateCorrection = date.Split('/');
            date = dateCorrection[1];
            dateCorrection[1] = dateCorrection[0];
            dateCorrection[0] = date;
            date = dateCorrection[0] + "/" + dateCorrection[1] + "/" + dateCorrection[2];
            string sqlQuery = @"SELECT Staff.Staff_name AS Name, Staff.Staff_surname AS Surname, Shifts.Start_time AS 'Shift start', Shifts.End_time AS 'Shift end' FROM Shifts INNER JOIN Staff ON Shifts.Staff_Id = Staff.Staff_Id WHERE Shifts.Shift_date = '" + date + "';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayShifts = connection.getDataSet(sqlQuery);
            DataTable dt = todayShifts.Tables[0];
            return dt;
        }

        public static void registerStaff(string name, string surname, string dob, string street, string city, string postcode, string phone, string email, string role, string username, string password)
        {
            //creates the query
            string sqlQuery;
            string psw = Login.hash(password);
            //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
            sqlQuery = @"INSERT INTO Staff (Staff_name, Staff_surname, Staff_date_of_birth, 
                        Staff_street, Staff_city, Staff_postcode, Staff_phone_number, Staff_email, Role, username, password) 
                        VALUES (@Name, @Surname, @Date_of_birth, @Street, @City, @Postcode, @Phone, @Email, @Role, @Username, @Password);";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //calls the registration method with all the data passed as parameters
            connection.registerStaff(sqlQuery, name, surname, dob, street, city, postcode, phone, email, role, username, psw);
            MessageBox.Show("Patient registered.");
        }

        public static void createShift(string id, string date, string start, string end)
        {
            //creates the query
            string sqlQuery;
            //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
            sqlQuery = @"INSERT INTO Shifts (Staff_ID, Shift_date, Start_time, End_time)
                        VALUES (@ID, @Date, @Start, @End);";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            //calls the registration method with all the data passed as parameters
            connection.createShift(sqlQuery, id, date, start, end);
            MessageBox.Show("Shift created.");
        }
    }
}
