
namespace BalhamCollege
{
    partial class RemoveLecturerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemoveLecturer = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblFirstNAme = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.lstLecturers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtProgrammeName = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgrammeName = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.aSSIGNMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSIGNMENTTableAdapter();
            this.lECTURERTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter();
            this.pROGRAMMETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter();
            this.aSSIGNMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECTURERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROGRAMMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSIGNMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 319);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 29);
            this.label2.TabIndex = 126;
            this.label2.Text = "Please select a lecturer:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(731, 607);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(192, 61);
            this.btnReturn.TabIndex = 125;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnRemoveLecturer
            // 
            this.btnRemoveLecturer.Location = new System.Drawing.Point(314, 607);
            this.btnRemoveLecturer.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveLecturer.Name = "btnRemoveLecturer";
            this.btnRemoveLecturer.Size = new System.Drawing.Size(230, 61);
            this.btnRemoveLecturer.TabIndex = 124;
            this.btnRemoveLecturer.Text = "Remove Lecturer";
            this.btnRemoveLecturer.UseVisualStyleBackColor = true;
            this.btnRemoveLecturer.Click += new System.EventHandler(this.btnRemoveLecturer_Click);
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(475, 516);
            this.txtRole.Margin = new System.Windows.Forms.Padding(4);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(103, 35);
            this.txtRole.TabIndex = 123;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(475, 470);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(242, 35);
            this.txtFirstName.TabIndex = 122;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(475, 423);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(242, 35);
            this.txtLastName.TabIndex = 121;
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Location = new System.Drawing.Point(475, 377);
            this.txtLecturerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.Size = new System.Drawing.Size(57, 35);
            this.txtLecturerID.TabIndex = 120;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(424, 521);
            this.lblRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(58, 29);
            this.lblRole.TabIndex = 119;
            this.lblRole.Text = "Role:";
            // 
            // lblFirstNAme
            // 
            this.lblFirstNAme.AutoSize = true;
            this.lblFirstNAme.Location = new System.Drawing.Point(370, 474);
            this.lblFirstNAme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstNAme.Name = "lblFirstNAme";
            this.lblFirstNAme.Size = new System.Drawing.Size(113, 29);
            this.lblFirstNAme.TabIndex = 118;
            this.lblFirstNAme.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(370, 428);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 29);
            this.lblLastName.TabIndex = 117;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.Location = new System.Drawing.Point(367, 381);
            this.lblLecturerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(114, 29);
            this.lblLecturerID.TabIndex = 116;
            this.lblLecturerID.Text = "Lecturer ID:";
            // 
            // lstLecturers
            // 
            this.lstLecturers.FormattingEnabled = true;
            this.lstLecturers.ItemHeight = 29;
            this.lstLecturers.Location = new System.Drawing.Point(32, 349);
            this.lstLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.lstLecturers.Name = "lstLecturers";
            this.lstLecturers.Size = new System.Drawing.Size(244, 236);
            this.lstLecturers.TabIndex = 115;
            this.lstLecturers.SelectedIndexChanged += new System.EventHandler(this.lstLecturers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 114;
            this.label1.Text = "Please select a course:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(475, 181);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(85, 35);
            this.txtStatus.TabIndex = 113;
            // 
            // txtProgrammeName
            // 
            this.txtProgrammeName.Location = new System.Drawing.Point(475, 228);
            this.txtProgrammeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProgrammeName.Name = "txtProgrammeName";
            this.txtProgrammeName.Size = new System.Drawing.Size(471, 35);
            this.txtProgrammeName.TabIndex = 112;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(475, 135);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(242, 35);
            this.txtCourseName.TabIndex = 111;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(475, 88);
            this.txtCourseID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(46, 35);
            this.txtCourseID.TabIndex = 110;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(407, 186);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 29);
            this.lblStatus.TabIndex = 109;
            this.lblStatus.Text = "Status:";
            // 
            // lblProgrammeName
            // 
            this.lblProgrammeName.AutoSize = true;
            this.lblProgrammeName.Location = new System.Drawing.Point(308, 232);
            this.lblProgrammeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgrammeName.Name = "lblProgrammeName";
            this.lblProgrammeName.Size = new System.Drawing.Size(178, 29);
            this.lblProgrammeName.TabIndex = 108;
            this.lblProgrammeName.Text = "Programme Name:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(346, 139);
            this.lblCourseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(139, 29);
            this.lblCourseName.TabIndex = 107;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(376, 93);
            this.lblCourseID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(105, 29);
            this.lblCourseID.TabIndex = 106;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 29;
            this.lstCourses.Location = new System.Drawing.Point(32, 61);
            this.lstCourses.Margin = new System.Windows.Forms.Padding(4);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(244, 236);
            this.lstCourses.TabIndex = 105;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
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
            this.tableAdapterManager.ASSIGNMENTTableAdapter = this.aSSIGNMENTTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = this.cOURSETableAdapter;
            this.tableAdapterManager.ENROLMENTTableAdapter = null;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.LECTURERTableAdapter = this.lECTURERTableAdapter;
            this.tableAdapterManager.PROGRAMMETableAdapter = this.pROGRAMMETableAdapter;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aSSIGNMENTTableAdapter
            // 
            this.aSSIGNMENTTableAdapter.ClearBeforeFill = true;
            // 
            // lECTURERTableAdapter
            // 
            this.lECTURERTableAdapter.ClearBeforeFill = true;
            // 
            // pROGRAMMETableAdapter
            // 
            this.pROGRAMMETableAdapter.ClearBeforeFill = true;
            // 
            // aSSIGNMENTBindingSource
            // 
            this.aSSIGNMENTBindingSource.DataMember = "ASSIGNMENT";
            this.aSSIGNMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // lECTURERBindingSource
            // 
            this.lECTURERBindingSource.DataMember = "LECTURER";
            this.lECTURERBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // pROGRAMMEBindingSource
            // 
            this.pROGRAMMEBindingSource.DataMember = "PROGRAMME";
            this.pROGRAMMEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // RemoveLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 710);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveLecturer);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblFirstNAme);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLecturerID);
            this.Controls.Add(this.lstLecturers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtProgrammeName);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblProgrammeName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.lstCourses);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveLecturerForm";
            this.Text = "RemoveLecturerForm";
            this.Load += new System.EventHandler(this.RemoveLecturerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSIGNMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemoveLecturer;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblFirstNAme;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.ListBox lstLecturers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtProgrammeName;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProgrammeName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.ListBox lstCourses;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.ASSIGNMENTTableAdapter aSSIGNMENTTableAdapter;
        private System.Windows.Forms.BindingSource aSSIGNMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter lECTURERTableAdapter;
        private System.Windows.Forms.BindingSource lECTURERBindingSource;
        private dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter pROGRAMMETableAdapter;
        private System.Windows.Forms.BindingSource pROGRAMMEBindingSource;
    }
}