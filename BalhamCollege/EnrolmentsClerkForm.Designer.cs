
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
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnStudentsReport = new System.Windows.Forms.Button();
            this.btnEnrolStudent = new System.Windows.Forms.Button();
            this.btnWithdrawStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(185, 230);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(200, 60);
            this.btnDeleteStudent.TabIndex = 0;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(185, 156);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(200, 60);
            this.btnUpdateStudent.TabIndex = 2;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(185, 85);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(200, 60);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Add a Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(323, 325);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 56);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnStudentsReport
            // 
            this.btnStudentsReport.Location = new System.Drawing.Point(443, 85);
            this.btnStudentsReport.Name = "btnStudentsReport";
            this.btnStudentsReport.Size = new System.Drawing.Size(200, 60);
            this.btnStudentsReport.TabIndex = 9;
            this.btnStudentsReport.Text = "Produce Students Report";
            this.btnStudentsReport.UseVisualStyleBackColor = true;
            this.btnStudentsReport.Click += new System.EventHandler(this.btnStudentsReport_Click);
            // 
            // btnEnrolStudent
            // 
            this.btnEnrolStudent.Location = new System.Drawing.Point(443, 156);
            this.btnEnrolStudent.Name = "btnEnrolStudent";
            this.btnEnrolStudent.Size = new System.Drawing.Size(200, 60);
            this.btnEnrolStudent.TabIndex = 8;
            this.btnEnrolStudent.Text = "Enrol Student";
            this.btnEnrolStudent.UseVisualStyleBackColor = true;
            this.btnEnrolStudent.Click += new System.EventHandler(this.btnEnrolStudent_Click);
            // 
            // btnWithdrawStudent
            // 
            this.btnWithdrawStudent.Location = new System.Drawing.Point(443, 230);
            this.btnWithdrawStudent.Name = "btnWithdrawStudent";
            this.btnWithdrawStudent.Size = new System.Drawing.Size(200, 60);
            this.btnWithdrawStudent.TabIndex = 7;
            this.btnWithdrawStudent.Text = "Withdraw Student";
            this.btnWithdrawStudent.UseVisualStyleBackColor = true;
            this.btnWithdrawStudent.Click += new System.EventHandler(this.btnWithdrawStudent_Click);
            // 
            // EnrolmentsClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnStudentsReport);
            this.Controls.Add(this.btnEnrolStudent);
            this.Controls.Add(this.btnWithdrawStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnDeleteStudent);
            this.Name = "EnrolmentsClerkForm";
            this.Text = "EnrolmentsClerkForm";
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
    }
}