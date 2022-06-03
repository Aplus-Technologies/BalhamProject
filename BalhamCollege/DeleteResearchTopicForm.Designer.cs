
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
            this.SuspendLayout();
            // 
            // txtTopicDescription
            // 
            this.txtTopicDescription.Location = new System.Drawing.Point(218, 254);
            this.txtTopicDescription.Name = "txtTopicDescription";
            this.txtTopicDescription.Size = new System.Drawing.Size(244, 26);
            this.txtTopicDescription.TabIndex = 162;
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Location = new System.Drawing.Point(88, 257);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(135, 20);
            this.lblTopicDescription.TabIndex = 161;
            this.lblTopicDescription.Text = "Topic Description:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(486, 337);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(157, 42);
            this.btnReturn.TabIndex = 160;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnDeleteResearchTopic
            // 
            this.btnDeleteResearchTopic.Location = new System.Drawing.Point(39, 337);
            this.btnDeleteResearchTopic.Name = "btnDeleteResearchTopic";
            this.btnDeleteResearchTopic.Size = new System.Drawing.Size(188, 42);
            this.btnDeleteResearchTopic.TabIndex = 159;
            this.btnDeleteResearchTopic.Text = "Delete Research Topic";
            this.btnDeleteResearchTopic.UseVisualStyleBackColor = true;
            // 
            // txtImpact
            // 
            this.txtImpact.Location = new System.Drawing.Point(218, 286);
            this.txtImpact.Name = "txtImpact";
            this.txtImpact.Size = new System.Drawing.Size(22, 26);
            this.txtImpact.TabIndex = 158;
            // 
            // txtResearchTopicID
            // 
            this.txtResearchTopicID.Location = new System.Drawing.Point(218, 222);
            this.txtResearchTopicID.Name = "txtResearchTopicID";
            this.txtResearchTopicID.Size = new System.Drawing.Size(38, 26);
            this.txtResearchTopicID.TabIndex = 157;
            // 
            // lblImpact
            // 
            this.lblImpact.AutoSize = true;
            this.lblImpact.Location = new System.Drawing.Point(160, 289);
            this.lblImpact.Name = "lblImpact";
            this.lblImpact.Size = new System.Drawing.Size(62, 20);
            this.lblImpact.TabIndex = 156;
            this.lblImpact.Text = "Impact:";
            // 
            // lblResearchTopicID
            // 
            this.lblResearchTopicID.AutoSize = true;
            this.lblResearchTopicID.Location = new System.Drawing.Point(76, 225);
            this.lblResearchTopicID.Name = "lblResearchTopicID";
            this.lblResearchTopicID.Size = new System.Drawing.Size(145, 20);
            this.lblResearchTopicID.TabIndex = 155;
            this.lblResearchTopicID.Text = "Research Topic ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 20);
            this.label1.TabIndex = 154;
            this.label1.Text = "Please select a research topic:";
            // 
            // lstResearchTopics
            // 
            this.lstResearchTopics.FormattingEnabled = true;
            this.lstResearchTopics.ItemHeight = 20;
            this.lstResearchTopics.Location = new System.Drawing.Point(36, 44);
            this.lstResearchTopics.Name = "lstResearchTopics";
            this.lstResearchTopics.Size = new System.Drawing.Size(607, 164);
            this.lstResearchTopics.TabIndex = 153;
            // 
            // DeleteResearchTopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 414);
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
            this.Name = "DeleteResearchTopicForm";
            this.Text = "DeleteResearchTopicForm";
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
    }
}