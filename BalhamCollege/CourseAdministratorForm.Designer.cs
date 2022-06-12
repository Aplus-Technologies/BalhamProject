
namespace BalhamCollege
{
    partial class CourseAdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseAdministratorForm));
            this.btnUpdateAssessment = new System.Windows.Forms.Button();
            this.btnDeleteAssessment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnAddAssessment = new System.Windows.Forms.Button();
            this.btnProduceAssessmentsReport = new System.Windows.Forms.Button();
            this.btnEnterResult = new System.Windows.Forms.Button();
            this.pbCourseAdmin = new System.Windows.Forms.PictureBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.aSSESSMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.aSSESSMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter();
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.eNROLMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter();
            this.rESULTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESULTTableAdapter();
            this.sTUDENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESULTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printAssessments = new System.Drawing.Printing.PrintDocument();
            this.prvAssessments = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbCourseAdmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateAssessment
            // 
            this.btnUpdateAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateAssessment.AutoSize = true;
            this.btnUpdateAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnUpdateAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAssessment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAssessment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateAssessment.Location = new System.Drawing.Point(20, 265);
            this.btnUpdateAssessment.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Size = new System.Drawing.Size(178, 50);
            this.btnUpdateAssessment.TabIndex = 36;
            this.btnUpdateAssessment.Text = "Update Assessment";
            this.btnUpdateAssessment.UseVisualStyleBackColor = false;
            this.btnUpdateAssessment.Click += new System.EventHandler(this.btnUpdateAssessment_Click);
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnDeleteAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAssessment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAssessment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteAssessment.Location = new System.Drawing.Point(20, 319);
            this.btnDeleteAssessment.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Size = new System.Drawing.Size(178, 45);
            this.btnDeleteAssessment.TabIndex = 35;
            this.btnDeleteAssessment.Text = "Delete Assessment";
            this.btnDeleteAssessment.UseVisualStyleBackColor = false;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(20, 465);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(178, 41);
            this.btnReturn.TabIndex = 34;
            this.btnReturn.Text = "Log Out";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAssessment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnAddAssessment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAssessment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAssessment.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddAssessment.Location = new System.Drawing.Point(20, 214);
            this.btnAddAssessment.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(178, 47);
            this.btnAddAssessment.TabIndex = 33;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.UseVisualStyleBackColor = false;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click);
            // 
            // btnProduceAssessmentsReport
            // 
            this.btnProduceAssessmentsReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduceAssessmentsReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnProduceAssessmentsReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduceAssessmentsReport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduceAssessmentsReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduceAssessmentsReport.Location = new System.Drawing.Point(20, 418);
            this.btnProduceAssessmentsReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduceAssessmentsReport.Name = "btnProduceAssessmentsReport";
            this.btnProduceAssessmentsReport.Size = new System.Drawing.Size(178, 43);
            this.btnProduceAssessmentsReport.TabIndex = 32;
            this.btnProduceAssessmentsReport.Text = "Produce Assessments Report";
            this.btnProduceAssessmentsReport.UseVisualStyleBackColor = false;
            this.btnProduceAssessmentsReport.Click += new System.EventHandler(this.btnProduceAssessmentsReport_Click);
            // 
            // btnEnterResult
            // 
            this.btnEnterResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnterResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnEnterResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterResult.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterResult.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEnterResult.Location = new System.Drawing.Point(20, 368);
            this.btnEnterResult.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnterResult.Name = "btnEnterResult";
            this.btnEnterResult.Size = new System.Drawing.Size(178, 46);
            this.btnEnterResult.TabIndex = 31;
            this.btnEnterResult.Text = "Enter Result";
            this.btnEnterResult.UseVisualStyleBackColor = false;
            this.btnEnterResult.Click += new System.EventHandler(this.btnEnterResult_Click);
            // 
            // pbCourseAdmin
            // 
            this.pbCourseAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCourseAdmin.Image = global::BalhamCollege.Properties.Resources.CourseAdmin1980x1080;
            this.pbCourseAdmin.Location = new System.Drawing.Point(-6, -4);
            this.pbCourseAdmin.Name = "pbCourseAdmin";
            this.pbCourseAdmin.Size = new System.Drawing.Size(979, 576);
            this.pbCourseAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCourseAdmin.TabIndex = 37;
            this.pbCourseAdmin.TabStop = false;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASSESSMENTTableAdapter = this.aSSESSMENTTableAdapter;
            this.tableAdapterManager.ASSIGNMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = this.cOURSETableAdapter;
            this.tableAdapterManager.ENROLMENTTableAdapter = this.eNROLMENTTableAdapter;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.LECTURERTableAdapter = null;
            this.tableAdapterManager.PROGRAMMETableAdapter = null;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = this.rESULTTableAdapter;
            this.tableAdapterManager.STUDENTTableAdapter = this.sTUDENTTableAdapter;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aSSESSMENTTableAdapter
            // 
            this.aSSESSMENTTableAdapter.ClearBeforeFill = true;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // eNROLMENTTableAdapter
            // 
            this.eNROLMENTTableAdapter.ClearBeforeFill = true;
            // 
            // rESULTTableAdapter
            // 
            this.rESULTTableAdapter.ClearBeforeFill = true;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // rESULTBindingSource
            // 
            this.rESULTBindingSource.DataMember = "RESULT";
            this.rESULTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // eNROLMENTBindingSource
            // 
            this.eNROLMENTBindingSource.DataMember = "ENROLMENT";
            this.eNROLMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // printAssessments
            // 
            this.printAssessments.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printAssessments_PrintPage);
            // 
            // prvAssessments
            // 
            this.prvAssessments.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvAssessments.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvAssessments.ClientSize = new System.Drawing.Size(400, 300);
            this.prvAssessments.Document = this.printAssessments;
            this.prvAssessments.Enabled = true;
            this.prvAssessments.Icon = ((System.Drawing.Icon)(resources.GetObject("prvAssessments.Icon")));
            this.prvAssessments.Name = "prvAssessments";
            this.prvAssessments.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(20, 510);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(178, 41);
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // CourseAdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(970, 570);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdateAssessment);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddAssessment);
            this.Controls.Add(this.btnProduceAssessmentsReport);
            this.Controls.Add(this.btnEnterResult);
            this.Controls.Add(this.pbCourseAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourseAdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Course Administrator Menu";
            this.Load += new System.EventHandler(this.CourseAdministratorForm_Load);
            this.Resize += new System.EventHandler(this.CourseAdministratorForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbCourseAdmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateAssessment;
        private System.Windows.Forms.Button btnDeleteAssessment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.Button btnProduceAssessmentsReport;
        private System.Windows.Forms.Button btnEnterResult;
        private System.Windows.Forms.PictureBox pbCourseAdmin;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource aSSESSMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter eNROLMENTTableAdapter;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private System.Windows.Forms.BindingSource rESULTBindingSource;
        private System.Windows.Forms.BindingSource eNROLMENTBindingSource;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private System.Drawing.Printing.PrintDocument printAssessments;
        private System.Windows.Forms.PrintPreviewDialog prvAssessments;
        private dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter aSSESSMENTTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private dsBalhamCollegeAzureTableAdapters.RESULTTableAdapter rESULTTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.Button btnExit;
    }
}