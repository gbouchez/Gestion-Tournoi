namespace Gestion_Tournoi
{
    partial class Synthese
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_teams = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_arbitres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_calendrier = new System.Windows.Forms.TextBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Présentation des équipes";
            // 
            // tb_teams
            // 
            this.tb_teams.Location = new System.Drawing.Point(12, 25);
            this.tb_teams.Multiline = true;
            this.tb_teams.Name = "tb_teams";
            this.tb_teams.ReadOnly = true;
            this.tb_teams.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_teams.Size = new System.Drawing.Size(233, 134);
            this.tb_teams.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Présentation des arbitres";
            // 
            // tb_arbitres
            // 
            this.tb_arbitres.Location = new System.Drawing.Point(258, 25);
            this.tb_arbitres.Multiline = true;
            this.tb_arbitres.Name = "tb_arbitres";
            this.tb_arbitres.ReadOnly = true;
            this.tb_arbitres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_arbitres.Size = new System.Drawing.Size(233, 134);
            this.tb_arbitres.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Calendrier des rencontres";
            // 
            // tb_calendrier
            // 
            this.tb_calendrier.Location = new System.Drawing.Point(12, 182);
            this.tb_calendrier.Multiline = true;
            this.tb_calendrier.Name = "tb_calendrier";
            this.tb_calendrier.ReadOnly = true;
            this.tb_calendrier.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_calendrier.Size = new System.Drawing.Size(479, 134);
            this.tb_calendrier.TabIndex = 5;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(205, 322);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "OK";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // Synthese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 349);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.tb_calendrier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_arbitres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_teams);
            this.Controls.Add(this.label1);
            this.Name = "Synthese";
            this.Text = "Synthese";
            this.Load += new System.EventHandler(this.Synthese_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_teams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_arbitres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_calendrier;
        private System.Windows.Forms.Button bt_ok;
    }
}