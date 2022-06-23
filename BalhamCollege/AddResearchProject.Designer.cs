
namespace BalhamCollege
{
    partial class AddResearchProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddResearchProject));
            this.lstLecturers = new System.Windows.Forms.ListBox();
            this.lblLecturers = new System.Windows.Forms.Label();
            this.lblResearchTopic = new System.Windows.Forms.Label();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblResearchProjects = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblResearchProjectDescription = new System.Windows.Forms.Label();
            this.dgvResearchTopics = new System.Windows.Forms.DataGridView();
            this.btnAddResearchProject = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.dgvResearchProjects = new System.Windows.Forms.DataGridView();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtResearchPrjDesc = new System.Windows.Forms.TextBox();
            this.lblRequiredFields = new System.Windows.Forms.Label();
            this.lblAsterix1 = new System.Windows.Forms.Label();
            this.lblAsterix2 = new System.Windows.Forms.Label();
            this.lblAsterix3 = new System.Windows.Forms.Label();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.lECTURERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECTURERTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.rESEARCHPROJECTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESEARCHPROJECTTableAdapter();
            this.rESEARCHTOPICTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter();
            this.rESEARCHTOPICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESEARCHPROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResearchTopics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResearchProjects)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHPROJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstLecturers
            // 
            this.lstLecturers.FormattingEnabled = true;
            this.lstLecturers.HorizontalScrollbar = true;
            this.lstLecturers.ItemHeight = 20;
            this.lstLecturers.Location = new System.Drawing.Point(9, 41);
            this.lstLecturers.Name = "lstLecturers";
            this.lstLecturers.ScrollAlwaysVisible = true;
            this.lstLecturers.Size = new System.Drawing.Size(663, 184);
            this.lstLecturers.TabIndex = 0;
            this.lstLecturers.SelectedIndexChanged += new System.EventHandler(this.lstLecturers_SelectedIndexChanged);
            // 
            // lblLecturers
            // 
            this.lblLecturers.AutoSize = true;
            this.lblLecturers.Location = new System.Drawing.Point(20, 9);
            this.lblLecturers.Name = "lblLecturers";
            this.lblLecturers.Size = new System.Drawing.Size(154, 20);
            this.lblLecturers.TabIndex = 12;
            this.lblLecturers.Text = "Please select a lecturer:";
            // 
            // lblResearchTopic
            // 
            this.lblResearchTopic.AutoSize = true;
            this.lblResearchTopic.Location = new System.Drawing.Point(677, 9);
            this.lblResearchTopic.Name = "lblResearchTopic";
            this.lblResearchTopic.Size = new System.Drawing.Size(195, 20);
            this.lblResearchTopic.TabIndex = 18;
            this.lblResearchTopic.Text = "Please select a research topic:";
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.Location = new System.Drawing.Point(20, 246);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(77, 20);
            this.lblLecturerID.TabIndex = 13;
            this.lblLecturerID.Text = "Lecturer ID:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(21, 279);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 20);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(316, 281);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 20);
            this.lblFirstName.TabIndex = 15;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(351, 246);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "Type:";
            // 
            // lblResearchProjects
            // 
            this.lblResearchProjects.AutoSize = true;
            this.lblResearchProjects.Location = new System.Drawing.Point(20, 318);
            this.lblResearchProjects.Name = "lblResearchProjects";
            this.lblResearchProjects.Size = new System.Drawing.Size(123, 20);
            this.lblResearchProjects.TabIndex = 17;
            this.lblResearchProjects.Text = "Research Projects:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(708, 404);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(51, 20);
            this.lblOutput.TabIndex = 19;
            this.lblOutput.Text = "Output:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(689, 357);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(70, 20);
            this.lblStartDate.TabIndex = 21;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblResearchProjectDescription
            // 
            this.lblResearchProjectDescription.AutoSize = true;
            this.lblResearchProjectDescription.Location = new System.Drawing.Point(970, 332);
            this.lblResearchProjectDescription.Name = "lblResearchProjectDescription";
            this.lblResearchProjectDescription.Size = new System.Drawing.Size(185, 20);
            this.lblResearchProjectDescription.TabIndex = 23;
            this.lblResearchProjectDescription.Text = "Research project description:";
            // 
            // dgvResearchTopics
            // 
            this.dgvResearchTopics.AllowUserToAddRows = false;
            this.dgvResearchTopics.AllowUserToDeleteRows = false;
            this.dgvResearchTopics.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResearchTopics.ColumnHeadersHeight = 29;
            this.dgvResearchTopics.Location = new System.Drawing.Point(681, 41);
            this.dgvResearchTopics.Name = "dgvResearchTopics";
            this.dgvResearchTopics.ReadOnly = true;
            this.dgvResearchTopics.RowHeadersVisible = false;
            this.dgvResearchTopics.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvResearchTopics.RowTemplate.Height = 24;
            this.dgvResearchTopics.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResearchTopics.Size = new System.Drawing.Size(540, 262);
            this.dgvResearchTopics.TabIndex = 6;
            this.dgvResearchTopics.SelectionChanged += new System.EventHandler(this.dgvResearchTopics_SelectionChanged);
            // 
            // btnAddResearchProject
            // 
            this.btnAddResearchProject.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddResearchProject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddResearchProject.Location = new System.Drawing.Point(710, 473);
            this.btnAddResearchProject.Name = "btnAddResearchProject";
            this.btnAddResearchProject.Size = new System.Drawing.Size(167, 40);
            this.btnAddResearchProject.TabIndex = 10;
            this.btnAddResearchProject.Text = "Add Research Project";
            this.btnAddResearchProject.UseVisualStyleBackColor = false;
            this.btnAddResearchProject.Click += new System.EventHandler(this.btnAddResearchProject_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.Location = new System.Drawing.Point(1054, 476);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(167, 40);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Location = new System.Drawing.Point(92, 245);
            this.txtLecturerID.MaxLength = 4;
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.ReadOnly = true;
            this.txtLecturerID.Size = new System.Drawing.Size(36, 26);
            this.txtLecturerID.TabIndex = 1;
            // 
            // dgvResearchProjects
            // 
            this.dgvResearchProjects.AllowUserToAddRows = false;
            this.dgvResearchProjects.AllowUserToDeleteRows = false;
            this.dgvResearchProjects.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvResearchProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResearchProjects.Location = new System.Drawing.Point(9, 341);
            this.dgvResearchProjects.Name = "dgvResearchProjects";
            this.dgvResearchProjects.ReadOnly = true;
            this.dgvResearchProjects.RowHeadersVisible = false;
            this.dgvResearchProjects.RowHeadersWidth = 51;
            this.dgvResearchProjects.RowTemplate.Height = 24;
            this.dgvResearchProjects.Size = new System.Drawing.Size(663, 172);
            this.dgvResearchProjects.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(92, 277);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(219, 26);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(388, 279);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(219, 26);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(390, 245);
            this.txtType.MaxLength = 8;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(72, 26);
            this.txtType.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(755, 355);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(107, 26);
            this.dtpStartDate.TabIndex = 8;
            this.dtpStartDate.Value = new System.DateTime(2022, 6, 8, 0, 0, 0, 0);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(755, 398);
            this.txtOutput.MaxLength = 30;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(219, 26);
            this.txtOutput.TabIndex = 7;
            // 
            // txtResearchPrjDesc
            // 
            this.txtResearchPrjDesc.Location = new System.Drawing.Point(985, 355);
            this.txtResearchPrjDesc.MaxLength = 100;
            this.txtResearchPrjDesc.Multiline = true;
            this.txtResearchPrjDesc.Name = "txtResearchPrjDesc";
            this.txtResearchPrjDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResearchPrjDesc.Size = new System.Drawing.Size(236, 95);
            this.txtResearchPrjDesc.TabIndex = 9;
            // 
            // lblRequiredFields
            // 
            this.lblRequiredFields.AutoSize = true;
            this.lblRequiredFields.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequiredFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRequiredFields.Location = new System.Drawing.Point(1080, 453);
            this.lblRequiredFields.Name = "lblRequiredFields";
            this.lblRequiredFields.Size = new System.Drawing.Size(110, 20);
            this.lblRequiredFields.TabIndex = 25;
            this.lblRequiredFields.Text = "*Required Fields";
            // 
            // lblAsterix1
            // 
            this.lblAsterix1.AutoSize = true;
            this.lblAsterix1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAsterix1.Location = new System.Drawing.Point(678, 349);
            this.lblAsterix1.Name = "lblAsterix1";
            this.lblAsterix1.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix1.TabIndex = 20;
            this.lblAsterix1.Text = "*";
            // 
            // lblAsterix2
            // 
            this.lblAsterix2.AutoSize = true;
            this.lblAsterix2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAsterix2.Location = new System.Drawing.Point(958, 332);
            this.lblAsterix2.Name = "lblAsterix2";
            this.lblAsterix2.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix2.TabIndex = 22;
            this.lblAsterix2.Text = "*";
            // 
            // lblAsterix3
            // 
            this.lblAsterix3.AutoSize = true;
            this.lblAsterix3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterix3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAsterix3.Location = new System.Drawing.Point(697, 398);
            this.lblAsterix3.Name = "lblAsterix3";
            this.lblAsterix3.Size = new System.Drawing.Size(14, 18);
            this.lblAsterix3.TabIndex = 24;
            this.lblAsterix3.Text = "*";
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
            this.tableAdapterManager.RESEARCHPROJECTTableAdapter = this.rESEARCHPROJECTTableAdapter;
            this.tableAdapterManager.RESEARCHTOPICTableAdapter = this.rESEARCHTOPICTableAdapter;
            this.tableAdapterManager.RESULTTableAdapter = null;
            this.tableAdapterManager.STUDENTTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // rESEARCHPROJECTTableAdapter
            // 
            this.rESEARCHPROJECTTableAdapter.ClearBeforeFill = true;
            // 
            // rESEARCHTOPICTableAdapter
            // 
            this.rESEARCHTOPICTableAdapter.ClearBeforeFill = true;
            // 
            // rESEARCHTOPICBindingSource
            // 
            this.rESEARCHTOPICBindingSource.DataMember = "RESEARCHTOPIC";
            this.rESEARCHTOPICBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // rESEARCHPROJECTBindingSource
            // 
            this.rESEARCHPROJECTBindingSource.DataMember = "RESEARCHPROJECT";
            this.rESEARCHPROJECTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(1204, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 89);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // AddResearchProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 528);
            this.ControlBox = false;
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblResearchProjectDescription);
            this.Controls.Add(this.lblRequiredFields);
            this.Controls.Add(this.txtResearchPrjDesc);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.dgvResearchProjects);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddResearchProject);
            this.Controls.Add(this.dgvResearchTopics);
            this.Controls.Add(this.lblResearchProjects);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLecturerID);
            this.Controls.Add(this.lblResearchTopic);
            this.Controls.Add(this.lblLecturers);
            this.Controls.Add(this.lstLecturers);
            this.Controls.Add(this.lblAsterix3);
            this.Controls.Add(this.lblAsterix2);
            this.Controls.Add(this.lblAsterix1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddResearchProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Research Project";
            this.Load += new System.EventHandler(this.AddResearchProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResearchTopics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResearchProjects)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHPROJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstLecturers;
        private System.Windows.Forms.Label lblLecturers;
        private System.Windows.Forms.Label lblResearchTopic;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblResearchProjects;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblResearchProjectDescription;
        private System.Windows.Forms.DataGridView dgvResearchTopics;
        private System.Windows.Forms.Button btnAddResearchProject;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.DataGridView dgvResearchProjects;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtResearchPrjDesc;
        private System.Windows.Forms.Label lblRequiredFields;
        private System.Windows.Forms.Label lblAsterix1;
        private System.Windows.Forms.Label lblAsterix2;
        private System.Windows.Forms.Label lblAsterix3;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource lECTURERBindingSource;
        private dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter lECTURERTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter rESEARCHTOPICTableAdapter;
        private System.Windows.Forms.BindingSource rESEARCHTOPICBindingSource;
        private dsBalhamCollegeAzureTableAdapters.RESEARCHPROJECTTableAdapter rESEARCHPROJECTTableAdapter;
        private System.Windows.Forms.BindingSource rESEARCHPROJECTBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}