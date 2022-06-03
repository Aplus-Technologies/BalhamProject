
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
            this.btnUpdateAssessment.Location = new System.Drawing.Point(413, 66);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Size = new System.Drawing.Size(200, 60);
            this.btnUpdateAssessment.TabIndex = 36;
            this.btnUpdateAssessment.Text = "Update Assessment";
            this.btnUpdateAssessment.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.Location = new System.Drawing.Point(187, 142);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Size = new System.Drawing.Size(200, 60);
            this.btnDeleteAssessment.TabIndex = 35;
            this.btnDeleteAssessment.Text = "Delete Assessment";
            this.btnDeleteAssessment.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(321, 329);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 56);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Location = new System.Drawing.Point(187, 66);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(200, 60);
            this.btnAddAssessment.TabIndex = 33;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.UseVisualStyleBackColor = true;
            // 
            // btnProduceAssessmentsReport
            // 
            this.btnProduceAssessmentsReport.Location = new System.Drawing.Point(413, 142);
            this.btnProduceAssessmentsReport.Name = "btnProduceAssessmentsReport";
            this.btnProduceAssessmentsReport.Size = new System.Drawing.Size(200, 60);
            this.btnProduceAssessmentsReport.TabIndex = 32;
            this.btnProduceAssessmentsReport.Text = "Produce Assessments Report";
            this.btnProduceAssessmentsReport.UseVisualStyleBackColor = true;
            // 
            // btnEnterResult
            // 
            this.btnEnterResult.Location = new System.Drawing.Point(304, 218);
            this.btnEnterResult.Name = "btnEnterResult";
            this.btnEnterResult.Size = new System.Drawing.Size(200, 60);
            this.btnEnterResult.TabIndex = 31;
            this.btnEnterResult.Text = "Enter Result";
            this.btnEnterResult.UseVisualStyleBackColor = true;
            // 
            // CourseAdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdateAssessment);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddAssessment);
            this.Controls.Add(this.btnProduceAssessmentsReport);
            this.Controls.Add(this.btnEnterResult);
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