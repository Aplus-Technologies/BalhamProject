
namespace BalhamCollege
{
    partial class EnterResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnterResultForm));
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.lECTURERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECTURERTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.txtAssessmentNumber = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtAssessmentName = new System.Windows.Forms.TextBox();
            this.txtMaximumMark = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.numMark = new System.Windows.Forms.NumericUpDown();
            this.btnEnterResult = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.aSSESSMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSESSMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter();
            this.eNROLMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eNROLMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter();
            this.dgvAssessments = new System.Windows.Forms.DataGridView();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.dgvEnrolments = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentTableAdapter1 = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESULTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESULTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESULTTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dsBalhamCollegeAzure
            // 
            this.dsBalhamCollegeAzure.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure.EnforceConstraints = false;
            this.dsBalhamCollegeAzure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASSESSMENTTableAdapter = null;
            this.tableAdapterManager.ASSIGNMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = null;
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
            // txtAssessmentNumber
            // 
            this.txtAssessmentNumber.Location = new System.Drawing.Point(948, 80);
            this.txtAssessmentNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAssessmentNumber.Name = "txtAssessmentNumber";
            this.txtAssessmentNumber.ReadOnly = true;
            this.txtAssessmentNumber.Size = new System.Drawing.Size(32, 30);
            this.txtAssessmentNumber.TabIndex = 12;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(948, 185);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.ReadOnly = true;
            this.txtCourseName.Size = new System.Drawing.Size(284, 30);
            this.txtCourseName.TabIndex = 13;
            // 
            // txtAssessmentName
            // 
            this.txtAssessmentName.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.txtAssessmentName.Location = new System.Drawing.Point(948, 115);
            this.txtAssessmentName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtAssessmentName.Name = "txtAssessmentName";
            this.txtAssessmentName.ReadOnly = true;
            this.txtAssessmentName.Size = new System.Drawing.Size(284, 30);
            this.txtAssessmentName.TabIndex = 14;
            // 
            // txtMaximumMark
            // 
            this.txtMaximumMark.Location = new System.Drawing.Point(948, 150);
            this.txtMaximumMark.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaximumMark.Name = "txtMaximumMark";
            this.txtMaximumMark.ReadOnly = true;
            this.txtMaximumMark.Size = new System.Drawing.Size(66, 30);
            this.txtMaximumMark.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(822, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Assessment Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(810, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Assessment Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(849, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "Maximum Mark:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(853, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Course Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(969, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mark:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(930, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Result Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(1007, 361);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(112, 30);
            this.dtpDate.TabIndex = 24;
            // 
            // numMark
            // 
            this.numMark.Location = new System.Drawing.Point(1007, 306);
            this.numMark.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.numMark.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numMark.Name = "numMark";
            this.numMark.Size = new System.Drawing.Size(48, 30);
            this.numMark.TabIndex = 25;
            // 
            // btnEnterResult
            // 
            this.btnEnterResult.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEnterResult.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnterResult.Location = new System.Drawing.Point(814, 471);
            this.btnEnterResult.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnEnterResult.Name = "btnEnterResult";
            this.btnEnterResult.Size = new System.Drawing.Size(180, 50);
            this.btnEnterResult.TabIndex = 26;
            this.btnEnterResult.Text = "Enter Result";
            this.btnEnterResult.UseVisualStyleBackColor = false;
            this.btnEnterResult.Click += new System.EventHandler(this.btnEnterResult_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.Location = new System.Drawing.Point(1053, 471);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(180, 50);
            this.btnReturn.TabIndex = 27;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            // eNROLMENTBindingSource
            // 
            this.eNROLMENTBindingSource.DataMember = "ENROLMENT";
            this.eNROLMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // eNROLMENTTableAdapter
            // 
            this.eNROLMENTTableAdapter.ClearBeforeFill = true;
            // 
            // dgvAssessments
            // 
            this.dgvAssessments.AllowUserToAddRows = false;
            this.dgvAssessments.AllowUserToDeleteRows = false;
            this.dgvAssessments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssessments.Location = new System.Drawing.Point(29, 41);
            this.dgvAssessments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAssessments.Name = "dgvAssessments";
            this.dgvAssessments.ReadOnly = true;
            this.dgvAssessments.RowHeadersWidth = 51;
            this.dgvAssessments.RowTemplate.Height = 24;
            this.dgvAssessments.Size = new System.Drawing.Size(750, 215);
            this.dgvAssessments.TabIndex = 28;
            this.dgvAssessments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssessments_CellClick);
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
            // dgvEnrolments
            // 
            this.dgvEnrolments.AllowUserToAddRows = false;
            this.dgvEnrolments.AllowUserToDeleteRows = false;
            this.dgvEnrolments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnrolments.Location = new System.Drawing.Point(29, 306);
            this.dgvEnrolments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvEnrolments.Name = "dgvEnrolments";
            this.dgvEnrolments.ReadOnly = true;
            this.dgvEnrolments.RowHeadersWidth = 51;
            this.dgvEnrolments.RowTemplate.Height = 24;
            this.dgvEnrolments.Size = new System.Drawing.Size(750, 215);
            this.dgvEnrolments.TabIndex = 29;
            this.dgvEnrolments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEnrolments_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Select an Assessment:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Select an Enrolment:";
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // rESULTBindingSource
            // 
            this.rESULTBindingSource.DataMember = "RESULT";
            this.rESULTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // rESULTTableAdapter
            // 
            this.rESULTTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(1088, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 24);
            this.label9.TabIndex = 32;
            this.label9.Text = "*Required Fields";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(921, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 24);
            this.label10.TabIndex = 33;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(957, 308);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1196, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 80);
            this.pictureBox1.TabIndex = 72;
            this.pictureBox1.TabStop = false;
            // 
            // EnterResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1266, 554);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvEnrolments);
            this.Controls.Add(this.dgvAssessments);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEnterResult);
            this.Controls.Add(this.numMark);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaximumMark);
            this.Controls.Add(this.txtAssessmentName);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtAssessmentNumber);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "EnterResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter Result";
            this.Load += new System.EventHandler(this.EnterResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSESSMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eNROLMENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssessments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnrolments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESULTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource lECTURERBindingSource;
        private dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter lECTURERTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtAssessmentNumber;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtAssessmentName;
        private System.Windows.Forms.TextBox txtMaximumMark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown numMark;
        private System.Windows.Forms.Button btnEnterResult;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.BindingSource aSSESSMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ASSESSMENTTableAdapter aSSESSMENTTableAdapter;
        private System.Windows.Forms.BindingSource eNROLMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ENROLMENTTableAdapter eNROLMENTTableAdapter;
        private System.Windows.Forms.DataGridView dgvAssessments;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.DataGridView dgvEnrolments;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private dsBalhamCollegeAzureTableAdapters.STUDENTTableAdapter studentTableAdapter1;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private System.Windows.Forms.BindingSource rESULTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.RESULTTableAdapter rESULTTableAdapter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}