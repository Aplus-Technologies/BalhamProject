
namespace BalhamCollege
{
    partial class UpdateAssessmentForm
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
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateAssessment = new System.Windows.Forms.Button();
            this.txtAssessmentID = new System.Windows.Forms.TextBox();
            this.lblMaximumMark = new System.Windows.Forms.Label();
            this.lblWeighting = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAssessmentName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAssessmentID = new System.Windows.Forms.Label();
            this.lblAssessments = new System.Windows.Forms.Label();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.nudMaximumMark = new System.Windows.Forms.NumericUpDown();
            this.nudWeighting = new System.Windows.Forms.NumericUpDown();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtAssessmentName = new System.Windows.Forms.TextBox();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.cboAssessments = new System.Windows.Forms.ComboBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.aSSESSMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSESSMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeighting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(58, 303);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(100, 19);
            this.lblCourseName.TabIndex = 64;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl8.Location = new System.Drawing.Point(31, 263);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(17, 19);
            this.lbl8.TabIndex = 63;
            this.lbl8.Text = "*";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl7.Location = new System.Drawing.Point(66, 223);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(17, 19);
            this.lbl7.TabIndex = 62;
            this.lbl7.Text = "*";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl6.Location = new System.Drawing.Point(102, 183);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(17, 19);
            this.lbl6.TabIndex = 61;
            this.lbl6.Text = "*";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl5.Location = new System.Drawing.Point(12, 143);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(17, 19);
            this.lbl5.TabIndex = 60;
            this.lbl5.Text = "*";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl4.Location = new System.Drawing.Point(81, 103);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(17, 19);
            this.lbl4.TabIndex = 59;
            this.lbl4.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequiredFields.Location = new System.Drawing.Point(444, 336);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(114, 19);
            this.lblRequiredFields.TabIndex = 55;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(423, 363);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 33);
            this.btnReturn.TabIndex = 54;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateAssessment
            // 
            this.btnUpdateAssessment.Location = new System.Drawing.Point(160, 363);
            this.btnUpdateAssessment.Name = "btnUpdateAssessment";
            this.btnUpdateAssessment.Size = new System.Drawing.Size(147, 33);
            this.btnUpdateAssessment.TabIndex = 53;
            this.btnUpdateAssessment.Text = "Update Assessment";
            this.btnUpdateAssessment.UseVisualStyleBackColor = true;
            this.btnUpdateAssessment.Click += new System.EventHandler(this.btnUpdateAssessment_Click);
            // 
            // txtAssessmentID
            // 
            this.txtAssessmentID.Enabled = false;
            this.txtAssessmentID.Location = new System.Drawing.Point(160, 60);
            this.txtAssessmentID.MaxLength = 3;
            this.txtAssessmentID.Name = "txtAssessmentID";
            this.txtAssessmentID.Size = new System.Drawing.Size(27, 27);
            this.txtAssessmentID.TabIndex = 46;
            // 
            // lblMaximumMark
            // 
            this.lblMaximumMark.AutoSize = true;
            this.lblMaximumMark.Location = new System.Drawing.Point(44, 263);
            this.lblMaximumMark.Name = "lblMaximumMark";
            this.lblMaximumMark.Size = new System.Drawing.Size(114, 19);
            this.lblMaximumMark.TabIndex = 42;
            this.lblMaximumMark.Text = "Maximum Mark:";
            // 
            // lblWeighting
            // 
            this.lblWeighting.AutoSize = true;
            this.lblWeighting.Location = new System.Drawing.Point(79, 223);
            this.lblWeighting.Name = "lblWeighting";
            this.lblWeighting.Size = new System.Drawing.Size(79, 19);
            this.lblWeighting.TabIndex = 41;
            this.lblWeighting.Text = "Weighting:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(115, 183);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 19);
            this.lblType.TabIndex = 40;
            this.lblType.Text = "Type:";
            // 
            // lblAssessmentName
            // 
            this.lblAssessmentName.AutoSize = true;
            this.lblAssessmentName.Location = new System.Drawing.Point(25, 143);
            this.lblAssessmentName.Name = "lblAssessmentName";
            this.lblAssessmentName.Size = new System.Drawing.Size(133, 19);
            this.lblAssessmentName.TabIndex = 39;
            this.lblAssessmentName.Text = "Assessment Name:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(94, 103);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(64, 19);
            this.lblNumber.TabIndex = 38;
            this.lblNumber.Text = "Number:";
            // 
            // lblAssessmentID
            // 
            this.lblAssessmentID.AutoSize = true;
            this.lblAssessmentID.Location = new System.Drawing.Point(49, 63);
            this.lblAssessmentID.Name = "lblAssessmentID";
            this.lblAssessmentID.Size = new System.Drawing.Size(109, 19);
            this.lblAssessmentID.TabIndex = 37;
            this.lblAssessmentID.Text = "Assessment ID:";
            // 
            // lblAssessments
            // 
            this.lblAssessments.AutoSize = true;
            this.lblAssessments.Location = new System.Drawing.Point(60, 23);
            this.lblAssessments.Name = "lblAssessments";
            this.lblAssessments.Size = new System.Drawing.Size(98, 19);
            this.lblAssessments.TabIndex = 34;
            this.lblAssessments.Text = "Assessments:";
            // 
            // txtCourseName
            // 
            this.txtCourseName.Enabled = false;
            this.txtCourseName.Location = new System.Drawing.Point(160, 300);
            this.txtCourseName.MaxLength = 50;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(410, 27);
            this.txtCourseName.TabIndex = 66;
            // 
            // nudMaximumMark
            // 
            this.nudMaximumMark.Location = new System.Drawing.Point(160, 260);
            this.nudMaximumMark.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMaximumMark.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMaximumMark.Name = "nudMaximumMark";
            this.nudMaximumMark.Size = new System.Drawing.Size(50, 27);
            this.nudMaximumMark.TabIndex = 67;
            this.nudMaximumMark.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // nudWeighting
            // 
            this.nudWeighting.Location = new System.Drawing.Point(160, 220);
            this.nudWeighting.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWeighting.Name = "nudWeighting";
            this.nudWeighting.Size = new System.Drawing.Size(50, 27);
            this.nudWeighting.TabIndex = 68;
            this.nudWeighting.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Assignment",
            "Written Test",
            "Practical Test",
            "Final Exam"});
            this.cboType.Location = new System.Drawing.Point(160, 180);
            this.cboType.MaxLength = 14;
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(121, 27);
            this.cboType.TabIndex = 69;
            // 
            // txtAssessmentName
            // 
            this.txtAssessmentName.Location = new System.Drawing.Point(160, 140);
            this.txtAssessmentName.MaxLength = 50;
            this.txtAssessmentName.Name = "txtAssessmentName";
            this.txtAssessmentName.Size = new System.Drawing.Size(410, 27);
            this.txtAssessmentName.TabIndex = 70;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(160, 101);
            this.nudNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(35, 27);
            this.nudNumber.TabIndex = 71;
            this.nudNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cboAssessments
            // 
            this.cboAssessments.FormattingEnabled = true;
            this.cboAssessments.Location = new System.Drawing.Point(160, 20);
            this.cboAssessments.Name = "cboAssessments";
            this.cboAssessments.Size = new System.Drawing.Size(410, 27);
            this.cboAssessments.TabIndex = 72;
            this.cboAssessments.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboAssessments_Format);
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
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // UpdateAssessmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 425);
            this.Controls.Add(this.cboAssessments);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.txtAssessmentName);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.nudWeighting);
            this.Controls.Add(this.nudMaximumMark);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateAssessment);
            this.Controls.Add(this.txtAssessmentID);
            this.Controls.Add(this.lblMaximumMark);
            this.Controls.Add(this.lblWeighting);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAssessmentName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblAssessmentID);
            this.Controls.Add(this.lblAssessments);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateAssessmentForm";
            this.Text = "Update Assessment";
            this.Load += new System.EventHandler(this.UpdateAssessmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaximumMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeighting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateAssessment;
        private System.Windows.Forms.TextBox txtAssessmentID;
        private System.Windows.Forms.Label lblMaximumMark;
        private System.Windows.Forms.Label lblWeighting;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAssessmentName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAssessmentID;
        private System.Windows.Forms.Label lblAssessments;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.NumericUpDown nudMaximumMark;
        private System.Windows.Forms.NumericUpDown nudWeighting;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.TextBox txtAssessmentName;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.ComboBox cboAssessments;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource aSSESSMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter aSSESSMENTTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
    }
}