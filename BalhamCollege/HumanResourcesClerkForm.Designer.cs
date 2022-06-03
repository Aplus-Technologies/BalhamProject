
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanResourcesClerkForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLecturerReport = new System.Windows.Forms.Button();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.btnUpdateLecturer = new System.Windows.Forms.Button();
            this.btnDeleteLecturer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(232, 249);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 46);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLecturerReport
            // 
            this.btnLecturerReport.Location = new System.Drawing.Point(332, 72);
            this.btnLecturerReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLecturerReport.Name = "btnLecturerReport";
            this.btnLecturerReport.Size = new System.Drawing.Size(150, 49);
            this.btnLecturerReport.TabIndex = 17;
            this.btnLecturerReport.Text = "Produce Students Report";
            this.btnLecturerReport.UseVisualStyleBackColor = true;
            this.btnLecturerReport.Click += new System.EventHandler(this.btnLecturerReport_Click);
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.Location = new System.Drawing.Point(119, 72);
            this.btnAddLecturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(150, 49);
            this.btnAddLecturer.TabIndex = 16;
            this.btnAddLecturer.Text = "Add Lecturer";
            this.btnAddLecturer.UseVisualStyleBackColor = true;
            this.btnAddLecturer.Click += new System.EventHandler(this.btnAddLecturer_Click);
            // 
            // btnUpdateLecturer
            // 
            this.btnUpdateLecturer.Location = new System.Drawing.Point(119, 130);
            this.btnUpdateLecturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateLecturer.Name = "btnUpdateLecturer";
            this.btnUpdateLecturer.Size = new System.Drawing.Size(150, 49);
            this.btnUpdateLecturer.TabIndex = 15;
            this.btnUpdateLecturer.Text = "Update Lecturer";
            this.btnUpdateLecturer.UseVisualStyleBackColor = true;
            this.btnUpdateLecturer.Click += new System.EventHandler(this.btnUpdateLecturer_Click);
            // 
            // btnDeleteLecturer
            // 
            this.btnDeleteLecturer.Location = new System.Drawing.Point(332, 130);
            this.btnDeleteLecturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteLecturer.Name = "btnDeleteLecturer";
            this.btnDeleteLecturer.Size = new System.Drawing.Size(150, 49);
            this.btnDeleteLecturer.TabIndex = 14;
            this.btnDeleteLecturer.Text = "Delete Lecturer";
            this.btnDeleteLecturer.UseVisualStyleBackColor = true;
            this.btnDeleteLecturer.Click += new System.EventHandler(this.btnDeleteLecturer_Click);
            // 
            // HumanResourcesClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLecturerReport);
            this.Controls.Add(this.btnAddLecturer);
            this.Controls.Add(this.btnUpdateLecturer);
            this.Controls.Add(this.btnDeleteLecturer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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