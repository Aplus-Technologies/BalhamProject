
namespace BalhamCollege
{
    partial class DeleteProgrammeForm
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
            this.txtProgrammeName = new System.Windows.Forms.TextBox();
            this.lblProgrammeName = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteProgramme = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtProgrammeID = new System.Windows.Forms.TextBox();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblProgrammeID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstProgrammes = new System.Windows.Forms.ListBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.pROGRAMMEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pROGRAMMETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.cOURSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOURSETableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.COURSETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProgrammeName
            // 
            this.txtProgrammeName.Location = new System.Drawing.Point(268, 377);
            this.txtProgrammeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProgrammeName.Name = "txtProgrammeName";
            this.txtProgrammeName.ReadOnly = true;
            this.txtProgrammeName.Size = new System.Drawing.Size(297, 35);
            this.txtProgrammeName.TabIndex = 152;
            // 
            // lblProgrammeName
            // 
            this.lblProgrammeName.AutoSize = true;
            this.lblProgrammeName.Location = new System.Drawing.Point(92, 381);
            this.lblProgrammeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgrammeName.Name = "lblProgrammeName";
            this.lblProgrammeName.Size = new System.Drawing.Size(178, 29);
            this.lblProgrammeName.TabIndex = 151;
            this.lblProgrammeName.Text = "Programme Name:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(597, 497);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(192, 61);
            this.btnReturn.TabIndex = 150;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteProgramme
            // 
            this.btnDeleteProgramme.Location = new System.Drawing.Point(50, 497);
            this.btnDeleteProgramme.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteProgramme.Name = "btnDeleteProgramme";
            this.btnDeleteProgramme.Size = new System.Drawing.Size(230, 61);
            this.btnDeleteProgramme.TabIndex = 149;
            this.btnDeleteProgramme.Text = "Delete Programme";
            this.btnDeleteProgramme.UseVisualStyleBackColor = true;
            this.btnDeleteProgramme.Click += new System.EventHandler(this.btnDeleteProgramme_Click);
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(268, 423);
            this.txtLevel.Margin = new System.Windows.Forms.Padding(4);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(81, 35);
            this.txtLevel.TabIndex = 148;
            // 
            // txtProgrammeID
            // 
            this.txtProgrammeID.Location = new System.Drawing.Point(268, 331);
            this.txtProgrammeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtProgrammeID.Name = "txtProgrammeID";
            this.txtProgrammeID.ReadOnly = true;
            this.txtProgrammeID.Size = new System.Drawing.Size(81, 35);
            this.txtProgrammeID.TabIndex = 147;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(210, 428);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(64, 29);
            this.lblLevel.TabIndex = 146;
            this.lblLevel.Text = "Level:";
            // 
            // lblProgrammeID
            // 
            this.lblProgrammeID.AutoSize = true;
            this.lblProgrammeID.Location = new System.Drawing.Point(129, 335);
            this.lblProgrammeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProgrammeID.Name = "lblProgrammeID";
            this.lblProgrammeID.Size = new System.Drawing.Size(144, 29);
            this.lblProgrammeID.TabIndex = 145;
            this.lblProgrammeID.Text = "Programme ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 144;
            this.label1.Text = "Please select a programme:";
            // 
            // lstProgrammes
            // 
            this.lstProgrammes.FormattingEnabled = true;
            this.lstProgrammes.ItemHeight = 29;
            this.lstProgrammes.Location = new System.Drawing.Point(47, 71);
            this.lstProgrammes.Margin = new System.Windows.Forms.Padding(4);
            this.lstProgrammes.Name = "lstProgrammes";
            this.lstProgrammes.ScrollAlwaysVisible = true;
            this.lstProgrammes.Size = new System.Drawing.Size(741, 236);
            this.lstProgrammes.TabIndex = 143;
            this.lstProgrammes.SelectedIndexChanged += new System.EventHandler(this.lstProgrammes_SelectedIndexChanged);
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
            // cOURSEBindingSource
            // 
            this.cOURSEBindingSource.DataMember = "COURSE";
            this.cOURSEBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // cOURSETableAdapter
            // 
            this.cOURSETableAdapter.ClearBeforeFill = true;
            // 
            // DeleteProgrammeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 647);
            this.Controls.Add(this.txtProgrammeName);
            this.Controls.Add(this.lblProgrammeName);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteProgramme);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtProgrammeID);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblProgrammeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProgrammes);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteProgrammeForm";
            this.Text = "DeleteProgrammeForm";
            this.Load += new System.EventHandler(this.DeleteProgrammeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pROGRAMMEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOURSEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProgrammeName;
        private System.Windows.Forms.Label lblProgrammeName;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteProgramme;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtProgrammeID;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblProgrammeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstProgrammes;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource pROGRAMMEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.PROGRAMMETableAdapter pROGRAMMETableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource cOURSEBindingSource;
        private dsBalhamCollegeAzureTableAdapters.COURSETableAdapter cOURSETableAdapter;
    }
}