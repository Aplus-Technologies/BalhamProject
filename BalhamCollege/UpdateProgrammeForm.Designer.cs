
namespace BalhamCollege
{
    partial class UpdateProgrammeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProgrammeForm));
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.txtProgrammeName = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateProgramme = new System.Windows.Forms.Button();
            this.lblProgrammeName = new System.Windows.Forms.Label();
            this.lblProgrammeID = new System.Windows.Forms.Label();
            this.lblSelectProgramme = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProgrammes = new System.Windows.Forms.ListBox();
            this.txtProgrammeID = new System.Windows.Forms.TextBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.pROGRAMMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROGRAMMETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(157, 306);
            this.nudLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(35, 26);
            this.nudLevel.TabIndex = 91;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtProgrammeName
            // 
            this.txtProgrammeName.Location = new System.Drawing.Point(157, 271);
            this.txtProgrammeName.MaxLength = 50;
            this.txtProgrammeName.Name = "txtProgrammeName";
            this.txtProgrammeName.Size = new System.Drawing.Size(362, 26);
            this.txtProgrammeName.TabIndex = 90;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(35, 309);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(120, 20);
            this.lblLevel.TabIndex = 89;
            this.lblLevel.Text = "Programme Level:";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl8.Location = new System.Drawing.Point(20, 274);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(14, 20);
            this.lbl8.TabIndex = 88;
            this.lbl8.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequiredFields.Location = new System.Drawing.Point(393, 358);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(105, 20);
            this.lblRequiredFields.TabIndex = 83;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.Location = new System.Drawing.Point(372, 386);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 40);
            this.btnReturn.TabIndex = 93;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateProgramme
            // 
            this.btnUpdateProgramme.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateProgramme.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdateProgramme.Location = new System.Drawing.Point(157, 386);
            this.btnUpdateProgramme.Name = "btnUpdateProgramme";
            this.btnUpdateProgramme.Size = new System.Drawing.Size(147, 40);
            this.btnUpdateProgramme.TabIndex = 92;
            this.btnUpdateProgramme.Text = "Update Programme";
            this.btnUpdateProgramme.UseVisualStyleBackColor = false;
            this.btnUpdateProgramme.Click += new System.EventHandler(this.btnUpdateProgramme_Click);
            // 
            // lblProgrammeName
            // 
            this.lblProgrammeName.AutoSize = true;
            this.lblProgrammeName.Location = new System.Drawing.Point(33, 274);
            this.lblProgrammeName.Name = "lblProgrammeName";
            this.lblProgrammeName.Size = new System.Drawing.Size(122, 20);
            this.lblProgrammeName.TabIndex = 79;
            this.lblProgrammeName.Text = "Programme Name:";
            // 
            // lblProgrammeID
            // 
            this.lblProgrammeID.AutoSize = true;
            this.lblProgrammeID.Location = new System.Drawing.Point(56, 239);
            this.lblProgrammeID.Name = "lblProgrammeID";
            this.lblProgrammeID.Size = new System.Drawing.Size(99, 20);
            this.lblProgrammeID.TabIndex = 78;
            this.lblProgrammeID.Text = "Programme ID:";
            // 
            // lblSelectProgramme
            // 
            this.lblSelectProgramme.AutoSize = true;
            this.lblSelectProgramme.Location = new System.Drawing.Point(33, 28);
            this.lblSelectProgramme.Name = "lblSelectProgramme";
            this.lblSelectProgramme.Size = new System.Drawing.Size(179, 20);
            this.lblSelectProgramme.TabIndex = 73;
            this.lblSelectProgramme.Text = "Please select a programme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(22, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 97;
            this.label1.Text = "*";
            // 
            // lstProgrammes
            // 
            this.lstProgrammes.FormattingEnabled = true;
            this.lstProgrammes.HorizontalScrollbar = true;
            this.lstProgrammes.ItemHeight = 20;
            this.lstProgrammes.Location = new System.Drawing.Point(30, 51);
            this.lstProgrammes.Name = "lstProgrammes";
            this.lstProgrammes.Size = new System.Drawing.Size(489, 144);
            this.lstProgrammes.TabIndex = 88;
            this.lstProgrammes.SelectedIndexChanged += new System.EventHandler(this.lstProgrammes_SelectedIndexChanged);
            this.lstProgrammes.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstProgrammes_Format);
            // 
            // txtProgrammeID
            // 
            this.txtProgrammeID.Location = new System.Drawing.Point(157, 236);
            this.txtProgrammeID.MaxLength = 2;
            this.txtProgrammeID.Name = "txtProgrammeID";
            this.txtProgrammeID.ReadOnly = true;
            this.txtProgrammeID.Size = new System.Drawing.Size(19, 26);
            this.txtProgrammeID.TabIndex = 89;
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
            this.tableAdapterManager.COURSETableAdapter = null;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(473, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateProgrammeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 447);
            this.Controls.Add(this.txtProgrammeID);
            this.Controls.Add(this.lstProgrammes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.txtProgrammeName);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateProgramme);
            this.Controls.Add(this.lblProgrammeName);
            this.Controls.Add(this.lblProgrammeID);
            this.Controls.Add(this.lblSelectProgramme);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateProgrammeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Programme";
            this.Load += new System.EventHandler(this.UpdateProgrammeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.TextBox txtProgrammeName;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateProgramme;
        private System.Windows.Forms.Label lblProgrammeName;
        private System.Windows.Forms.Label lblProgrammeID;
        private System.Windows.Forms.Label lblSelectProgramme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProgrammes;
        private System.Windows.Forms.TextBox txtProgrammeID;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource pROGRAMMEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter pROGRAMMETableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}