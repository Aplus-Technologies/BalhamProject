
namespace BalhamCollege
{
    partial class StudentsSupportClerkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsSupportClerkForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnProduceIssuesReport = new System.Windows.Forms.Button();
            this.btnRecordIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(231, 224);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(121, 46);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnProduceIssuesReport
            // 
            this.btnProduceIssuesReport.Location = new System.Drawing.Point(326, 96);
            this.btnProduceIssuesReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduceIssuesReport.Name = "btnProduceIssuesReport";
            this.btnProduceIssuesReport.Size = new System.Drawing.Size(150, 49);
            this.btnProduceIssuesReport.TabIndex = 34;
            this.btnProduceIssuesReport.Text = "Produce Issues Report";
            this.btnProduceIssuesReport.UseVisualStyleBackColor = true;
            this.btnProduceIssuesReport.Click += new System.EventHandler(this.btnProduceIssuesReport_Click);
            // 
            // btnRecordIssue
            // 
            this.btnRecordIssue.Location = new System.Drawing.Point(125, 96);
            this.btnRecordIssue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecordIssue.Name = "btnRecordIssue";
            this.btnRecordIssue.Size = new System.Drawing.Size(150, 49);
            this.btnRecordIssue.TabIndex = 33;
            this.btnRecordIssue.Text = "Record Issue";
            this.btnRecordIssue.UseVisualStyleBackColor = true;
            this.btnRecordIssue.Click += new System.EventHandler(this.btnRecordIssue_Click);
            // 
            // StudentsSupportClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnProduceIssuesReport);
            this.Controls.Add(this.btnRecordIssue);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudentsSupportClerkForm";
            this.Text = "StudentsSupportClerkForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnProduceIssuesReport;
        private System.Windows.Forms.Button btnRecordIssue;
    }
}