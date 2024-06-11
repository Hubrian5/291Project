namespace My_first_App_Monday
{
    partial class manageCar
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
            this.Cars = new System.Windows.Forms.Label();
            this.carBranchLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.typeCarLabel = new System.Windows.Forms.Label();
            this.addCarButton = new System.Windows.Forms.RadioButton();
            this.modifyCarButton = new System.Windows.Forms.RadioButton();
            this.deleteCarButton = new System.Windows.Forms.RadioButton();
            this.carBranchComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.carModelComboBox = new System.Windows.Forms.ComboBox();
            this.carYearComboBox = new System.Windows.Forms.ComboBox();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.carFindLabel = new System.Windows.Forms.Label();
            this.carFindComboBox = new System.Windows.Forms.ComboBox();
            this.findButton = new System.Windows.Forms.Button();
            this.carModifyIDLabel = new System.Windows.Forms.Label();
            this.carModifyIDComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cars
            // 
            this.Cars.AutoSize = true;
            this.Cars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cars.Location = new System.Drawing.Point(23, 22);
            this.Cars.Name = "Cars";
            this.Cars.Size = new System.Drawing.Size(191, 25);
            this.Cars.TabIndex = 0;
            this.Cars.Text = "Car Management";
            // 
            // carBranchLabel
            // 
            this.carBranchLabel.AutoSize = true;
            this.carBranchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carBranchLabel.Location = new System.Drawing.Point(28, 126);
            this.carBranchLabel.Name = "carBranchLabel";
            this.carBranchLabel.Size = new System.Drawing.Size(60, 20);
            this.carBranchLabel.TabIndex = 1;
            this.carBranchLabel.Text = "Branch";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carModelLabel.Location = new System.Drawing.Point(28, 167);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(52, 20);
            this.carModelLabel.TabIndex = 2;
            this.carModelLabel.Text = "Model";
            // 
            // carYearLabel
            // 
            this.carYearLabel.AutoSize = true;
            this.carYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carYearLabel.Location = new System.Drawing.Point(28, 210);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(142, 20);
            this.carYearLabel.TabIndex = 3;
            this.carYearLabel.Text = "Manufacturer Year";
            // 
            // typeCarLabel
            // 
            this.typeCarLabel.AutoSize = true;
            this.typeCarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.typeCarLabel.Location = new System.Drawing.Point(28, 248);
            this.typeCarLabel.Name = "typeCarLabel";
            this.typeCarLabel.Size = new System.Drawing.Size(72, 20);
            this.typeCarLabel.TabIndex = 4;
            this.typeCarLabel.Text = "Car Type";
            // 
            // addCarButton
            // 
            this.addCarButton.AutoSize = true;
            this.addCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addCarButton.Location = new System.Drawing.Point(28, 62);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(56, 24);
            this.addCarButton.TabIndex = 5;
            this.addCarButton.TabStop = true;
            this.addCarButton.Text = "Add";
            this.addCarButton.UseVisualStyleBackColor = true;
            // 
            // modifyCarButton
            // 
            this.modifyCarButton.AutoSize = true;
            this.modifyCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.modifyCarButton.Location = new System.Drawing.Point(97, 62);
            this.modifyCarButton.Name = "modifyCarButton";
            this.modifyCarButton.Size = new System.Drawing.Size(73, 24);
            this.modifyCarButton.TabIndex = 6;
            this.modifyCarButton.TabStop = true;
            this.modifyCarButton.Text = "Modify";
            this.modifyCarButton.UseVisualStyleBackColor = true;
            this.modifyCarButton.CheckedChanged += new System.EventHandler(this.modifyCarButton_CheckedChanged);
            // 
            // deleteCarButton
            // 
            this.deleteCarButton.AutoSize = true;
            this.deleteCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deleteCarButton.Location = new System.Drawing.Point(176, 62);
            this.deleteCarButton.Name = "deleteCarButton";
            this.deleteCarButton.Size = new System.Drawing.Size(74, 24);
            this.deleteCarButton.TabIndex = 7;
            this.deleteCarButton.TabStop = true;
            this.deleteCarButton.Text = "Delete";
            this.deleteCarButton.UseVisualStyleBackColor = true;
            // 
            // carBranchComboBox
            // 
            this.carBranchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carBranchComboBox.FormattingEnabled = true;
            this.carBranchComboBox.Location = new System.Drawing.Point(186, 120);
            this.carBranchComboBox.Name = "carBranchComboBox";
            this.carBranchComboBox.Size = new System.Drawing.Size(201, 28);
            this.carBranchComboBox.TabIndex = 11;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(614, 92);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(136, 84);
            this.confirmButton.TabIndex = 12;
            this.confirmButton.Text = "Confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(614, 219);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(136, 84);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // carModelComboBox
            // 
            this.carModelComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carModelComboBox.FormattingEnabled = true;
            this.carModelComboBox.Location = new System.Drawing.Point(186, 164);
            this.carModelComboBox.Name = "carModelComboBox";
            this.carModelComboBox.Size = new System.Drawing.Size(201, 28);
            this.carModelComboBox.TabIndex = 14;
            // 
            // carYearComboBox
            // 
            this.carYearComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carYearComboBox.FormattingEnabled = true;
            this.carYearComboBox.Location = new System.Drawing.Point(186, 207);
            this.carYearComboBox.Name = "carYearComboBox";
            this.carYearComboBox.Size = new System.Drawing.Size(201, 28);
            this.carYearComboBox.TabIndex = 15;
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Location = new System.Drawing.Point(186, 245);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(201, 28);
            this.carTypeComboBox.TabIndex = 16;
            // 
            // carFindLabel
            // 
            this.carFindLabel.AutoSize = true;
            this.carFindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carFindLabel.Location = new System.Drawing.Point(301, 38);
            this.carFindLabel.Name = "carFindLabel";
            this.carFindLabel.Size = new System.Drawing.Size(69, 20);
            this.carFindLabel.TabIndex = 20;
            this.carFindLabel.Text = "Find Car";
            // 
            // carFindComboBox
            // 
            this.carFindComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carFindComboBox.FormattingEnabled = true;
            this.carFindComboBox.Location = new System.Drawing.Point(376, 35);
            this.carFindComboBox.Name = "carFindComboBox";
            this.carFindComboBox.Size = new System.Drawing.Size(201, 28);
            this.carFindComboBox.TabIndex = 21;
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(425, 69);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(90, 55);
            this.findButton.TabIndex = 22;
            this.findButton.Text = "Find";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // carModifyIDLabel
            // 
            this.carModifyIDLabel.AutoSize = true;
            this.carModifyIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carModifyIDLabel.Location = new System.Drawing.Point(18, 405);
            this.carModifyIDLabel.Name = "carModifyIDLabel";
            this.carModifyIDLabel.Size = new System.Drawing.Size(162, 20);
            this.carModifyIDLabel.TabIndex = 23;
            this.carModifyIDLabel.Text = "Delete/Modify Car ID*";
            // 
            // carModifyIDComboBox
            // 
            this.carModifyIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.carModifyIDComboBox.FormattingEnabled = true;
            this.carModifyIDComboBox.Location = new System.Drawing.Point(186, 402);
            this.carModifyIDComboBox.Name = "carModifyIDComboBox";
            this.carModifyIDComboBox.Size = new System.Drawing.Size(201, 28);
            this.carModifyIDComboBox.TabIndex = 24;
            this.carModifyIDComboBox.SelectedIndexChanged += new System.EventHandler(this.carModifyIDComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "This does nothing unless modify is selected";
            // 
            // manageCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.carModifyIDComboBox);
            this.Controls.Add(this.carModifyIDLabel);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.carFindComboBox);
            this.Controls.Add(this.carFindLabel);
            this.Controls.Add(this.carTypeComboBox);
            this.Controls.Add(this.carYearComboBox);
            this.Controls.Add(this.carModelComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.carBranchComboBox);
            this.Controls.Add(this.deleteCarButton);
            this.Controls.Add(this.modifyCarButton);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.typeCarLabel);
            this.Controls.Add(this.carYearLabel);
            this.Controls.Add(this.carModelLabel);
            this.Controls.Add(this.carBranchLabel);
            this.Controls.Add(this.Cars);
            this.Name = "manageCar";
            this.Text = "addCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Cars;
        private System.Windows.Forms.Label carBranchLabel;
        private System.Windows.Forms.Label carModelLabel;
        private System.Windows.Forms.Label carYearLabel;
        private System.Windows.Forms.Label typeCarLabel;
        private System.Windows.Forms.RadioButton addCarButton;
        private System.Windows.Forms.RadioButton modifyCarButton;
        private System.Windows.Forms.RadioButton deleteCarButton;
        private System.Windows.Forms.ComboBox carBranchComboBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox carModelComboBox;
        private System.Windows.Forms.ComboBox carYearComboBox;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.Label carFindLabel;
        private System.Windows.Forms.ComboBox carFindComboBox;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label carModifyIDLabel;
        private System.Windows.Forms.ComboBox carModifyIDComboBox;
        private System.Windows.Forms.Label label1;
    }
}