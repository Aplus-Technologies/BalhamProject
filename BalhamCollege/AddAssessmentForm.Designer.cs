
namespace BalhamCollege
{
    partial class AddAssessmentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAssessmentForm));
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lblSelectCourse = new System.Windows.Forms.Label();
            this.lblAssessmentNumber = new System.Windows.Forms.Label();
            this.lblAssessmentName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblWeighting = new System.Windows.Forms.Label();
            this.lblMaximumMark = new System.Windows.Forms.Label();
            this.btnAddAssessment = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtAssessmentName = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.nudAsmntNumber = new System.Windows.Forms.NumericUpDown();
            this.nudWeighting = new System.Windows.Forms.NumericUpDown();
            this.nudMaxMark = new System.Windows.Forms.NumericUpDown();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lblAsterix1 = new System.Windows.Forms.Label();
            this.lblAsterix2 = new System.Windows.Forms.Label();
            this.lblAsterix3 = new System.Windows.Forms.Label();
            this.lblAsterix4 = new System.Windows.Forms.Label();
            this.lblAsterix5 = new System.Windows.Forms.Label();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.aSSESSMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter();
            this.aSSESSMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAsmntNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeighting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.HorizontalScrollbar = true;
            this.lstCourses.ItemHeight = 20;
            this.lstCourses.Location = new System.Drawing.Point(30, 43);
            this.lstCourses.Margin = new System.Windows.Forms.Padding(4);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.ScrollAlwaysVisible = true;
            this.lstCourses.Size = new System.Drawing.Size(283, 364);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // lblSelectCourse
            // 
            this.lblSelectCourse.AutoSize = true;
            this.lblSelectCourse.Location = new System.Drawing.Point(26, 19);
            this.lblSelectCourse.Name = "lblSelectCourse";
            this.lblSelectCourse.Size = new System.Drawing.Size(151, 20);
            this.lblSelectCourse.TabIndex = 1;
            this.lblSelectCourse.Text = "Please select a course:";
            // 
            // lblAssessmentNumber
            // 
            this.lblAssessmentNumber.AutoSize = true;
            this.lblAssessmentNumber.Location = new System.Drawing.Point(429, 63);
            this.lblAssessmentNumber.Name = "lblAssessmentNumber";
            this.lblAssessmentNumber.Size = new System.Drawing.Size(138, 20);
            this.lblAssessmentNumber.TabIndex = 2;
            this.lblAssessmentNumber.Text = "Assessment Number:";
            // 
            // lblAssessmentName
            // 
            this.lblAssessmentName.AutoSize = true;
            this.lblAssessmentName.Location = new System.Drawing.Point(441, 104);
            this.lblAssessmentName.Name = "lblAssessmentName";
            this.lblAssessmentName.Size = new System.Drawing.Size(126, 20);
            this.lblAssessmentName.TabIndex = 3;
            this.lblAssessmentName.Text = "Assessment Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(524, 149);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type:";
            // 
            // lblWeighting
            // 
            this.lblWeighting.AutoSize = true;
            this.lblWeighting.Location = new System.Drawing.Point(495, 190);
            this.lblWeighting.Name = "lblWeighting";
            this.lblWeighting.Size = new System.Drawing.Size(72, 20);
            this.lblWeighting.TabIndex = 5;
            this.lblWeighting.Text = "Weighting:";
            // 
            // lblMaximumMark
            // 
            this.lblMaximumMark.AutoSize = true;
            this.lblMaximumMark.Location = new System.Drawing.Point(465, 233);
            this.lblMaximumMark.Name = "lblMaximumMark";
            this.lblMaximumMark.Size = new System.Drawing.Size(103, 20);
            this.lblMaximumMark.TabIndex = 6;
            this.lblMaximumMark.Text = "Maximum Mark:";
            // 
            // btnAddAssessment
            // 
            this.btnAddAssessment.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddAssessment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddAssessment.Location = new System.Drawing.Point(389, 367);
            this.btnAddAssessment.Name = "btnAddAssessment";
            this.btnAddAssessment.Size = new System.Drawing.Size(137, 40);
            this.btnAddAssessment.TabIndex = 7;
            this.btnAddAssessment.Text = "Add Assessment";
            this.btnAddAssessment.UseVisualStyleBackColor = false;
            this.btnAddAssessment.Click += new System.EventHandler(this.btnAddAssessment_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.Location = new System.Drawing.Point(790, 367);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(137, 40);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtAssessmentName
            // 
            this.txtAssessmentName.Location = new System.Drawing.Point(564, 98);
            this.txtAssessmentName.MaxLength = 50;
            this.txtAssessmentName.Name = "txtAssessmentName";
            this.txtAssessmentName.Size = new System.Drawing.Size(330, 26);
            this.txtAssessmentName.TabIndex = 9;
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Assignment",
            "Written Test",
            "Practical Test",
            "Final Exam"});
            this.cboType.Location = new System.Drawing.Point(564, 141);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(122, 28);
            this.cboType.TabIndex = 10;
            // 
            // nudAsmntNumber
            // 
            this.nudAsmntNumber.Location = new System.Drawing.Point(564, 57);
            this.nudAsmntNumber.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAsmntNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAsmntNumber.Name = "nudAsmntNumber";
            this.nudAsmntNumber.Size = new System.Drawing.Size(67, 26);
            this.nudAsmntNumber.TabIndex = 11;
            this.nudAsmntNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudWeighting
            // 
            this.nudWeighting.Location = new System.Drawing.Point(564, 184);
            this.nudWeighting.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWeighting.Name = "nudWeighting";
            this.nudWeighting.Size = new System.Drawing.Size(67, 26);
            this.nudWeighting.TabIndex = 12;
            this.nudWeighting.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudMaxMark
            // 
            this.nudMaxMark.Location = new System.Drawing.Point(564, 227);
            this.nudMaxMark.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudMaxMark.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMaxMark.Name = "nudMaxMark";
            this.nudMaxMark.Size = new System.Drawing.Size(67, 26);
            this.nudMaxMark.TabIndex = 13;
            this.nudMaxMark.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(810, 325);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(110, 20);
            this.lblRequiredFields.TabIndex = 28;
            this.lblRequiredFields.Text = "*Required Fields";
            // 
            // lblAsterix1
            // 
            this.lblAsterix1.AutoSize = true;
            this.lblAsterix1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix1.Location = new System.Drawing.Point(420, 57);
            this.lblAsterix1.Name = "lblAsterix1";
            this.lblAsterix1.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix1.TabIndex = 33;
            this.lblAsterix1.Text = "*";
            // 
            // lblAsterix2
            // 
            this.lblAsterix2.AutoSize = true;
            this.lblAsterix2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix2.Location = new System.Drawing.Point(433, 98);
            this.lblAsterix2.Name = "lblAsterix2";
            this.lblAsterix2.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix2.TabIndex = 34;
            this.lblAsterix2.Text = "*";
            // 
            // lblAsterix3
            // 
            this.lblAsterix3.AutoSize = true;
            this.lblAsterix3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix3.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix3.Location = new System.Drawing.Point(512, 141);
            this.lblAsterix3.Name = "lblAsterix3";
            this.lblAsterix3.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix3.TabIndex = 35;
            this.lblAsterix3.Text = "*";
            // 
            // lblAsterix4
            // 
            this.lblAsterix4.AutoSize = true;
            this.lblAsterix4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix4.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix4.Location = new System.Drawing.Point(487, 184);
            this.lblAsterix4.Name = "lblAsterix4";
            this.lblAsterix4.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix4.TabIndex = 36;
            this.lblAsterix4.Text = "*";
            // 
            // lblAsterix5
            // 
            this.lblAsterix5.AutoSize = true;
            this.lblAsterix5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix5.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix5.Location = new System.Drawing.Point(455, 227);
            this.lblAsterix5.Name = "lblAsterix5";
            this.lblAsterix5.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix5.TabIndex = 37;
            this.lblAsterix5.Text = "*";
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
            // aSSESSMENTTableAdapter
            // 
            this.aSSESSMENTTableAdapter.ClearBeforeFill = true;
            // 
            // aSSESSMENTBindingSource
            // 
            this.aSSESSMENTBindingSource.DataMember = "ASSESSMENT";
            this.aSSESSMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(923, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 89);
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // AddAssessmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(995, 441);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblAsterix5);
            this.Controls.Add(this.lblAsterix4);
            this.Controls.Add(this.lblAsterix3);
            this.Controls.Add(this.lblAsterix2);
            this.Controls.Add(this.lblAsterix1);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.nudMaxMark);
            this.Controls.Add(this.nudWeighting);
            this.Controls.Add(this.nudAsmntNumber);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.txtAssessmentName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddAssessment);
            this.Controls.Add(this.lblMaximumMark);
            this.Controls.Add(this.lblWeighting);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblAssessmentName);
            this.Controls.Add(this.lblAssessmentNumber);
            this.Controls.Add(this.lblSelectCourse);
            this.Controls.Add(this.lstCourses);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddAssessmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Assessment Form";
            this.Load += new System.EventHandler(this.AddAssessmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAsmntNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeighting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Label lblSelectCourse;
        private System.Windows.Forms.Label lblAssessmentNumber;
        private System.Windows.Forms.Label lblAssessmentName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblWeighting;
        private System.Windows.Forms.Label lblMaximumMark;
        private System.Windows.Forms.Button btnAddAssessment;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtAssessmentName;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.NumericUpDown nudAsmntNumber;
        private System.Windows.Forms.NumericUpDown nudWeighting;
        private System.Windows.Forms.NumericUpDown nudMaxMark;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblAsterix1;
        private System.Windows.Forms.Label lblAsterix2;
        private System.Windows.Forms.Label lblAsterix3;
        private System.Windows.Forms.Label lblAsterix4;
        private System.Windows.Forms.Label lblAsterix5;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter aSSESSMENTTableAdapter;
        private System.Windows.Forms.BindingSource aSSESSMENTBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}