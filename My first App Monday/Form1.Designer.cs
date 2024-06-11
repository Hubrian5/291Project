namespace My_first_App_Monday
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.from_date_label = new System.Windows.Forms.Label();
            this.to_date_label = new System.Windows.Forms.Label();
            this.from_date = new System.Windows.Forms.DateTimePicker();
            this.to_date = new System.Windows.Forms.DateTimePicker();
            this.to_branch_label = new System.Windows.Forms.Label();
            this.to_branch = new System.Windows.Forms.ComboBox();
            this.make_reservation = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.databaseTab = new System.Windows.Forms.TabPage();
            this.showAllButton = new System.Windows.Forms.Button();
            this.searchCarIDButton = new System.Windows.Forms.Button();
            this.findCarIDTextBox = new System.Windows.Forms.TextBox();
            this.findIDLabel = new System.Windows.Forms.Label();
            this.filterButton = new System.Windows.Forms.Button();
            this.yearLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.branchLabel = new System.Windows.Forms.Label();
            this.yearComboBox = new System.Windows.Forms.ComboBox();
            this.modelComboBox = new System.Windows.Forms.ComboBox();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.manageButton = new System.Windows.Forms.Button();
            this.carInfo = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.start_over = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.from_branch = new System.Windows.Forms.ComboBox();
            this.from_branch_label = new System.Windows.Forms.Label();
            this.browse_vehicles = new System.Windows.Forms.Button();
            this.select_vehicle_label = new System.Windows.Forms.Label();
            this.select_vehicle = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.databaseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carInfo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // from_date_label
            // 
            this.from_date_label.AutoSize = true;
            this.from_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_date_label.Location = new System.Drawing.Point(29, 34);
            this.from_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.from_date_label.Name = "from_date_label";
            this.from_date_label.Size = new System.Drawing.Size(133, 24);
            this.from_date_label.TabIndex = 0;
            this.from_date_label.Text = "Check-in Date:";
            this.from_date_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // to_date_label
            // 
            this.to_date_label.AutoSize = true;
            this.to_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_date_label.Location = new System.Drawing.Point(29, 93);
            this.to_date_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.to_date_label.Name = "to_date_label";
            this.to_date_label.Size = new System.Drawing.Size(144, 24);
            this.to_date_label.TabIndex = 1;
            this.to_date_label.Text = "Check-out Date:";
            // 
            // from_date
            // 
            this.from_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_date.Location = new System.Drawing.Point(253, 33);
            this.from_date.Margin = new System.Windows.Forms.Padding(2);
            this.from_date.Name = "from_date";
            this.from_date.Size = new System.Drawing.Size(224, 26);
            this.from_date.TabIndex = 2;
            this.from_date.ValueChanged += new System.EventHandler(this.fromDate_ValueChanged);
            // 
            // to_date
            // 
            this.to_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_date.Location = new System.Drawing.Point(253, 95);
            this.to_date.Margin = new System.Windows.Forms.Padding(2);
            this.to_date.Name = "to_date";
            this.to_date.Size = new System.Drawing.Size(224, 26);
            this.to_date.TabIndex = 3;
            // 
            // to_branch_label
            // 
            this.to_branch_label.AutoSize = true;
            this.to_branch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_branch_label.Location = new System.Drawing.Point(29, 217);
            this.to_branch_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.to_branch_label.Name = "to_branch_label";
            this.to_branch_label.Size = new System.Drawing.Size(119, 24);
            this.to_branch_label.TabIndex = 4;
            this.to_branch_label.Text = "Price Range:";
            // 
            // to_branch
            // 
            this.to_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_branch.FormattingEnabled = true;
            this.to_branch.Items.AddRange(new object[] {
            "Edmonton"});
            this.to_branch.Location = new System.Drawing.Point(253, 217);
            this.to_branch.Margin = new System.Windows.Forms.Padding(2);
            this.to_branch.Name = "to_branch";
            this.to_branch.Size = new System.Drawing.Size(224, 28);
            this.to_branch.TabIndex = 5;
            // 
            // make_reservation
            // 
            this.make_reservation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.make_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_reservation.Location = new System.Drawing.Point(687, 218);
            this.make_reservation.Margin = new System.Windows.Forms.Padding(2);
            this.make_reservation.Name = "make_reservation";
            this.make_reservation.Size = new System.Drawing.Size(151, 34);
            this.make_reservation.TabIndex = 6;
            this.make_reservation.Text = "Make Reservation";
            this.make_reservation.UseVisualStyleBackColor = true;
            this.make_reservation.Visible = false;
            this.make_reservation.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.databaseTab);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1016, 485);
            this.tabControl1.TabIndex = 7;
            // 
            // databaseTab
            // 
            this.databaseTab.Controls.Add(this.showAllButton);
            this.databaseTab.Controls.Add(this.searchCarIDButton);
            this.databaseTab.Controls.Add(this.findCarIDTextBox);
            this.databaseTab.Controls.Add(this.findIDLabel);
            this.databaseTab.Controls.Add(this.filterButton);
            this.databaseTab.Controls.Add(this.yearLabel);
            this.databaseTab.Controls.Add(this.modelLabel);
            this.databaseTab.Controls.Add(this.branchLabel);
            this.databaseTab.Controls.Add(this.yearComboBox);
            this.databaseTab.Controls.Add(this.modelComboBox);
            this.databaseTab.Controls.Add(this.branchComboBox);
            this.databaseTab.Controls.Add(this.manageButton);
            this.databaseTab.Controls.Add(this.carInfo);
            this.databaseTab.Location = new System.Drawing.Point(4, 22);
            this.databaseTab.Name = "databaseTab";
            this.databaseTab.Size = new System.Drawing.Size(1008, 459);
            this.databaseTab.TabIndex = 2;
            this.databaseTab.Text = "Car Database";
            this.databaseTab.UseVisualStyleBackColor = true;
            // 
            // showAllButton
            // 
            this.showAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.showAllButton.Location = new System.Drawing.Point(60, 23);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(140, 57);
            this.showAllButton.TabIndex = 12;
            this.showAllButton.Text = "Show All";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // searchCarIDButton
            // 
            this.searchCarIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.searchCarIDButton.Location = new System.Drawing.Point(557, 127);
            this.searchCarIDButton.Name = "searchCarIDButton";
            this.searchCarIDButton.Size = new System.Drawing.Size(120, 39);
            this.searchCarIDButton.TabIndex = 11;
            this.searchCarIDButton.Text = "Search";
            this.searchCarIDButton.UseVisualStyleBackColor = true;
            this.searchCarIDButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // findCarIDTextBox
            // 
            this.findCarIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.findCarIDTextBox.Location = new System.Drawing.Point(557, 20);
            this.findCarIDTextBox.Name = "findCarIDTextBox";
            this.findCarIDTextBox.Size = new System.Drawing.Size(120, 26);
            this.findCarIDTextBox.TabIndex = 10;
            this.findCarIDTextBox.TextChanged += new System.EventHandler(this.findCarIDTextBox_TextChanged);
            // 
            // findIDLabel
            // 
            this.findIDLabel.AutoSize = true;
            this.findIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findIDLabel.Location = new System.Drawing.Point(417, 23);
            this.findIDLabel.Name = "findIDLabel";
            this.findIDLabel.Size = new System.Drawing.Size(134, 20);
            this.findIDLabel.TabIndex = 9;
            this.findIDLabel.Text = "Find by Car ID: ";
            // 
            // filterButton
            // 
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.filterButton.Location = new System.Drawing.Point(869, 127);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(120, 39);
            this.filterButton.TabIndex = 8;
            this.filterButton.Text = "Filter";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLabel.Location = new System.Drawing.Point(785, 88);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(57, 20);
            this.yearLabel.TabIndex = 7;
            this.yearLabel.Text = "Year: ";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.Location = new System.Drawing.Point(775, 54);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(67, 20);
            this.modelLabel.TabIndex = 6;
            this.modelLabel.Text = "Model: ";
            // 
            // branchLabel
            // 
            this.branchLabel.AutoSize = true;
            this.branchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branchLabel.Location = new System.Drawing.Point(766, 20);
            this.branchLabel.Name = "branchLabel";
            this.branchLabel.Size = new System.Drawing.Size(76, 20);
            this.branchLabel.TabIndex = 5;
            this.branchLabel.Text = "Branch: ";
            // 
            // yearComboBox
            // 
            this.yearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.yearComboBox.FormattingEnabled = true;
            this.yearComboBox.Location = new System.Drawing.Point(848, 85);
            this.yearComboBox.Name = "yearComboBox";
            this.yearComboBox.Size = new System.Drawing.Size(150, 28);
            this.yearComboBox.TabIndex = 4;
            // 
            // modelComboBox
            // 
            this.modelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modelComboBox.FormattingEnabled = true;
            this.modelComboBox.Location = new System.Drawing.Point(848, 51);
            this.modelComboBox.Name = "modelComboBox";
            this.modelComboBox.Size = new System.Drawing.Size(150, 28);
            this.modelComboBox.TabIndex = 3;
            // 
            // branchComboBox
            // 
            this.branchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(848, 17);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(150, 28);
            this.branchComboBox.TabIndex = 2;
            this.branchComboBox.SelectedIndexChanged += new System.EventHandler(this.branchComboBox_SelectedIndexChanged);
            // 
            // manageButton
            // 
            this.manageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.manageButton.Location = new System.Drawing.Point(60, 107);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(140, 59);
            this.manageButton.TabIndex = 1;
            this.manageButton.Text = "Manage Cars";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // carInfo
            // 
            this.carInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.carInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.carInfo.Location = new System.Drawing.Point(3, 197);
            this.carInfo.Name = "carInfo";
            this.carInfo.Size = new System.Drawing.Size(1002, 259);
            this.carInfo.TabIndex = 0;
            this.carInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databaseGrid_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.start_over);
            this.tabPage2.Controls.Add(this.username);
            this.tabPage2.Controls.Add(this.username_label);
            this.tabPage2.Controls.Add(this.from_branch);
            this.tabPage2.Controls.Add(this.from_branch_label);
            this.tabPage2.Controls.Add(this.browse_vehicles);
            this.tabPage2.Controls.Add(this.select_vehicle_label);
            this.tabPage2.Controls.Add(this.select_vehicle);
            this.tabPage2.Controls.Add(this.from_date_label);
            this.tabPage2.Controls.Add(this.make_reservation);
            this.tabPage2.Controls.Add(this.to_date_label);
            this.tabPage2.Controls.Add(this.to_branch);
            this.tabPage2.Controls.Add(this.from_date);
            this.tabPage2.Controls.Add(this.to_branch_label);
            this.tabPage2.Controls.Add(this.to_date);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1008, 459);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservation";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // start_over
            // 
            this.start_over.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.start_over.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_over.Location = new System.Drawing.Point(906, 300);
            this.start_over.Margin = new System.Windows.Forms.Padding(2);
            this.start_over.Name = "start_over";
            this.start_over.Size = new System.Drawing.Size(92, 34);
            this.start_over.TabIndex = 14;
            this.start_over.Text = "Start Over";
            this.start_over.UseVisualStyleBackColor = true;
            this.start_over.Click += new System.EventHandler(this.start_over_Click);
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(611, 72);
            this.username.Margin = new System.Windows.Forms.Padding(2);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(261, 26);
            this.username.TabIndex = 13;
            this.username.Visible = false;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_label.Location = new System.Drawing.Point(666, 34);
            this.username_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(152, 24);
            this.username_label.TabIndex = 12;
            this.username_label.Text = "Enter Username:";
            this.username_label.Visible = false;
            // 
            // from_branch
            // 
            this.from_branch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_branch.FormattingEnabled = true;
            this.from_branch.Items.AddRange(new object[] {
            "Edmonton"});
            this.from_branch.Location = new System.Drawing.Point(253, 153);
            this.from_branch.Margin = new System.Windows.Forms.Padding(2);
            this.from_branch.Name = "from_branch";
            this.from_branch.Size = new System.Drawing.Size(224, 28);
            this.from_branch.TabIndex = 11;
            this.from_branch.SelectedIndexChanged += new System.EventHandler(this.from_branch_SelectedIndexChanged);
            // 
            // from_branch_label
            // 
            this.from_branch_label.AutoSize = true;
            this.from_branch_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_branch_label.Location = new System.Drawing.Point(29, 153);
            this.from_branch_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.from_branch_label.Name = "from_branch_label";
            this.from_branch_label.Size = new System.Drawing.Size(45, 24);
            this.from_branch_label.TabIndex = 10;
            this.from_branch_label.Text = "City:";
            this.from_branch_label.Click += new System.EventHandler(this.label5_Click);
            // 
            // browse_vehicles
            // 
            this.browse_vehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browse_vehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_vehicles.Location = new System.Drawing.Point(182, 278);
            this.browse_vehicles.Margin = new System.Windows.Forms.Padding(2);
            this.browse_vehicles.Name = "browse_vehicles";
            this.browse_vehicles.Size = new System.Drawing.Size(193, 34);
            this.browse_vehicles.TabIndex = 9;
            this.browse_vehicles.Text = "Browse Accomodations";
            this.browse_vehicles.UseVisualStyleBackColor = true;
            this.browse_vehicles.Click += new System.EventHandler(this.browse_vehicles_Click);
            // 
            // select_vehicle_label
            // 
            this.select_vehicle_label.AutoSize = true;
            this.select_vehicle_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_vehicle_label.Location = new System.Drawing.Point(533, 157);
            this.select_vehicle_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.select_vehicle_label.Name = "select_vehicle_label";
            this.select_vehicle_label.Size = new System.Drawing.Size(132, 24);
            this.select_vehicle_label.TabIndex = 8;
            this.select_vehicle_label.Text = "Select Branch:";
            this.select_vehicle_label.Visible = false;
            // 
            // select_vehicle
            // 
            this.select_vehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_vehicle.FormattingEnabled = true;
            this.select_vehicle.Items.AddRange(new object[] {
            "Car1"});
            this.select_vehicle.Location = new System.Drawing.Point(757, 154);
            this.select_vehicle.Margin = new System.Windows.Forms.Padding(2);
            this.select_vehicle.Name = "select_vehicle";
            this.select_vehicle.Size = new System.Drawing.Size(224, 28);
            this.select_vehicle.TabIndex = 7;
            this.select_vehicle.Visible = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1008, 459);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 485);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "My first application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.databaseTab.ResumeLayout(false);
            this.databaseTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carInfo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label from_date_label;
        private System.Windows.Forms.Label to_date_label;
        private System.Windows.Forms.DateTimePicker from_date;
        private System.Windows.Forms.DateTimePicker to_date;
        private System.Windows.Forms.Label to_branch_label;
        private System.Windows.Forms.ComboBox to_branch;
        private System.Windows.Forms.Button make_reservation;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label select_vehicle_label;
        private System.Windows.Forms.ComboBox select_vehicle;
        private System.Windows.Forms.Button browse_vehicles;
        private System.Windows.Forms.ComboBox from_branch;
        private System.Windows.Forms.Label from_branch_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button start_over;
        private System.Windows.Forms.TabPage databaseTab;
        private System.Windows.Forms.DataGridView carInfo;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label branchLabel;
        private System.Windows.Forms.ComboBox yearComboBox;
        private System.Windows.Forms.ComboBox modelComboBox;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.Label findIDLabel;
        private System.Windows.Forms.Button searchCarIDButton;
        private System.Windows.Forms.TextBox findCarIDTextBox;
        private System.Windows.Forms.Button showAllButton;
    }
}

