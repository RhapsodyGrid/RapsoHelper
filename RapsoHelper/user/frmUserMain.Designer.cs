namespace RapsoHelper.user
{
    partial class frmUserMain
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
            this.grBox = new System.Windows.Forms.GroupBox();
            this.btn_userMigration = new System.Windows.Forms.Button();
            this.btn_generalList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_vistaActual = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_status = new System.Windows.Forms.Label();
            this.iduserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.useremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userbirthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usercreateddayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcitylocalizationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userreadyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usruserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapsodyapp_dbDataSet = new RapsoHelper.rapsodyapp_dbDataSet();
            this.usr_userTableAdapter = new RapsoHelper.rapsodyapp_dbDataSetTableAdapters.usr_userTableAdapter();
            this.btn_migrateUserToPerson = new System.Windows.Forms.Button();
            this.grBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usruserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapsodyapp_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grBox
            // 
            this.grBox.Controls.Add(this.btn_migrateUserToPerson);
            this.grBox.Controls.Add(this.btn_userMigration);
            this.grBox.Controls.Add(this.btn_generalList);
            this.grBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.grBox.Location = new System.Drawing.Point(0, 0);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(200, 450);
            this.grBox.TabIndex = 0;
            this.grBox.TabStop = false;
            this.grBox.Text = "Basic Options";
            // 
            // btn_userMigration
            // 
            this.btn_userMigration.Location = new System.Drawing.Point(6, 48);
            this.btn_userMigration.Name = "btn_userMigration";
            this.btn_userMigration.Size = new System.Drawing.Size(188, 23);
            this.btn_userMigration.TabIndex = 1;
            this.btn_userMigration.Text = "List User On Migration";
            this.btn_userMigration.UseVisualStyleBackColor = true;
            this.btn_userMigration.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_generalList
            // 
            this.btn_generalList.Location = new System.Drawing.Point(6, 19);
            this.btn_generalList.Name = "btn_generalList";
            this.btn_generalList.Size = new System.Drawing.Size(188, 23);
            this.btn_generalList.TabIndex = 0;
            this.btn_generalList.Text = "General List";
            this.btn_generalList.UseVisualStyleBackColor = true;
            this.btn_generalList.Click += new System.EventHandler(this.btn_generalList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduserDataGridViewTextBoxColumn,
            this.userloginDataGridViewTextBoxColumn,
            this.userpassDataGridViewTextBoxColumn,
            this.useremailDataGridViewTextBoxColumn,
            this.userbirthdayDataGridViewTextBoxColumn,
            this.usercreateddayDataGridViewTextBoxColumn,
            this.idusertypeDataGridViewTextBoxColumn,
            this.idcitylocalizationDataGridViewTextBoxColumn,
            this.userreadyDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.usruserBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(206, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(981, 394);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(206, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table Users - List of Users";
            // 
            // lbl_vistaActual
            // 
            this.lbl_vistaActual.AutoSize = true;
            this.lbl_vistaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vistaActual.Location = new System.Drawing.Point(444, 9);
            this.lbl_vistaActual.Name = "lbl_vistaActual";
            this.lbl_vistaActual.Size = new System.Drawing.Size(70, 20);
            this.lbl_vistaActual.TabIndex = 3;
            this.lbl_vistaActual.Text = "- empty -";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(200, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1010, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Blue;
            this.lbl_status.Location = new System.Drawing.Point(206, 430);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(136, 20);
            this.lbl_status.TabIndex = 5;
            this.lbl_status.Text = "System on relax";
            // 
            // iduserDataGridViewTextBoxColumn
            // 
            this.iduserDataGridViewTextBoxColumn.DataPropertyName = "id_user";
            this.iduserDataGridViewTextBoxColumn.HeaderText = "id_user";
            this.iduserDataGridViewTextBoxColumn.Name = "iduserDataGridViewTextBoxColumn";
            this.iduserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userloginDataGridViewTextBoxColumn
            // 
            this.userloginDataGridViewTextBoxColumn.DataPropertyName = "user_login";
            this.userloginDataGridViewTextBoxColumn.HeaderText = "user_login";
            this.userloginDataGridViewTextBoxColumn.Name = "userloginDataGridViewTextBoxColumn";
            this.userloginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userpassDataGridViewTextBoxColumn
            // 
            this.userpassDataGridViewTextBoxColumn.DataPropertyName = "user_pass";
            this.userpassDataGridViewTextBoxColumn.HeaderText = "user_pass";
            this.userpassDataGridViewTextBoxColumn.Name = "userpassDataGridViewTextBoxColumn";
            this.userpassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // useremailDataGridViewTextBoxColumn
            // 
            this.useremailDataGridViewTextBoxColumn.DataPropertyName = "user_email";
            this.useremailDataGridViewTextBoxColumn.HeaderText = "user_email";
            this.useremailDataGridViewTextBoxColumn.Name = "useremailDataGridViewTextBoxColumn";
            this.useremailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userbirthdayDataGridViewTextBoxColumn
            // 
            this.userbirthdayDataGridViewTextBoxColumn.DataPropertyName = "user_birthday";
            this.userbirthdayDataGridViewTextBoxColumn.HeaderText = "user_birthday";
            this.userbirthdayDataGridViewTextBoxColumn.Name = "userbirthdayDataGridViewTextBoxColumn";
            this.userbirthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usercreateddayDataGridViewTextBoxColumn
            // 
            this.usercreateddayDataGridViewTextBoxColumn.DataPropertyName = "user_createdday";
            this.usercreateddayDataGridViewTextBoxColumn.HeaderText = "user_createdday";
            this.usercreateddayDataGridViewTextBoxColumn.Name = "usercreateddayDataGridViewTextBoxColumn";
            this.usercreateddayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idusertypeDataGridViewTextBoxColumn
            // 
            this.idusertypeDataGridViewTextBoxColumn.DataPropertyName = "id_user_type";
            this.idusertypeDataGridViewTextBoxColumn.HeaderText = "id_user_type";
            this.idusertypeDataGridViewTextBoxColumn.Name = "idusertypeDataGridViewTextBoxColumn";
            this.idusertypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcitylocalizationDataGridViewTextBoxColumn
            // 
            this.idcitylocalizationDataGridViewTextBoxColumn.DataPropertyName = "id_city_localization";
            this.idcitylocalizationDataGridViewTextBoxColumn.HeaderText = "id_city_localization";
            this.idcitylocalizationDataGridViewTextBoxColumn.Name = "idcitylocalizationDataGridViewTextBoxColumn";
            this.idcitylocalizationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userreadyDataGridViewCheckBoxColumn
            // 
            this.userreadyDataGridViewCheckBoxColumn.DataPropertyName = "user_ready";
            this.userreadyDataGridViewCheckBoxColumn.HeaderText = "user_ready";
            this.userreadyDataGridViewCheckBoxColumn.Name = "userreadyDataGridViewCheckBoxColumn";
            this.userreadyDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // usruserBindingSource
            // 
            this.usruserBindingSource.DataMember = "usr_user";
            this.usruserBindingSource.DataSource = this.rapsodyapp_dbDataSet;
            // 
            // rapsodyapp_dbDataSet
            // 
            this.rapsodyapp_dbDataSet.DataSetName = "rapsodyapp_dbDataSet";
            this.rapsodyapp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usr_userTableAdapter
            // 
            this.usr_userTableAdapter.ClearBeforeFill = true;
            // 
            // btn_migrateUserToPerson
            // 
            this.btn_migrateUserToPerson.Location = new System.Drawing.Point(6, 77);
            this.btn_migrateUserToPerson.Name = "btn_migrateUserToPerson";
            this.btn_migrateUserToPerson.Size = new System.Drawing.Size(188, 23);
            this.btn_migrateUserToPerson.TabIndex = 2;
            this.btn_migrateUserToPerson.Text = "List User On Migration";
            this.btn_migrateUserToPerson.UseVisualStyleBackColor = true;
            this.btn_migrateUserToPerson.Click += new System.EventHandler(this.btn_migrateUserToPerson_Click);
            // 
            // frmUserMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 450);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_vistaActual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUserMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table User";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmUserMain_Load);
            this.grBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usruserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapsodyapp_dbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private rapsodyapp_dbDataSet rapsodyapp_dbDataSet;
        private System.Windows.Forms.BindingSource usruserBindingSource;
        private rapsodyapp_dbDataSetTableAdapters.usr_userTableAdapter usr_userTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn useremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userbirthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usercreateddayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcitylocalizationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn userreadyDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_generalList;
        private System.Windows.Forms.Label lbl_vistaActual;
        private System.Windows.Forms.Button btn_userMigration;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Button btn_migrateUserToPerson;
    }
}