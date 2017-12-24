using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class DBConnection
    {
        //attributes
        private static DBConnection _instance;

        private static string connectionString;

        private SqlConnection connectionToDB;

        private SqlDataAdapter dataAdapter;


        //properties
        public static string ConnectionStr
        {
            set
            {
                connectionString = value;
            }
        }

        //methods
        public static DBConnection getDBConnectionInstance()
        {
            if (_instance == null)
                _instance = new DBConnection();

            return _instance;
        }

        // Open the connection
        public void openConnection()
        {
            string filepath = Directory.GetCurrentDirectory();
            string[] dividedPath = filepath.Split('\\');
            filepath = dividedPath[0] + "\\" + dividedPath[1] + "\\" + dividedPath[2] + "\\" + dividedPath[3] + "\\" + dividedPath[4] + "\\" + dividedPath[5] + "\\";
            ConnectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + filepath + "Database1.mdf;Integrated Security=True";
            // create the connection to the database as an instance of SqlConnection
            connectionToDB = new SqlConnection(connectionString);

            //open connection
            connectionToDB.Open();
        }

        public void closeConnection()
        {
            connectionToDB.Close();
        }


       //create a data set for a certain request
        public DataSet getDataSet(String sqlStatement)
        {
            DataSet dataSet = new DataSet();

            //open connection
            openConnection();

            //create the data adapter object
            dataAdapter = new SqlDataAdapter(sqlStatement, connectionToDB);

            //fill in the data set
            dataAdapter.Fill(dataSet);
            

            //close connection
            closeConnection();

            return dataSet;
        }
        //G
        public DataSet getDataById(string sqlStatement, string id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlStatement;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("ID", id));
            openConnection();
            command.Connection = connectionToDB;
            dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            closeConnection();
            return dataSet;
        }
        //G
        public DataSet login(string sqlStatement, string user, string pass)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlStatement;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("User", user));
            command.Parameters.Add(new SqlParameter("Password", pass));
            openConnection();
            command.Connection = connectionToDB;
            dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            closeConnection();
            return dataSet;

        }
        //G
        public DataSet searchPatientByName(string sqlStatement, string name, string surname, string dobOrAddress)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlStatement;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("Name", name));
            command.Parameters.Add(new SqlParameter("Surname", surname));
            command.Parameters.Add(new SqlParameter("DobOrAddress", dobOrAddress));
            openConnection();
            command.Connection = connectionToDB;
            dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            closeConnection();
            return dataSet;
        }

        //create a patient record in the database. Data from the user is inserted into the query here as parameters, rather than directly on the front-end
        //G
        public int register(string sqlQuery, string name, string surname, string date_of_birth, string street, 
                            string city, string postcode, string phone, string emergency_phone, string email)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("Name", name));
            command.Parameters.Add(new SqlParameter("Surname", surname));
            command.Parameters.Add(new SqlParameter("Date_of_birth", date_of_birth));
            command.Parameters.Add(new SqlParameter("Street", street));
            command.Parameters.Add(new SqlParameter("City", city));
            command.Parameters.Add(new SqlParameter("Postcode", postcode));
            command.Parameters.Add(new SqlParameter("Phone", phone));
            command.Parameters.Add(new SqlParameter("Emergency_phone", emergency_phone));
            command.Parameters.Add(new SqlParameter("Email", email));
            //open the connection
            openConnection();
            command.Connection = connectionToDB;
            //executes the query and closes the connection
            int count = command.ExecuteNonQuery();
            closeConnection();
            return count;
        }

        //update a patient record in the database
        //G
        public void updatePatient(string sqlQuery, string name, string surname, string date_of_birth, 
                                  string street, string city, string postcode, string phone, 
                                  string emergency_phone, string email, string id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("Name", name));
            command.Parameters.Add(new SqlParameter("Surname", surname));
            command.Parameters.Add(new SqlParameter("Date_of_birth", date_of_birth));
            command.Parameters.Add(new SqlParameter("Street", street));
            command.Parameters.Add(new SqlParameter("City", city));
            command.Parameters.Add(new SqlParameter("Postcode", postcode));
            command.Parameters.Add(new SqlParameter("Phone", phone));
            command.Parameters.Add(new SqlParameter("Emergency_phone", emergency_phone));
            command.Parameters.Add(new SqlParameter("Email", email));
            command.Parameters.Add(new SqlParameter("PatientID", id));
            //open the connection
            openConnection();
            command.Connection = connectionToDB;
            //executes the query and closes the connection
            command.ExecuteNonQuery();
            closeConnection();
        }

        //create a new booking
        public int book(string sqlQuery, string patientID, string doctorID, string date, 
                        string time, string room, string description)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("PatientID", patientID));
            command.Parameters.Add(new SqlParameter("DoctorID", doctorID));
            command.Parameters.Add(new SqlParameter("Date", date));
            command.Parameters.Add(new SqlParameter("Time", time));
            command.Parameters.Add(new SqlParameter("Room", room));
            command.Parameters.Add(new SqlParameter("Description", description));
            //open the connection
            openConnection();
            command.Connection = connectionToDB;
            //executes the query and closes the connection
            int count = command.ExecuteNonQuery();
            closeConnection();
            return count;
        }
        //J
        public void deleteBooking(string sqlQuery, string id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;

            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("ID", id));

            //open the connection
            openConnection();
            command.Connection = connectionToDB;

            //executes the query and closes the connection
            command.ExecuteNonQuery();
            closeConnection();



        }

        //registers a new staff member into the database
        public void registerStaff(string sqlQuery, string name, string surname, string date_of_birth, string street,
                            string city, string postcode, string phone, string email, string role, string username, string password)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("Name", name));
            command.Parameters.Add(new SqlParameter("Surname", surname));
            command.Parameters.Add(new SqlParameter("Date_of_birth", date_of_birth));
            command.Parameters.Add(new SqlParameter("Street", street));
            command.Parameters.Add(new SqlParameter("City", city));
            command.Parameters.Add(new SqlParameter("Postcode", postcode));
            command.Parameters.Add(new SqlParameter("Phone", phone));
            command.Parameters.Add(new SqlParameter("Email", email));
            command.Parameters.Add(new SqlParameter("Role", role));
            command.Parameters.Add(new SqlParameter("Username", username));
            command.Parameters.Add(new SqlParameter("Password", password));
            //open the connection
            openConnection();
            command.Connection = connectionToDB;
            //executes the query and closes the connection
            command.ExecuteNonQuery();
            closeConnection();
        }

        //registers a new shift into the database
        public void createShift(string sqlQuery, string id, string date, string start, string end)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("ID", id));
            command.Parameters.Add(new SqlParameter("Date", date));
            command.Parameters.Add(new SqlParameter("Start", start));
            command.Parameters.Add(new SqlParameter("End", end));
            //open the connection
            openConnection();
            command.Connection = connectionToDB;
            //executes the query and closes the connection
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void createPrescription(string sqlQuery, string id, string name, string start, string end)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("ID", id));
            command.Parameters.Add(new SqlParameter("Name", name));
            command.Parameters.Add(new SqlParameter("Start", start));
            command.Parameters.Add(new SqlParameter("End", end));
            //open the connection
            openConnection();
            command.Connection = connectionToDB;
            //executes the query and closes the connection
            command.ExecuteNonQuery();
            closeConnection();
        }

        public void extendPrescription(string sqlQuery, string id, string end)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("ID", id));
            command.Parameters.Add(new SqlParameter("End", end));
            //open the connection
            openConnection();
            command.Connection = connectionToDB;
            //executes the query and closes the connection
            command.ExecuteNonQuery();
            closeConnection();
        }
    }
}
