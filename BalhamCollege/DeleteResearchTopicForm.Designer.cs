
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
            this.txtTopicDescription.Location = new System.Drawing.Point(145, 165);
            this.txtTopicDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtTopicDescription.Name = "txtTopicDescription";
            this.txtTopicDescription.Size = new System.Drawing.Size(284, 20);
            this.txtTopicDescription.TabIndex = 162;
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Location = new System.Drawing.Point(59, 167);
            this.lblTopicDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(93, 13);
            this.lblTopicDescription.TabIndex = 161;
            this.lblTopicDescription.Text = "Topic Description:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(324, 219);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(105, 27);
            this.btnReturn.TabIndex = 160;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteResearchTopic
            // 
            this.btnDeleteResearchTopic.Location = new System.Drawing.Point(26, 219);
            this.btnDeleteResearchTopic.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteResearchTopic.Name = "btnDeleteResearchTopic";
            this.btnDeleteResearchTopic.Size = new System.Drawing.Size(125, 27);
            this.btnDeleteResearchTopic.TabIndex = 159;
            this.btnDeleteResearchTopic.Text = "Delete Research Topic";
            this.btnDeleteResearchTopic.UseVisualStyleBackColor = true;
            this.btnDeleteResearchTopic.Click += new System.EventHandler(this.btnDeleteResearchTopic_Click);
            // 
            // txtImpact
            // 
            this.txtImpact.Location = new System.Drawing.Point(145, 186);
            this.txtImpact.Margin = new System.Windows.Forms.Padding(2);
            this.txtImpact.Name = "txtImpact";
            this.txtImpact.Size = new System.Drawing.Size(66, 20);
            this.txtImpact.TabIndex = 158;
            // 
            // txtResearchTopicID
            // 
            this.txtResearchTopicID.Location = new System.Drawing.Point(145, 144);
            this.txtResearchTopicID.Margin = new System.Windows.Forms.Padding(2);
            this.txtResearchTopicID.Name = "txtResearchTopicID";
            this.txtResearchTopicID.Size = new System.Drawing.Size(44, 20);
            this.txtResearchTopicID.TabIndex = 157;
            // 
            // lblImpact
            // 
            this.lblImpact.AutoSize = true;
            this.lblImpact.Location = new System.Drawing.Point(107, 188);
            this.lblImpact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImpact.Name = "lblImpact";
            this.lblImpact.Size = new System.Drawing.Size(42, 13);
            this.lblImpact.TabIndex = 156;
            this.lblImpact.Text = "Impact:";
            // 
            // lblResearchTopicID
            // 
            this.lblResearchTopicID.AutoSize = true;
            this.lblResearchTopicID.Location = new System.Drawing.Point(51, 146);
            this.lblResearchTopicID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResearchTopicID.Name = "lblResearchTopicID";
            this.lblResearchTopicID.Size = new System.Drawing.Size(100, 13);
            this.lblResearchTopicID.TabIndex = 155;
            this.lblResearchTopicID.Text = "Research Topic ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 154;
            this.label1.Text = "Please select a research topic:";
            // 
            // lstResearchTopics
            // 
            this.lstResearchTopics.FormattingEnabled = true;
            this.lstResearchTopics.Location = new System.Drawing.Point(24, 29);
            this.lstResearchTopics.Margin = new System.Windows.Forms.Padding(2);
            this.lstResearchTopics.Name = "lstResearchTopics";
            this.lstResearchTopics.ScrollAlwaysVisible = true;
            this.lstResearchTopics.Size = new System.Drawing.Size(406, 108);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 289);
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
            this.Margin = new System.Windows.Forms.Padding(2);
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