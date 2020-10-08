namespace RapsoHelper.user
{
    partial class frmMigratorToPerson
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iduserpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrpersonfirstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usrpersonlastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcountryprimaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentprefixPrimaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentcountryprimaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcountrysecundaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentcountrysecundaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bloodtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personreadyDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usrpersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rapsodyapp_dbDataSet = new RapsoHelper.rapsodyapp_dbDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrpersonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapsodyapp_dbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iduserpersonDataGridViewTextBoxColumn,
            this.usrpersonfirstnameDataGridViewTextBoxColumn,
            this.usrpersonlastnameDataGridViewTextBoxColumn,
            this.idcountryprimaryDataGridViewTextBoxColumn,
            this.documentprefixPrimaryDataGridViewTextBoxColumn,
            this.documentcountryprimaryDataGridViewTextBoxColumn,
            this.idcountrysecundaryDataGridViewTextBoxColumn,
            this.documentcountrysecundaryDataGridViewTextBoxColumn,
            this.bloodtypeDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.personreadyDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.usrpersonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(24, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(708, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // iduserpersonDataGridViewTextBoxColumn
            // 
            this.iduserpersonDataGridViewTextBoxColumn.DataPropertyName = "id_user_person";
            this.iduserpersonDataGridViewTextBoxColumn.HeaderText = "id_user_person";
            this.iduserpersonDataGridViewTextBoxColumn.Name = "iduserpersonDataGridViewTextBoxColumn";
            // 
            // usrpersonfirstnameDataGridViewTextBoxColumn
            // 
            this.usrpersonfirstnameDataGridViewTextBoxColumn.DataPropertyName = "usr_person_firstname";
            this.usrpersonfirstnameDataGridViewTextBoxColumn.HeaderText = "usr_person_firstname";
            this.usrpersonfirstnameDataGridViewTextBoxColumn.Name = "usrpersonfirstnameDataGridViewTextBoxColumn";
            // 
            // usrpersonlastnameDataGridViewTextBoxColumn
            // 
            this.usrpersonlastnameDataGridViewTextBoxColumn.DataPropertyName = "usr_person_lastname";
            this.usrpersonlastnameDataGridViewTextBoxColumn.HeaderText = "usr_person_lastname";
            this.usrpersonlastnameDataGridViewTextBoxColumn.Name = "usrpersonlastnameDataGridViewTextBoxColumn";
            // 
            // idcountryprimaryDataGridViewTextBoxColumn
            // 
            this.idcountryprimaryDataGridViewTextBoxColumn.DataPropertyName = "id_country_primary";
            this.idcountryprimaryDataGridViewTextBoxColumn.HeaderText = "id_country_primary";
            this.idcountryprimaryDataGridViewTextBoxColumn.Name = "idcountryprimaryDataGridViewTextBoxColumn";
            // 
            // documentprefixPrimaryDataGridViewTextBoxColumn
            // 
            this.documentprefixPrimaryDataGridViewTextBoxColumn.DataPropertyName = "document_prefix_Primary";
            this.documentprefixPrimaryDataGridViewTextBoxColumn.HeaderText = "document_prefix_Primary";
            this.documentprefixPrimaryDataGridViewTextBoxColumn.Name = "documentprefixPrimaryDataGridViewTextBoxColumn";
            // 
            // documentcountryprimaryDataGridViewTextBoxColumn
            // 
            this.documentcountryprimaryDataGridViewTextBoxColumn.DataPropertyName = "document_country_primary";
            this.documentcountryprimaryDataGridViewTextBoxColumn.HeaderText = "document_country_primary";
            this.documentcountryprimaryDataGridViewTextBoxColumn.Name = "documentcountryprimaryDataGridViewTextBoxColumn";
            // 
            // idcountrysecundaryDataGridViewTextBoxColumn
            // 
            this.idcountrysecundaryDataGridViewTextBoxColumn.DataPropertyName = "id_country_secundary";
            this.idcountrysecundaryDataGridViewTextBoxColumn.HeaderText = "id_country_secundary";
            this.idcountrysecundaryDataGridViewTextBoxColumn.Name = "idcountrysecundaryDataGridViewTextBoxColumn";
            // 
            // documentcountrysecundaryDataGridViewTextBoxColumn
            // 
            this.documentcountrysecundaryDataGridViewTextBoxColumn.DataPropertyName = "document_country_secundary";
            this.documentcountrysecundaryDataGridViewTextBoxColumn.HeaderText = "document_country_secundary";
            this.documentcountrysecundaryDataGridViewTextBoxColumn.Name = "documentcountrysecundaryDataGridViewTextBoxColumn";
            // 
            // bloodtypeDataGridViewTextBoxColumn
            // 
            this.bloodtypeDataGridViewTextBoxColumn.DataPropertyName = "blood_type";
            this.bloodtypeDataGridViewTextBoxColumn.HeaderText = "blood_type";
            this.bloodtypeDataGridViewTextBoxColumn.Name = "bloodtypeDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // personreadyDataGridViewCheckBoxColumn
            // 
            this.personreadyDataGridViewCheckBoxColumn.DataPropertyName = "person_ready";
            this.personreadyDataGridViewCheckBoxColumn.HeaderText = "person_ready";
            this.personreadyDataGridViewCheckBoxColumn.Name = "personreadyDataGridViewCheckBoxColumn";
            // 
            // usrpersonBindingSource
            // 
            this.usrpersonBindingSource.DataMember = "usr_person";
            this.usrpersonBindingSource.DataSource = this.rapsodyapp_dbDataSet;
            // 
            // rapsodyapp_dbDataSet
            // 
            this.rapsodyapp_dbDataSet.DataSetName = "rapsodyapp_dbDataSet";
            this.rapsodyapp_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usr_personTableAdapter
            // 
            // 
            // frmMigratorToPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmMigratorToPerson";
            this.Text = "frmMigratorToPerson";
            this.Load += new System.EventHandler(this.frmMigratorToPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usrpersonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rapsodyapp_dbDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private rapsodyapp_dbDataSet rapsodyapp_dbDataSet;
        private System.Windows.Forms.BindingSource usrpersonBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduserpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrpersonfirstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usrpersonlastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcountryprimaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentprefixPrimaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentcountryprimaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcountrysecundaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentcountrysecundaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bloodtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn personreadyDataGridViewCheckBoxColumn;
    }
}