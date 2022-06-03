
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
            this.SuspendLayout();
            // 
            // btnUpdateAssessment
            // 
            this.btnUpdateAssessment.Location = new System.Drawing.Point(310, 54);
            this.btnUpdateAssessment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Size = new System.Drawing.Size(150, 49);
            this.btnUpdateAssessment.TabIndex = 36;
            this.btnUpdateAssessment.Text = "Update Assessment";
            this.btnUpdateAssessment.UseVisualStyleBackColor = true;
            this.btnUpdateAssessment.Click += new System.EventHandler(this.btnUpdateAssessment_Click);
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.Location = new System.Drawing.Point(140, 115);
            this.btnDeleteAssessment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Size = new System.Drawing.Size(150, 49);
            this.btnDeleteAssessment.TabIndex = 35;
            this.btnDeleteAssessment.Text = "Delete Assessment";
            this.btnDeleteAssessment.UseVisualStyleBackColor = true;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(241, 267);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 46);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Location = new System.Drawing.Point(140, 54);
            this.btnAddAssessment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(150, 49);
            this.btnAddAssessment.TabIndex = 33;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.UseVisualStyleBackColor = true;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click);
            // 
            // btnProduceAssessmentsReport
            // 
            this.btnProduceAssessmentsReport.Location = new System.Drawing.Point(310, 115);
            this.btnProduceAssessmentsReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduceAssessmentsReport.Name = "btnProduceAssessmentsReport";
            this.btnProduceAssessmentsReport.Size = new System.Drawing.Size(150, 49);
            this.btnProduceAssessmentsReport.TabIndex = 32;
            this.btnProduceAssessmentsReport.Text = "Produce Assessments Report";
            this.btnProduceAssessmentsReport.UseVisualStyleBackColor = true;
            this.btnProduceAssessmentsReport.Click += new System.EventHandler(this.btnProduceAssessmentsReport_Click);
            // 
            // btnEnterResult
            // 
            this.btnEnterResult.Location = new System.Drawing.Point(228, 177);
            this.btnEnterResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnterResult.Name = "btnEnterResult";
            this.btnEnterResult.Size = new System.Drawing.Size(150, 49);
            this.btnEnterResult.TabIndex = 31;
            this.btnEnterResult.Text = "Enter Result";
            this.btnEnterResult.UseVisualStyleBackColor = true;
            this.btnEnterResult.Click += new System.EventHandler(this.btnEnterResult_Click);
            // 
            // CourseAdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnUpdateAssessment);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddAssessment);
            this.Controls.Add(this.btnProduceAssessmentsReport);
            this.Controls.Add(this.btnEnterResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CourseAdministratorForm";
            this.Text = "CourseAdministratorForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAssessment;
        private System.Windows.Forms.Button btnDeleteAssessment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.Button btnProduceAssessmentsReport;
        private System.Windows.Forms.Button btnEnterResult;
    }
}