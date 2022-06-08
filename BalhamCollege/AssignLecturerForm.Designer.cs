﻿
namespace BalhamCollege
{
    partial class AssignLecturerForm
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
            this.components = new System.ComponentModel.Container();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.cboRole = new System.Windows.Forms.ComboBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAssignLecturer = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.lblRanking = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.lblSelectLecturer = new System.Windows.Forms.Label();
            this.lstLecturers = new System.Windows.Forms.ListBox();
            this.txtRanking = new System.Windows.Forms.TextBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.lECTURERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECTURERTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCourseName
            // 
            this.txtCourseName.Enabled = false;
            this.txtCourseName.Location = new System.Drawing.Point(489, 83);
            this.txtCourseName.MaxLength = 50;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(410, 27);
            this.txtCourseName.TabIndex = 40;
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(428, 126);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(59, 19);
            this.lblCredits.TabIndex = 36;
            this.lblCredits.Text = "Credits:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(387, 86);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(100, 19);
            this.lblCourseName.TabIndex = 35;
            this.lblCourseName.Text = "Course Name:";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Enabled = false;
            this.txtCourseID.Location = new System.Drawing.Point(489, 43);
            this.txtCourseID.MaxLength = 4;
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(37, 27);
            this.txtCourseID.TabIndex = 34;
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(411, 46);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(76, 19);
            this.lblCourseID.TabIndex = 33;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lstCourses
            // 
            this.lstCourses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 19;
            this.lstCourses.Location = new System.Drawing.Point(23, 46);
            this.lstCourses.Margin = new System.Windows.Forms.Padding(4);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(304, 118);
            this.lstCourses.TabIndex = 32;
            this.lstCourses.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstCourses_Format);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Location = new System.Drawing.Point(19, 23);
            this.lblSelectCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(158, 19);
            this.lblSelectCourse.TabIndex = 31;
            this.lblSelectCourse.Text = "Please select a course:";
            // 
            // txtCredits
            // 
            this.txtCredits.Enabled = false;
            this.txtCredits.Location = new System.Drawing.Point(489, 123);
            this.txtCredits.MaxLength = 3;
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(28, 27);
            this.txtCredits.TabIndex = 41;
            // 
            // cboRole
            // 
            this.cboRole.FormattingEnabled = true;
            this.cboRole.Items.AddRange(new object[] {
            "Primary",
            "Secondary"});
            this.cboRole.Location = new System.Drawing.Point(489, 364);
            this.cboRole.MaxLength = 9;
            this.cboRole.Name = "cboRole";
            this.cboRole.Size = new System.Drawing.Size(93, 27);
            this.cboRole.TabIndex = 62;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl9.Location = new System.Drawing.Point(432, 367);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(17, 19);
            this.lbl9.TabIndex = 75;
            this.lbl9.Text = "*";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(445, 367);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(42, 19);
            this.lblRole.TabIndex = 74;
            this.lblRole.Text = "Role:";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequiredFields.Location = new System.Drawing.Point(773, 380);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(114, 19);
            this.lblRequiredFields.TabIndex = 65;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(777, 427);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(122, 33);
            this.btnReturn.TabIndex = 64;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAssignLecturer
            // 
            this.btnAssignLecturer.Location = new System.Drawing.Point(489, 427);
            this.btnAssignLecturer.Name = "btnAssignLecturer";
            this.btnAssignLecturer.Size = new System.Drawing.Size(122, 33);
            this.btnAssignLecturer.TabIndex = 63;
            this.btnAssignLecturer.Text = "Assign Lecturer";
            this.btnAssignLecturer.UseVisualStyleBackColor = true;
            this.btnAssignLecturer.Click += new System.EventHandler(this.btnAssignLecturer_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(489, 284);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 27);
            this.txtFirstName.TabIndex = 55;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(489, 244);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 27);
            this.txtLastName.TabIndex = 54;
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Enabled = false;
            this.txtLecturerID.Location = new System.Drawing.Point(489, 204);
            this.txtLecturerID.MaxLength = 4;
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.Size = new System.Drawing.Size(37, 27);
            this.txtLecturerID.TabIndex = 53;
            // 
            // lblRanking
            // 
            this.lblRanking.AutoSize = true;
            this.lblRanking.Location = new System.Drawing.Point(422, 327);
            this.lblRanking.Name = "lblRanking";
            this.lblRanking.Size = new System.Drawing.Size(65, 19);
            this.lblRanking.TabIndex = 52;
            this.lblRanking.Text = "Ranking:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(404, 287);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 19);
            this.lblFirstName.TabIndex = 46;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(405, 247);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 19);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.Location = new System.Drawing.Point(403, 207);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(84, 19);
            this.lblLecturerID.TabIndex = 44;
            this.lblLecturerID.Text = "Lecturer ID:";
            // 
            // lblSelectLecturer
            // 
            this.lblSelectLecturer.AutoSize = true;
            this.lblSelectLecturer.Location = new System.Drawing.Point(19, 184);
            this.lblSelectLecturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectLecturer.Name = "lblSelectLecturer";
            this.lblSelectLecturer.Size = new System.Drawing.Size(165, 19);
            this.lblSelectLecturer.TabIndex = 43;
            this.lblSelectLecturer.Text = "Please select a lecturer:";
            // 
            // lstLecturers
            // 
            this.lstLecturers.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstLecturers.FormattingEnabled = true;
            this.lstLecturers.ItemHeight = 19;
            this.lstLecturers.Location = new System.Drawing.Point(23, 207);
            this.lstLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.lstLecturers.Name = "lstLecturers";
            this.lstLecturers.Size = new System.Drawing.Size(304, 194);
            this.lstLecturers.TabIndex = 42;
            this.lstLecturers.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstLecturers_Format);
            // 
            // txtRanking
            // 
            this.txtRanking.Enabled = false;
            this.txtRanking.Location = new System.Drawing.Point(489, 324);
            this.txtRanking.MaxLength = 1;
            this.txtRanking.Name = "txtRanking";
            this.txtRanking.Size = new System.Drawing.Size(18, 27);
            this.txtRanking.TabIndex = 76;
            // 
            // dsBalhamCollegeAzure
            // 
            this.dsBalhamCollegeAzure.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure.EnforceConstraints = false;
            this.dsBalhamCollegeAzure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASSESSMENTTableAdapter = null;
            this.tableAdapterManager.ASSIGNMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = this.cOURSETableAdapter;
            this.tableAdapterManager.ENROLMENTTableAdapter = null;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.LECTURERTableAdapter = this.lECTURERTableAdapter;
            this.tableAdapterManager.PROGRAMMETableAdapter = null;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lECTURERBindingSource
            // 
            this.lECTURERBindingSource.DataMember = "LECTURER";
            this.lECTURERBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // lECTURERTableAdapter
            // 
            this.lECTURERTableAdapter.ClearBeforeFill = true;
            // 
            // AssignLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 486);
            this.Controls.Add(this.txtRanking);
            this.Controls.Add(this.cboRole);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAssignLecturer);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.lblRanking);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLecturerID);
            this.Controls.Add(this.lblSelectLecturer);
            this.Controls.Add(this.lstLecturers);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.lblSelectCourse);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AssignLecturerForm";
            this.Text = "Assign Lecturer";
            this.Load += new System.EventHandler(this.AssignLecturerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.ComboBox cboRole;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAssignLecturer;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.Label lblRanking;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.Label lblSelectLecturer;
        private System.Windows.Forms.ListBox lstLecturers;
        private System.Windows.Forms.TextBox txtRanking;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter lECTURERTableAdapter;
        private System.Windows.Forms.BindingSource lECTURERBindingSource;
    }
}