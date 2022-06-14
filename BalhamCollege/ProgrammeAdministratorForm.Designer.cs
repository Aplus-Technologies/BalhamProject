
namespace BalhamCollege
{
    partial class ProgrammeAdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgrammeAdministratorForm));
            this.btnUpdateProgramme = new System.Windows.Forms.Button();
            this.btnDeleteProgramme = new System.Windows.Forms.Button();
            this.btnAssignLecturer = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateCourse = new System.Windows.Forms.Button();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.btnAddProgramme = new System.Windows.Forms.Button();
            this.btnProduceCoursesReport = new System.Windows.Forms.Button();
            this.btnRemoveLecturer = new System.Windows.Forms.Button();
            this.pbProgrammeAdmin = new System.Windows.Forms.PictureBox();
            this.printCourses = new System.Drawing.Printing.PrintDocument();
            this.prvCourses = new System.Windows.Forms.PrintPreviewDialog();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.aSSESSMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter();
            this.eNROLMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter();
            this.pROGRAMMETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter();
            this.pROGRAMMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSESSMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgrammeAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateProgramme
            // 
            this.btnUpdateProgramme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProgramme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnUpdateProgramme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProgramme.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProgramme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateProgramme.Location = new System.Drawing.Point(30, 311);
            this.btnUpdateProgramme.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateProgramme.Name = "btnUpdateProgramme";
            this.btnUpdateProgramme.Size = new System.Drawing.Size(185, 31);
            this.btnUpdateProgramme.TabIndex = 4;
            this.btnUpdateProgramme.Text = "Update Programme";
            this.btnUpdateProgramme.UseVisualStyleBackColor = false;
            this.btnUpdateProgramme.Click += new System.EventHandler(this.btnUpdateProgramme_Click);
            // 
            // btnDeleteProgramme
            // 
            this.btnDeleteProgramme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProgramme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnDeleteProgramme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteProgramme.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProgramme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProgramme.Location = new System.Drawing.Point(30, 344);
            this.btnDeleteProgramme.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteProgramme.Name = "btnDeleteProgramme";
            this.btnDeleteProgramme.Size = new System.Drawing.Size(185, 31);
            this.btnDeleteProgramme.TabIndex = 5;
            this.btnDeleteProgramme.Text = "Delete Programme";
            this.btnDeleteProgramme.UseVisualStyleBackColor = false;
            this.btnDeleteProgramme.Click += new System.EventHandler(this.btnDeleteProgramme_Click);
            // 
            // btnAssignLecturer
            // 
            this.btnAssignLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssignLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnAssignLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignLecturer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignLecturer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAssignLecturer.Location = new System.Drawing.Point(30, 377);
            this.btnAssignLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAssignLecturer.Name = "btnAssignLecturer";
            this.btnAssignLecturer.Size = new System.Drawing.Size(185, 31);
            this.btnAssignLecturer.TabIndex = 6;
            this.btnAssignLecturer.Text = "Assign Lecturer";
            this.btnAssignLecturer.UseVisualStyleBackColor = false;
            this.btnAssignLecturer.Click += new System.EventHandler(this.btnAssignLecturer_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(30, 476);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(185, 31);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Log Out";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateCourse
            // 
            this.btnUpdateCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnUpdateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCourse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCourse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateCourse.Location = new System.Drawing.Point(30, 212);
            this.btnUpdateCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCourse.Name = "btnUpdateCourse";
            this.btnUpdateCourse.Size = new System.Drawing.Size(185, 31);
            this.btnUpdateCourse.TabIndex = 1;
            this.btnUpdateCourse.Text = "Update Course";
            this.btnUpdateCourse.UseVisualStyleBackColor = false;
            this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCourse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddCourse.Location = new System.Drawing.Point(30, 179);
            this.btnAddCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(185, 31);
            this.btnAddCourse.TabIndex = 0;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnDeleteCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCourse.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCourse.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCourse.Location = new System.Drawing.Point(30, 245);
            this.btnDeleteCourse.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(185, 31);
            this.btnDeleteCourse.TabIndex = 2;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = false;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // btnAddProgramme
            // 
            this.btnAddProgramme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProgramme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnAddProgramme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProgramme.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProgramme.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddProgramme.Location = new System.Drawing.Point(30, 278);
            this.btnAddProgramme.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProgramme.Name = "btnAddProgramme";
            this.btnAddProgramme.Size = new System.Drawing.Size(185, 31);
            this.btnAddProgramme.TabIndex = 3;
            this.btnAddProgramme.Text = "Add Programme";
            this.btnAddProgramme.UseVisualStyleBackColor = false;
            this.btnAddProgramme.Click += new System.EventHandler(this.btnAddProgramme_Click);
            // 
            // btnProduceCoursesReport
            // 
            this.btnProduceCoursesReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduceCoursesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnProduceCoursesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduceCoursesReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduceCoursesReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduceCoursesReport.Location = new System.Drawing.Point(30, 443);
            this.btnProduceCoursesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduceCoursesReport.Name = "btnProduceCoursesReport";
            this.btnProduceCoursesReport.Size = new System.Drawing.Size(185, 31);
            this.btnProduceCoursesReport.TabIndex = 8;
            this.btnProduceCoursesReport.Text = "Produce Courses Report";
            this.btnProduceCoursesReport.UseVisualStyleBackColor = false;
            this.btnProduceCoursesReport.Click += new System.EventHandler(this.btnProduceCoursesReport_Click);
            // 
            // btnRemoveLecturer
            // 
            this.btnRemoveLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnRemoveLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveLecturer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveLecturer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveLecturer.Location = new System.Drawing.Point(30, 410);
            this.btnRemoveLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveLecturer.Name = "btnRemoveLecturer";
            this.btnRemoveLecturer.Size = new System.Drawing.Size(185, 31);
            this.btnRemoveLecturer.TabIndex = 7;
            this.btnRemoveLecturer.Text = "Remove Lecturer";
            this.btnRemoveLecturer.UseVisualStyleBackColor = false;
            this.btnRemoveLecturer.Click += new System.EventHandler(this.btnRemoveLecturer_Click);
            // 
            // pbProgrammeAdmin
            // 
            this.pbProgrammeAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbProgrammeAdmin.Image = global::BalhamCollege.Properties.Resources.ProgrammeAdmin1980x1080v3;
            this.pbProgrammeAdmin.Location = new System.Drawing.Point(-3, -8);
            this.pbProgrammeAdmin.Name = "pbProgrammeAdmin";
            this.pbProgrammeAdmin.Size = new System.Drawing.Size(979, 576);
            this.pbProgrammeAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProgrammeAdmin.TabIndex = 34;
            this.pbProgrammeAdmin.TabStop = false;
            // 
            // printCourses
            // 
            this.printCourses.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printCourses_PrintPage);
            // 
            // prvCourses
            // 
            this.prvCourses.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvCourses.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvCourses.ClientSize = new System.Drawing.Size(400, 300);
            this.prvCourses.Document = this.printCourses;
            this.prvCourses.Enabled = true;
            this.prvCourses.Icon = ((System.Drawing.Icon)(resources.GetObject("prvCourses.Icon")));
            this.prvCourses.Name = "prvCourses";
            this.prvCourses.Visible = false;
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
            this.tableAdapterManager.ASSESSMENTTableAdapter = this.aSSESSMENTTableAdapter;
            this.tableAdapterManager.ASSIGNMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = this.cOURSETableAdapter;
            this.tableAdapterManager.ENROLMENTTableAdapter = this.eNROLMENTTableAdapter;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.LECTURERTableAdapter = null;
            this.tableAdapterManager.PROGRAMMETableAdapter = this.pROGRAMMETableAdapter;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aSSESSMENTTableAdapter
            // 
            this.aSSESSMENTTableAdapter.ClearBeforeFill = true;
            // 
            // eNROLMENTTableAdapter
            // 
            this.eNROLMENTTableAdapter.ClearBeforeFill = true;
            // 
            // pROGRAMMETableAdapter
            // 
            this.pROGRAMMETableAdapter.ClearBeforeFill = true;
            // 
            // pROGRAMMEBindingSource
            // 
            this.pROGRAMMEBindingSource.DataMember = "PROGRAMME";
            this.pROGRAMMEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // eNROLMENTBindingSource
            // 
            this.eNROLMENTBindingSource.DataMember = "ENROLMENT";
            this.eNROLMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // aSSESSMENTBindingSource
            // 
            this.aSSESSMENTBindingSource.DataMember = "ASSESSMENT";
            this.aSSESSMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(30, 510);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ProgrammeAdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(970, 560);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateProgramme);
            this.Controls.Add(this.btnDeleteProgramme);
            this.Controls.Add(this.btnAssignLecturer);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnAddProgramme);
            this.Controls.Add(this.btnProduceCoursesReport);
            this.Controls.Add(this.btnRemoveLecturer);
            this.Controls.Add(this.pbProgrammeAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProgrammeAdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programme Administrator Menu";
            this.Load += new System.EventHandler(this.ProgrammeAdministratorForm_Load);
            this.Resize += new System.EventHandler(this.ProgrammeAdministratorForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbProgrammeAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateProgramme;
        private System.Windows.Forms.Button btnDeleteProgramme;
        private System.Windows.Forms.Button btnAssignLecturer;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Button btnAddProgramme;
        private System.Windows.Forms.Button btnProduceCoursesReport;
        private System.Windows.Forms.Button btnRemoveLecturer;
        private System.Windows.Forms.PictureBox pbProgrammeAdmin;
        private System.Drawing.Printing.PrintDocument printCourses;
        private System.Windows.Forms.PrintPreviewDialog prvCourses;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter pROGRAMMETableAdapter;
        private System.Windows.Forms.BindingSource pROGRAMMEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter eNROLMENTTableAdapter;
        private System.Windows.Forms.BindingSource eNROLMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter aSSESSMENTTableAdapter;
        private System.Windows.Forms.BindingSource aSSESSMENTBindingSource;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
    }
}