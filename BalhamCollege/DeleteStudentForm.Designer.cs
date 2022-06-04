namespace BalhamCollege
{
    partial class DeleteStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.dsBalhamCollegeAzure1 = new BalhamCollege.dsBalhamCollegeAzure();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter();
            this.eNROLMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter();
            this.studentTableAdapter1 = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Please select a student:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(609, 380);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(157, 42);
            this.btnReturn.TabIndex = 42;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(268, 380);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(188, 42);
            this.btnDeleteStudent.TabIndex = 41;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(380, 305);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(76, 26);
            this.txtStatus.TabIndex = 40;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(380, 273);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 26);
            this.txtPhoneNumber.TabIndex = 39;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(380, 241);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(386, 26);
            this.txtEmailAddress.TabIndex = 38;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(380, 209);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(221, 26);
            this.txtCity.TabIndex = 37;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(380, 177);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(221, 26);
            this.txtSuburb.TabIndex = 36;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(380, 145);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(386, 26);
            this.txtStreetAddress.TabIndex = 35;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(380, 113);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(221, 26);
            this.txtFirstName.TabIndex = 34;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(380, 81);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(221, 26);
            this.txtLastName.TabIndex = 33;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(380, 49);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(42, 26);
            this.txtStudentID.TabIndex = 32;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(323, 308);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 31;
            this.lblStatus.Text = "Status:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(269, 276);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.lblPhoneNumber.TabIndex = 30;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(269, 244);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(115, 20);
            this.lblEmailAddress.TabIndex = 29;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(345, 212);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 28;
            this.lblCity.Text = "City:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(319, 180);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(65, 20);
            this.lblSuburb.TabIndex = 27;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(264, 148);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(120, 20);
            this.lblStreetAddress.TabIndex = 26;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(293, 116);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(90, 20);
            this.lblFirstName.TabIndex = 25;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(294, 84);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 20);
            this.lblLastName.TabIndex = 24;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(293, 52);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(91, 20);
            this.lblStudentID.TabIndex = 23;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lstStudents
            // 
            this.lstStudents.FormattingEnabled = true;
            this.lstStudents.ItemHeight = 20;
            this.lstStudents.Location = new System.Drawing.Point(37, 49);
            this.lstStudents.Name = "lstStudents";
            this.lstStudents.Size = new System.Drawing.Size(200, 284);
            this.lstStudents.TabIndex = 22;
            this.lstStudents.SelectedIndexChanged += new System.EventHandler(this.lstStudents_SelectedIndexChanged);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dsBalhamCollegeAzure1
            // 
            this.dsBalhamCollegeAzure1.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure1.EnforceConstraints = false;
            this.dsBalhamCollegeAzure1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dsBalhamCollegeAzure1;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // eNROLMENTBindingSource
            // 
            this.eNROLMENTBindingSource.DataMember = "ENROLMENT";
            this.eNROLMENTBindingSource.DataSource = this.dsBalhamCollegeAzure1;
            // 
            // eNROLMENTTableAdapter
            // 
            this.eNROLMENTTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // DeleteStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 630);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lstStudents);
            this.Name = "DeleteStudentForm";
            this.Text = "DeleteStudentForm";
            this.Load += new System.EventHandler(this.DeleteStudentForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.ListBox lstStudents;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure1;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.BindingSource eNROLMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter eNROLMENTTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter studentTableAdapter1;
    }
}