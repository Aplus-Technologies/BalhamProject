
namespace BalhamCollege
{
    partial class EnrolmentsClerkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnrolmentsClerkForm));
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnStudentsReport = new System.Windows.Forms.Button();
            this.btnEnrolStudent = new System.Windows.Forms.Button();
            this.btnWithdrawStudent = new System.Windows.Forms.Button();
            this.pbEnrolmentsClerk = new System.Windows.Forms.PictureBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.eNROLMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.pROGRAMMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROGRAMMETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter();
            this.printStudents = new System.Drawing.Printing.PrintDocument();
            this.prvStudents = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbEnrolmentsClerk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnDeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteStudent.Location = new System.Drawing.Point(31, 365);
            this.btnDeleteStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(242, 50);
            this.btnDeleteStudent.TabIndex = 0;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateStudent.Location = new System.Drawing.Point(31, 311);
            this.btnUpdateStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(242, 50);
            this.btnUpdateStudent.TabIndex = 2;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddStudent.Location = new System.Drawing.Point(31, 257);
            this.btnAddStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(242, 50);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add a Student";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(31, 581);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(242, 50);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Log Out";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnStudentsReport
            // 
            this.btnStudentsReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnStudentsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentsReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentsReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStudentsReport.Location = new System.Drawing.Point(31, 527);
            this.btnStudentsReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentsReport.Name = "btnStudentsReport";
            this.btnStudentsReport.Size = new System.Drawing.Size(242, 50);
            this.btnStudentsReport.TabIndex = 9;
            this.btnStudentsReport.Text = "Produce Students Report";
            this.btnStudentsReport.UseVisualStyleBackColor = false;
            this.btnStudentsReport.Click += new System.EventHandler(this.btnStudentsReport_Click);
            // 
            // btnEnrolStudent
            // 
            this.btnEnrolStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnEnrolStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnrolStudent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnrolStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnrolStudent.Location = new System.Drawing.Point(31, 419);
            this.btnEnrolStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnrolStudent.Name = "btnEnrolStudent";
            this.btnEnrolStudent.Size = new System.Drawing.Size(242, 50);
            this.btnEnrolStudent.TabIndex = 8;
            this.btnEnrolStudent.Text = "Enrol Student";
            this.btnEnrolStudent.UseVisualStyleBackColor = false;
            this.btnEnrolStudent.Click += new System.EventHandler(this.btnEnrolStudent_Click);
            // 
            // btnWithdrawStudent
            // 
            this.btnWithdrawStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnWithdrawStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWithdrawStudent.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWithdrawStudent.ForeColor = System.Drawing.SystemColors.Control;
            this.btnWithdrawStudent.Location = new System.Drawing.Point(31, 473);
            this.btnWithdrawStudent.Margin = new System.Windows.Forms.Padding(2);
            this.btnWithdrawStudent.Name = "btnWithdrawStudent";
            this.btnWithdrawStudent.Size = new System.Drawing.Size(242, 50);
            this.btnWithdrawStudent.TabIndex = 7;
            this.btnWithdrawStudent.Text = "Withdraw Student";
            this.btnWithdrawStudent.UseVisualStyleBackColor = false;
            this.btnWithdrawStudent.Click += new System.EventHandler(this.btnWithdrawStudent_Click);
            // 
            // pbEnrolmentsClerk
            // 
            this.pbEnrolmentsClerk.Image = global::BalhamCollege.Properties.Resources.enrolmentsClerkPage;
            this.pbEnrolmentsClerk.Location = new System.Drawing.Point(0, -5);
            this.pbEnrolmentsClerk.Name = "pbEnrolmentsClerk";
            this.pbEnrolmentsClerk.Size = new System.Drawing.Size(1103, 713);
            this.pbEnrolmentsClerk.TabIndex = 11;
            this.pbEnrolmentsClerk.TabStop = false;
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
            this.tableAdapterManager.COURSETableAdapter = this.cOURSETableAdapter;
            this.tableAdapterManager.ENROLMENTTableAdapter = this.eNROLMENTTableAdapter;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.LECTURERTableAdapter = null;
            this.tableAdapterManager.PROGRAMMETableAdapter = this.pROGRAMMETableAdapter;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = this.sTUDENTTableAdapter;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eNROLMENTBindingSource
            // 
            this.eNROLMENTBindingSource.DataMember = "ENROLMENT";
            this.eNROLMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // eNROLMENTTableAdapter
            // 
            this.eNROLMENTTableAdapter.ClearBeforeFill = true;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            //
            // pROGRAMMETableAdapter
            // 
            this.pROGRAMMETableAdapter.ClearBeforeFill = true;
            // 
            // printStudents
            // 
            this.printStudents.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printStudents_PrintPage);
            // 
            // prvStudents
            // 
            this.prvStudents.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvStudents.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvStudents.ClientSize = new System.Drawing.Size(400, 300);
            this.prvStudents.Document = this.printStudents;
            this.prvStudents.Enabled = true;
            this.prvStudents.Icon = ((System.Drawing.Icon)(resources.GetObject("prvStudents.Icon")));
            this.prvStudents.Name = "prvStudents";
            this.prvStudents.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(31, 635);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(242, 50);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // EnrolmentsClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1095, 706);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnStudentsReport);
            this.Controls.Add(this.btnEnrolStudent);
            this.Controls.Add(this.btnWithdrawStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.pbEnrolmentsClerk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EnrolmentsClerkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enrolments Clerk Menu";
            this.Load += new System.EventHandler(this.EnrolmentsClerkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEnrolmentsClerk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnStudentsReport;
        private System.Windows.Forms.Button btnEnrolStudent;
        private System.Windows.Forms.Button btnWithdrawStudent;
        private System.Windows.Forms.PictureBox pbEnrolmentsClerk;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter eNROLMENTTableAdapter;
        private System.Windows.Forms.BindingSource eNROLMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter pROGRAMMETableAdapter;
        private System.Windows.Forms.BindingSource pROGRAMMEBindingSource;
        private System.Drawing.Printing.PrintDocument printStudents;
        private System.Windows.Forms.PrintPreviewDialog prvStudents;
        private System.Windows.Forms.Button btnExit;
    }
}