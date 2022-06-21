
namespace BalhamCollege
{
    partial class DeleteAssessmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteAssessmentForm));
            this.txtAssessmentName = new System.Windows.Forms.TextBox();
            this.lblAssessmentName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteAssessment = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtAssessmentNumber = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtAssessmentID = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAssessmentNumber = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblAssessmentID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstAssessments = new System.Windows.Forms.ListBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.aSSESSMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSESSMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.rESULTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESULTTableAdapter();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESULTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAssessmentName
            // 
            this.txtAssessmentName.Location = new System.Drawing.Point(150, 258);
            this.txtAssessmentName.MaxLength = 50;
            this.txtAssessmentName.Name = "txtAssessmentName";
            this.txtAssessmentName.ReadOnly = true;
            this.txtAssessmentName.Size = new System.Drawing.Size(323, 26);
            this.txtAssessmentName.TabIndex = 4;
            // 
            // lblAssessmentName
            // 
            this.lblAssessmentName.AutoSize = true;
            this.lblAssessmentName.Location = new System.Drawing.Point(27, 261);
            this.lblAssessmentName.Name = "lblAssessmentName";
            this.lblAssessmentName.Size = new System.Drawing.Size(126, 20);
            this.lblAssessmentName.TabIndex = 141;
            this.lblAssessmentName.Text = "Assessment Name:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.Location = new System.Drawing.Point(339, 387);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 40);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteAssessment
            // 
            this.btnDeleteAssessment.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDeleteAssessment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteAssessment.Location = new System.Drawing.Point(19, 387);
            this.btnDeleteAssessment.Name = "btnDeleteAssessment";
            this.btnDeleteAssessment.Size = new System.Drawing.Size(159, 40);
            this.btnDeleteAssessment.TabIndex = 7;
            this.btnDeleteAssessment.Text = "Delete Assessment";
            this.btnDeleteAssessment.UseVisualStyleBackColor = false;
            this.btnDeleteAssessment.Click += new System.EventHandler(this.btnDeleteAssessment_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(150, 294);
            this.txtType.MaxLength = 14;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(106, 26);
            this.txtType.TabIndex = 5;
            // 
            // txtAssessmentNumber
            // 
            this.txtAssessmentNumber.Location = new System.Drawing.Point(150, 223);
            this.txtAssessmentNumber.MaxLength = 1;
            this.txtAssessmentNumber.Name = "txtAssessmentNumber";
            this.txtAssessmentNumber.ReadOnly = true;
            this.txtAssessmentNumber.Size = new System.Drawing.Size(19, 26);
            this.txtAssessmentNumber.TabIndex = 3;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(150, 330);
            this.txtCourseName.MaxLength = 50;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(323, 26);
            this.txtCourseName.TabIndex = 6;
            // 
            // txtAssessmentID
            // 
            this.txtAssessmentID.Location = new System.Drawing.Point(150, 188);
            this.txtAssessmentID.MaxLength = 3;
            this.txtAssessmentID.Name = "txtAssessmentID";
            this.txtAssessmentID.ReadOnly = true;
            this.txtAssessmentID.Size = new System.Drawing.Size(33, 26);
            this.txtAssessmentID.TabIndex = 2;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(110, 297);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 134;
            this.lblType.Text = "Type:";
            // 
            // lblAssessmentNumber
            // 
            this.lblAssessmentNumber.AutoSize = true;
            this.lblAssessmentNumber.Location = new System.Drawing.Point(15, 226);
            this.lblAssessmentNumber.Name = "lblAssessmentNumber";
            this.lblAssessmentNumber.Size = new System.Drawing.Size(138, 20);
            this.lblAssessmentNumber.TabIndex = 133;
            this.lblAssessmentNumber.Text = "Assessment Number:";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(58, 333);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(95, 20);
            this.lblCourseName.TabIndex = 132;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblAssessmentID
            // 
            this.lblAssessmentID.AutoSize = true;
            this.lblAssessmentID.Location = new System.Drawing.Point(51, 191);
            this.lblAssessmentID.Name = "lblAssessmentID";
            this.lblAssessmentID.Size = new System.Drawing.Size(103, 20);
            this.lblAssessmentID.TabIndex = 131;
            this.lblAssessmentID.Text = "Assessment ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 130;
            this.label1.Text = "Please select an assessment:";
            // 
            // lstAssessments
            // 
            this.lstAssessments.FormattingEnabled = true;
            this.lstAssessments.ItemHeight = 20;
            this.lstAssessments.Location = new System.Drawing.Point(19, 52);
            this.lstAssessments.Name = "lstAssessments";
            this.lstAssessments.ScrollAlwaysVisible = true;
            this.lstAssessments.Size = new System.Drawing.Size(454, 104);
            this.lstAssessments.TabIndex = 1;
            this.lstAssessments.SelectedIndexChanged += new System.EventHandler(this.lstAssessments_SelectedIndexChanged);
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
            this.tableAdapterManager.RESULTTableAdapter = this.rESULTTableAdapter;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // rESULTTableAdapter
            // 
            this.rESULTTableAdapter.ClearBeforeFill = true;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(430, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 80);
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeleteAssessmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(494, 448);
            this.ControlBox = false;
            this.Controls.Add(this.txtAssessmentName);
            this.Controls.Add(this.lblAssessmentName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteAssessment);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtAssessmentNumber);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtAssessmentID);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAssessmentNumber);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblAssessmentID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstAssessments);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteAssessmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Assessment";
            this.Load += new System.EventHandler(this.DeleteAssessmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAssessmentName;
        private System.Windows.Forms.Label lblAssessmentName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteAssessment;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtAssessmentNumber;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtAssessmentID;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAssessmentNumber;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblAssessmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstAssessments;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource aSSESSMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter aSSESSMENTTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.RESULTTableAdapter rESULTTableAdapter;
        private System.Windows.Forms.BindingSource rESULTBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}