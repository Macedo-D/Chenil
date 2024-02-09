namespace Refuge_chien
{
    partial class Form_Resultat_recherche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Resultat_recherche));
            this.gb_resultat = new System.Windows.Forms.GroupBox();
            this.lb_resuRaceNom = new System.Windows.Forms.Label();
            this.bt_validerChoixSelectionChien = new System.Windows.Forms.Button();
            this.clb_selectionChien = new System.Windows.Forms.CheckedListBox();
            this.lb_selectionChien = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_titre = new System.Windows.Forms.Label();
            this.lb_logo = new System.Windows.Forms.Label();
            this.lb_sousTitre = new System.Windows.Forms.Label();
            this.bt_Quitter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_resultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_resultat
            // 
            this.gb_resultat.Controls.Add(this.lb_resuRaceNom);
            this.gb_resultat.Controls.Add(this.bt_validerChoixSelectionChien);
            this.gb_resultat.Controls.Add(this.clb_selectionChien);
            this.gb_resultat.Controls.Add(this.lb_selectionChien);
            this.gb_resultat.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_resultat.Location = new System.Drawing.Point(423, 218);
            this.gb_resultat.Name = "gb_resultat";
            this.gb_resultat.Size = new System.Drawing.Size(570, 223);
            this.gb_resultat.TabIndex = 14;
            this.gb_resultat.TabStop = false;
            this.gb_resultat.Text = "Résultat de la recherche :";
            // 
            // lb_resuRaceNom
            // 
            this.lb_resuRaceNom.AutoSize = true;
            this.lb_resuRaceNom.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_resuRaceNom.Location = new System.Drawing.Point(231, 0);
            this.lb_resuRaceNom.Name = "lb_resuRaceNom";
            this.lb_resuRaceNom.Size = new System.Drawing.Size(119, 21);
            this.lb_resuRaceNom.TabIndex = 3;
            this.lb_resuRaceNom.Text = "chienrace-sexe";
            // 
            // bt_validerChoixSelectionChien
            // 
            this.bt_validerChoixSelectionChien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_validerChoixSelectionChien.Location = new System.Drawing.Point(381, 70);
            this.bt_validerChoixSelectionChien.Name = "bt_validerChoixSelectionChien";
            this.bt_validerChoixSelectionChien.Size = new System.Drawing.Size(144, 31);
            this.bt_validerChoixSelectionChien.TabIndex = 2;
            this.bt_validerChoixSelectionChien.Text = "Voir description";
            this.bt_validerChoixSelectionChien.UseVisualStyleBackColor = true;
            this.bt_validerChoixSelectionChien.Click += new System.EventHandler(this.bt_validerChoixSelectionChien_Click);
            // 
            // clb_selectionChien
            // 
            this.clb_selectionChien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clb_selectionChien.FormattingEnabled = true;
            this.clb_selectionChien.Location = new System.Drawing.Point(277, 70);
            this.clb_selectionChien.Name = "clb_selectionChien";
            this.clb_selectionChien.Size = new System.Drawing.Size(84, 48);
            this.clb_selectionChien.TabIndex = 1;
            // 
            // lb_selectionChien
            // 
            this.lb_selectionChien.AutoSize = true;
            this.lb_selectionChien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_selectionChien.Location = new System.Drawing.Point(64, 70);
            this.lb_selectionChien.Name = "lb_selectionChien";
            this.lb_selectionChien.Size = new System.Drawing.Size(179, 21);
            this.lb_selectionChien.TabIndex = 0;
            this.lb_selectionChien.Text = "Selectionnez un chien :";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pb_logo.BackgroundImage = global::Refuge_chien.Properties.Resources.logo_refuge;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(76, 13);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(91, 90);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 20;
            this.pb_logo.TabStop = false;
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_titre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.Location = new System.Drawing.Point(193, 86);
            this.lb_titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(156, 17);
            this.lb_titre.TabIndex = 19;
            this.lb_titre.Text = "CHIEN SANS FOYER";
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_logo.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logo.Location = new System.Drawing.Point(181, -4);
            this.lb_logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(188, 90);
            this.lb_logo.TabIndex = 18;
            this.lb_logo.Text = "CSF";
            // 
            // lb_sousTitre
            // 
            this.lb_sousTitre.AutoSize = true;
            this.lb_sousTitre.BackColor = System.Drawing.Color.Transparent;
            this.lb_sousTitre.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sousTitre.ForeColor = System.Drawing.Color.Black;
            this.lb_sousTitre.Location = new System.Drawing.Point(454, 26);
            this.lb_sousTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sousTitre.Name = "lb_sousTitre";
            this.lb_sousTitre.Size = new System.Drawing.Size(370, 55);
            this.lb_sousTitre.TabIndex = 17;
            this.lb_sousTitre.Text = "Refuge de Massy";
            // 
            // bt_Quitter
            // 
            this.bt_Quitter.Location = new System.Drawing.Point(1131, 12);
            this.bt_Quitter.Name = "bt_Quitter";
            this.bt_Quitter.Size = new System.Drawing.Size(89, 36);
            this.bt_Quitter.TabIndex = 16;
            this.bt_Quitter.Text = "Quitter";
            this.bt_Quitter.UseVisualStyleBackColor = true;
            this.bt_Quitter.Click += new System.EventHandler(this.bt_Quitter_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button1.Location = new System.Drawing.Point(1131, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "Accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Resultat_recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Refuge_chien.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 708);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.lb_logo);
            this.Controls.Add(this.lb_sousTitre);
            this.Controls.Add(this.bt_Quitter);
            this.Controls.Add(this.gb_resultat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Resultat_recherche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultat_recherche";
            this.Load += new System.EventHandler(this.Form_Resultat_recherche_Load);
            this.gb_resultat.ResumeLayout(false);
            this.gb_resultat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_resultat;
        private System.Windows.Forms.Label lb_resuRaceNom;
        private System.Windows.Forms.Button bt_validerChoixSelectionChien;
        private System.Windows.Forms.CheckedListBox clb_selectionChien;
        private System.Windows.Forms.Label lb_selectionChien;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.Label lb_sousTitre;
        private System.Windows.Forms.Button bt_Quitter;
        private System.Windows.Forms.Button button1;
    }
}