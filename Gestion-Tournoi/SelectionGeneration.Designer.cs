namespace Gestion_Tournoi
{
    partial class SelectionGeneration
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
            this.bt_genFile = new System.Windows.Forms.Button();
            this.bt_show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_genFile
            // 
            this.bt_genFile.Location = new System.Drawing.Point(12, 41);
            this.bt_genFile.Name = "bt_genFile";
            this.bt_genFile.Size = new System.Drawing.Size(260, 23);
            this.bt_genFile.TabIndex = 0;
            this.bt_genFile.Text = "Générer un fichier récapitulatif";
            this.bt_genFile.UseVisualStyleBackColor = true;
            this.bt_genFile.Click += new System.EventHandler(this.bt_genFile_Click);
            // 
            // bt_show
            // 
            this.bt_show.Location = new System.Drawing.Point(12, 12);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(260, 23);
            this.bt_show.TabIndex = 1;
            this.bt_show.Text = "Afficher le résumé du tournoi";
            this.bt_show.UseVisualStyleBackColor = true;
            this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
            // 
            // SelectionGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 74);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.bt_genFile);
            this.Name = "SelectionGeneration";
            this.Text = "Mode de génération";
            this.Load += new System.EventHandler(this.SelectionGeneration_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_genFile;
        private System.Windows.Forms.Button bt_show;
    }
}