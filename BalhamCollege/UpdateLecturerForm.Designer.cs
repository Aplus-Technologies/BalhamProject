﻿
namespace BalhamCollege
{
    partial class UpdateLecturerForm
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
            this.lstLecturers = new System.Windows.Forms.ListBox();
            this.lblSelectLecturer = new System.Windows.Forms.Label();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.lblRanking = new System.Windows.Forms.Label();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.cboRanking = new System.Windows.Forms.ComboBox();
            this.btnUpdateLecturer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstLecturers
            // 
            this.lstLecturers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLecturers.FormattingEnabled = true;
            this.lstLecturers.ItemHeight = 19;
            this.lstLecturers.Location = new System.Drawing.Point(17, 45);
            this.lstLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.lstLecturers.Name = "lstLecturers";
            this.lstLecturers.Size = new System.Drawing.Size(304, 346);
            this.lstLecturers.TabIndex = 1;
            this.lstLecturers.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstLecturers_Format);
            // 
            // lblSelectLecturer
            // 
            this.lblSelectLecturer.AutoSize = true;
            this.lblSelectLecturer.Location = new System.Drawing.Point(13, 22);
            this.lblSelectLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectLecturer.Name = "lblSelectLecturer";
            this.lblSelectLecturer.Size = new System.Drawing.Size(165, 19);
            this.lblSelectLecturer.TabIndex = 2;
            this.lblSelectLecturer.Text = "Please select a lecturer:";
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.Location = new System.Drawing.Point(397, 45);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(84, 19);
            this.lblLecturerID.TabIndex = 3;
            this.lblLecturerID.Text = "Lecturer ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(399, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(398, 125);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 5;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(374, 165);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(107, 19);
            this.lblStreetAddress.TabIndex = 6;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(424, 205);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(57, 19);
            this.lblSuburb.TabIndex = 7;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(443, 245);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 19);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(373, 285);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(108, 19);
            this.lblPhoneNumber.TabIndex = 9;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(376, 325);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(105, 19);
            this.lblEmailAddress.TabIndex = 10;
            this.lblEmailAddress.Text = "Email Address:";
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Location = new System.Drawing.Point(416, 365);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(65, 19);
            this.lblRanking.TabIndex = 11;
            this.lblRanking.Text = "Ranking:";
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Enabled = false;
            this.txtLecturerID.Location = new System.Drawing.Point(483, 42);
            this.txtLecturerID.MaxLength = 4;
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.Size = new System.Drawing.Size(37, 27);
            this.txtLecturerID.TabIndex = 12;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(483, 82);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 27);
            this.txtLastName.TabIndex = 13;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(483, 122);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 27);
            this.txtFirstName.TabIndex = 14;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(483, 162);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(410, 27);
            this.txtStreetAddress.TabIndex = 15;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(483, 202);
            this.txtSuburb.MaxLength = 30;
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(250, 27);
            this.txtSuburb.TabIndex = 16;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(483, 242);
            this.txtCity.MaxLength = 30;
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(250, 27);
            this.txtCity.TabIndex = 17;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(483, 282);
            this.txtPhoneNumber.MaxLength = 16;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(140, 27);
            this.txtPhoneNumber.TabIndex = 18;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(483, 322);
            this.txtEmailAddress.MaxLength = 50;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(410, 27);
            this.txtEmailAddress.TabIndex = 19;
            // 
            // cboRanking
            // 
            this.cboRanking.FormattingEnabled = true;
            this.cboRanking.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboRanking.Location = new System.Drawing.Point(483, 362);
            this.cboRanking.MaxLength = 1;
            this.cboRanking.Name = "cboRanking";
            this.cboRanking.Size = new System.Drawing.Size(36, 27);
            this.cboRanking.TabIndex = 20;
            // 
            // btnUpdateLecturer
            // 
            this.btnUpdateLecturer.Location = new System.Drawing.Point(483, 465);
            this.btnUpdateLecturer.Name = "btnUpdateLecturer";
            this.btnUpdateLecturer.Size = new System.Drawing.Size(122, 33);
            this.btnUpdateLecturer.TabIndex = 22;
            this.btnUpdateLecturer.Text = "Update Lecturer";
            this.btnUpdateLecturer.UseVisualStyleBackColor = true;
            this.btnUpdateLecturer.Click += new System.EventHandler(this.btnUpdateLecturer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(771, 465);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(122, 33);
            this.btnReturn.TabIndex = 23;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequiredFields.Location = new System.Drawing.Point(767, 418);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(114, 19);
            this.lblRequiredFields.TabIndex = 23;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl1.Location = new System.Drawing.Point(386, 85);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(17, 19);
            this.lbl1.TabIndex = 24;
            this.lbl1.Text = "*";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl2.Location = new System.Drawing.Point(385, 125);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(17, 19);
            this.lbl2.TabIndex = 25;
            this.lbl2.Text = "*";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl3.Location = new System.Drawing.Point(361, 165);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(17, 19);
            this.lbl3.TabIndex = 26;
            this.lbl3.Text = "*";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl4.Location = new System.Drawing.Point(411, 205);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(17, 19);
            this.lbl4.TabIndex = 27;
            this.lbl4.Text = "*";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl5.Location = new System.Drawing.Point(430, 245);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(17, 19);
            this.lbl5.TabIndex = 28;
            this.lbl5.Text = "*";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl6.Location = new System.Drawing.Point(360, 285);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(17, 19);
            this.lbl6.TabIndex = 29;
            this.lbl6.Text = "*";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl7.Location = new System.Drawing.Point(363, 325);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(17, 19);
            this.lbl7.TabIndex = 30;
            this.lbl7.Text = "*";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl8.Location = new System.Drawing.Point(403, 365);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(17, 19);
            this.lbl8.TabIndex = 31;
            this.lbl8.Text = "*";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(438, 405);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 19);
            this.lblType.TabIndex = 32;
            this.lblType.Text = "Type:";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl9.Location = new System.Drawing.Point(425, 405);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(17, 19);
            this.lbl9.TabIndex = 33;
            this.lbl9.Text = "*";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Academic",
            "Contract"});
            this.cboType.Location = new System.Drawing.Point(483, 402);
            this.cboType.MaxLength = 8;
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(86, 27);
            this.cboType.TabIndex = 21;
            // 
            // UpdateLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 524);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateLecturer);
            this.Controls.Add(this.cboRanking);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLecturerID);
            this.Controls.Add(this.lblSelectLecturer);
            this.Controls.Add(this.lstLecturers);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateLecturerForm";
            this.Text = "Update Lecturer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstLecturers;
        private System.Windows.Forms.Label lblSelectLecturer;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.ComboBox cboRanking;
        private System.Windows.Forms.Button btnUpdateLecturer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.ComboBox cboType;
    }
}