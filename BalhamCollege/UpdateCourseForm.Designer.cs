﻿
namespace BalhamCollege
{
    partial class UpdateCourseForm
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
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblProgrammeName = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.nudCredits = new System.Windows.Forms.NumericUpDown();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.nudFee = new System.Windows.Forms.NumericUpDown();
            this.txtProgrammeName = new System.Windows.Forms.TextBox();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Location = new System.Drawing.Point(13, 22);
            this.lblSelectCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(158, 19);
            this.lblSelectCourse.TabIndex = 3;
            this.lblSelectCourse.Text = "Please select a course:";
            // 
            // lstCourses
            // 
            this.lstCourses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 19;
            this.lstCourses.Location = new System.Drawing.Point(17, 45);
            this.lstCourses.Margin = new System.Windows.Forms.Padding(4);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(304, 232);
            this.lstCourses.TabIndex = 4;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            this.lstCourses.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstCourses_Format);
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(405, 45);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(76, 19);
            this.lblCourseID.TabIndex = 5;
            this.lblCourseID.Text = "Course ID:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Enabled = false;
            this.txtCourseID.Location = new System.Drawing.Point(483, 42);
            this.txtCourseID.MaxLength = 4;
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(37, 27);
            this.txtCourseID.TabIndex = 13;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(381, 85);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(100, 19);
            this.lblCourseName.TabIndex = 14;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(422, 125);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(59, 19);
            this.lblCredits.TabIndex = 15;
            this.lblCredits.Text = "Credits:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(428, 165);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(445, 205);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(36, 19);
            this.lblFee.TabIndex = 17;
            this.lblFee.Text = "Fee:";
            // 
            // lblProgrammeName
            // 
            this.lblProgrammeName.AutoSize = true;
            this.lblProgrammeName.Location = new System.Drawing.Point(352, 245);
            this.lblProgrammeName.Name = "lblProgrammeName";
            this.lblProgrammeName.Size = new System.Drawing.Size(129, 19);
            this.lblProgrammeName.TabIndex = 18;
            this.lblProgrammeName.Text = "Programme Name:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(483, 82);
            this.txtCourseName.MaxLength = 50;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(410, 27);
            this.txtCourseName.TabIndex = 19;
            // 
            // nudCredits
            // 
            this.nudCredits.Location = new System.Drawing.Point(483, 122);
            this.nudCredits.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudCredits.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCredits.Name = "nudCredits";
            this.nudCredits.Size = new System.Drawing.Size(49, 27);
            this.nudCredits.TabIndex = 20;
            this.nudCredits.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Current",
            "Suspended"});
            this.cboStatus.Location = new System.Drawing.Point(483, 162);
            this.cboStatus.MaxLength = 9;
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(97, 27);
            this.cboStatus.TabIndex = 21;
            this.cboStatus.Text = "Current";
            // 
            // nudFee
            // 
            this.nudFee.DecimalPlaces = 2;
            this.nudFee.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudFee.Location = new System.Drawing.Point(483, 202);
            this.nudFee.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.nudFee.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudFee.Name = "nudFee";
            this.nudFee.Size = new System.Drawing.Size(77, 27);
            this.nudFee.TabIndex = 22;
            this.nudFee.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // txtProgrammeName
            // 
            this.txtProgrammeName.Enabled = false;
            this.txtProgrammeName.Location = new System.Drawing.Point(483, 242);
            this.txtProgrammeName.MaxLength = 50;
            this.txtProgrammeName.Name = "txtProgrammeName";
            this.txtProgrammeName.Size = new System.Drawing.Size(410, 27);
            this.txtProgrammeName.TabIndex = 23;
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Location = new System.Drawing.Point(483, 307);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(122, 33);
            this.btnUpdateCourse.TabIndex = 24;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = true;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(771, 307);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(122, 33);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequiredFields.Location = new System.Drawing.Point(767, 275);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(114, 19);
            this.lblRequiredFields.TabIndex = 26;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl1.Location = new System.Drawing.Point(368, 85);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(17, 19);
            this.lbl1.TabIndex = 27;
            this.lbl1.Text = "*";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl2.Location = new System.Drawing.Point(409, 125);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(17, 19);
            this.lbl2.TabIndex = 28;
            this.lbl2.Text = "*";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl3.Location = new System.Drawing.Point(415, 165);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(17, 19);
            this.lbl3.TabIndex = 29;
            this.lbl3.Text = "*";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl4.Location = new System.Drawing.Point(432, 205);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(17, 19);
            this.lbl4.TabIndex = 30;
            this.lbl4.Text = "*";
            // 
            // UpdateCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 365);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.txtProgrammeName);
            this.Controls.Add(this.nudFee);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.nudCredits);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblProgrammeName);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.lblSelectCourse);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateCourseForm";
            this.Text = "Update Course";
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblProgrammeName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.NumericUpDown nudCredits;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.NumericUpDown nudFee;
        private System.Windows.Forms.TextBox txtProgrammeName;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
    }
}