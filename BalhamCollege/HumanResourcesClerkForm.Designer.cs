
namespace BalhamCollege
{
    partial class HumanResourcesClerkForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLecturerReport = new System.Windows.Forms.Button();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.btnUpdateLecturer = new System.Windows.Forms.Button();
            this.btnDeleteLecturer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(309, 306);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 56);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnLecturerReport
            // 
            this.btnLecturerReport.Location = new System.Drawing.Point(442, 89);
            this.btnLecturerReport.Name = "btnLecturerReport";
            this.btnLecturerReport.Size = new System.Drawing.Size(200, 60);
            this.btnLecturerReport.TabIndex = 17;
            this.btnLecturerReport.Text = "Produce Students Report";
            this.btnLecturerReport.UseVisualStyleBackColor = true;
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.Location = new System.Drawing.Point(159, 89);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(200, 60);
            this.btnAddLecturer.TabIndex = 16;
            this.btnAddLecturer.Text = "Add Lecturer";
            this.btnAddLecturer.UseVisualStyleBackColor = true;
            // 
            // btnUpdateLecturer
            // 
            this.btnUpdateLecturer.Location = new System.Drawing.Point(159, 160);
            this.btnUpdateLecturer.Name = "btnUpdateLecturer";
            this.btnUpdateLecturer.Size = new System.Drawing.Size(200, 60);
            this.btnUpdateLecturer.TabIndex = 15;
            this.btnUpdateLecturer.Text = "Update Lecturer";
            this.btnUpdateLecturer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteLecturer
            // 
            this.btnDeleteLecturer.Location = new System.Drawing.Point(442, 160);
            this.btnDeleteLecturer.Name = "btnDeleteLecturer";
            this.btnDeleteLecturer.Size = new System.Drawing.Size(200, 60);
            this.btnDeleteLecturer.TabIndex = 14;
            this.btnDeleteLecturer.Text = "Delete Lecturer";
            this.btnDeleteLecturer.UseVisualStyleBackColor = true;
            // 
            // HumanResourcesClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLecturerReport);
            this.Controls.Add(this.btnAddLecturer);
            this.Controls.Add(this.btnUpdateLecturer);
            this.Controls.Add(this.btnDeleteLecturer);
            this.Name = "HumanResourcesClerkForm";
            this.Text = "HumanResourcesClerkForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLecturerReport;
        private System.Windows.Forms.Button btnAddLecturer;
        private System.Windows.Forms.Button btnUpdateLecturer;
        private System.Windows.Forms.Button btnDeleteLecturer;
    }
}