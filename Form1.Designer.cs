namespace Refuge_chien
{
    partial class Form_RefugeChien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_RefugeChien));
            this.gb_rechch = new System.Windows.Forms.GroupBox();
            this.bt_valider = new System.Windows.Forms.Button();
            this.cb_sexe = new System.Windows.Forms.ComboBox();
            this.cb_race = new System.Windows.Forms.ComboBox();
            this.lb_sexe = new System.Windows.Forms.Label();
            this.lb_race = new System.Windows.Forms.Label();
            this.bt_Quitter = new System.Windows.Forms.Button();
            this.lb_sousTitre = new System.Windows.Forms.Label();
            this.lb_logo = new System.Windows.Forms.Label();
            this.lb_titre = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.gb_accueil = new System.Windows.Forms.GroupBox();
            this.btVoirAdoption = new System.Windows.Forms.Button();
            this.lb_accueil = new System.Windows.Forms.Label();
            this.gb_rechch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.gb_accueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_rechch
            // 
            this.gb_rechch.BackColor = System.Drawing.Color.White;
            this.gb_rechch.Controls.Add(this.bt_valider);
            this.gb_rechch.Controls.Add(this.cb_sexe);
            this.gb_rechch.Controls.Add(this.cb_race);
            this.gb_rechch.Controls.Add(this.lb_sexe);
            this.gb_rechch.Controls.Add(this.lb_race);
            this.gb_rechch.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_rechch.Location = new System.Drawing.Point(1005, 223);
            this.gb_rechch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gb_rechch.Name = "gb_rechch";
            this.gb_rechch.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gb_rechch.Size = new System.Drawing.Size(221, 168);
            this.gb_rechch.TabIndex = 8;
            this.gb_rechch.TabStop = false;
            this.gb_rechch.Text = "Rechercher un chien :";
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(79, 117);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(75, 28);
            this.bt_valider.TabIndex = 8;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            this.bt_valider.Click += new System.EventHandler(this.bt_valider_Click);
            // 
            // cb_sexe
            // 
            this.cb_sexe.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold);
            this.cb_sexe.FormattingEnabled = true;
            this.cb_sexe.Items.AddRange(new object[] {
            "Male",
            "Femelle"});
            this.cb_sexe.Location = new System.Drawing.Point(64, 77);
            this.cb_sexe.Name = "cb_sexe";
            this.cb_sexe.Size = new System.Drawing.Size(121, 23);
            this.cb_sexe.TabIndex = 5;
            // 
            // cb_race
            // 
            this.cb_race.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_race.FormattingEnabled = true;
            this.cb_race.Location = new System.Drawing.Point(64, 37);
            this.cb_race.Name = "cb_race";
            this.cb_race.Size = new System.Drawing.Size(121, 23);
            this.cb_race.TabIndex = 4;
            // 
            // lb_sexe
            // 
            this.lb_sexe.AutoSize = true;
            this.lb_sexe.Location = new System.Drawing.Point(14, 77);
            this.lb_sexe.Name = "lb_sexe";
            this.lb_sexe.Size = new System.Drawing.Size(48, 17);
            this.lb_sexe.TabIndex = 1;
            this.lb_sexe.Text = "sexe :";
            // 
            // lb_race
            // 
            this.lb_race.AutoSize = true;
            this.lb_race.Location = new System.Drawing.Point(13, 37);
            this.lb_race.Name = "lb_race";
            this.lb_race.Size = new System.Drawing.Size(45, 17);
            this.lb_race.TabIndex = 0;
            this.lb_race.Text = "race :";
            // 
            // bt_Quitter
            // 
            this.bt_Quitter.Location = new System.Drawing.Point(1137, 12);
            this.bt_Quitter.Name = "bt_Quitter";
            this.bt_Quitter.Size = new System.Drawing.Size(89, 36);
            this.bt_Quitter.TabIndex = 10;
            this.bt_Quitter.Text = "Quitter";
            this.bt_Quitter.UseVisualStyleBackColor = true;
            this.bt_Quitter.Click += new System.EventHandler(this.bt_Quitter_Click);
            // 
            // lb_sousTitre
            // 
            this.lb_sousTitre.AutoSize = true;
            this.lb_sousTitre.BackColor = System.Drawing.Color.Transparent;
            this.lb_sousTitre.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sousTitre.ForeColor = System.Drawing.Color.Black;
            this.lb_sousTitre.Location = new System.Drawing.Point(460, 26);
            this.lb_sousTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sousTitre.Name = "lb_sousTitre";
            this.lb_sousTitre.Size = new System.Drawing.Size(370, 55);
            this.lb_sousTitre.TabIndex = 11;
            this.lb_sousTitre.Text = "Refuge de Massy";
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_logo.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logo.Location = new System.Drawing.Point(177, -4);
            this.lb_logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(188, 90);
            this.lb_logo.TabIndex = 12;
            this.lb_logo.Text = "CSF";
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_titre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.Location = new System.Drawing.Point(189, 86);
            this.lb_titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(156, 17);
            this.lb_titre.TabIndex = 13;
            this.lb_titre.Text = "CHIEN SANS FOYER";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pb_logo.BackgroundImage = global::Refuge_chien.Properties.Resources.logo_refuge;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(82, 9);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(91, 90);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 14;
            this.pb_logo.TabStop = false;
            // 
            // gb_accueil
            // 
            this.gb_accueil.BackColor = System.Drawing.Color.White;
            this.gb_accueil.Controls.Add(this.btVoirAdoption);
            this.gb_accueil.Controls.Add(this.lb_accueil);
            this.gb_accueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_accueil.Location = new System.Drawing.Point(374, 223);
            this.gb_accueil.Name = "gb_accueil";
            this.gb_accueil.Size = new System.Drawing.Size(614, 388);
            this.gb_accueil.TabIndex = 16;
            this.gb_accueil.TabStop = false;
            this.gb_accueil.Text = "Accueil";
            // 
            // btVoirAdoption
            // 
            this.btVoirAdoption.Location = new System.Drawing.Point(414, 346);
            this.btVoirAdoption.Name = "btVoirAdoption";
            this.btVoirAdoption.Size = new System.Drawing.Size(184, 36);
            this.btVoirAdoption.TabIndex = 17;
            this.btVoirAdoption.Text = "Voir Adoptions";
            this.btVoirAdoption.UseVisualStyleBackColor = true;
            this.btVoirAdoption.Click += new System.EventHandler(this.btVoirAdoption_Click);
            // 
            // lb_accueil
            // 
            this.lb_accueil.AutoSize = true;
            this.lb_accueil.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_accueil.Location = new System.Drawing.Point(14, 47);
            this.lb_accueil.Name = "lb_accueil";
            this.lb_accueil.Size = new System.Drawing.Size(153, 21);
            this.lb_accueil.TabIndex = 0;
            this.lb_accueil.Text = " J\'adopte un chien :";
            // 
            // Form_RefugeChien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Refuge_chien.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 720);
            this.Controls.Add(this.gb_accueil);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.lb_logo);
            this.Controls.Add(this.lb_sousTitre);
            this.Controls.Add(this.bt_Quitter);
            this.Controls.Add(this.gb_rechch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_RefugeChien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Refuge pour chien";
            this.gb_rechch.ResumeLayout(false);
            this.gb_rechch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.gb_accueil.ResumeLayout(false);
            this.gb_accueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_rechch;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.ComboBox cb_sexe;
        private System.Windows.Forms.ComboBox cb_race;
        private System.Windows.Forms.Label lb_sexe;
        private System.Windows.Forms.Label lb_race;
        private System.Windows.Forms.Button bt_Quitter;
        private System.Windows.Forms.Label lb_sousTitre;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.GroupBox gb_accueil;
        private System.Windows.Forms.Label lb_accueil;
        private System.Windows.Forms.Button btVoirAdoption;
    }
}

