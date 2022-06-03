
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
            this.SuspendLayout();
            // 
            // txtProgrammeName
            // 
            this.txtProgrammeName.Location = new System.Drawing.Point(219, 260);
            this.txtProgrammeName.Name = "txtProgrammeName";
            this.txtProgrammeName.Size = new System.Drawing.Size(244, 26);
            this.txtProgrammeName.TabIndex = 152;
            // 
            // lblProgrammeName
            // 
            this.lblProgrammeName.AutoSize = true;
            this.lblProgrammeName.Location = new System.Drawing.Point(75, 263);
            this.lblProgrammeName.Name = "lblProgrammeName";
            this.lblProgrammeName.Size = new System.Drawing.Size(141, 20);
            this.lblProgrammeName.TabIndex = 151;
            this.lblProgrammeName.Text = "Programme Name:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(487, 343);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(157, 42);
            this.btnReturn.TabIndex = 150;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProgramme
            // 
            this.btnDeleteProgramme.Location = new System.Drawing.Point(40, 343);
            this.btnDeleteProgramme.Name = "btnDeleteProgramme";
            this.btnDeleteProgramme.Size = new System.Drawing.Size(188, 42);
            this.btnDeleteProgramme.TabIndex = 149;
            this.btnDeleteProgramme.Text = "Delete Programme";
            this.btnDeleteProgramme.UseVisualStyleBackColor = true;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(219, 292);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(22, 26);
            this.txtLevel.TabIndex = 148;
            // 
            // txtProgrammeID
            // 
            this.txtProgrammeID.Location = new System.Drawing.Point(219, 228);
            this.txtProgrammeID.Name = "txtProgrammeID";
            this.txtProgrammeID.Size = new System.Drawing.Size(38, 26);
            this.txtProgrammeID.TabIndex = 147;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(172, 295);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(50, 20);
            this.lblLevel.TabIndex = 146;
            this.lblLevel.Text = "Level:";
            // 
            // lblProgrammeID
            // 
            this.lblProgrammeID.AutoSize = true;
            this.lblProgrammeID.Location = new System.Drawing.Point(107, 231);
            this.lblProgrammeID.Name = "lblProgrammeID";
            this.lblProgrammeID.Size = new System.Drawing.Size(116, 20);
            this.lblProgrammeID.TabIndex = 145;
            this.lblProgrammeID.Text = "Programme ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 144;
            this.label1.Text = "Please select a programme:";
            // 
            // lstProgrammes
            // 
            this.lstProgrammes.FormattingEnabled = true;
            this.lstProgrammes.ItemHeight = 20;
            this.lstProgrammes.Location = new System.Drawing.Point(37, 50);
            this.lstProgrammes.Name = "lstProgrammes";
            this.lstProgrammes.Size = new System.Drawing.Size(607, 164);
            this.lstProgrammes.TabIndex = 143;
            // 
            // DeleteProgrammeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 422);
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
            this.Name = "DeleteProgrammeForm";
            this.Text = "DeleteProgrammeForm";
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
    }
}