namespace Gestion_Tournoi
{
    partial class NouvellePersonne
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
            this.tb_prenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.cb_arbitre = new System.Windows.Forms.CheckBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_prenom
            // 
            this.tb_prenom.Location = new System.Drawing.Point(12, 25);
            this.tb_prenom.Name = "tb_prenom";
            this.tb_prenom.Size = new System.Drawing.Size(200, 20);
            this.tb_prenom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom :";
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(15, 64);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(197, 20);
            this.tb_nom.TabIndex = 3;
            // 
            // cb_arbitre
            // 
            this.cb_arbitre.AutoSize = true;
            this.cb_arbitre.Location = new System.Drawing.Point(15, 90);
            this.cb_arbitre.Name = "cb_arbitre";
            this.cb_arbitre.Size = new System.Drawing.Size(56, 17);
            this.cb_arbitre.TabIndex = 5;
            this.cb_arbitre.Text = "Arbitre";
            this.cb_arbitre.UseVisualStyleBackColor = true;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(15, 117);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(101, 23);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "Sauvegarder";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(122, 117);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(92, 23);
            this.bt_annuler.TabIndex = 7;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // NouvellePersonne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 152);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.cb_arbitre);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_prenom);
            this.Name = "NouvellePersonne";
            this.Text = "Nouvelle personne";
            this.Load += new System.EventHandler(this.NouvellePersonne_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_prenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.CheckBox cb_arbitre;
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Button bt_annuler;
    }
}