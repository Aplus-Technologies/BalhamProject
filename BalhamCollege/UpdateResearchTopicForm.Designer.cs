
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateResearchTopicForm));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTopicID
            // 
            this.txtTopicID.Location = new System.Drawing.Point(157, 238);
            this.txtTopicID.MaxLength = 2;
            this.txtTopicID.Name = "txtTopicID";
            this.txtTopicID.ReadOnly = true;
            this.txtTopicID.Size = new System.Drawing.Size(19, 26);
            this.txtTopicID.TabIndex = 112;
            // 
            // lstResearchTopics
            // 
            this.lstResearchTopics.FormattingEnabled = true;
            this.lstResearchTopics.HorizontalScrollbar = true;
            this.lstResearchTopics.ItemHeight = 20;
            this.lstResearchTopics.Location = new System.Drawing.Point(30, 51);
            this.lstResearchTopics.Name = "lstResearchTopics";
            this.lstResearchTopics.Size = new System.Drawing.Size(489, 144);
            this.lstResearchTopics.TabIndex = 111;
            this.lstResearchTopics.SelectedIndexChanged += new System.EventHandler(this.lstResearchTopics_SelectedIndexChanged);
            this.lstResearchTopics.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstResearchTopics_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(94, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 110;
            this.label1.Text = "*";
            // 
            // txtTopicDescription
            // 
            this.txtTopicDescription.Location = new System.Drawing.Point(157, 273);
            this.txtTopicDescription.MaxLength = 100;
            this.txtTopicDescription.Multiline = true;
            this.txtTopicDescription.Name = "txtTopicDescription";
            this.txtTopicDescription.Size = new System.Drawing.Size(362, 52);
            this.txtTopicDescription.TabIndex = 113;
            // 
            // lblImpact
            // 
            this.lblImpact.AutoSize = true;
            this.lblImpact.Location = new System.Drawing.Point(107, 338);
            this.lblImpact.Name = "lblImpact";
            this.lblImpact.Size = new System.Drawing.Size(52, 20);
            this.lblImpact.TabIndex = 107;
            this.lblImpact.Text = "Impact:";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl8.Location = new System.Drawing.Point(29, 276);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(14, 20);
            this.lbl8.TabIndex = 106;
            this.lbl8.Text = "*";
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequiredFields.Location = new System.Drawing.Point(393, 388);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(105, 20);
            this.lblRequiredFields.TabIndex = 105;
            this.lblRequiredFields.Text = "*Required fields";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.Location = new System.Drawing.Point(372, 417);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(147, 40);
            this.btnReturn.TabIndex = 116;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateTopic
            // 
            this.btnUpdateTopic.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateTopic.Location = new System.Drawing.Point(157, 417);
            this.btnUpdateTopic.Name = "btnUpdateTopic";
            this.btnUpdateTopic.Size = new System.Drawing.Size(147, 40);
            this.btnUpdateTopic.TabIndex = 115;
            this.btnUpdateTopic.Text = "Update Topic";
            this.btnUpdateTopic.UseVisualStyleBackColor = false;
            this.btnUpdateTopic.Click += new System.EventHandler(this.btnUpdateTopic_Click);
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Location = new System.Drawing.Point(42, 276);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(117, 20);
            this.lblTopicDescription.TabIndex = 102;
            this.lblTopicDescription.Text = "Topic Description:";
            // 
            // lblTopicID
            // 
            this.lblTopicID.AutoSize = true;
            this.lblTopicID.Location = new System.Drawing.Point(97, 241);
            this.lblTopicID.Name = "lblTopicID";
            this.lblTopicID.Size = new System.Drawing.Size(62, 20);
            this.lblTopicID.TabIndex = 101;
            this.lblTopicID.Text = "Topic ID:";
            // 
            // lblSelectResearchTopic
            // 
            this.lblSelectResearchTopic.AutoSize = true;
            this.lblSelectResearchTopic.Location = new System.Drawing.Point(33, 28);
            this.lblSelectResearchTopic.Name = "lblSelectResearchTopic";
            this.lblSelectResearchTopic.Size = new System.Drawing.Size(195, 20);
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
            this.cboImpact.Location = new System.Drawing.Point(157, 334);
            this.cboImpact.MaxLength = 6;
            this.cboImpact.Name = "cboImpact";
            this.cboImpact.Size = new System.Drawing.Size(71, 28);
            this.cboImpact.TabIndex = 114;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(473, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateResearchTopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 480);
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
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UpdateResearchTopicForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Research Topic";
            this.Load += new System.EventHandler(this.UpdateResearchTopicForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}