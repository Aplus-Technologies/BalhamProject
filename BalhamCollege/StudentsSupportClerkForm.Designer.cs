
namespace BalhamCollege
{
    partial class StudentsSupportClerkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsSupportClerkForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnProduceIssuesReport = new System.Windows.Forms.Button();
            this.btnRecordIssue = new System.Windows.Forms.Button();
            this.pbStudentSupportClerk = new System.Windows.Forms.PictureBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.iSSUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iSSUETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ISSUETableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.eNROLMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter();
            this.printIssues = new System.Drawing.Printing.PrintDocument();
            this.prvIssues = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentSupportClerk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(31, 545);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(241, 72);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.Text = "Log Out";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnProduceIssuesReport
            // 
            this.btnProduceIssuesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnProduceIssuesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduceIssuesReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduceIssuesReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduceIssuesReport.Location = new System.Drawing.Point(31, 339);
            this.btnProduceIssuesReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduceIssuesReport.Name = "btnProduceIssuesReport";
            this.btnProduceIssuesReport.Size = new System.Drawing.Size(241, 68);
            this.btnProduceIssuesReport.TabIndex = 34;
            this.btnProduceIssuesReport.Text = "Produce Issues Report";
            this.btnProduceIssuesReport.UseVisualStyleBackColor = false;
            this.btnProduceIssuesReport.Click += new System.EventHandler(this.btnProduceIssuesReport_Click);
            // 
            // btnRecordIssue
            // 
            this.btnRecordIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnRecordIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordIssue.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecordIssue.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRecordIssue.Location = new System.Drawing.Point(31, 269);
            this.btnRecordIssue.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecordIssue.Name = "btnRecordIssue";
            this.btnRecordIssue.Size = new System.Drawing.Size(241, 66);
            this.btnRecordIssue.TabIndex = 33;
            this.btnRecordIssue.Text = "Record Issue";
            this.btnRecordIssue.UseVisualStyleBackColor = false;
            this.btnRecordIssue.Click += new System.EventHandler(this.btnRecordIssue_Click);
            // 
            // pbStudentSupportClerk
            // 
            this.pbStudentSupportClerk.Image = global::BalhamCollege.Properties.Resources.studentSupportClerkPage;
            this.pbStudentSupportClerk.Location = new System.Drawing.Point(0, -4);
            this.pbStudentSupportClerk.Name = "pbStudentSupportClerk";
            this.pbStudentSupportClerk.Size = new System.Drawing.Size(1115, 710);
            this.pbStudentSupportClerk.TabIndex = 36;
            this.pbStudentSupportClerk.TabStop = false;
            // 
            // dsBalhamCollegeAzure
            // 
            this.dsBalhamCollegeAzure.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure.EnforceConstraints = false;
            this.dsBalhamCollegeAzure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iSSUEBindingSource
            // 
            this.iSSUEBindingSource.DataMember = "ISSUE";
            this.iSSUEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // iSSUETableAdapter
            // 
            this.iSSUETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASSESSMENTTableAdapter = null;
            this.tableAdapterManager.ASSIGNMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = this.cOURSETableAdapter;
            this.tableAdapterManager.ENROLMENTTableAdapter = this.eNROLMENTTableAdapter;
            this.tableAdapterManager.ISSUETableAdapter = this.iSSUETableAdapter;
            this.tableAdapterManager.LECTURERTableAdapter = null;
            this.tableAdapterManager.PROGRAMMETableAdapter = null;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = this.sTUDENTTableAdapter;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // printIssues
            // 
            this.printIssues.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printIssues_PrintPage);
            // 
            // prvIssues
            // 
            this.prvIssues.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvIssues.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvIssues.ClientSize = new System.Drawing.Size(400, 300);
            this.prvIssues.Document = this.printIssues;
            this.prvIssues.Enabled = true;
            this.prvIssues.Icon = ((System.Drawing.Icon)(resources.GetObject("prvIssues.Icon")));
            this.prvIssues.Name = "prvIssues";
            this.prvIssues.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(31, 621);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(241, 72);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // StudentsSupportClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1111, 704);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnProduceIssuesReport);
            this.Controls.Add(this.btnRecordIssue);
            this.Controls.Add(this.pbStudentSupportClerk);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentsSupportClerkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Support Clerk Menu";
            this.Load += new System.EventHandler(this.StudentsSupportClerkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStudentSupportClerk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iSSUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnProduceIssuesReport;
        private System.Windows.Forms.Button btnRecordIssue;
        private System.Windows.Forms.PictureBox pbStudentSupportClerk;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource iSSUEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ISSUETableAdapter iSSUETableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter eNROLMENTTableAdapter;
        private System.Windows.Forms.BindingSource eNROLMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private System.Drawing.Printing.PrintDocument printIssues;
        private System.Windows.Forms.PrintPreviewDialog prvIssues;
        private System.Windows.Forms.Button btnExit;
    }
}