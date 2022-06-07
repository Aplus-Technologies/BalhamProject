
namespace BalhamCollege
{
    partial class DeleteLecturerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnDeleteLecturer = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.lstLecturers = new System.Windows.Forms.ListBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.lECTURERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECTURERTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.aSSIGNMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aSSIGNMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSIGNMENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSIGNMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Please select a lecturer:";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(514, 275);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(134, 39);
            this.btnReturn.TabIndex = 57;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnDeleteLecturer
            // 
            this.btnDeleteLecturer.Location = new System.Drawing.Point(226, 275);
            this.btnDeleteLecturer.Name = "btnDeleteLecturer";
            this.btnDeleteLecturer.Size = new System.Drawing.Size(159, 39);
            this.btnDeleteLecturer.TabIndex = 56;
            this.btnDeleteLecturer.Text = "Delete Lecturer";
            this.btnDeleteLecturer.UseVisualStyleBackColor = true;
            this.btnDeleteLecturer.Click += new System.EventHandler(this.btnDeleteLecturer_Click);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(322, 213);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(188, 35);
            this.txtCity.TabIndex = 55;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuburb.Location = new System.Drawing.Point(322, 183);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.ReadOnly = true;
            this.txtSuburb.Size = new System.Drawing.Size(188, 35);
            this.txtSuburb.TabIndex = 54;
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreetAddress.Location = new System.Drawing.Point(322, 153);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.ReadOnly = true;
            this.txtStreetAddress.Size = new System.Drawing.Size(327, 35);
            this.txtStreetAddress.TabIndex = 53;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(322, 123);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(188, 35);
            this.txtFirstName.TabIndex = 52;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(322, 92);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(188, 35);
            this.txtLastName.TabIndex = 51;
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLecturerID.Location = new System.Drawing.Point(322, 61);
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.ReadOnly = true;
            this.txtLecturerID.Size = new System.Drawing.Size(33, 35);
            this.txtLecturerID.TabIndex = 50;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(291, 216);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(50, 29);
            this.lblCity.TabIndex = 49;
            this.lblCity.Text = "City:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(269, 186);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(82, 29);
            this.lblSuburb.TabIndex = 48;
            this.lblSuburb.Text = "Suburb:";
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.AutoSize = true;
            this.lblStreetAddress.Location = new System.Drawing.Point(222, 156);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(148, 29);
            this.lblStreetAddress.TabIndex = 47;
            this.lblStreetAddress.Text = "Street Address:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(247, 126);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(113, 29);
            this.lblFirstName.TabIndex = 46;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(247, 95);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(112, 29);
            this.lblLastName.TabIndex = 45;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.Location = new System.Drawing.Point(247, 64);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(114, 29);
            this.lblLecturerID.TabIndex = 44;
            this.lblLecturerID.Text = "Lecturer ID:";
            // 
            // lstLecturers
            // 
            this.lstLecturers.FormattingEnabled = true;
            this.lstLecturers.ItemHeight = 29;
            this.lstLecturers.Location = new System.Drawing.Point(30, 61);
            this.lstLecturers.Name = "lstLecturers";
            this.lstLecturers.Size = new System.Drawing.Size(170, 178);
            this.lstLecturers.TabIndex = 43;
            this.lstLecturers.SelectedIndexChanged += new System.EventHandler(this.lstLecturers_SelectedIndexChanged);
            // 
            // dsBalhamCollegeAzure
            // 
            this.dsBalhamCollegeAzure.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure.EnforceConstraints = false;
            this.dsBalhamCollegeAzure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lECTURERBindingSource
            // 
            this.lECTURERBindingSource.DataMember = "LECTURER";
            this.lECTURERBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // lECTURERTableAdapter
            // 
            this.lECTURERTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ASSESSMENTTableAdapter = null;
            this.tableAdapterManager.ASSIGNMENTTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.COURSETableAdapter = null;
            this.tableAdapterManager.ENROLMENTTableAdapter = null;
            this.tableAdapterManager.ISSUETableAdapter = null;
            this.tableAdapterManager.LECTURERTableAdapter = this.lECTURERTableAdapter;
            this.tableAdapterManager.PROGRAMMETableAdapter = null;
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = null;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = null;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // aSSIGNMENTBindingSource
            // 
            this.aSSIGNMENTBindingSource.DataMember = "ASSIGNMENT";
            this.aSSIGNMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // aSSIGNMENTTableAdapter
            // 
            this.aSSIGNMENTTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteLecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteLecturer);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtSuburb);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblSuburb);
            this.Controls.Add(this.lblStreetAddress);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLecturerID);
            this.Controls.Add(this.lstLecturers);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeleteLecturerForm";
            this.Text = "DeleteLecturerForm";
            this.Load += new System.EventHandler(this.DeleteLecturerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSIGNMENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnDeleteLecturer;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.ListBox lstLecturers;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource lECTURERBindingSource;
        private dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter lECTURERTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource aSSIGNMENTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.ASSIGNMENTTableAdapter aSSIGNMENTTableAdapter;
    }
}