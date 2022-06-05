
namespace BalhamCollege
{
    partial class RecordIssueForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStudentFirstName = new System.Windows.Forms.TextBox();
            this.txtStudentLastName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.dgvEnrolments = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIssueDescription = new System.Windows.Forms.TextBox();
            this.txtActionTaken = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.btnRecordIssue = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.courseTableAdapter1 = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.eNROLMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter();
            this.eNROLMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSSUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSSUETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ISSUETableAdapter();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(861, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Street Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(837, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Student First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(889, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Student ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(834, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Student Last Name:";
            // 
            // txtStudentFirstName
            // 
            this.txtStudentFirstName.Location = new System.Drawing.Point(973, 134);
            this.txtStudentFirstName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentFirstName.Name = "txtStudentFirstName";
            this.txtStudentFirstName.ReadOnly = true;
            this.txtStudentFirstName.Size = new System.Drawing.Size(248, 22);
            this.txtStudentFirstName.TabIndex = 25;
            // 
            // txtStudentLastName
            // 
            this.txtStudentLastName.Location = new System.Drawing.Point(973, 101);
            this.txtStudentLastName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentLastName.Name = "txtStudentLastName";
            this.txtStudentLastName.ReadOnly = true;
            this.txtStudentLastName.Size = new System.Drawing.Size(248, 22);
            this.txtStudentLastName.TabIndex = 24;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(973, 169);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(284, 22);
            this.txtStreetAddress.TabIndex = 23;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(973, 67);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(58, 22);
            this.txtStudentID.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(932, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(909, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Suburb:";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(973, 199);
            this.txtSuburb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(248, 22);
            this.txtSuburb.TabIndex = 31;
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(973, 229);
            this.txtcity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcity.Name = "txtcity";
            this.txtcity.ReadOnly = true;
            this.txtcity.Size = new System.Drawing.Size(248, 22);
            this.txtcity.TabIndex = 30;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(41, 53);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(750, 230);
            this.dgvStudents.TabIndex = 34;
            this.dgvStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellClick);
            // 
            // dgvEnrolments
            // 
            this.dgvEnrolments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolments.Location = new System.Drawing.Point(41, 332);
            this.dgvEnrolments.Name = "dgvEnrolments";
            this.dgvEnrolments.RowHeadersWidth = 51;
            this.dgvEnrolments.RowTemplate.Height = 24;
            this.dgvEnrolments.Size = new System.Drawing.Size(590, 200);
            this.dgvEnrolments.TabIndex = 35;
            this.dgvEnrolments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrolments_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Please select a student:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 312);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Please select an Enrolment";
            // 
            // txtIssueDescription
            // 
            this.txtIssueDescription.Location = new System.Drawing.Point(695, 332);
            this.txtIssueDescription.Multiline = true;
            this.txtIssueDescription.Name = "txtIssueDescription";
            this.txtIssueDescription.Size = new System.Drawing.Size(300, 80);
            this.txtIssueDescription.TabIndex = 38;
            // 
            // txtActionTaken
            // 
            this.txtActionTaken.Location = new System.Drawing.Point(693, 452);
            this.txtActionTaken.Multiline = true;
            this.txtActionTaken.Name = "txtActionTaken";
            this.txtActionTaken.Size = new System.Drawing.Size(300, 80);
            this.txtActionTaken.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(692, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 41;
            this.label10.Text = "Action Taken:";
            // 
            // dtpIssueDate
            // 
            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(1177, 330);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(109, 22);
            this.dtpIssueDate.TabIndex = 42;
            // 
            // btnRecordIssue
            // 
            this.btnRecordIssue.Location = new System.Drawing.Point(1119, 387);
            this.btnRecordIssue.Name = "btnRecordIssue";
            this.btnRecordIssue.Size = new System.Drawing.Size(187, 62);
            this.btnRecordIssue.TabIndex = 43;
            this.btnRecordIssue.Text = "Record Issue";
            this.btnRecordIssue.UseVisualStyleBackColor = true;
            this.btnRecordIssue.Click += new System.EventHandler(this.btnRecordIssue_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(1119, 470);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(187, 62);
            this.btnReturn.TabIndex = 44;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(692, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "Issue Description:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1092, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 45;
            this.label11.Text = "Issue Date:";
            // 
            // dsBalhamCollegeAzure
            // 
            this.dsBalhamCollegeAzure.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure.EnforceConstraints = false;
            this.dsBalhamCollegeAzure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASSESSMENTTableAdapter = null;
            this.tableAdapterManager.ASSIGNMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = this.courseTableAdapter1;
            this.tableAdapterManager.ENROLMENTTableAdapter = this.eNROLMENTTableAdapter;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.LECTURERTableAdapter = null;
            this.tableAdapterManager.PROGRAMMETableAdapter = null;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = this.sTUDENTTableAdapter;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // eNROLMENTTableAdapter
            // 
            this.eNROLMENTTableAdapter.ClearBeforeFill = true;
            // 
            // eNROLMENTBindingSource
            // 
            this.eNROLMENTBindingSource.DataMember = "ENROLMENT";
            this.eNROLMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // iSSUEBindingSource
            // 
            this.iSSUEBindingSource.DataMember = "ISSUE";
            this.iSSUEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // iSSUETableAdapter
            // 
            this.iSSUETableAdapter.ClearBeforeFill = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1270, 546);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "*Required";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(673, 432);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 48;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(673, 312);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 17);
            this.label15.TabIndex = 49;
            this.label15.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(1083, 332);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(13, 17);
            this.label13.TabIndex = 47;
            this.label13.Text = "*";
            // 
            // RecordIssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 582);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRecordIssue);
            this.Controls.Add(this.dtpIssueDate);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtActionTaken);
            this.Controls.Add(this.txtIssueDescription);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvEnrolments);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStudentFirstName);
            this.Controls.Add(this.txtStudentLastName);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtStudentID);
            this.Name = "RecordIssueForm";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.RecordIssueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStudentFirstName;
        private System.Windows.Forms.TextBox txtStudentLastName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvEnrolments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIssueDescription;
        private System.Windows.Forms.TextBox txtActionTaken;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Button btnRecordIssue;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter eNROLMENTTableAdapter;
        private System.Windows.Forms.BindingSource eNROLMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter courseTableAdapter1;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private System.Windows.Forms.BindingSource iSSUEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ISSUETableAdapter iSSUETableAdapter;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
    }
}