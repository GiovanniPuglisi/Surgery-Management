using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp2
{
    public static class Booking 
    {
        
        //G
        public static int createBooking(string id, string doctor, string date, string time, string room, string description)
        {
            //creates the query
            string sqlQuery;
            //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
            sqlQuery = @"INSERT INTO Bookings (Patient_ID, Staff_ID, Booking_Date, Time, Room, Description) 
                         VALUES (@PatientID, @DoctorID, @Date, @Time, @Room, @Description);";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            int count = connection.book(sqlQuery, id, doctor, date, time, room, description);
            return count;
               
        }
        //J
        public static void cancelBooking(string id)
        {
            string sqlQuery;
            //creates the query with parameters 
            sqlQuery = @"DELETE FROM Bookings where Booking_Id = @ID;";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            connection.deleteBooking(sqlQuery, id);
            MessageBox.Show("Booking deleted.");
        }

        public static void viewBooking(string id)
        {
            //creates the SQL query
            string query = @"SELECT *, Patients.Patient_name, Patients.Patient_surname FROM Bookings INNER JOIN Patients ON Bookings.Patient_ID = Patients.Patient_ID WHERE Booking_Id = @ID;";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet bookingData = connection.getDataById(query, id);
            //checks that the query returned exactly one result
            int count = bookingData.Tables[0].Rows.Count;

            if (count == 1)
            {
                Individual_bookings booking = new Individual_bookings(id, bookingData);
                booking.Show();
            }
            else
            {
                MessageBox.Show("No booking found.");              
            }      
        }      
        //G
        public static DataTable showBookingsGrid()
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Patients.Patient_ID AS 'ID', Patients.Patient_name AS 'Name', Patients.Patient_surname AS 'Surname', Staff.Staff_id AS 'Staff ID', Bookings.Booking_ID AS 'Booking ID', Bookings.Booking_Date AS 'Date', Bookings.Time AS 'Time', Bookings.Room AS 'Room', Bookings.Description FROM Bookings INNER JOIN Patients ON Patients.Patient_ID = Bookings.Patient_ID INNER JOIN Staff on Bookings.Staff_ID = Staff.Staff_ID WHERE Bookings.Booking_date = '" + date + "'";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayBookings = connection.getDataSet(sqlQuery);
            DataTable dt = todayBookings.Tables[0];
            return dt;
        }
        //J
        public static DataTable showBookingsGridDate(string d)
        {
            //Stores the date from the datepicker
            string date = d;
            //Turns the date around to the MM/DD/YYYY format, which will not give an error
            string[] dateCorrection = date.Split('/');
            date = dateCorrection[1];
            dateCorrection[1] = dateCorrection[0];
            dateCorrection[0] = date;
            date = dateCorrection[0] + "/" + dateCorrection[1] + "/" + dateCorrection[2];
            string sqlQuery = @"SELECT Patients.Patient_ID AS 'ID', Patients.Patient_name AS 'Name', Patients.Patient_surname AS 'Surname', Staff.Staff_id AS 'Staff ID', Bookings.Booking_ID AS 'Booking ID', Bookings.Booking_Date AS 'Date', Bookings.Time AS 'Time', Bookings.Room AS 'Room', Bookings.Description FROM Bookings INNER JOIN Patients ON Patients.Patient_ID = Bookings.Patient_ID INNER JOIN Staff on Bookings.Staff_ID = Staff.Staff_ID WHERE Bookings.Booking_date = '" + date + "'";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayBookings = connection.getDataSet(sqlQuery);
            DataTable dt = todayBookings.Tables[0];
            return dt;
        }
        //G
        public static void updateBooking(string id, string patientId, string doctor, 
                                        string date, string time, string room, string description)
        {
            string sqlQuery;
            //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
            sqlQuery = @"UPDATE Bookings SET Patient_Id = @PatientID, Staff_Id = @DoctorID, Booking_Date = @Date, Time = @Time, 
                        Room = @Room, Description = @Description WHERE Booking_Id = '" + id + "';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            connection.book(sqlQuery, patientId, doctor, date, time, room, description);
            System.Windows.MessageBox.Show("Booking updated.");
        }
    }
}

