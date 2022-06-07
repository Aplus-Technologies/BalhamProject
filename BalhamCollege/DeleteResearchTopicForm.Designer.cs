
namespace BalhamCollege
{
    partial class DeleteResearchTopicForm
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
            this.txtTopicDescription = new System.Windows.Forms.TextBox();
            this.lblTopicDescription = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteResearchTopic = new System.Windows.Forms.Button();
            this.txtImpact = new System.Windows.Forms.TextBox();
            this.txtResearchTopicID = new System.Windows.Forms.TextBox();
            this.lblImpact = new System.Windows.Forms.Label();
            this.lblResearchTopicID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResearchTopics = new System.Windows.Forms.ListBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.rESEARCHTOPICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESEARCHTOPICTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.rESEARCHPROJECTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESEARCHPROJECTTableAdapter();
            this.rESEARCHPROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHPROJECTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTopicDescription
            // 
            this.txtTopicDescription.Location = new System.Drawing.Point(266, 368);
            this.txtTopicDescription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTopicDescription.Name = "txtTopicDescription";
            this.txtTopicDescription.ReadOnly = true;
            this.txtTopicDescription.Size = new System.Drawing.Size(517, 35);
            this.txtTopicDescription.TabIndex = 162;
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Location = new System.Drawing.Point(108, 373);
            this.lblTopicDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(169, 29);
            this.lblTopicDescription.TabIndex = 161;
            this.lblTopicDescription.Text = "Topic Description:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(594, 489);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(193, 61);
            this.btnReturn.TabIndex = 160;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteResearchTopic
            // 
            this.btnDeleteResearchTopic.Location = new System.Drawing.Point(48, 489);
            this.btnDeleteResearchTopic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteResearchTopic.Name = "btnDeleteResearchTopic";
            this.btnDeleteResearchTopic.Size = new System.Drawing.Size(230, 61);
            this.btnDeleteResearchTopic.TabIndex = 159;
            this.btnDeleteResearchTopic.Text = "Delete Research Topic";
            this.btnDeleteResearchTopic.UseVisualStyleBackColor = true;
            this.btnDeleteResearchTopic.Click += new System.EventHandler(this.btnDeleteResearchTopic_Click);
            // 
            // txtImpact
            // 
            this.txtImpact.Location = new System.Drawing.Point(266, 415);
            this.txtImpact.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtImpact.Name = "txtImpact";
            this.txtImpact.ReadOnly = true;
            this.txtImpact.Size = new System.Drawing.Size(118, 35);
            this.txtImpact.TabIndex = 158;
            // 
            // txtResearchTopicID
            // 
            this.txtResearchTopicID.Location = new System.Drawing.Point(266, 322);
            this.txtResearchTopicID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResearchTopicID.Name = "txtResearchTopicID";
            this.txtResearchTopicID.ReadOnly = true;
            this.txtResearchTopicID.Size = new System.Drawing.Size(77, 35);
            this.txtResearchTopicID.TabIndex = 157;
            // 
            // lblImpact
            // 
            this.lblImpact.AutoSize = true;
            this.lblImpact.Location = new System.Drawing.Point(196, 419);
            this.lblImpact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImpact.Name = "lblImpact";
            this.lblImpact.Size = new System.Drawing.Size(75, 29);
            this.lblImpact.TabIndex = 156;
            this.lblImpact.Text = "Impact:";
            // 
            // lblResearchTopicID
            // 
            this.lblResearchTopicID.AutoSize = true;
            this.lblResearchTopicID.Location = new System.Drawing.Point(93, 326);
            this.lblResearchTopicID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResearchTopicID.Name = "lblResearchTopicID";
            this.lblResearchTopicID.Size = new System.Drawing.Size(179, 29);
            this.lblResearchTopicID.TabIndex = 155;
            this.lblResearchTopicID.Text = "Research Topic ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 154;
            this.label1.Text = "Please select a research topic:";
            // 
            // lstResearchTopics
            // 
            this.lstResearchTopics.FormattingEnabled = true;
            this.lstResearchTopics.ItemHeight = 29;
            this.lstResearchTopics.Location = new System.Drawing.Point(44, 65);
            this.lstResearchTopics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstResearchTopics.Name = "lstResearchTopics";
            this.lstResearchTopics.ScrollAlwaysVisible = true;
            this.lstResearchTopics.Size = new System.Drawing.Size(741, 236);
            this.lstResearchTopics.TabIndex = 153;
            this.lstResearchTopics.SelectedIndexChanged += new System.EventHandler(this.lstResearchTopics_SelectedIndexChanged);
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
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = this.rESEARCHPROJECTTableAdapter;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = this.rESEARCHTOPICTableAdapter;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rESEARCHPROJECTTableAdapter
            // 
            this.rESEARCHPROJECTTableAdapter.ClearBeforeFill = true;
            // 
            // rESEARCHPROJECTBindingSource
            // 
            this.rESEARCHPROJECTBindingSource.DataMember = "RESEARCHPROJECT";
            this.rESEARCHPROJECTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // DeleteResearchTopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 645);
            this.Controls.Add(this.txtTopicDescription);
            this.Controls.Add(this.lblTopicDescription);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteResearchTopic);
            this.Controls.Add(this.txtImpact);
            this.Controls.Add(this.txtResearchTopicID);
            this.Controls.Add(this.lblImpact);
            this.Controls.Add(this.lblResearchTopicID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstResearchTopics);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeleteResearchTopicForm";
            this.Text = "DeleteResearchTopicForm";
            this.Load += new System.EventHandler(this.DeleteResearchTopicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHPROJECTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTopicDescription;
        private System.Windows.Forms.Label lblTopicDescription;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteResearchTopic;
        private System.Windows.Forms.TextBox txtImpact;
        private System.Windows.Forms.TextBox txtResearchTopicID;
        private System.Windows.Forms.Label lblImpact;
        private System.Windows.Forms.Label lblResearchTopicID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstResearchTopics;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource rESEARCHTOPICBindingSource;
        private dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter rESEARCHTOPICTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.RESEARCHPROJECTTableAdapter rESEARCHPROJECTTableAdapter;
        private System.Windows.Forms.BindingSource rESEARCHPROJECTBindingSource;
    }
}