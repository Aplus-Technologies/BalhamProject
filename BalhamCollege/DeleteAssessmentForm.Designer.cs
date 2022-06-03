
namespace BalhamCollege
{
    partial class DeleteAssessmentForm
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
            this.txtAssessmentName = new System.Windows.Forms.TextBox();
            this.lblAssessmentName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteAssessment = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAssessmentNumber = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtAssessmentID = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAssessmentNumber = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblAssessmentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAssessments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtAssessmentName
            // 
            this.txtAssessmentName.Location = new System.Drawing.Point(213, 288);
            this.txtAssessmentName.Name = "txtAssessmentName";
            this.txtAssessmentName.Size = new System.Drawing.Size(244, 26);
            this.txtAssessmentName.TabIndex = 142;
            // 
            // lblAssessmentName
            // 
            this.lblAssessmentName.AutoSize = true;
            this.lblAssessmentName.Location = new System.Drawing.Point(69, 291);
            this.lblAssessmentName.Name = "lblAssessmentName";
            this.lblAssessmentName.Size = new System.Drawing.Size(147, 20);
            this.lblAssessmentName.TabIndex = 141;
            this.lblAssessmentName.Text = "Assessment Name:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(481, 424);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(157, 42);
            this.btnReturn.TabIndex = 140;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.Location = new System.Drawing.Point(34, 424);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Size = new System.Drawing.Size(188, 42);
            this.btnDeleteAssessment.TabIndex = 139;
            this.btnDeleteAssessment.Text = "Delete Assessment";
            this.btnDeleteAssessment.UseVisualStyleBackColor = true;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(213, 320);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(124, 26);
            this.txtType.TabIndex = 138;
            // 
            // txtAssessmentNumber
            // 
            this.txtAssessmentNumber.Location = new System.Drawing.Point(213, 256);
            this.txtAssessmentNumber.Name = "txtAssessmentNumber";
            this.txtAssessmentNumber.Size = new System.Drawing.Size(22, 26);
            this.txtAssessmentNumber.TabIndex = 137;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(213, 352);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(244, 26);
            this.txtCourseName.TabIndex = 136;
            // 
            // txtAssessmentID
            // 
            this.txtAssessmentID.Location = new System.Drawing.Point(213, 224);
            this.txtAssessmentID.Name = "txtAssessmentID";
            this.txtAssessmentID.Size = new System.Drawing.Size(38, 26);
            this.txtAssessmentID.TabIndex = 135;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(169, 323);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 134;
            this.lblType.Text = "Type:";
            // 
            // lblAssessmentNumber
            // 
            this.lblAssessmentNumber.AutoSize = true;
            this.lblAssessmentNumber.Location = new System.Drawing.Point(56, 259);
            this.lblAssessmentNumber.Name = "lblAssessmentNumber";
            this.lblAssessmentNumber.Size = new System.Drawing.Size(161, 20);
            this.lblAssessmentNumber.TabIndex = 133;
            this.lblAssessmentNumber.Text = "Assessment Number:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(107, 355);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(110, 20);
            this.lblCourseName.TabIndex = 132;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblAssessmentID
            // 
            this.lblAssessmentID.AutoSize = true;
            this.lblAssessmentID.Location = new System.Drawing.Point(95, 227);
            this.lblAssessmentID.Name = "lblAssessmentID";
            this.lblAssessmentID.Size = new System.Drawing.Size(122, 20);
            this.lblAssessmentID.TabIndex = 131;
            this.lblAssessmentID.Text = "Assessment ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 130;
            this.label1.Text = "Please select an assessment:";
            // 
            // lstAssessments
            // 
            this.lstAssessments.FormattingEnabled = true;
            this.lstAssessments.ItemHeight = 20;
            this.lstAssessments.Location = new System.Drawing.Point(31, 46);
            this.lstAssessments.Name = "lstAssessments";
            this.lstAssessments.Size = new System.Drawing.Size(607, 164);
            this.lstAssessments.TabIndex = 129;
            // 
            // DeleteAssessmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 505);
            this.Controls.Add(this.txtAssessmentName);
            this.Controls.Add(this.lblAssessmentName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtAssessmentNumber);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtAssessmentID);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAssessmentNumber);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblAssessmentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAssessments);
            this.Name = "DeleteAssessmentForm";
            this.Text = "DeleteAssessmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssessmentName;
        private System.Windows.Forms.Label lblAssessmentName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteAssessment;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAssessmentNumber;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtAssessmentID;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAssessmentNumber;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblAssessmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAssessments;
    }
}