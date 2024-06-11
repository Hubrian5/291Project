using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_first_App_Monday
{
    public partial class Form1 : Form
    {
        private DatabaseConnection dbConnection;
        private manageCar manageCarForm;

        public Form1()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();

            // Event-handlers for populating combo box
            branchComboBox.DropDown += branchComboBox_DropDown;
            modelComboBox.DropDown += modelComboBox_DropDown;
            yearComboBox.DropDown += yearComboBox_DropDown;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (username.Text == "")
                {
                    MessageBox.Show("Username does not exist");
                    return;
                }
                if (select_vehicle.SelectedItem == null)
                {
                    MessageBox.Show("Please select a vehicle");
                    return;
                }



                string confirmString = "Reservation from the " + to_branch.Text + " Branch for " + from_date.Text + " to " + to_date.Text + " is confirmed.";
                MessageBox.Show(confirmString);

            }
            catch
            {

                string errorString = "Selection invalid.";
                MessageBox.Show(errorString);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbConnection.OpenConnection();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbConnection.CloseConnection();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void fromDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void start_over_Click(object sender, EventArgs e)
        {
            //from_date.Value = DateTime.Now;
            //to_date.Value = DateTime.Now;

            from_branch.SelectedItem = null;
            to_branch.SelectedItem = null;
            username.Text = "";
            select_vehicle.SelectedItem = null;
            select_vehicle.Items.Clear();

            from_date.Visible = true;
            from_date_label.Visible = true;
            to_date_label.Visible = true;
            to_date.Visible = true;
            from_branch.Visible = true;
            from_branch_label.Visible = true;
            to_branch.Visible = true;
            to_branch_label.Visible = true;
            browse_vehicles.Visible = true;
            username.Visible = false;
            username_label.Visible = false;
            select_vehicle.Visible = false;
            select_vehicle_label.Visible = false;
            make_reservation.Visible = false;
        }

        private void browse_vehicles_Click(object sender, EventArgs e)
        {

            if (to_date.Value < from_date.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date");
                return;
            }

            if (from_branch.SelectedItem == null || to_branch.SelectedItem == null)
            {
                MessageBox.Show("Please select a From Branch and a To Branch");
                return;
            }

            from_date.Visible = false;
            from_date_label.Visible = false;
            to_date_label.Visible = false;
            to_date.Visible = false;
            from_branch.Visible = false;
            from_branch_label.Visible = false;
            to_branch.Visible = false;
            to_branch_label.Visible = false;
            browse_vehicles.Visible = false;
            username.Visible = true;
            username_label.Visible = true;
            select_vehicle.Visible = true;
            select_vehicle_label.Visible = true;
            make_reservation.Visible = true;
        }

        private void from_branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string Sql = "select name, city from Branches"
        }

        private void databaseGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void manageButton_Click(object sender, EventArgs e)
        {
            if (manageCarForm == null || manageCarForm.IsDisposed)
            {
                manageCarForm = new manageCar();
            }
            manageCarForm.Show();
            manageCarForm.BringToFront();
        }

        private void findCarIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string carID = findCarIDTextBox.Text;

            // Check if the input is numeric
            if (string.IsNullOrEmpty(carID) || !int.TryParse(carID, out _))
            {
                MessageBox.Show("Enter a valid car ID.");
                return;
            }

            try
            {
                dbConnection.OpenConnection();
                SqlCommand command = dbConnection.GetCommand();
                command.CommandText = @"
                    SELECT Cars.car_id, Cars.type_id, Cars.model, Cars.manufacture_date, 
                           Branches.name AS branch_name, 
                           Car_Types.daily_price, Car_Types.weekly_price, Car_Types.monthly_price,
                           CASE 
                               WHEN EXISTS (SELECT 1 
                                            FROM Rental_Transactions 
                                            WHERE car_id = Cars.car_id 
                                              AND @current_date BETWEEN start_date AND end_date)
                               THEN 'Yes'
                               ELSE 'No'
                           END AS is_rented_out
                    FROM Cars
                    INNER JOIN Branches ON Cars.branch_id = Branches.branch_id
                    INNER JOIN Car_Types ON Cars.type_id = Car_Types.type_id
                    WHERE Cars.car_id = @car_id";
                command.Parameters.AddWithValue("@car_id", carID);
                command.Parameters.AddWithValue("@current_date", DateTime.Now);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    string carDetails = $"Car ID: {reader["car_id"]}\n" +
                                        $"Branch Name: {reader["branch_name"]}\n" +
                                        $"Model: {reader["model"]}\n" +
                                        $"Manufacture Date: {reader["manufacture_date"]}\n" +
                                        $"Daily Price: {reader["daily_price"]}\n" +
                                        $"Weekly Price: {reader["weekly_price"]}\n" +
                                        $"Monthly Price: {reader["monthly_price"]}\n" +
                                        $"Is Currently Rented Out: {reader["is_rented_out"]}";
                    MessageBox.Show(carDetails);
                }
                else
                {
                    MessageBox.Show("Car not found.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private void branchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            string branch = branchComboBox.Text;
            string model = modelComboBox.Text;
            string year = yearComboBox.Text;

            string query = @"
        SELECT Cars.car_id AS [Car ID], 
               Branches.name AS Branch, 
               Cars.model AS Model, 
               YEAR(Cars.manufacture_date) AS [Manufacturer's Year],
               Car_Types.type_name AS [Car Type],  -- Include Car Type
               CASE 
                   WHEN EXISTS (SELECT 1 
                                FROM Rental_Transactions 
                                WHERE car_id = Cars.car_id 
                                  AND @current_date BETWEEN start_date AND end_date)
                   THEN 'Yes'
                   ELSE 'No'
               END AS [Currently Rented],
               Car_Types.daily_price AS [Daily Price], 
               Car_Types.weekly_price AS [Weekly Price], 
               Car_Types.monthly_price AS [Monthly Price]
        FROM Cars
        INNER JOIN Branches ON Cars.branch_id = Branches.branch_id
        INNER JOIN Car_Types ON Cars.type_id = Car_Types.type_id
        WHERE 1 = 1"; // 1=1 is a trick to simplify appending filters

            if (!string.IsNullOrEmpty(branch))
            {
                query += " AND Branches.name = @branch";
            }

            if (!string.IsNullOrEmpty(model))
            {
                query += " AND Cars.model = @model";
            }

            if (!string.IsNullOrEmpty(year))
            {
                query += " AND YEAR(Cars.manufacture_date) = @year";
            }

            try
            {
                dbConnection.OpenConnection();
                SqlCommand command = dbConnection.GetCommand();
                command.CommandText = query;
                command.Parameters.AddWithValue("@current_date", DateTime.Now);

                if (!string.IsNullOrEmpty(branch))
                {
                    command.Parameters.AddWithValue("@branch", branch);
                }

                if (!string.IsNullOrEmpty(model))
                {
                    command.Parameters.AddWithValue("@model", model);
                }

                if (!string.IsNullOrEmpty(year))
                {
                    command.Parameters.AddWithValue("@year", year);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                carInfo.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }

        private void DisplayAllData()
        {
            try
            {
                dbConnection.OpenConnection();
                SqlCommand command = dbConnection.GetCommand();
                command.CommandText = @"
            SELECT Cars.car_id AS [Car ID], 
                   Branches.name AS Branch, 
                   Cars.model AS Model, 
                   YEAR(Cars.manufacture_date) AS [Manufacturer's Year],
                   Car_Types.type_name AS [Car Type],  -- Include Car Type
                   CASE 
                       WHEN EXISTS (SELECT 1 
                                    FROM Rental_Transactions 
                                    WHERE car_id = Cars.car_id 
                                      AND @current_date BETWEEN start_date AND end_date)
                       THEN 'Yes'
                       ELSE 'No'
                   END AS [Currently Rented],
                   Car_Types.daily_price AS [Daily Price], 
                   Car_Types.weekly_price AS [Weekly Price], 
                   Car_Types.monthly_price AS [Monthly Price]
            FROM Cars
            INNER JOIN Branches ON Cars.branch_id = Branches.branch_id
            INNER JOIN Car_Types ON Cars.type_id = Car_Types.type_id";
                command.Parameters.AddWithValue("@current_date", DateTime.Now);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                carInfo.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }


        private void showAllButton_Click(object sender, EventArgs e)
        {
            DisplayAllData();
        }

        private void branchComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox(branchComboBox, "SELECT DISTINCT name FROM Branches", "name");
        }

        private void modelComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox(modelComboBox, "SELECT DISTINCT model FROM Cars", "model");
        }

        private void yearComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox(yearComboBox, "SELECT DISTINCT YEAR(manufacture_date) AS year FROM Cars", "year", true);
        }
        private void PopulateComboBox(ComboBox comboBox, string query, string displayMember, bool isNumeric = false)
        {
            try
            {
                dbConnection.OpenConnection();
                SqlCommand command = dbConnection.GetCommand();
                command.CommandText = query;

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Add empty option
                if (isNumeric)
                {
                    DataRow emptyRow = dataTable.NewRow();
                    emptyRow[displayMember] = DBNull.Value;
                    dataTable.Rows.InsertAt(emptyRow, 0);
                }
                else
                {
                    DataRow emptyRow = dataTable.NewRow();
                    emptyRow[displayMember] = "";
                    dataTable.Rows.InsertAt(emptyRow, 0);
                }

                comboBox.DataSource = dataTable;
                comboBox.DisplayMember = displayMember;
                comboBox.ValueMember = displayMember;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
        }
    }
}
