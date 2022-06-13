
namespace BalhamCollege
{
    partial class RemoveResearchProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveResearchProjectForm));
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRemoveResearchProject = new System.Windows.Forms.Button();
            this.txtTopicDescription = new System.Windows.Forms.TextBox();
            this.txtProjectDescription = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtResearchProjectID = new System.Windows.Forms.TextBox();
            this.lblTopicDescription = new System.Windows.Forms.Label();
            this.lblProjectDescription = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblResearchProjectID = new System.Windows.Forms.Label();
            this.lstResearchProjects = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtLecturerID = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblLecturerID = new System.Windows.Forms.Label();
            this.lstLecturers = new System.Windows.Forms.ListBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.lECTURERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECTURERTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.rESEARCHPROJECTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESEARCHPROJECTTableAdapter();
            this.rESEARCHTOPICTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter();
            this.rESEARCHPROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESEARCHTOPICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHPROJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 20);
            this.label2.TabIndex = 148;
            this.label2.Text = "Please select a research project:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReturn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReturn.Location = new System.Drawing.Point(622, 500);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(203, 40);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoveResearchProject
            // 
            this.btnRemoveResearchProject.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRemoveResearchProject.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRemoveResearchProject.Location = new System.Drawing.Point(19, 500);
            this.btnRemoveResearchProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveResearchProject.Name = "btnRemoveResearchProject";
            this.btnRemoveResearchProject.Size = new System.Drawing.Size(203, 40);
            this.btnRemoveResearchProject.TabIndex = 3;
            this.btnRemoveResearchProject.Text = "Remove Research Project";
            this.btnRemoveResearchProject.UseVisualStyleBackColor = false;
            this.btnRemoveResearchProject.Click += new System.EventHandler(this.btnRemoveResearchProject_Click);
            // 
            // txtTopicDescription
            // 
            this.txtTopicDescription.Location = new System.Drawing.Point(457, 414);
            this.txtTopicDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtTopicDescription.MaxLength = 100;
            this.txtTopicDescription.Multiline = true;
            this.txtTopicDescription.Name = "txtTopicDescription";
            this.txtTopicDescription.ReadOnly = true;
            this.txtTopicDescription.Size = new System.Drawing.Size(361, 47);
            this.txtTopicDescription.TabIndex = 145;
            // 
            // txtProjectDescription
            // 
            this.txtProjectDescription.Location = new System.Drawing.Point(457, 358);
            this.txtProjectDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtProjectDescription.MaxLength = 100;
            this.txtProjectDescription.Multiline = true;
            this.txtProjectDescription.Name = "txtProjectDescription";
            this.txtProjectDescription.ReadOnly = true;
            this.txtProjectDescription.Size = new System.Drawing.Size(361, 47);
            this.txtProjectDescription.TabIndex = 144;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(457, 323);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.MaxLength = 30;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(214, 26);
            this.txtOutput.TabIndex = 143;
            // 
            // txtResearchProjectID
            // 
            this.txtResearchProjectID.Location = new System.Drawing.Point(457, 288);
            this.txtResearchProjectID.Margin = new System.Windows.Forms.Padding(4);
            this.txtResearchProjectID.MaxLength = 4;
            this.txtResearchProjectID.Name = "txtResearchProjectID";
            this.txtResearchProjectID.ReadOnly = true;
            this.txtResearchProjectID.Size = new System.Drawing.Size(33, 26);
            this.txtResearchProjectID.TabIndex = 142;
            // 
            // lblTopicDescription
            // 
            this.lblTopicDescription.AutoSize = true;
            this.lblTopicDescription.Location = new System.Drawing.Point(343, 417);
            this.lblTopicDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTopicDescription.Name = "lblTopicDescription";
            this.lblTopicDescription.Size = new System.Drawing.Size(117, 20);
            this.lblTopicDescription.TabIndex = 141;
            this.lblTopicDescription.Text = "Topic Description:";
            // 
            // lblProjectDescription
            // 
            this.lblProjectDescription.AutoSize = true;
            this.lblProjectDescription.Location = new System.Drawing.Point(334, 361);
            this.lblProjectDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProjectDescription.Name = "lblProjectDescription";
            this.lblProjectDescription.Size = new System.Drawing.Size(126, 20);
            this.lblProjectDescription.TabIndex = 140;
            this.lblProjectDescription.Text = "Project Description:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(409, 326);
            this.lblOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(51, 20);
            this.lblOutput.TabIndex = 139;
            this.lblOutput.Text = "Output:";
            this.lblOutput.Click += new System.EventHandler(this.lblOutput_Click);
            // 
            // lblResearchProjectID
            // 
            this.lblResearchProjectID.AutoSize = true;
            this.lblResearchProjectID.Location = new System.Drawing.Point(328, 291);
            this.lblResearchProjectID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResearchProjectID.Name = "lblResearchProjectID";
            this.lblResearchProjectID.Size = new System.Drawing.Size(132, 20);
            this.lblResearchProjectID.TabIndex = 138;
            this.lblResearchProjectID.Text = "Research Project ID:";
            // 
            // lstResearchProjects
            // 
            this.lstResearchProjects.FormattingEnabled = true;
            this.lstResearchProjects.HorizontalScrollbar = true;
            this.lstResearchProjects.ItemHeight = 20;
            this.lstResearchProjects.Location = new System.Drawing.Point(380, 54);
            this.lstResearchProjects.Margin = new System.Windows.Forms.Padding(4);
            this.lstResearchProjects.Name = "lstResearchProjects";
            this.lstResearchProjects.Size = new System.Drawing.Size(438, 204);
            this.lstResearchProjects.TabIndex = 2;
            this.lstResearchProjects.SelectedIndexChanged += new System.EventHandler(this.lstResearchProjects_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 136;
            this.label1.Text = "Please select a lecturer:";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(90, 392);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.MaxLength = 8;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(83, 26);
            this.txtType.TabIndex = 135;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(90, 357);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.MaxLength = 30;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(214, 26);
            this.txtFirstName.TabIndex = 134;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(90, 322);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(214, 26);
            this.txtLastName.TabIndex = 133;
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            // 
            // txtLecturerID
            // 
            this.txtLecturerID.Location = new System.Drawing.Point(90, 287);
            this.txtLecturerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLecturerID.MaxLength = 4;
            this.txtLecturerID.Name = "txtLecturerID";
            this.txtLecturerID.ReadOnly = true;
            this.txtLecturerID.Size = new System.Drawing.Size(33, 26);
            this.txtLecturerID.TabIndex = 132;
            this.txtLecturerID.TextChanged += new System.EventHandler(this.txtLecturerID_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(49, 395);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 131;
            this.lblType.Text = "Type:";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(16, 361);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(77, 20);
            this.lblFirstName.TabIndex = 130;
            this.lblFirstName.Text = "First Name:";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(17, 327);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 20);
            this.lblLastName.TabIndex = 129;
            this.lblLastName.Text = "Last Name:";
            this.lblLastName.Click += new System.EventHandler(this.lblLastName_Click);
            // 
            // lblLecturerID
            // 
            this.lblLecturerID.AutoSize = true;
            this.lblLecturerID.Location = new System.Drawing.Point(16, 291);
            this.lblLecturerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLecturerID.Name = "lblLecturerID";
            this.lblLecturerID.Size = new System.Drawing.Size(77, 20);
            this.lblLecturerID.TabIndex = 128;
            this.lblLecturerID.Text = "Lecturer ID:";
            this.lblLecturerID.Click += new System.EventHandler(this.lblLecturerID_Click);
            // 
            // lstLecturers
            // 
            this.lstLecturers.FormattingEnabled = true;
            this.lstLecturers.ItemHeight = 20;
            this.lstLecturers.Location = new System.Drawing.Point(19, 54);
            this.lstLecturers.Margin = new System.Windows.Forms.Padding(4);
            this.lstLecturers.Name = "lstLecturers";
            this.lstLecturers.Size = new System.Drawing.Size(340, 204);
            this.lstLecturers.TabIndex = 1;
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
            // rESEARCHPROJECTBindingSource
            // 
            this.rESEARCHPROJECTBindingSource.DataMember = "RESEARCHPROJECT";
            this.rESEARCHPROJECTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // rESEARCHTOPICBindingSource
            // 
            this.rESEARCHTOPICBindingSource.DataMember = "RESEARCHTOPIC";
            this.rESEARCHTOPICBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(754, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.TabIndex = 149;
            this.pictureBox1.TabStop = false;
            // 
            // RemoveResearchProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 559);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRemoveResearchProject);
            this.Controls.Add(this.txtTopicDescription);
            this.Controls.Add(this.txtProjectDescription);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtResearchProjectID);
            this.Controls.Add(this.lblTopicDescription);
            this.Controls.Add(this.lblProjectDescription);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblResearchProjectID);
            this.Controls.Add(this.lstResearchProjects);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtLecturerID);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblLecturerID);
            this.Controls.Add(this.lstLecturers);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RemoveResearchProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Research Project";
            this.Load += new System.EventHandler(this.RemoveResearchProjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHPROJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRemoveResearchProject;
        private System.Windows.Forms.TextBox txtTopicDescription;
        private System.Windows.Forms.TextBox txtProjectDescription;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtResearchProjectID;
        private System.Windows.Forms.Label lblTopicDescription;
        private System.Windows.Forms.Label lblProjectDescription;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblResearchProjectID;
        private System.Windows.Forms.ListBox lstResearchProjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtLecturerID;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblLecturerID;
        private System.Windows.Forms.ListBox lstLecturers;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource lECTURERBindingSource;
        private dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter lECTURERTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.RESEARCHPROJECTTableAdapter rESEARCHPROJECTTableAdapter;
        private System.Windows.Forms.BindingSource rESEARCHPROJECTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter rESEARCHTOPICTableAdapter;
        private System.Windows.Forms.BindingSource rESEARCHTOPICBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}