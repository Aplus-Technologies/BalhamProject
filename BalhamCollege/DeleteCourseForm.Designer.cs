
namespace BalhamCollege
{
    partial class DeleteCourseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 70;
            this.label1.Text = "Please select a course:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(523, 264);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(157, 42);
            this.btnReturn.TabIndex = 69;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(281, 264);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(188, 42);
            this.btnDeleteCourse.TabIndex = 68;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(413, 175);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(70, 26);
            this.txtStatus.TabIndex = 67;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(413, 143);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(30, 26);
            this.txtCredits.TabIndex = 66;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(413, 111);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(267, 26);
            this.txtCourseName.TabIndex = 65;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(413, 79);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(38, 26);
            this.txtCourseID.TabIndex = 64;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(357, 178);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(60, 20);
            this.lblStatus.TabIndex = 63;
            this.lblStatus.Text = "Status:";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(354, 146);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(63, 20);
            this.lblCredits.TabIndex = 62;
            this.lblCredits.Text = "Credits:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(307, 114);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(110, 20);
            this.lblCourseName.TabIndex = 61;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(332, 82);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(85, 20);
            this.lblCourseID.TabIndex = 60;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 20;
            this.lstCourses.Location = new System.Drawing.Point(50, 60);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(200, 164);
            this.lstCourses.TabIndex = 59;
            // 
            // DeleteCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 359);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lstCourses);
            this.Name = "DeleteCourseForm";
            this.Text = "DeleteCourseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.ListBox lstCourses;
    }
}