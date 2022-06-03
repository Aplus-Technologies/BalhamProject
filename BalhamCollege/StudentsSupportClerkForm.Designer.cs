
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnProduceIssuesReport = new System.Windows.Forms.Button();
            this.btnRecordIssue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(308, 276);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(161, 56);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnProduceIssuesReport
            // 
            this.btnProduceIssuesReport.Location = new System.Drawing.Point(434, 118);
            this.btnProduceIssuesReport.Name = "btnProduceIssuesReport";
            this.btnProduceIssuesReport.Size = new System.Drawing.Size(200, 60);
            this.btnProduceIssuesReport.TabIndex = 34;
            this.btnProduceIssuesReport.Text = "Produce Issues Report";
            this.btnProduceIssuesReport.UseVisualStyleBackColor = true;
            this.btnProduceIssuesReport.Click += new System.EventHandler(this.btnProduceIssuesReport_Click);
            // 
            // btnRecordIssue
            // 
            this.btnRecordIssue.Location = new System.Drawing.Point(167, 118);
            this.btnRecordIssue.Name = "btnRecordIssue";
            this.btnRecordIssue.Size = new System.Drawing.Size(200, 60);
            this.btnRecordIssue.TabIndex = 33;
            this.btnRecordIssue.Text = "Record Issue";
            this.btnRecordIssue.UseVisualStyleBackColor = true;
            this.btnRecordIssue.Click += new System.EventHandler(this.btnRecordIssue_Click);
            // 
            // StudentsSupportClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnProduceIssuesReport);
            this.Controls.Add(this.btnRecordIssue);
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