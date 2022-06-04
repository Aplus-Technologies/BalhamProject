
namespace BalhamCollege
{
    partial class CourseAdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAdministratorForm));
            this.btnUpdateAssessment = new System.Windows.Forms.Button();
            this.btnDeleteAssessment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddAssessment = new System.Windows.Forms.Button();
            this.btnProduceAssessmentsReport = new System.Windows.Forms.Button();
            this.btnEnterResult = new System.Windows.Forms.Button();
            this.pbCourseAdmin = new System.Windows.Forms.PictureBox();
            this.courseTableAdapter1 = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.assessmentTableAdapter1 = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter();
            this.resultTableAdapter1 = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESULTTableAdapter();
            this.studentTableAdapter1 = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pbCourseAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateAssessment
            // 
            this.btnUpdateAssessment.AutoSize = true;
            this.btnUpdateAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnUpdateAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAssessment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAssessment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateAssessment.Location = new System.Drawing.Point(33, 421);
            this.btnUpdateAssessment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Size = new System.Drawing.Size(323, 78);
            this.btnUpdateAssessment.TabIndex = 36;
            this.btnUpdateAssessment.Text = "Update Assessment";
            this.btnUpdateAssessment.UseVisualStyleBackColor = false;
            this.btnUpdateAssessment.Click += new System.EventHandler(this.btnUpdateAssessment_Click);
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnDeleteAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAssessment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAssessment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteAssessment.Location = new System.Drawing.Point(33, 503);
            this.btnDeleteAssessment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Size = new System.Drawing.Size(323, 80);
            this.btnDeleteAssessment.TabIndex = 35;
            this.btnDeleteAssessment.Text = "Delete Assessment";
            this.btnDeleteAssessment.UseVisualStyleBackColor = false;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(33, 764);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(323, 87);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnAddAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAssessment.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssessment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAssessment.Location = new System.Drawing.Point(33, 331);
            this.btnAddAssessment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(323, 85);
            this.btnAddAssessment.TabIndex = 33;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.UseVisualStyleBackColor = false;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click);
            // 
            // btnProduceAssessmentsReport
            // 
            this.btnProduceAssessmentsReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnProduceAssessmentsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduceAssessmentsReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduceAssessmentsReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduceAssessmentsReport.Location = new System.Drawing.Point(33, 677);
            this.btnProduceAssessmentsReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduceAssessmentsReport.Name = "btnProduceAssessmentsReport";
            this.btnProduceAssessmentsReport.Size = new System.Drawing.Size(323, 82);
            this.btnProduceAssessmentsReport.TabIndex = 32;
            this.btnProduceAssessmentsReport.Text = "Produce Assessments Report";
            this.btnProduceAssessmentsReport.UseVisualStyleBackColor = false;
            this.btnProduceAssessmentsReport.Click += new System.EventHandler(this.btnProduceAssessmentsReport_Click);
            // 
            // btnEnterResult
            // 
            this.btnEnterResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnEnterResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterResult.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterResult.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnterResult.Location = new System.Drawing.Point(33, 588);
            this.btnEnterResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEnterResult.Name = "btnEnterResult";
            this.btnEnterResult.Size = new System.Drawing.Size(323, 84);
            this.btnEnterResult.TabIndex = 31;
            this.btnEnterResult.Text = "Enter Result";
            this.btnEnterResult.UseVisualStyleBackColor = false;
            this.btnEnterResult.Click += new System.EventHandler(this.btnEnterResult_Click);
            // 
            // pbCourseAdmin
            // 
            this.pbCourseAdmin.Image = global::BalhamCollege.Properties.Resources.courseAdminPage;
            this.pbCourseAdmin.Location = new System.Drawing.Point(-8, -5);
            this.pbCourseAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbCourseAdmin.Name = "pbCourseAdmin";
            this.pbCourseAdmin.Size = new System.Drawing.Size(1488, 874);
            this.pbCourseAdmin.TabIndex = 37;
            this.pbCourseAdmin.TabStop = false;
            // 
            // courseTableAdapter1
            // 
            this.courseTableAdapter1.ClearBeforeFill = true;
            // 
            // assessmentTableAdapter1
            // 
            this.assessmentTableAdapter1.ClearBeforeFill = true;
            // 
            // resultTableAdapter1
            // 
            this.resultTableAdapter1.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // CourseAdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1472, 865);
            this.Controls.Add(this.btnUpdateAssessment);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddAssessment);
            this.Controls.Add(this.btnProduceAssessmentsReport);
            this.Controls.Add(this.btnEnterResult);
            this.Controls.Add(this.pbCourseAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CourseAdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Administrator Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbCourseAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAssessment;
        private System.Windows.Forms.Button btnDeleteAssessment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.Button btnProduceAssessmentsReport;
        private System.Windows.Forms.Button btnEnterResult;
        private System.Windows.Forms.PictureBox pbCourseAdmin;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter courseTableAdapter1;
        private dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter assessmentTableAdapter1;
        private dsBalhamCollegeAzureTableAdapters.RESULTTableAdapter resultTableAdapter1;
        private dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter studentTableAdapter1;
    }
}