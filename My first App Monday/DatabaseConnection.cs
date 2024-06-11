using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_first_App_Monday
{
    internal class DatabaseConnection
    {
        private SqlConnection myConnection;
        private SqlCommand myCommand;
        private SqlDataReader myReader;

        private string connectionString = "Server=localhost;Database=291Project;Trusted_Connection=yes;";


        public void OpenConnection()
        {
            myConnection = new SqlConnection(connectionString);

            try
            {
                myConnection.Open();
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection;
                //MessageBox.Show("Connection opened successfully.", "Success");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (myConnection != null && myConnection.State == System.Data.ConnectionState.Open)
                {
                    myConnection.Close();
                    //MessageBox.Show("Connection closed successfully.", "Success");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }
        }

        public SqlCommand GetCommand()
        {
            if (myCommand != null)
            {
                return myCommand;
            }
            else
            {
                throw new InvalidOperationException("Connection is not open. Call OpenConnection() first.");
            }
        }
    }
}
