
namespace BalhamCollege
{
    partial class UpdateResearchTopicForm
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
            this.txtTopicID = new System.Windows.Forms.TextBox();
            this.lstResearchTopics = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTopicDescription = new System.Windows.Forms.TextBox();
            this.lblImpact = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateTopic = new System.Windows.Forms.Button();
            this.lblTopicDescription = new System.Windows.Forms.Label();
            this.lblTopicID = new System.Windows.Forms.Label();
            this.lblSelectResearchTopic = new System.Windows.Forms.Label();
            this.cboImpact = new System.Windows.Forms.ComboBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.rESEARCHTOPICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESEARCHTOPICTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTopicID
            // 
            this.txtTopicID.Enabled = false;
            this.txtTopicID.Location = new System.Drawing.Point(165, 223);
            this.txtTopicID.MaxLength = 2;
            this.txtTopicID.Name = "txtTopicID";
            this.txtTopicID.Size = new System.Drawing.Size(19, 27);
            this.txtTopicID.TabIndex = 112;
            // 
            // lstResearchTopics
            // 
            this.lstResearchTopics.FormattingEnabled = true;
            this.lstResearchTopics.ItemHeight = 19;
            this.lstResearchTopics.Location = new System.Drawing.Point(38, 47);
            this.lstResearchTopics.Name = "lstResearchTopics";
            this.lstResearchTopics.Size = new System.Drawing.Size(537, 137);
            this.lstResearchTopics.TabIndex = 111;
            this.lstResearchTopics.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstResearchTopics_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(93, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 19);
            this.label1.TabIndex = 110;
            this.label1.Text = "*";
            // 
            // txtTopicDescription
            // 
            this.txtTopicDescription.Location = new System.Drawing.Point(165, 263);
            this.txtTopicDescription.MaxLength = 100;
            this.txtTopicDescription.Multiline = true;
            this.txtTopicDescription.Name = "txtTopicDescription";
            this.txtTopicDescription.Size = new System.Drawing.Size(410, 54);
            this.txtTopicDescription.TabIndex = 108;
            // 
            // lblImpact
            // 
            this.lblImpact.AutoSize = true;
            this.lblImpact.Location = new System.Drawing.Point(106, 333);
            this.lblImpact.Name = "lblImpact";
            this.lblImpact.Size = new System.Drawing.Size(57, 19);
            this.lblImpact.TabIndex = 107;
            this.lblImpact.Text = "Impact:";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl8.Location = new System.Drawing.Point(25, 266);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(17, 19);
            this.lbl8.TabIndex = 106;
            this.lbl8.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequiredFields.Location = new System.Drawing.Point(449, 366);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(114, 19);
            this.lblRequiredFields.TabIndex = 105;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(428, 393);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 33);
            this.btnReturn.TabIndex = 104;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateTopic
            // 
            this.btnUpdateTopic.Location = new System.Drawing.Point(165, 393);
            this.btnUpdateTopic.Name = "btnUpdateTopic";
            this.btnUpdateTopic.Size = new System.Drawing.Size(147, 33);
            this.btnUpdateTopic.TabIndex = 103;
            this.btnUpdateTopic.Text = "Update Topic";
            this.btnUpdateTopic.UseVisualStyleBackColor = true;
            this.btnUpdateTopic.Click += new System.EventHandler(this.btnUpdateTopic_Click);
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Location = new System.Drawing.Point(38, 266);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(125, 19);
            this.lblTopicDescription.TabIndex = 102;
            this.lblTopicDescription.Text = "Topic Description:";
            // 
            // lblTopicID
            // 
            this.lblTopicID.AutoSize = true;
            this.lblTopicID.Location = new System.Drawing.Point(98, 226);
            this.lblTopicID.Name = "lblTopicID";
            this.lblTopicID.Size = new System.Drawing.Size(65, 19);
            this.lblTopicID.TabIndex = 101;
            this.lblTopicID.Text = "Topic ID:";
            // 
            // lblSelectResearchTopic
            // 
            this.lblSelectResearchTopic.AutoSize = true;
            this.lblSelectResearchTopic.Location = new System.Drawing.Point(41, 26);
            this.lblSelectResearchTopic.Name = "lblSelectResearchTopic";
            this.lblSelectResearchTopic.Size = new System.Drawing.Size(207, 19);
            this.lblSelectResearchTopic.TabIndex = 100;
            this.lblSelectResearchTopic.Text = "Please select a research topic:";
            // 
            // cboImpact
            // 
            this.cboImpact.FormattingEnabled = true;
            this.cboImpact.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cboImpact.Location = new System.Drawing.Point(165, 333);
            this.cboImpact.MaxLength = 6;
            this.cboImpact.Name = "cboImpact";
            this.cboImpact.Size = new System.Drawing.Size(71, 27);
            this.cboImpact.TabIndex = 113;
            // 
            // dsBalhamCollegeAzure
            // 
            this.dsBalhamCollegeAzure.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure.EnforceConstraints = false;
            this.dsBalhamCollegeAzure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rESEARCHTOPICBindingSource
            // 
            this.rESEARCHTOPICBindingSource.DataMember = "RESEARCHTOPIC";
            this.rESEARCHTOPICBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // rESEARCHTOPICTableAdapter
            // 
            this.rESEARCHTOPICTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PROGRAMMETableAdapter = null;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = this.rESEARCHTOPICTableAdapter;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // UpdateResearchTopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 468);
            this.Controls.Add(this.cboImpact);
            this.Controls.Add(this.txtTopicID);
            this.Controls.Add(this.lstResearchTopics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTopicDescription);
            this.Controls.Add(this.lblImpact);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateTopic);
            this.Controls.Add(this.lblTopicDescription);
            this.Controls.Add(this.lblTopicID);
            this.Controls.Add(this.lblSelectResearchTopic);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateResearchTopicForm";
            this.Text = "Update Research Topic";
            this.Load += new System.EventHandler(this.UpdateResearchTopicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTopicID;
        private System.Windows.Forms.ListBox lstResearchTopics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTopicDescription;
        private System.Windows.Forms.Label lblImpact;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateTopic;
        private System.Windows.Forms.Label lblTopicDescription;
        private System.Windows.Forms.Label lblTopicID;
        private System.Windows.Forms.Label lblSelectResearchTopic;
        private System.Windows.Forms.ComboBox cboImpact;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource rESEARCHTOPICBindingSource;
        private dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter rESEARCHTOPICTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
    }
}