
namespace BalhamCollege
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkBox_login = new System.Windows.Forms.CheckBox();
            this.pbLoginButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblForgot = new System.Windows.Forms.Label();
            this.btnCourseAdmin = new System.Windows.Forms.Button();
            this.btnStudentSupport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(448, 386);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(266, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(448, 282);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(266, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // chkBox_login
            // 
            this.chkBox_login.AutoSize = true;
            this.chkBox_login.Location = new System.Drawing.Point(425, 461);
            this.chkBox_login.Name = "chkBox_login";
            this.chkBox_login.Size = new System.Drawing.Size(18, 17);
            this.chkBox_login.TabIndex = 14;
            this.chkBox_login.UseVisualStyleBackColor = true;
            // 
            // pbLoginButton
            // 
            this.pbLoginButton.Image = global::BalhamCollege.Properties.Resources.loginBtn;
            this.pbLoginButton.Location = new System.Drawing.Point(422, 521);
            this.pbLoginButton.Name = "pbLoginButton";
            this.pbLoginButton.Size = new System.Drawing.Size(319, 50);
            this.pbLoginButton.TabIndex = 15;
            this.pbLoginButton.TabStop = false;
            this.pbLoginButton.Click += new System.EventHandler(this.pbLoginButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.BalhamLogin6;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1103, 713);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.BackColor = System.Drawing.Color.White;
            this.lblForgot.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblForgot.Location = new System.Drawing.Point(468, 490);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(289, 17);
            this.lblForgot.TabIndex = 19;
            this.lblForgot.Text = "Forgot your username or password, click here";
            this.lblForgot.Click += new System.EventHandler(this.lblForgot_Click);
            // 
            // btnCourseAdmin
            // 
            this.btnCourseAdmin.Location = new System.Drawing.Point(873, 192);
            this.btnCourseAdmin.Name = "btnCourseAdmin";
            this.btnCourseAdmin.Size = new System.Drawing.Size(150, 40);
            this.btnCourseAdmin.TabIndex = 20;
            this.btnCourseAdmin.Text = "Course Admin";
            this.btnCourseAdmin.UseVisualStyleBackColor = true;
            this.btnCourseAdmin.Click += new System.EventHandler(this.btnCourseAdmin_Click);
            // 
            // btnStudentSupport
            // 
            this.btnStudentSupport.Location = new System.Drawing.Point(873, 238);
            this.btnStudentSupport.Name = "btnStudentSupport";
            this.btnStudentSupport.Size = new System.Drawing.Size(150, 40);
            this.btnStudentSupport.TabIndex = 21;
            this.btnStudentSupport.Text = "Student Support";
            this.btnStudentSupport.UseVisualStyleBackColor = true;
            this.btnStudentSupport.Click += new System.EventHandler(this.btnStudentSupport_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1094, 671);
            this.Controls.Add(this.btnStudentSupport);
            this.Controls.Add(this.btnCourseAdmin);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.pbLoginButton);
            this.Controls.Add(this.chkBox_login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox chkBox_login;
        private System.Windows.Forms.PictureBox pbLoginButton;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Button btnCourseAdmin;
        private System.Windows.Forms.Button btnStudentSupport;
    }
}

