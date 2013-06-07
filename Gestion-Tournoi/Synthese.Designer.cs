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
            // Synthese
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 328);
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
    }
}