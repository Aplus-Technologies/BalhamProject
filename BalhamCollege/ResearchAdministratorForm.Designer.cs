
namespace BalhamCollege
{
    partial class ResearchAdministratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResearchAdministratorForm));
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnUpdateResearchTopic = new System.Windows.Forms.Button();
            this.btnAddResearchProject = new System.Windows.Forms.Button();
            this.btnDeleteResearchTopic = new System.Windows.Forms.Button();
            this.btnAddResearchTopic = new System.Windows.Forms.Button();
            this.btnProduceResearchReport = new System.Windows.Forms.Button();
            this.btnRemoveResearchProject = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsBalhamCollegeAzure = new BalhamCollege.dsBalhamCollegeAzure();
            this.rESEARCHPROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rESEARCHPROJECTTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESEARCHPROJECTTableAdapter();
            this.tableAdapterManager = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.TableAdapterManager();
            this.lECTURERTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter();
            this.rESEARCHTOPICTableAdapter = new BalhamCollege.dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter();
            this.rESEARCHTOPICBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lECTURERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.printResearch = new System.Drawing.Printing.PrintDocument();
            this.prvResearches = new System.Windows.Forms.PrintPreviewDialog();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHPROJECTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReturn.Location = new System.Drawing.Point(25, 467);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(181, 38);
            this.btnReturn.TabIndex = 20;
            this.btnReturn.Text = "Log Out";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnUpdateResearchTopic
            // 
            this.btnUpdateResearchTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateResearchTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnUpdateResearchTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateResearchTopic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateResearchTopic.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdateResearchTopic.Location = new System.Drawing.Point(25, 339);
            this.btnUpdateResearchTopic.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateResearchTopic.Name = "btnUpdateResearchTopic";
            this.btnUpdateResearchTopic.Size = new System.Drawing.Size(181, 38);
            this.btnUpdateResearchTopic.TabIndex = 19;
            this.btnUpdateResearchTopic.Text = "Update Research Topic";
            this.btnUpdateResearchTopic.UseVisualStyleBackColor = false;
            this.btnUpdateResearchTopic.Click += new System.EventHandler(this.btnUpdateResearchTopic_Click);
            // 
            // btnAddResearchProject
            // 
            this.btnAddResearchProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddResearchProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnAddResearchProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddResearchProject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddResearchProject.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddResearchProject.Location = new System.Drawing.Point(25, 213);
            this.btnAddResearchProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddResearchProject.Name = "btnAddResearchProject";
            this.btnAddResearchProject.Size = new System.Drawing.Size(181, 38);
            this.btnAddResearchProject.TabIndex = 18;
            this.btnAddResearchProject.Text = "Add Research Project";
            this.btnAddResearchProject.UseVisualStyleBackColor = false;
            this.btnAddResearchProject.Click += new System.EventHandler(this.btnAddResearchProject_Click);
            // 
            // btnDeleteResearchTopic
            // 
            this.btnDeleteResearchTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteResearchTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnDeleteResearchTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteResearchTopic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteResearchTopic.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDeleteResearchTopic.Location = new System.Drawing.Point(25, 381);
            this.btnDeleteResearchTopic.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteResearchTopic.Name = "btnDeleteResearchTopic";
            this.btnDeleteResearchTopic.Size = new System.Drawing.Size(181, 38);
            this.btnDeleteResearchTopic.TabIndex = 17;
            this.btnDeleteResearchTopic.Text = "Delete Research Topic";
            this.btnDeleteResearchTopic.UseVisualStyleBackColor = false;
            this.btnDeleteResearchTopic.Click += new System.EventHandler(this.btnDeleteResearchTopic_Click);
            // 
            // btnAddResearchTopic
            // 
            this.btnAddResearchTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddResearchTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnAddResearchTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddResearchTopic.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddResearchTopic.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddResearchTopic.Location = new System.Drawing.Point(25, 297);
            this.btnAddResearchTopic.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddResearchTopic.Name = "btnAddResearchTopic";
            this.btnAddResearchTopic.Size = new System.Drawing.Size(181, 38);
            this.btnAddResearchTopic.TabIndex = 16;
            this.btnAddResearchTopic.Text = "Add Research Topic";
            this.btnAddResearchTopic.UseVisualStyleBackColor = false;
            this.btnAddResearchTopic.Click += new System.EventHandler(this.btnAddResearchTopic_Click);
            // 
            // btnProduceResearchReport
            // 
            this.btnProduceResearchReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProduceResearchReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnProduceResearchReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduceResearchReport.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduceResearchReport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnProduceResearchReport.Location = new System.Drawing.Point(25, 425);
            this.btnProduceResearchReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnProduceResearchReport.Name = "btnProduceResearchReport";
            this.btnProduceResearchReport.Size = new System.Drawing.Size(181, 38);
            this.btnProduceResearchReport.TabIndex = 15;
            this.btnProduceResearchReport.Text = "Produce Research Report";
            this.btnProduceResearchReport.UseVisualStyleBackColor = false;
            this.btnProduceResearchReport.Click += new System.EventHandler(this.btnProduceResearchReport_Click);
            // 
            // btnRemoveResearchProject
            // 
            this.btnRemoveResearchProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveResearchProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnRemoveResearchProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveResearchProject.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveResearchProject.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveResearchProject.Location = new System.Drawing.Point(25, 255);
            this.btnRemoveResearchProject.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveResearchProject.Name = "btnRemoveResearchProject";
            this.btnRemoveResearchProject.Size = new System.Drawing.Size(181, 38);
            this.btnRemoveResearchProject.TabIndex = 14;
            this.btnRemoveResearchProject.Text = "Remove Research Project";
            this.btnRemoveResearchProject.UseVisualStyleBackColor = false;
            this.btnRemoveResearchProject.Click += new System.EventHandler(this.btnRemoveResearchProject_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::BalhamCollege.Properties.Resources.ResearchAdmin1980x1080;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(979, 576);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // dsBalhamCollegeAzure
            // 
            this.dsBalhamCollegeAzure.DataSetName = "dsBalhamCollegeAzure";
            this.dsBalhamCollegeAzure.EnforceConstraints = false;
            this.dsBalhamCollegeAzure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rESEARCHPROJECTBindingSource
            // 
            this.rESEARCHPROJECTBindingSource.DataMember = "RESEARCHPROJECT";
            this.rESEARCHPROJECTBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // rESEARCHPROJECTTableAdapter
            // 
            this.rESEARCHPROJECTTableAdapter.ClearBeforeFill = true;
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
            // lECTURERTableAdapter
            // 
            this.lECTURERTableAdapter.ClearBeforeFill = true;
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
            // lECTURERBindingSource
            // 
            this.lECTURERBindingSource.DataMember = "LECTURER";
            this.lECTURERBindingSource.DataSource = this.dsBalhamCollegeAzure;
            // 
            // printResearch
            // 
            this.printResearch.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printResearch_PrintPage);
            // 
            // prvResearches
            // 
            this.prvResearches.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.prvResearches.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.prvResearches.ClientSize = new System.Drawing.Size(400, 300);
            this.prvResearches.Document = this.printResearch;
            this.prvResearches.Enabled = true;
            this.prvResearches.Icon = ((System.Drawing.Icon)(resources.GetObject("prvResearches.Icon")));
            this.prvResearches.Name = "prvResearches";
            this.prvResearches.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(94)))), ((int)(((byte)(132)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(25, 509);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 38);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ResearchAdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(970, 570);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateResearchTopic);
            this.Controls.Add(this.btnAddResearchProject);
            this.Controls.Add(this.btnDeleteResearchTopic);
            this.Controls.Add(this.btnAddResearchTopic);
            this.Controls.Add(this.btnProduceResearchReport);
            this.Controls.Add(this.btnRemoveResearchProject);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ResearchAdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Research Administrator Menu";
            this.Load += new System.EventHandler(this.ResearchAdministratorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsBalhamCollegeAzure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHPROJECTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rESEARCHTOPICBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lECTURERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnUpdateResearchTopic;
        private System.Windows.Forms.Button btnAddResearchProject;
        private System.Windows.Forms.Button btnDeleteResearchTopic;
        private System.Windows.Forms.Button btnAddResearchTopic;
        private System.Windows.Forms.Button btnProduceResearchReport;
        private System.Windows.Forms.Button btnRemoveResearchProject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private dsBalhamCollegeAzure dsBalhamCollegeAzure;
        private System.Windows.Forms.BindingSource rESEARCHPROJECTBindingSource;
        private dsBalhamCollegeAzureTableAdapters.RESEARCHPROJECTTableAdapter rESEARCHPROJECTTableAdapter;
        private dsBalhamCollegeAzureTableAdapters.TableAdapterManager tableAdapterManager;
        private dsBalhamCollegeAzureTableAdapters.RESEARCHTOPICTableAdapter rESEARCHTOPICTableAdapter;
        private System.Windows.Forms.BindingSource rESEARCHTOPICBindingSource;
        private dsBalhamCollegeAzureTableAdapters.LECTURERTableAdapter lECTURERTableAdapter;
        private System.Windows.Forms.BindingSource lECTURERBindingSource;
        private System.Drawing.Printing.PrintDocument printResearch;
        private System.Windows.Forms.PrintPreviewDialog prvResearches;
        private System.Windows.Forms.Button btnExit;
    }
}