
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
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(157, 305);
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
            this.nudLevel.Size = new System.Drawing.Size(35, 27);
            this.nudLevel.TabIndex = 91;
            this.nudLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtProgrammeName
            // 
            this.txtProgrammeName.Location = new System.Drawing.Point(157, 264);
            this.txtProgrammeName.MaxLength = 50;
            this.txtProgrammeName.Name = "txtProgrammeName";
            this.txtProgrammeName.Size = new System.Drawing.Size(410, 27);
            this.txtProgrammeName.TabIndex = 90;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(108, 307);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(47, 19);
            this.lblLevel.TabIndex = 89;
            this.lblLevel.Text = "Level:";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl8.Location = new System.Drawing.Point(13, 267);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(17, 19);
            this.lbl8.TabIndex = 88;
            this.lbl8.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequiredFields.Location = new System.Drawing.Point(441, 340);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(114, 19);
            this.lblRequiredFields.TabIndex = 83;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(420, 367);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 33);
            this.btnReturn.TabIndex = 82;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateProgramme
            // 
            this.btnUpdateProgramme.Location = new System.Drawing.Point(157, 367);
            this.btnUpdateProgramme.Name = "btnUpdateProgramme";
            this.btnUpdateProgramme.Size = new System.Drawing.Size(147, 33);
            this.btnUpdateProgramme.TabIndex = 81;
            this.btnUpdateProgramme.Text = "Update Programme";
            this.btnUpdateProgramme.UseVisualStyleBackColor = true;
            this.btnUpdateProgramme.Click += new System.EventHandler(this.btnUpdateProgramme_Click);
            // 
            // lblProgrammeName
            // 
            this.lblProgrammeName.AutoSize = true;
            this.lblProgrammeName.Location = new System.Drawing.Point(26, 267);
            this.lblProgrammeName.Name = "lblProgrammeName";
            this.lblProgrammeName.Size = new System.Drawing.Size(129, 19);
            this.lblProgrammeName.TabIndex = 79;
            this.lblProgrammeName.Text = "Programme Name:";
            // 
            // lblProgrammeID
            // 
            this.lblProgrammeID.AutoSize = true;
            this.lblProgrammeID.Location = new System.Drawing.Point(50, 227);
            this.lblProgrammeID.Name = "lblProgrammeID";
            this.lblProgrammeID.Size = new System.Drawing.Size(105, 19);
            this.lblProgrammeID.TabIndex = 78;
            this.lblProgrammeID.Text = "Programme ID:";
            // 
            // lblSelectProgramme
            // 
            this.lblSelectProgramme.AutoSize = true;
            this.lblSelectProgramme.Location = new System.Drawing.Point(33, 27);
            this.lblSelectProgramme.Name = "lblSelectProgramme";
            this.lblSelectProgramme.Size = new System.Drawing.Size(189, 19);
            this.lblSelectProgramme.TabIndex = 73;
            this.lblSelectProgramme.Text = "Please select a programme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(95, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 97;
            this.label1.Text = "*";
            // 
            // lstProgrammes
            // 
            this.lstProgrammes.FormattingEnabled = true;
            this.lstProgrammes.ItemHeight = 19;
            this.lstProgrammes.Location = new System.Drawing.Point(30, 48);
            this.lstProgrammes.Name = "lstProgrammes";
            this.lstProgrammes.Size = new System.Drawing.Size(537, 137);
            this.lstProgrammes.TabIndex = 98;
            this.lstProgrammes.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstProgrammes_Format);
            // 
            // txtProgrammeID
            // 
            this.txtProgrammeID.Enabled = false;
            this.txtProgrammeID.Location = new System.Drawing.Point(157, 224);
            this.txtProgrammeID.MaxLength = 2;
            this.txtProgrammeID.Name = "txtProgrammeID";
            this.txtProgrammeID.Size = new System.Drawing.Size(19, 27);
            this.txtProgrammeID.TabIndex = 99;
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
            // UpdateProgrammeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 425);
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
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateProgrammeForm";
            this.Text = "Update Programme";
            this.Load += new System.EventHandler(this.UpdateProgrammeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).EndInit();
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
    }
}