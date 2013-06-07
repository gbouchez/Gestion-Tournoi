namespace Gestion_Tournoi
{
    partial class Main
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
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arbitreDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new Gestion_Tournoi.dbDataSet();
            this.bt_newpers = new System.Windows.Forms.Button();
            this.bt_newteam = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capitaineidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_editTeam = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nbTerrains = new System.Windows.Forms.TextBox();
            this.cb_lundi = new System.Windows.Forms.CheckBox();
            this.cb_mardi = new System.Windows.Forms.CheckBox();
            this.cb_mercredi = new System.Windows.Forms.CheckBox();
            this.cb_jeudi = new System.Windows.Forms.CheckBox();
            this.cb_vendredi = new System.Windows.Forms.CheckBox();
            this.cb_samedi = new System.Windows.Forms.CheckBox();
            this.cb_dimanche = new System.Windows.Forms.CheckBox();
            this.personneTableAdapter = new Gestion_Tournoi.dbDataSetTableAdapters.personneTableAdapter();
            this.equipeTableAdapter = new Gestion_Tournoi.dbDataSetTableAdapters.equipeTableAdapter();
            this.bt_generate = new System.Windows.Forms.Button();
            this.bt_editIgnore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.equipeidDataGridViewTextBoxColumn,
            this.arbitreDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.personneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(342, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowLeave);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // equipeidDataGridViewTextBoxColumn
            // 
            this.equipeidDataGridViewTextBoxColumn.DataPropertyName = "equipe_id";
            this.equipeidDataGridViewTextBoxColumn.HeaderText = "equipe_id";
            this.equipeidDataGridViewTextBoxColumn.Name = "equipeidDataGridViewTextBoxColumn";
            this.equipeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // arbitreDataGridViewCheckBoxColumn
            // 
            this.arbitreDataGridViewCheckBoxColumn.DataPropertyName = "arbitre";
            this.arbitreDataGridViewCheckBoxColumn.HeaderText = "Arbitre";
            this.arbitreDataGridViewCheckBoxColumn.Name = "arbitreDataGridViewCheckBoxColumn";
            this.arbitreDataGridViewCheckBoxColumn.Width = 50;
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataMember = "personne";
            this.personneBindingSource.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_newpers
            // 
            this.bt_newpers.Location = new System.Drawing.Point(12, 12);
            this.bt_newpers.Name = "bt_newpers";
            this.bt_newpers.Size = new System.Drawing.Size(342, 23);
            this.bt_newpers.TabIndex = 1;
            this.bt_newpers.Text = "Nouvelle personne";
            this.bt_newpers.UseVisualStyleBackColor = true;
            this.bt_newpers.Click += new System.EventHandler(this.bt_newpers_Click);
            // 
            // bt_newteam
            // 
            this.bt_newteam.Location = new System.Drawing.Point(360, 12);
            this.bt_newteam.Name = "bt_newteam";
            this.bt_newteam.Size = new System.Drawing.Size(243, 23);
            this.bt_newteam.TabIndex = 2;
            this.bt_newteam.Text = "Nouvelle équipe";
            this.bt_newteam.UseVisualStyleBackColor = true;
            this.bt_newteam.Click += new System.EventHandler(this.bt_newteam_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomDataGridViewTextBoxColumn1,
            this.capitaineidDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.equipeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(360, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(243, 150);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_RowLeave);
            this.dataGridView2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView2_RowsRemoved);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 30;
            // 
            // nomDataGridViewTextBoxColumn1
            // 
            this.nomDataGridViewTextBoxColumn1.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn1.Name = "nomDataGridViewTextBoxColumn1";
            this.nomDataGridViewTextBoxColumn1.Width = 180;
            // 
            // capitaineidDataGridViewTextBoxColumn
            // 
            this.capitaineidDataGridViewTextBoxColumn.DataPropertyName = "capitaine_id";
            this.capitaineidDataGridViewTextBoxColumn.HeaderText = "capitaine_id";
            this.capitaineidDataGridViewTextBoxColumn.Name = "capitaineidDataGridViewTextBoxColumn";
            this.capitaineidDataGridViewTextBoxColumn.Visible = false;
            // 
            // equipeBindingSource
            // 
            this.equipeBindingSource.DataMember = "equipe";
            this.equipeBindingSource.DataSource = this.dbDataSet;
            // 
            // bt_editTeam
            // 
            this.bt_editTeam.Location = new System.Drawing.Point(360, 197);
            this.bt_editTeam.Name = "bt_editTeam";
            this.bt_editTeam.Size = new System.Drawing.Size(243, 23);
            this.bt_editTeam.TabIndex = 4;
            this.bt_editTeam.Text = "Editer l\'équipe...";
            this.bt_editTeam.UseVisualStyleBackColor = true;
            this.bt_editTeam.Click += new System.EventHandler(this.bt_editTeam_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre de terrains :";
            // 
            // tb_nbTerrains
            // 
            this.tb_nbTerrains.Location = new System.Drawing.Point(120, 194);
            this.tb_nbTerrains.Name = "tb_nbTerrains";
            this.tb_nbTerrains.Size = new System.Drawing.Size(100, 20);
            this.tb_nbTerrains.TabIndex = 6;
            this.tb_nbTerrains.TextChanged += new System.EventHandler(this.tb_nbTerrains_TextChanged);
            this.tb_nbTerrains.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_nbTerrains_KeyPress);
            // 
            // cb_lundi
            // 
            this.cb_lundi.AutoSize = true;
            this.cb_lundi.Location = new System.Drawing.Point(14, 225);
            this.cb_lundi.Name = "cb_lundi";
            this.cb_lundi.Size = new System.Drawing.Size(32, 17);
            this.cb_lundi.TabIndex = 7;
            this.cb_lundi.Text = "L";
            this.cb_lundi.UseVisualStyleBackColor = true;
            this.cb_lundi.CheckedChanged += new System.EventHandler(this.cb_lundi_CheckedChanged);
            // 
            // cb_mardi
            // 
            this.cb_mardi.AutoSize = true;
            this.cb_mardi.Location = new System.Drawing.Point(52, 225);
            this.cb_mardi.Name = "cb_mardi";
            this.cb_mardi.Size = new System.Drawing.Size(35, 17);
            this.cb_mardi.TabIndex = 8;
            this.cb_mardi.Text = "M";
            this.cb_mardi.UseVisualStyleBackColor = true;
            this.cb_mardi.CheckedChanged += new System.EventHandler(this.cb_mardi_CheckedChanged);
            // 
            // cb_mercredi
            // 
            this.cb_mercredi.AutoSize = true;
            this.cb_mercredi.Location = new System.Drawing.Point(93, 225);
            this.cb_mercredi.Name = "cb_mercredi";
            this.cb_mercredi.Size = new System.Drawing.Size(35, 17);
            this.cb_mercredi.TabIndex = 9;
            this.cb_mercredi.Text = "M";
            this.cb_mercredi.UseVisualStyleBackColor = true;
            this.cb_mercredi.CheckedChanged += new System.EventHandler(this.cb_mercredi_CheckedChanged);
            // 
            // cb_jeudi
            // 
            this.cb_jeudi.AutoSize = true;
            this.cb_jeudi.Location = new System.Drawing.Point(134, 225);
            this.cb_jeudi.Name = "cb_jeudi";
            this.cb_jeudi.Size = new System.Drawing.Size(31, 17);
            this.cb_jeudi.TabIndex = 10;
            this.cb_jeudi.Text = "J";
            this.cb_jeudi.UseVisualStyleBackColor = true;
            this.cb_jeudi.CheckedChanged += new System.EventHandler(this.cb_jeudi_CheckedChanged);
            // 
            // cb_vendredi
            // 
            this.cb_vendredi.AutoSize = true;
            this.cb_vendredi.Location = new System.Drawing.Point(171, 225);
            this.cb_vendredi.Name = "cb_vendredi";
            this.cb_vendredi.Size = new System.Drawing.Size(33, 17);
            this.cb_vendredi.TabIndex = 11;
            this.cb_vendredi.Text = "V";
            this.cb_vendredi.UseVisualStyleBackColor = true;
            this.cb_vendredi.CheckedChanged += new System.EventHandler(this.cb_vendredi_CheckedChanged);
            // 
            // cb_samedi
            // 
            this.cb_samedi.AutoSize = true;
            this.cb_samedi.Location = new System.Drawing.Point(210, 225);
            this.cb_samedi.Name = "cb_samedi";
            this.cb_samedi.Size = new System.Drawing.Size(33, 17);
            this.cb_samedi.TabIndex = 12;
            this.cb_samedi.Text = "S";
            this.cb_samedi.UseVisualStyleBackColor = true;
            this.cb_samedi.CheckedChanged += new System.EventHandler(this.cb_samedi_CheckedChanged);
            // 
            // cb_dimanche
            // 
            this.cb_dimanche.AutoSize = true;
            this.cb_dimanche.Location = new System.Drawing.Point(249, 225);
            this.cb_dimanche.Name = "cb_dimanche";
            this.cb_dimanche.Size = new System.Drawing.Size(34, 17);
            this.cb_dimanche.TabIndex = 13;
            this.cb_dimanche.Text = "D";
            this.cb_dimanche.UseVisualStyleBackColor = true;
            this.cb_dimanche.CheckedChanged += new System.EventHandler(this.cb_dimanche_CheckedChanged);
            // 
            // personneTableAdapter
            // 
            this.personneTableAdapter.ClearBeforeFill = true;
            // 
            // equipeTableAdapter
            // 
            this.equipeTableAdapter.ClearBeforeFill = true;
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(12, 254);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(591, 23);
            this.bt_generate.TabIndex = 14;
            this.bt_generate.Text = "Générer le tournoi";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // bt_editIgnore
            // 
            this.bt_editIgnore.Location = new System.Drawing.Point(360, 225);
            this.bt_editIgnore.Name = "bt_editIgnore";
            this.bt_editIgnore.Size = new System.Drawing.Size(243, 23);
            this.bt_editIgnore.TabIndex = 15;
            this.bt_editIgnore.Text = "Gérer les exceptions de rencontres...";
            this.bt_editIgnore.UseVisualStyleBackColor = true;
            this.bt_editIgnore.Click += new System.EventHandler(this.bt_editIgnore_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 289);
            this.Controls.Add(this.bt_editIgnore);
            this.Controls.Add(this.bt_generate);
            this.Controls.Add(this.cb_dimanche);
            this.Controls.Add(this.cb_samedi);
            this.Controls.Add(this.cb_vendredi);
            this.Controls.Add(this.cb_jeudi);
            this.Controls.Add(this.cb_mercredi);
            this.Controls.Add(this.cb_mardi);
            this.Controls.Add(this.cb_lundi);
            this.Controls.Add(this.tb_nbTerrains);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_editTeam);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.bt_newteam);
            this.Controls.Add(this.bt_newpers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Main";
            this.Text = "Gestion de tournoi";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private dbDataSetTableAdapters.personneTableAdapter personneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn arbitreDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button bt_newpers;
        private System.Windows.Forms.Button bt_newteam;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource equipeBindingSource;
        private dbDataSetTableAdapters.equipeTableAdapter equipeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn capitaineidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button bt_editTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nbTerrains;
        private System.Windows.Forms.CheckBox cb_lundi;
        private System.Windows.Forms.CheckBox cb_mardi;
        private System.Windows.Forms.CheckBox cb_mercredi;
        private System.Windows.Forms.CheckBox cb_jeudi;
        private System.Windows.Forms.CheckBox cb_vendredi;
        private System.Windows.Forms.CheckBox cb_samedi;
        private System.Windows.Forms.CheckBox cb_dimanche;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.Button bt_editIgnore;
    }
}