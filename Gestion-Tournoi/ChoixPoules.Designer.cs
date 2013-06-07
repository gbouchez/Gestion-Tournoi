namespace Gestion_Tournoi
{
    partial class ChoixPoules
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
            this.cb_poules = new System.Windows.Forms.ComboBox();
            this.bt_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choisissez l\'organisation des poules :";
            // 
            // cb_poules
            // 
            this.cb_poules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_poules.FormattingEnabled = true;
            this.cb_poules.Location = new System.Drawing.Point(12, 25);
            this.cb_poules.Name = "cb_poules";
            this.cb_poules.Size = new System.Drawing.Size(260, 21);
            this.cb_poules.TabIndex = 1;
            // 
            // bt_ok
            // 
            this.bt_ok.Location = new System.Drawing.Point(197, 52);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(75, 23);
            this.bt_ok.TabIndex = 2;
            this.bt_ok.Text = "Sélectionner";
            this.bt_ok.UseVisualStyleBackColor = true;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // ChoixPoules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 84);
            this.Controls.Add(this.bt_ok);
            this.Controls.Add(this.cb_poules);
            this.Controls.Add(this.label1);
            this.Name = "ChoixPoules";
            this.Text = "Choix de l\'organisation";
            this.Load += new System.EventHandler(this.ChoixPoules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_poules;
        private System.Windows.Forms.Button bt_ok;
    }
}