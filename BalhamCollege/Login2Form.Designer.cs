
namespace BalhamCollege
{
    partial class Login2Form
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
            this.chkBoxSignIn = new System.Windows.Forms.CheckBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbLoginButton = new System.Windows.Forms.PictureBox();
            this.pbQuitLogin = new System.Windows.Forms.PictureBox();
            this.pbLogin = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBoxSignIn
            // 
            this.chkBoxSignIn.AutoSize = true;
            this.chkBoxSignIn.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxSignIn.Location = new System.Drawing.Point(389, 499);
            this.chkBoxSignIn.Name = "chkBoxSignIn";
            this.chkBoxSignIn.Size = new System.Drawing.Size(15, 14);
            this.chkBoxSignIn.TabIndex = 1;
            this.chkBoxSignIn.UseVisualStyleBackColor = false;
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Location = new System.Drawing.Point(399, 322);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(288, 20);
            this.txtUserName.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(399, 422);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(288, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(176)))), ((int)(((byte)(201)))));
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.pbLoginButton);
            this.panel1.Controls.Add(this.pbQuitLogin);
            this.panel1.Controls.Add(this.chkBoxSignIn);
            this.panel1.Controls.Add(this.pbLogin);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 710);
            this.panel1.TabIndex = 0;
            // 
            // pbLoginButton
            // 
            this.pbLoginButton.Image = global::BalhamCollege.Properties.Resources.btnLogin;
            this.pbLoginButton.Location = new System.Drawing.Point(362, 547);
            this.pbLoginButton.Name = "pbLoginButton";
            this.pbLoginButton.Size = new System.Drawing.Size(345, 72);
            this.pbLoginButton.TabIndex = 3;
            this.pbLoginButton.TabStop = false;
            // 
            // pbQuitLogin
            // 
            this.pbQuitLogin.Image = global::BalhamCollege.Properties.Resources.buttonQuit3;
            this.pbQuitLogin.Location = new System.Drawing.Point(1025, 0);
            this.pbQuitLogin.Name = "pbQuitLogin";
            this.pbQuitLogin.Size = new System.Drawing.Size(46, 44);
            this.pbQuitLogin.TabIndex = 2;
            this.pbQuitLogin.TabStop = false;
            this.pbQuitLogin.Click += new System.EventHandler(this.pbQuitLogin_Click);
            // 
            // pbLogin
            // 
            this.pbLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(176)))), ((int)(((byte)(201)))));
            this.pbLogin.Image = global::BalhamCollege.Properties.Resources.BalhamLogin6;
            this.pbLogin.Location = new System.Drawing.Point(-59, -14);
            this.pbLogin.Name = "pbLogin";
            this.pbLogin.Size = new System.Drawing.Size(1156, 740);
            this.pbLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogin.TabIndex = 0;
            this.pbLogin.TabStop = false;
            // 
            // Login2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(176)))), ((int)(((byte)(201)))));
            this.ClientSize = new System.Drawing.Size(1076, 717);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login2Form";
            this.Text = "LoginBalhamCollege";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbQuitLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogin;
        private System.Windows.Forms.CheckBox chkBoxSignIn;
        private System.Windows.Forms.PictureBox pbQuitLogin;
        private System.Windows.Forms.PictureBox pbLoginButton;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel1;
    }
}