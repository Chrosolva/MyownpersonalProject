using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//add mysql Library 
using System.Data; 
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace Login
{
    public class ConnectDB
    {
        public SqlConnection connection = new SqlConnection();
        public SqlDataAdapter da;
        public DataTable dt;
        public SqlCommand cmd;
        public SqlTransaction transaction; 
        private string server;
        private string database;
        public string connectionString;

        //Constructor
        public ConnectDB()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "DESKTOP-L6KAGNN";
            database = "MaterialManagement";
            

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "Trusted_Connection=True;";

            connection = new SqlConnection(connectionString);

        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(string query)
        {

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                SqlCommand cmd = new SqlCommand(query,connection);

                SqlDataReader cmdreader;
                cmdreader = cmd.ExecuteReader();
                while (cmdreader.Read()) {
                }

                //close connection
                this.CloseConnection();
            }
        }
        //Update statement
        public void Update(string query)
        {

            //Open connection
            if (this.OpenConnection() == true)
            {
                //create mysql command
                SqlCommand cmd = new SqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {

            if (this.OpenConnection() == true)
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public List<string>[] Select()
        {
            string query = "SELECT * FROM tableinfo";

            //Create a list to store the result
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                SqlCommand cmd = new SqlCommand(query, connection);
                //Create a data reader and Execute the command
                SqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement
        public int Count()
        {
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                SqlCommand cmd = new SqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        public int countdata(string query)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmd = new SqlCommand(query, connection);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public DataTable FillDataTable(string query)
        {
            try
            {
                this.OpenConnection();
                da = new SqlDataAdapter(query, connection);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        //Backup
        public void Backup()
        {

        }

        //Restore
        public void Restore()
        {
        }
    }
}
