using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace My_first_App_Monday
{
    public partial class manageCar : Form
    {
        private DatabaseConnection dbConnection;
        private bool isNewCarAdded = false;
        private Timer deleteTimer;

        public manageCar()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();

            // Initialize the timer
            deleteTimer = new Timer();
            deleteTimer.Interval = 100; // Set the interval to 100 milliseconds
            deleteTimer.Tick += DeleteTimer_Tick;

            // Attach event handlers
            carBranchComboBox.DropDown += carBranchComboBox_DropDown;
            carModelComboBox.DropDown += carModelComboBox_DropDown;
            carYearComboBox.DropDown += carYearComboBox_DropDown;
            carTypeComboBox.DropDown += carTypeComboBox_DropDown;

            carModifyIDComboBox.DropDown += carModifyIDComboBox_DropDown;
            carModifyIDComboBox.SelectedIndexChanged += carModifyIDComboBox_SelectedIndexChanged;

            modifyCarButton.CheckedChanged += modifyCarButton_CheckedChanged;
            addCarButton.CheckedChanged += addCarButton_CheckedChanged;
            deleteCarButton.CheckedChanged += deleteCarButton_CheckedChanged; // Add this line

            findButton.Click += findButton_Click;
            confirmButton.Click += confirmButton_Click;
        }

        private void carBranchComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox(carBranchComboBox, "SELECT DISTINCT name FROM Branches", "name");
        }

        private void carModelComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox(carModelComboBox, "SELECT DISTINCT model FROM Cars", "model");
        }

        private void carYearComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox(carYearComboBox, "SELECT DISTINCT YEAR(manufacture_date) AS year FROM Cars", "year", true);
        }

        private void carTypeComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox(carTypeComboBox, "SELECT DISTINCT type_name FROM Car_Types", "type_name");
        }

        private void carModifyIDComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox(carModifyIDComboBox, "SELECT car_id FROM Cars", "car_id");
        }

        private void carFindComboBox_DropDown(object sender, EventArgs e)
        {
            PopulateComboBox(carFindComboBox, "SELECT car_id FROM Cars", "car_id");
        }

        private void modifyCarButton_CheckedChanged(object sender, EventArgs e)
        {
            if (modifyCarButton.Checked)
            {
                // Enable the carModifyIDComboBox when the modifyCarButton is toggled on
                carModifyIDComboBox.Enabled = true;
                // Populate the carModifyIDComboBox with car IDs
                PopulateComboBox(carModifyIDComboBox, "SELECT car_id FROM Cars", "car_id");
            }
            else
            {
                // Disable the carModifyIDComboBox when the modifyCarButton is toggled off
                carModifyIDComboBox.Enabled = false;
                carModifyIDComboBox.DataSource = null;
            }
        }

        private void addCarButton_CheckedChanged(object sender, EventArgs e)
        {
            if (addCarButton.Checked)
            {
                // Ensure carModifyIDComboBox is disabled when adding a new car
                carModifyIDComboBox.Enabled = false;
                carModifyIDComboBox.DataSource = null;
            }
        }

        private void deleteCarButton_CheckedChanged(object sender, EventArgs e)
        {
            if (deleteCarButton.Checked)
            {
                // Enable the carModifyIDComboBox when the deleteCarButton is toggled on
                carModifyIDComboBox.Enabled = true;
                // Populate the carModifyIDComboBox with car IDs
                PopulateComboBox(carModifyIDComboBox, "SELECT car_id FROM Cars", "car_id");
            }
            else
            {
                // Disable the carModifyIDComboBox when the deleteCarButton is toggled off
                carModifyIDComboBox.Enabled = false;
                carModifyIDComboBox.DataSource = null;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string carID = carFindComboBox.Text;

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
                       Car_Types.type_name
                FROM Cars
                INNER JOIN Branches ON Cars.branch_id = Branches.branch_id
                INNER JOIN Car_Types ON Cars.type_id = Car_Types.type_id
                WHERE Cars.car_id = @car_id";
                command.Parameters.AddWithValue("@car_id", carID);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    carBranchComboBox.Text = reader["branch_name"].ToString();
                    carModelComboBox.Text = reader["model"].ToString();
                    carYearComboBox.Text = reader["manufacture_date"].ToString().Substring(0, 4); // Only year part
                    carTypeComboBox.Text = reader["type_name"].ToString();
                }
                else
                {
                    //MessageBox.Show("Car not found.");
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


        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (addCarButton.Checked)
            {
                // Ensure all fields are populated
                if (string.IsNullOrEmpty(carBranchComboBox.Text) ||
                    string.IsNullOrEmpty(carModelComboBox.Text) ||
                    string.IsNullOrEmpty(carYearComboBox.Text) ||
                    string.IsNullOrEmpty(carTypeComboBox.Text))
                {
                    MessageBox.Show("All fields must be populated.");
                    return;
                }

                try
                {
                    dbConnection.OpenConnection();

                    // Get the next available car ID
                    int nextCarID;
                    using (SqlCommand command = dbConnection.GetCommand())
                    {
                        command.CommandText = "SELECT ISNULL(MAX(car_id), 0) + 1 FROM Cars";
                        nextCarID = (int)command.ExecuteScalar();
                    }

                    // Insert the new car
                    using (SqlCommand command = dbConnection.GetCommand())
                    {
                        command.CommandText = @"
                        INSERT INTO Cars (car_id, type_id, branch_id, model, manufacture_date)
                        VALUES (
                            @car_id,
                            (SELECT type_id FROM Car_Types WHERE type_name = @type_name),
                            (SELECT branch_id FROM Branches WHERE name = @branch_name),
                            @model, @manufacture_date)";
                        command.Parameters.AddWithValue("@car_id", nextCarID);
                        command.Parameters.AddWithValue("@type_name", carTypeComboBox.Text);
                        command.Parameters.AddWithValue("@branch_name", carBranchComboBox.Text);
                        command.Parameters.AddWithValue("@model", carModelComboBox.Text);
                        command.Parameters.AddWithValue("@manufacture_date", new DateTime(int.Parse(carYearComboBox.Text), 1, 1));

                        command.ExecuteNonQuery();
                    }

                    // Set the flag and start the timer
                    isNewCarAdded = true;
                    deleteTimer.Start();
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
            else if (modifyCarButton.Checked)
            {
                // Ensure a car ID is selected and all fields are populated
                if (string.IsNullOrEmpty(carModifyIDComboBox.Text) ||
                    string.IsNullOrEmpty(carBranchComboBox.Text) ||
                    string.IsNullOrEmpty(carModelComboBox.Text) ||
                    string.IsNullOrEmpty(carYearComboBox.Text) ||
                    string.IsNullOrEmpty(carTypeComboBox.Text))
                {
                    MessageBox.Show("All fields must be populated.");
                    return;
                }

                try
                {
                    dbConnection.OpenConnection();

                    // Update the existing car
                    using (SqlCommand command = dbConnection.GetCommand())
                    {
                        command.CommandText = @"
                        UPDATE Cars
                        SET type_id = (SELECT type_id FROM Car_Types WHERE type_name = @type_name),
                            branch_id = (SELECT branch_id FROM Branches WHERE name = @branch_name),
                            model = @model,
                            manufacture_date = @manufacture_date
                        WHERE car_id = @car_id";
                        command.Parameters.AddWithValue("@car_id", carModifyIDComboBox.Text);
                        command.Parameters.AddWithValue("@type_name", carTypeComboBox.Text);
                        command.Parameters.AddWithValue("@branch_name", carBranchComboBox.Text);
                        command.Parameters.AddWithValue("@model", carModelComboBox.Text);
                        command.Parameters.AddWithValue("@manufacture_date", new DateTime(int.Parse(carYearComboBox.Text), 1, 1));

                        command.ExecuteNonQuery();
                    }

                    //MessageBox.Show("Car updated successfully.");
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
            else if (deleteCarButton.Checked)
            {
                // Ensure a car ID is selected
                if (string.IsNullOrEmpty(carModifyIDComboBox.Text))
                {
                    MessageBox.Show("Please select a car ID to delete.");
                    return;
                }

                try
                {
                    dbConnection.OpenConnection();

                    // Delete the car
                    using (SqlCommand command = dbConnection.GetCommand())
                    {
                        command.CommandText = "DELETE FROM Cars WHERE car_id = @car_id";
                        command.Parameters.AddWithValue("@car_id", carModifyIDComboBox.Text);

                        command.ExecuteNonQuery();
                    }

                    //MessageBox.Show("Car deleted successfully.");
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

        private void DeleteTimer_Tick(object sender, EventArgs e)
        {
            if (isNewCarAdded)
            {
                DeleteLatestEntry();
                isNewCarAdded = false;
                deleteTimer.Stop();
            }
        }

        private void DeleteLatestEntry()
        {
            try
            {
                dbConnection.OpenConnection();

                using (SqlCommand command = dbConnection.GetCommand())
                {
                    command.CommandText = @"
                    DELETE FROM Cars
                    WHERE car_id = (
                        SELECT MAX(car_id)
                        FROM Cars
                    )";
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the duplicate entry: " + ex.Message);
            }
            finally
            {
                dbConnection.CloseConnection();
            }
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes the manageCar form
        }

        private void carModifyIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (carModifyIDComboBox.SelectedItem != null)
            {
                string selectedCarID = carModifyIDComboBox.SelectedValue.ToString();

                try
                {
                    dbConnection.OpenConnection();
                    SqlCommand command = dbConnection.GetCommand();
                    command.CommandText = @"
                SELECT Cars.car_id, Cars.type_id, Cars.model, Cars.manufacture_date, 
                       Branches.name AS branch_name, 
                       Car_Types.type_name
                FROM Cars
                INNER JOIN Branches ON Cars.branch_id = Branches.branch_id
                INNER JOIN Car_Types ON Cars.type_id = Car_Types.type_id
                WHERE Cars.car_id = @car_id";
                    command.Parameters.AddWithValue("@car_id", selectedCarID);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        carBranchComboBox.Text = reader["branch_name"].ToString();
                        carModelComboBox.Text = reader["model"].ToString();
                        carYearComboBox.Text = reader["manufacture_date"].ToString().Substring(0, 4); // Only year part
                        carTypeComboBox.Text = reader["type_name"].ToString();
                    }
                    else
                    {
                        //MessageBox.Show("Car not found.");
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
        }
    }
}
