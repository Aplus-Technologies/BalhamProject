
namespace BalhamCollege
{
    partial class AddCourseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCourseForm));
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCredits = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.nudCredits = new System.Windows.Forms.NumericUpDown();
            this.nudFee = new System.Windows.Forms.NumericUpDown();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.pROGRAMMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROGRAMMETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaceHolder = new System.Windows.Forms.TextBox();
            this.txtProgrammeID = new System.Windows.Forms.TextBox();
            this.lblProgrammeName = new System.Windows.Forms.Label();
            this.cboProgramme = new System.Windows.Forms.ComboBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtPlaceHolder2 = new System.Windows.Forms.TextBox();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lblAsterix1 = new System.Windows.Forms.Label();
            this.lblAsterix2 = new System.Windows.Forms.Label();
            this.lblAsterix3 = new System.Windows.Forms.Label();
            this.lblAsterix4 = new System.Windows.Forms.Label();
            this.lblAsterix5 = new System.Windows.Forms.Label();
            this.lblAsterix6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(83, 40);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(95, 20);
            this.lblCourseName.TabIndex = 10;
            this.lblCourseName.Text = "Course Name:";
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(123, 77);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(55, 20);
            this.lblCredits.TabIndex = 12;
            this.lblCredits.Text = "Credits:";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(126, 110);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(48, 20);
            this.lblFee.TabIndex = 14;
            this.lblFee.Text = "Fee: $";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(129, 151);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 20);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Status:";
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddCourse.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddCourse.Location = new System.Drawing.Point(186, 343);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(115, 40);
            this.btnAddCourse.TabIndex = 8;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            this.btnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.Location = new System.Drawing.Point(467, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(115, 40);
            this.btnReturn.TabIndex = 9;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(174, 34);
            this.txtCourseName.MaxLength = 50;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(373, 26);
            this.txtCourseName.TabIndex = 0;
            this.txtCourseName.TextChanged += new System.EventHandler(this.txtCourseName_TextChanged);
            // 
            // nudCredits
            // 
            this.nudCredits.Location = new System.Drawing.Point(174, 71);
            this.nudCredits.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudCredits.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCredits.Name = "nudCredits";
            this.nudCredits.Size = new System.Drawing.Size(107, 26);
            this.nudCredits.TabIndex = 1;
            this.nudCredits.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudFee
            // 
            this.nudFee.DecimalPlaces = 2;
            this.nudFee.Location = new System.Drawing.Point(174, 108);
            this.nudFee.Maximum = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            this.nudFee.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudFee.Name = "nudFee";
            this.nudFee.Size = new System.Drawing.Size(107, 26);
            this.nudFee.TabIndex = 2;
            this.nudFee.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // cboStatus
            // 
            this.cboStatus.DisplayMember = "Current";
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Current",
            "Suspended"});
            this.cboStatus.Location = new System.Drawing.Point(174, 143);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(176, 28);
            this.cboStatus.TabIndex = 3;
            this.cboStatus.ValueMember = "Current";
            // 
            // dsBalhamCollegeAzure
            // 
            this.dsBalhamCollegeAzure.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure.EnforceConstraints = false;
            this.dsBalhamCollegeAzure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pROGRAMMEBindingSource
            // 
            this.pROGRAMMEBindingSource.DataMember = "PROGRAMME";
            this.pROGRAMMEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // pROGRAMMETableAdapter
            // 
            this.pROGRAMMETableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASSESSMENTTableAdapter = null;
            this.tableAdapterManager.ASSIGNMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = this.cOURSETableAdapter;
            this.tableAdapterManager.ENROLMENTTableAdapter = null;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.LECTURERTableAdapter = null;
            this.tableAdapterManager.PROGRAMMETableAdapter = this.pROGRAMMETableAdapter;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Please complete required fields above to select a program:";
            // 
            // txtPlaceHolder
            // 
            this.txtPlaceHolder.Location = new System.Drawing.Point(174, 225);
            this.txtPlaceHolder.MaxLength = 50;
            this.txtPlaceHolder.Multiline = true;
            this.txtPlaceHolder.Name = "txtPlaceHolder";
            this.txtPlaceHolder.ReadOnly = true;
            this.txtPlaceHolder.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlaceHolder.Size = new System.Drawing.Size(373, 27);
            this.txtPlaceHolder.TabIndex = 4;
            // 
            // txtProgrammeID
            // 
            this.txtProgrammeID.Location = new System.Drawing.Point(491, 348);
            this.txtProgrammeID.Name = "txtProgrammeID";
            this.txtProgrammeID.ReadOnly = true;
            this.txtProgrammeID.Size = new System.Drawing.Size(70, 26);
            this.txtProgrammeID.TabIndex = 24;
            // 
            // lblProgrammeName
            // 
            this.lblProgrammeName.AutoSize = true;
            this.lblProgrammeName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgrammeName.Location = new System.Drawing.Point(56, 232);
            this.lblProgrammeName.Name = "lblProgrammeName";
            this.lblProgrammeName.Size = new System.Drawing.Size(122, 20);
            this.lblProgrammeName.TabIndex = 20;
            this.lblProgrammeName.Text = "Programme Name:";
            // 
            // cboProgramme
            // 
            this.cboProgramme.FormattingEnabled = true;
            this.cboProgramme.Location = new System.Drawing.Point(174, 225);
            this.cboProgramme.Name = "cboProgramme";
            this.cboProgramme.Size = new System.Drawing.Size(373, 28);
            this.cboProgramme.TabIndex = 5;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(174, 263);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(100, 26);
            this.txtLevel.TabIndex = 7;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(132, 270);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(46, 20);
            this.lblLevel.TabIndex = 22;
            this.lblLevel.Text = "Level:";
            // 
            // txtPlaceHolder2
            // 
            this.txtPlaceHolder2.Location = new System.Drawing.Point(174, 263);
            this.txtPlaceHolder2.MaxLength = 50;
            this.txtPlaceHolder2.Multiline = true;
            this.txtPlaceHolder2.Name = "txtPlaceHolder2";
            this.txtPlaceHolder2.ReadOnly = true;
            this.txtPlaceHolder2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPlaceHolder2.Size = new System.Drawing.Size(100, 27);
            this.txtPlaceHolder2.TabIndex = 6;
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(472, 300);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(110, 20);
            this.lblRequiredFields.TabIndex = 23;
            this.lblRequiredFields.Text = "*Required Fields";
            // 
            // lblAsterix1
            // 
            this.lblAsterix1.AutoSize = true;
            this.lblAsterix1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix1.Location = new System.Drawing.Point(75, 34);
            this.lblAsterix1.Name = "lblAsterix1";
            this.lblAsterix1.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix1.TabIndex = 11;
            this.lblAsterix1.Text = "*";
            // 
            // lblAsterix2
            // 
            this.lblAsterix2.AutoSize = true;
            this.lblAsterix2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix2.Location = new System.Drawing.Point(115, 73);
            this.lblAsterix2.Name = "lblAsterix2";
            this.lblAsterix2.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix2.TabIndex = 13;
            this.lblAsterix2.Text = "*";
            // 
            // lblAsterix3
            // 
            this.lblAsterix3.AutoSize = true;
            this.lblAsterix3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix3.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix3.Location = new System.Drawing.Point(117, 108);
            this.lblAsterix3.Name = "lblAsterix3";
            this.lblAsterix3.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix3.TabIndex = 15;
            this.lblAsterix3.Text = "*";
            // 
            // lblAsterix4
            // 
            this.lblAsterix4.AutoSize = true;
            this.lblAsterix4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix4.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix4.Location = new System.Drawing.Point(121, 149);
            this.lblAsterix4.Name = "lblAsterix4";
            this.lblAsterix4.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix4.TabIndex = 17;
            this.lblAsterix4.Text = "*";
            // 
            // lblAsterix5
            // 
            this.lblAsterix5.AutoSize = true;
            this.lblAsterix5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix5.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix5.Location = new System.Drawing.Point(47, 229);
            this.lblAsterix5.Name = "lblAsterix5";
            this.lblAsterix5.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix5.TabIndex = 19;
            this.lblAsterix5.Text = "*";
            // 
            // lblAsterix6
            // 
            this.lblAsterix6.AutoSize = true;
            this.lblAsterix6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix6.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix6.Location = new System.Drawing.Point(123, 268);
            this.lblAsterix6.Name = "lblAsterix6";
            this.lblAsterix6.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix6.TabIndex = 21;
            this.lblAsterix6.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(630, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 89);
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // AddCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(703, 392);
            this.Controls.Add(this.txtPlaceHolder);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.nudCredits);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.lblAsterix6);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAsterix5);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.lblAsterix4);
            this.Controls.Add(this.lblAsterix3);
            this.Controls.Add(this.lblAsterix2);
            this.Controls.Add(this.lblAsterix1);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.txtPlaceHolder2);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudFee);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtProgrammeID);
            this.Controls.Add(this.cboProgramme);
            this.Controls.Add(this.lblProgrammeName);
            this.Controls.Add(this.lblLevel);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCourseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Course Form";
            this.Load += new System.EventHandler(this.AddCourseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblFee;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.NumericUpDown nudCredits;
        private System.Windows.Forms.NumericUpDown nudFee;
        private System.Windows.Forms.ComboBox cboStatus;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource pROGRAMMEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter pROGRAMMETableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlaceHolder;
        private System.Windows.Forms.TextBox txtProgrammeID;
        private System.Windows.Forms.Label lblProgrammeName;
        private System.Windows.Forms.ComboBox cboProgramme;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtPlaceHolder2;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblAsterix1;
        private System.Windows.Forms.Label lblAsterix2;
        private System.Windows.Forms.Label lblAsterix3;
        private System.Windows.Forms.Label lblAsterix4;
        private System.Windows.Forms.Label lblAsterix5;
        private System.Windows.Forms.Label lblAsterix6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}