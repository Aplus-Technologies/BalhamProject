
namespace BalhamCollege
{
    partial class Login3Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login3Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkBox_login = new System.Windows.Forms.CheckBox();
            this.btnLogin3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.BalhamLogin6;
            this.pictureBox1.Location = new System.Drawing.Point(-17, -42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1118, 717);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Location = new System.Drawing.Point(426, 282);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(287, 13);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(426, 386);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(287, 13);
            this.txtPassword.TabIndex = 2;
            // 
            // chkBox_login
            // 
            this.chkBox_login.AutoSize = true;
            this.chkBox_login.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chkBox_login.Location = new System.Drawing.Point(411, 457);
            this.chkBox_login.Name = "chkBox_login";
            this.chkBox_login.Size = new System.Drawing.Size(15, 14);
            this.chkBox_login.TabIndex = 3;
            this.chkBox_login.UseVisualStyleBackColor = false;
            // 
            // btnLogin3
            // 
            this.btnLogin3.Image = global::BalhamCollege.Properties.Resources.btnLogin;
            this.btnLogin3.Location = new System.Drawing.Point(387, 504);
            this.btnLogin3.Name = "btnLogin3";
            this.btnLogin3.Size = new System.Drawing.Size(353, 78);
            this.btnLogin3.TabIndex = 4;
            this.btnLogin3.TabStop = false;
            // 
            // Login3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1093, 666);
            this.Controls.Add(this.btnLogin3);
            this.Controls.Add(this.chkBox_login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login3Form";
            this.Text = "Login3Trial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogin3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkBox_login;
        private System.Windows.Forms.PictureBox btnLogin3;
    }
}