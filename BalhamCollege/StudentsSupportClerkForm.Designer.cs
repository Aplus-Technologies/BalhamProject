
namespace BalhamCollege
{
    partial class StudentsSupportClerkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsSupportClerkForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnProduceIssuesReport = new System.Windows.Forms.Button();
            this.btnRecordIssue = new System.Windows.Forms.Button();
            this.pbStudentSupportClerk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentSupportClerk)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(31, 621);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(241, 72);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnProduceIssuesReport
            // 
            this.btnProduceIssuesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnProduceIssuesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduceIssuesReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduceIssuesReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduceIssuesReport.Location = new System.Drawing.Point(31, 339);
            this.btnProduceIssuesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduceIssuesReport.Name = "btnProduceIssuesReport";
            this.btnProduceIssuesReport.Size = new System.Drawing.Size(241, 68);
            this.btnProduceIssuesReport.TabIndex = 34;
            this.btnProduceIssuesReport.Text = "Produce Issues Report";
            this.btnProduceIssuesReport.UseVisualStyleBackColor = false;
            this.btnProduceIssuesReport.Click += new System.EventHandler(this.btnProduceIssuesReport_Click);
            // 
            // btnRecordIssue
            // 
            this.btnRecordIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnRecordIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordIssue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordIssue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecordIssue.Location = new System.Drawing.Point(31, 269);
            this.btnRecordIssue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecordIssue.Name = "btnRecordIssue";
            this.btnRecordIssue.Size = new System.Drawing.Size(241, 66);
            this.btnRecordIssue.TabIndex = 33;
            this.btnRecordIssue.Text = "Record Issue";
            this.btnRecordIssue.UseVisualStyleBackColor = false;
            this.btnRecordIssue.Click += new System.EventHandler(this.btnRecordIssue_Click);
            // 
            // pbStudentSupportClerk
            // 
            this.pbStudentSupportClerk.Image = global::BalhamCollege.Properties.Resources.studentSupportClerkPage;
            this.pbStudentSupportClerk.Location = new System.Drawing.Point(0, -4);
            this.pbStudentSupportClerk.Name = "pbStudentSupportClerk";
            this.pbStudentSupportClerk.Size = new System.Drawing.Size(1115, 710);
            this.pbStudentSupportClerk.TabIndex = 36;
            this.pbStudentSupportClerk.TabStop = false;
            // 
            // StudentsSupportClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 704);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnProduceIssuesReport);
            this.Controls.Add(this.btnRecordIssue);
            this.Controls.Add(this.pbStudentSupportClerk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentsSupportClerkForm";
            this.Text = "Student Support Clerk Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentSupportClerk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnProduceIssuesReport;
        private System.Windows.Forms.Button btnRecordIssue;
        private System.Windows.Forms.PictureBox pbStudentSupportClerk;
    }
}