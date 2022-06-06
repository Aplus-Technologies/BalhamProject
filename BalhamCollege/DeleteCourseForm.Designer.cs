
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
            this.components = new System.ComponentModel.Container();
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
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.aSSESSMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSESSMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter();
            this.aSSIGNMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSIGNMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSIGNMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSIGNMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 19);
            this.label1.TabIndex = 70;
            this.label1.Text = "Please select a course:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(524, 251);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(158, 39);
            this.btnReturn.TabIndex = 69;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(280, 251);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(188, 39);
            this.btnDeleteCourse.TabIndex = 68;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(412, 167);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(70, 27);
            this.txtStatus.TabIndex = 67;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(412, 136);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(44, 27);
            this.txtCredits.TabIndex = 66;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(412, 105);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(266, 27);
            this.txtCourseName.TabIndex = 65;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(412, 75);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(44, 27);
            this.txtCourseID.TabIndex = 64;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(357, 170);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(58, 19);
            this.lblStatus.TabIndex = 63;
            this.lblStatus.Text = "Status:";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(354, 139);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(64, 19);
            this.lblCredits.TabIndex = 62;
            this.lblCredits.Text = "Credits:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(308, 108);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(110, 19);
            this.lblCourseName.TabIndex = 61;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(332, 77);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(86, 19);
            this.lblCourseID.TabIndex = 60;
            this.lblCourseID.Text = "Course ID:";
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 19;
            this.lstCourses.Location = new System.Drawing.Point(50, 57);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.ScrollAlwaysVisible = true;
            this.lstCourses.Size = new System.Drawing.Size(237, 156);
            this.lstCourses.TabIndex = 59;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // dsBalhamCollegeAzure
            // 
            this.dsBalhamCollegeAzure.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure.EnforceConstraints = false;
            this.dsBalhamCollegeAzure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aSSESSMENTBindingSource
            // 
            this.aSSESSMENTBindingSource.DataMember = "ASSESSMENT";
            this.aSSESSMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // aSSESSMENTTableAdapter
            // 
            this.aSSESSMENTTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASSESSMENTTableAdapter = this.aSSESSMENTTableAdapter;
            this.tableAdapterManager.ASSIGNMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = this.cOURSETableAdapter;
            this.tableAdapterManager.ENROLMENTTableAdapter = null;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.LECTURERTableAdapter = null;
            this.tableAdapterManager.PROGRAMMETableAdapter = null;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // eNROLMENTBindingSource
            // 
            this.eNROLMENTBindingSource.DataMember = "ENROLMENT";
            this.eNROLMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // eNROLMENTTableAdapter
            // 
            this.eNROLMENTTableAdapter.ClearBeforeFill = true;
            // 
            // aSSIGNMENTBindingSource
            // 
            this.aSSIGNMENTBindingSource.DataMember = "ASSIGNMENT";
            this.aSSIGNMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // aSSIGNMENTTableAdapter
            // 
            this.aSSIGNMENTTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 341);
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
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeleteCourseForm";
            this.Text = "DeleteCourseForm";
            this.Load += new System.EventHandler(this.DeleteCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSIGNMENTBindingSource)).EndInit();
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
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource aSSESSMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter aSSESSMENTTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private System.Windows.Forms.BindingSource eNROLMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter eNROLMENTTableAdapter;
        private System.Windows.Forms.BindingSource aSSIGNMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ASSIGNMENTTableAdapter aSSIGNMENTTableAdapter;
    }
}