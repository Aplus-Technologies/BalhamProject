
namespace BalhamCollege
{
    partial class HumanResourcesClerkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HumanResourcesClerkForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLecturerReport = new System.Windows.Forms.Button();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.btnUpdateLecturer = new System.Windows.Forms.Button();
            this.btnDeleteLecturer = new System.Windows.Forms.Button();
            this.pbHumanResources = new System.Windows.Forms.PictureBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.lECTURERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECTURERTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.aSSIGNMENTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.ASSIGNMENTTableAdapter();
            this.aSSIGNMENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printLecturers = new System.Drawing.Printing.PrintDocument();
            this.prvLecturers = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbHumanResources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSIGNMENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(30, 454);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(172, 52);
            this.btnReturn.TabIndex = 18;
            this.btnReturn.Text = "Log Out";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLecturerReport
            // 
            this.btnLecturerReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLecturerReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnLecturerReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLecturerReport.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturerReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLecturerReport.Location = new System.Drawing.Point(30, 396);
            this.btnLecturerReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnLecturerReport.Name = "btnLecturerReport";
            this.btnLecturerReport.Size = new System.Drawing.Size(172, 54);
            this.btnLecturerReport.TabIndex = 17;
            this.btnLecturerReport.Text = "Produce Lecturers Report";
            this.btnLecturerReport.UseVisualStyleBackColor = false;
            this.btnLecturerReport.Click += new System.EventHandler(this.btnLecturerReport_Click);
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnAddLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLecturer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLecturer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddLecturer.Location = new System.Drawing.Point(30, 228);
            this.btnAddLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(172, 53);
            this.btnAddLecturer.TabIndex = 16;
            this.btnAddLecturer.Text = "Add Lecturer";
            this.btnAddLecturer.UseVisualStyleBackColor = false;
            this.btnAddLecturer.Click += new System.EventHandler(this.btnAddLecturer_Click);
            // 
            // btnUpdateLecturer
            // 
            this.btnUpdateLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnUpdateLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLecturer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateLecturer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateLecturer.Location = new System.Drawing.Point(30, 285);
            this.btnUpdateLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateLecturer.Name = "btnUpdateLecturer";
            this.btnUpdateLecturer.Size = new System.Drawing.Size(172, 55);
            this.btnUpdateLecturer.TabIndex = 15;
            this.btnUpdateLecturer.Text = "Update Lecturer";
            this.btnUpdateLecturer.UseVisualStyleBackColor = false;
            this.btnUpdateLecturer.Click += new System.EventHandler(this.btnUpdateLecturer_Click);
            // 
            // btnDeleteLecturer
            // 
            this.btnDeleteLecturer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLecturer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnDeleteLecturer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteLecturer.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLecturer.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteLecturer.Location = new System.Drawing.Point(30, 344);
            this.btnDeleteLecturer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteLecturer.Name = "btnDeleteLecturer";
            this.btnDeleteLecturer.Size = new System.Drawing.Size(172, 48);
            this.btnDeleteLecturer.TabIndex = 14;
            this.btnDeleteLecturer.Text = "Delete Lecturer";
            this.btnDeleteLecturer.UseVisualStyleBackColor = false;
            this.btnDeleteLecturer.Click += new System.EventHandler(this.btnDeleteLecturer_Click);
            // 
            // pbHumanResources
            // 
            this.pbHumanResources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHumanResources.Image = global::BalhamCollege.Properties.Resources.HumanResClerk1980x1080;
            this.pbHumanResources.Location = new System.Drawing.Point(0, -2);
            this.pbHumanResources.Name = "pbHumanResources";
            this.pbHumanResources.Size = new System.Drawing.Size(979, 586);
            this.pbHumanResources.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHumanResources.TabIndex = 19;
            this.pbHumanResources.TabStop = false;
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
            this.tableAdapterManager.ASSIGNMENTTableAdapter = this.aSSIGNMENTTableAdapter;
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
            // aSSIGNMENTTableAdapter
            // 
            this.aSSIGNMENTTableAdapter.ClearBeforeFill = true;
            // 
            // aSSIGNMENTBindingSource
            // 
            this.aSSIGNMENTBindingSource.DataMember = "ASSIGNMENT";
            this.aSSIGNMENTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // printLecturers
            // 
            this.printLecturers.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printLecturers_PrintPage);
            // 
            // prvLecturers
            // 
            this.prvLecturers.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvLecturers.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvLecturers.ClientSize = new System.Drawing.Size(400, 300);
            this.prvLecturers.Document = this.printLecturers;
            this.prvLecturers.Enabled = true;
            this.prvLecturers.Icon = ((System.Drawing.Icon)(resources.GetObject("prvLecturers.Icon")));
            this.prvLecturers.Name = "prvLecturers";
            this.prvLecturers.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(30, 510);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 48);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // HumanResourcesClerkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(969, 580);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLecturerReport);
            this.Controls.Add(this.btnAddLecturer);
            this.Controls.Add(this.btnUpdateLecturer);
            this.Controls.Add(this.btnDeleteLecturer);
            this.Controls.Add(this.pbHumanResources);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HumanResourcesClerkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Human Resources Clerk Menu";
            this.Load += new System.EventHandler(this.HumanResourcesClerkForm_Load);
            this.Resize += new System.EventHandler(this.HumanResourcesClerkForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbHumanResources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aSSIGNMENTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLecturerReport;
        private System.Windows.Forms.Button btnAddLecturer;
        private System.Windows.Forms.Button btnUpdateLecturer;
        private System.Windows.Forms.Button btnDeleteLecturer;
        private System.Windows.Forms.PictureBox pbHumanResources;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource lECTURERBindingSource;
        private dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter lECTURERTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.ASSIGNMENTTableAdapter aSSIGNMENTTableAdapter;
        private System.Windows.Forms.BindingSource aSSIGNMENTBindingSource;
        private System.Drawing.Printing.PrintDocument printLecturers;
        private System.Windows.Forms.PrintPreviewDialog prvLecturers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
    }
}