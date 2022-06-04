
namespace BalhamCollege
{
    partial class AddStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblAsterix1 = new System.Windows.Forms.Label();
            this.lblAsterix2 = new System.Windows.Forms.Label();
            this.lblAsterix3 = new System.Windows.Forms.Label();
            this.lblAsterix4 = new System.Windows.Forms.Label();
            this.lblAsterix5 = new System.Windows.Forms.Label();
            this.lblAsterix6 = new System.Windows.Forms.Label();
            this.lblAsterix7 = new System.Windows.Forms.Label();
            this.lblAsterix8 = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(239, 53);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(224, 27);
            this.txtLastName.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(239, 107);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(224, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(239, 165);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(438, 27);
            this.txtStreetAddress.TabIndex = 2;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(239, 222);
            this.txtSuburb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSuburb.MaxLength = 30;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(224, 27);
            this.txtSuburb.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(239, 276);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(224, 27);
            this.txtCity.TabIndex = 4;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(239, 332);
            this.txtEmailAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmailAddress.MaxLength = 50;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(438, 27);
            this.txtEmailAddress.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(239, 388);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPhoneNumber.MaxLength = 16;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(132, 27);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Part-time",
            "Full-time"});
            this.cboStatus.Location = new System.Drawing.Point(240, 441);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(109, 27);
            this.cboStatus.TabIndex = 7;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(149, 61);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(89, 19);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(147, 115);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(91, 19);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetAddress.Location = new System.Drawing.Point(120, 173);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(118, 19);
            this.lblStreetAddress.TabIndex = 10;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuburb.Location = new System.Drawing.Point(174, 230);
            this.lblSuburb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(66, 19);
            this.lblSuburb.TabIndex = 11;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(198, 284);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(42, 19);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "City:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(124, 340);
            this.lblEmailAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(116, 19);
            this.lblEmailAddress.TabIndex = 13;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(120, 396);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(121, 19);
            this.lblPhoneNumber.TabIndex = 14;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(183, 449);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 19);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "Status:";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStudent.Location = new System.Drawing.Point(119, 535);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(202, 61);
            this.btnAddStudent.TabIndex = 16;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(232)))), ((int)(((byte)(252)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.Location = new System.Drawing.Point(554, 535);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(202, 61);
            this.btnReturn.TabIndex = 17;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblAsterix1
            // 
            this.lblAsterix1.AutoSize = true;
            this.lblAsterix1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix1.Location = new System.Drawing.Point(132, 53);
            this.lblAsterix1.Name = "lblAsterix1";
            this.lblAsterix1.Size = new System.Drawing.Size(18, 19);
            this.lblAsterix1.TabIndex = 18;
            this.lblAsterix1.Text = "*";
            // 
            // lblAsterix2
            // 
            this.lblAsterix2.AutoSize = true;
            this.lblAsterix2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix2.Location = new System.Drawing.Point(132, 107);
            this.lblAsterix2.Name = "lblAsterix2";
            this.lblAsterix2.Size = new System.Drawing.Size(18, 19);
            this.lblAsterix2.TabIndex = 19;
            this.lblAsterix2.Text = "*";
            // 
            // lblAsterix3
            // 
            this.lblAsterix3.AutoSize = true;
            this.lblAsterix3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix3.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix3.Location = new System.Drawing.Point(104, 165);
            this.lblAsterix3.Name = "lblAsterix3";
            this.lblAsterix3.Size = new System.Drawing.Size(18, 19);
            this.lblAsterix3.TabIndex = 20;
            this.lblAsterix3.Text = "*";
            // 
            // lblAsterix4
            // 
            this.lblAsterix4.AutoSize = true;
            this.lblAsterix4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix4.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix4.Location = new System.Drawing.Point(160, 225);
            this.lblAsterix4.Name = "lblAsterix4";
            this.lblAsterix4.Size = new System.Drawing.Size(18, 19);
            this.lblAsterix4.TabIndex = 21;
            this.lblAsterix4.Text = "*";
            // 
            // lblAsterix5
            // 
            this.lblAsterix5.AutoSize = true;
            this.lblAsterix5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix5.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix5.Location = new System.Drawing.Point(183, 276);
            this.lblAsterix5.Name = "lblAsterix5";
            this.lblAsterix5.Size = new System.Drawing.Size(18, 19);
            this.lblAsterix5.TabIndex = 22;
            this.lblAsterix5.Text = "*";
            // 
            // lblAsterix6
            // 
            this.lblAsterix6.AutoSize = true;
            this.lblAsterix6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix6.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix6.Location = new System.Drawing.Point(115, 332);
            this.lblAsterix6.Name = "lblAsterix6";
            this.lblAsterix6.Size = new System.Drawing.Size(18, 19);
            this.lblAsterix6.TabIndex = 23;
            this.lblAsterix6.Text = "*";
            // 
            // lblAsterix7
            // 
            this.lblAsterix7.AutoSize = true;
            this.lblAsterix7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix7.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix7.Location = new System.Drawing.Point(115, 388);
            this.lblAsterix7.Name = "lblAsterix7";
            this.lblAsterix7.Size = new System.Drawing.Size(18, 19);
            this.lblAsterix7.TabIndex = 24;
            this.lblAsterix7.Text = "*";
            // 
            // lblAsterix8
            // 
            this.lblAsterix8.AutoSize = true;
            this.lblAsterix8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix8.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix8.Location = new System.Drawing.Point(174, 441);
            this.lblAsterix8.Name = "lblAsterix8";
            this.lblAsterix8.Size = new System.Drawing.Size(18, 19);
            this.lblAsterix8.TabIndex = 25;
            this.lblAsterix8.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(630, 473);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(126, 19);
            this.lblRequiredFields.TabIndex = 26;
            this.lblRequiredFields.Text = "*Required Fields";
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(901, 631);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.lblAsterix8);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAsterix7);
            this.Controls.Add(this.lblAsterix6);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblAsterix4);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblAsterix3);
            this.Controls.Add(this.lblAsterix1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lblAsterix5);
            this.Controls.Add(this.lblAsterix2);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddStudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblAsterix1;
        private System.Windows.Forms.Label lblAsterix2;
        private System.Windows.Forms.Label lblAsterix3;
        private System.Windows.Forms.Label lblAsterix4;
        private System.Windows.Forms.Label lblAsterix5;
        private System.Windows.Forms.Label lblAsterix6;
        private System.Windows.Forms.Label lblAsterix7;
        private System.Windows.Forms.Label lblAsterix8;
        private System.Windows.Forms.Label lblRequiredFields;
    }
}