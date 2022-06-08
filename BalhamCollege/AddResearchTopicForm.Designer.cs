
namespace BalhamCollege
{
    partial class AddResearchTopicForm
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
            this.lblResTopicDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResearchTopicDesc = new System.Windows.Forms.TextBox();
            this.cboImpact = new System.Windows.Forms.ComboBox();
            this.btnAddResearchTopic = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lblAsterix1 = new System.Windows.Forms.Label();
            this.lblAsterix2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResTopicDesc
            // 
            this.lblResTopicDesc.AutoSize = true;
            this.lblResTopicDesc.Location = new System.Drawing.Point(69, 75);
            this.lblResTopicDesc.Name = "lblResTopicDesc";
            this.lblResTopicDesc.Size = new System.Drawing.Size(256, 23);
            this.lblResTopicDesc.TabIndex = 0;
            this.lblResTopicDesc.Text = "Research Topic Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Impact:";
            // 
            // txtResearchTopicDesc
            // 
            this.txtResearchTopicDesc.Location = new System.Drawing.Point(331, 75);
            this.txtResearchTopicDesc.MaxLength = 100;
            this.txtResearchTopicDesc.Multiline = true;
            this.txtResearchTopicDesc.Name = "txtResearchTopicDesc";
            this.txtResearchTopicDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResearchTopicDesc.Size = new System.Drawing.Size(542, 82);
            this.txtResearchTopicDesc.TabIndex = 2;
            // 
            // cboImpact
            // 
            this.cboImpact.FormattingEnabled = true;
            this.cboImpact.Items.AddRange(new object[] {
            "High",
            "Medium",
            "Low"});
            this.cboImpact.Location = new System.Drawing.Point(331, 176);
            this.cboImpact.Name = "cboImpact";
            this.cboImpact.Size = new System.Drawing.Size(152, 31);
            this.cboImpact.TabIndex = 3;
            // 
            // btnAddResearchTopic
            // 
            this.btnAddResearchTopic.Location = new System.Drawing.Point(73, 282);
            this.btnAddResearchTopic.Name = "btnAddResearchTopic";
            this.btnAddResearchTopic.Size = new System.Drawing.Size(213, 48);
            this.btnAddResearchTopic.TabIndex = 4;
            this.btnAddResearchTopic.Text = "Add Research Topic";
            this.btnAddResearchTopic.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(660, 282);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(213, 48);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.Red;
            this.lblRequiredFields.Location = new System.Drawing.Point(716, 220);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(157, 24);
            this.lblRequiredFields.TabIndex = 28;
            this.lblRequiredFields.Text = "*Required Fields";
            // 
            // lblAsterix1
            // 
            this.lblAsterix1.AutoSize = true;
            this.lblAsterix1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix1.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix1.Location = new System.Drawing.Point(52, 61);
            this.lblAsterix1.Name = "lblAsterix1";
            this.lblAsterix1.Size = new System.Drawing.Size(21, 24);
            this.lblAsterix1.TabIndex = 29;
            this.lblAsterix1.Text = "*";
            // 
            // lblAsterix2
            // 
            this.lblAsterix2.AutoSize = true;
            this.lblAsterix2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix2.ForeColor = System.Drawing.Color.Red;
            this.lblAsterix2.Location = new System.Drawing.Point(232, 165);
            this.lblAsterix2.Name = "lblAsterix2";
            this.lblAsterix2.Size = new System.Drawing.Size(21, 24);
            this.lblAsterix2.TabIndex = 30;
            this.lblAsterix2.Text = "*";
            // 
            // AddResearchTopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 378);
            this.Controls.Add(this.lblAsterix2);
            this.Controls.Add(this.lblAsterix1);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddResearchTopic);
            this.Controls.Add(this.cboImpact);
            this.Controls.Add(this.txtResearchTopicDesc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResTopicDesc);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddResearchTopicForm";
            this.Text = "AddResearchTopicForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResTopicDesc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResearchTopicDesc;
        private System.Windows.Forms.ComboBox cboImpact;
        private System.Windows.Forms.Button btnAddResearchTopic;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblAsterix1;
        private System.Windows.Forms.Label lblAsterix2;
    }
}