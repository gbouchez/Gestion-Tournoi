namespace Gestion_Tournoi
{
    partial class AjoutException
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
            this.cb_equipe1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_equipe2 = new System.Windows.Forms.ComboBox();
            this.bt_save = new System.Windows.Forms.Button();
            this.dbDataSet = new Gestion_Tournoi.dbDataSet();
            this.equipeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipeTableAdapter = new Gestion_Tournoi.dbDataSetTableAdapters.equipeTableAdapter();
            this.equipeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_equipe1
            // 
            this.cb_equipe1.DataSource = this.equipeBindingSource;
            this.cb_equipe1.DisplayMember = "nom";
            this.cb_equipe1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_equipe1.FormattingEnabled = true;
            this.cb_equipe1.Location = new System.Drawing.Point(12, 25);
            this.cb_equipe1.Name = "cb_equipe1";
            this.cb_equipe1.Size = new System.Drawing.Size(121, 21);
            this.cb_equipe1.TabIndex = 0;
            this.cb_equipe1.ValueMember = "id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equipe 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Equipe 2 :";
            // 
            // cb_equipe2
            // 
            this.cb_equipe2.DataSource = this.equipeBindingSource1;
            this.cb_equipe2.DisplayMember = "nom";
            this.cb_equipe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_equipe2.FormattingEnabled = true;
            this.cb_equipe2.Location = new System.Drawing.Point(151, 25);
            this.cb_equipe2.Name = "cb_equipe2";
            this.cb_equipe2.Size = new System.Drawing.Size(121, 21);
            this.cb_equipe2.TabIndex = 3;
            this.cb_equipe2.ValueMember = "id";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(12, 62);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(260, 23);
            this.bt_save.TabIndex = 4;
            this.bt_save.Text = "Enregistrer l\'exception";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // equipeBindingSource
            // 
            this.equipeBindingSource.DataMember = "equipe";
            this.equipeBindingSource.DataSource = this.dbDataSet;
            // 
            // equipeTableAdapter
            // 
            this.equipeTableAdapter.ClearBeforeFill = true;
            // 
            // equipeBindingSource1
            // 
            this.equipeBindingSource1.DataMember = "equipe";
            this.equipeBindingSource1.DataSource = this.dbDataSet;
            // 
            // AjoutException
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.cb_equipe2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_equipe1);
            this.Name = "AjoutException";
            this.Text = "AjoutException";
            this.Load += new System.EventHandler(this.AjoutException_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipeBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_equipe1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_equipe2;
        private System.Windows.Forms.Button bt_save;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource equipeBindingSource;
        private dbDataSetTableAdapters.equipeTableAdapter equipeTableAdapter;
        private System.Windows.Forms.BindingSource equipeBindingSource1;
    }
}