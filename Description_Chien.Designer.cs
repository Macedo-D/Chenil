namespace Refuge_chien
{
    partial class Form_Description_Chien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Description_Chien));
            this.lb_logo = new System.Windows.Forms.Label();
            this.lb_titre = new System.Windows.Forms.Label();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.lb_sousTitre = new System.Windows.Forms.Label();
            this.bt_Quitter = new System.Windows.Forms.Button();
            this.pbChien = new System.Windows.Forms.PictureBox();
            this.gb_description = new System.Windows.Forms.GroupBox();
            this.lb_parrains = new System.Windows.Forms.Label();
            this.rtb_listeparrain = new System.Windows.Forms.RichTextBox();
            this.tb_NumUtilisateur = new System.Windows.Forms.TextBox();
            this.lb_NumTelUtilisateur = new System.Windows.Forms.Label();
            this.lb_numChienDesc = new System.Windows.Forms.Label();
            this.tb_AdresseUtilisateur = new System.Windows.Forms.TextBox();
            this.mtb_CodePostalUtil = new System.Windows.Forms.MaskedTextBox();
            this.tb_prenomUtil = new System.Windows.Forms.TextBox();
            this.lb_AdresseUtil = new System.Windows.Forms.Label();
            this.lb_CodePostalUtil = new System.Windows.Forms.Label();
            this.lb_prenomUtil = new System.Windows.Forms.Label();
            this.bt_parrainer = new System.Windows.Forms.Button();
            this.cb_chx = new System.Windows.Forms.ComboBox();
            this.lb_chx = new System.Windows.Forms.Label();
            this.lb_nomUtil = new System.Windows.Forms.Label();
            this.mtb_somme = new System.Windows.Forms.MaskedTextBox();
            this.lb_somme = new System.Windows.Forms.Label();
            this.lb_coordonnees = new System.Windows.Forms.Label();
            this.tb_nomUtilisateur = new System.Windows.Forms.TextBox();
            this.bt_validerChx = new System.Windows.Forms.Button();
            this.rtb_resultat = new System.Windows.Forms.RichTextBox();
            this.bt_cliquer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChien)).BeginInit();
            this.gb_description.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_logo
            // 
            this.lb_logo.AutoSize = true;
            this.lb_logo.BackColor = System.Drawing.Color.Transparent;
            this.lb_logo.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logo.Location = new System.Drawing.Point(161, -1);
            this.lb_logo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_logo.Name = "lb_logo";
            this.lb_logo.Size = new System.Drawing.Size(188, 90);
            this.lb_logo.TabIndex = 13;
            this.lb_logo.Text = "CSF";
            // 
            // lb_titre
            // 
            this.lb_titre.AutoSize = true;
            this.lb_titre.BackColor = System.Drawing.Color.Transparent;
            this.lb_titre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_titre.Location = new System.Drawing.Point(173, 89);
            this.lb_titre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_titre.Name = "lb_titre";
            this.lb_titre.Size = new System.Drawing.Size(156, 17);
            this.lb_titre.TabIndex = 16;
            this.lb_titre.Text = "CHIEN SANS FOYER";
            // 
            // pb_logo
            // 
            this.pb_logo.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pb_logo.BackgroundImage = global::Refuge_chien.Properties.Resources.logo_refuge;
            this.pb_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_logo.Location = new System.Drawing.Point(43, 10);
            this.pb_logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(114, 96);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logo.TabIndex = 21;
            this.pb_logo.TabStop = false;
            // 
            // lb_sousTitre
            // 
            this.lb_sousTitre.AutoSize = true;
            this.lb_sousTitre.BackColor = System.Drawing.Color.Transparent;
            this.lb_sousTitre.Font = new System.Drawing.Font("Times New Roman", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sousTitre.ForeColor = System.Drawing.Color.Black;
            this.lb_sousTitre.Location = new System.Drawing.Point(444, 29);
            this.lb_sousTitre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_sousTitre.Name = "lb_sousTitre";
            this.lb_sousTitre.Size = new System.Drawing.Size(370, 55);
            this.lb_sousTitre.TabIndex = 22;
            this.lb_sousTitre.Text = "Refuge de Massy";
            // 
            // bt_Quitter
            // 
            this.bt_Quitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.bt_Quitter.Location = new System.Drawing.Point(1445, 10);
            this.bt_Quitter.Name = "bt_Quitter";
            this.bt_Quitter.Size = new System.Drawing.Size(89, 36);
            this.bt_Quitter.TabIndex = 23;
            this.bt_Quitter.Text = "Quitter";
            this.bt_Quitter.UseVisualStyleBackColor = true;
            // 
            // pbChien
            // 
            this.pbChien.BackColor = System.Drawing.Color.White;
            this.pbChien.Location = new System.Drawing.Point(184, 351);
            this.pbChien.Name = "pbChien";
            this.pbChien.Size = new System.Drawing.Size(128, 127);
            this.pbChien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChien.TabIndex = 24;
            this.pbChien.TabStop = false;
            // 
            // gb_description
            // 
            this.gb_description.BackColor = System.Drawing.Color.White;
            this.gb_description.Controls.Add(this.lb_parrains);
            this.gb_description.Controls.Add(this.rtb_listeparrain);
            this.gb_description.Controls.Add(this.tb_NumUtilisateur);
            this.gb_description.Controls.Add(this.lb_NumTelUtilisateur);
            this.gb_description.Controls.Add(this.lb_numChienDesc);
            this.gb_description.Controls.Add(this.tb_AdresseUtilisateur);
            this.gb_description.Controls.Add(this.mtb_CodePostalUtil);
            this.gb_description.Controls.Add(this.tb_prenomUtil);
            this.gb_description.Controls.Add(this.lb_AdresseUtil);
            this.gb_description.Controls.Add(this.lb_CodePostalUtil);
            this.gb_description.Controls.Add(this.lb_prenomUtil);
            this.gb_description.Controls.Add(this.bt_parrainer);
            this.gb_description.Controls.Add(this.cb_chx);
            this.gb_description.Controls.Add(this.lb_chx);
            this.gb_description.Controls.Add(this.lb_nomUtil);
            this.gb_description.Controls.Add(this.mtb_somme);
            this.gb_description.Controls.Add(this.lb_somme);
            this.gb_description.Controls.Add(this.lb_coordonnees);
            this.gb_description.Controls.Add(this.tb_nomUtilisateur);
            this.gb_description.Controls.Add(this.bt_validerChx);
            this.gb_description.Controls.Add(this.rtb_resultat);
            this.gb_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_description.Location = new System.Drawing.Point(428, 227);
            this.gb_description.Name = "gb_description";
            this.gb_description.Size = new System.Drawing.Size(615, 447);
            this.gb_description.TabIndex = 25;
            this.gb_description.TabStop = false;
            this.gb_description.Text = "Description : Chien N°";
            // 
            // lb_parrains
            // 
            this.lb_parrains.AutoSize = true;
            this.lb_parrains.Location = new System.Drawing.Point(300, 44);
            this.lb_parrains.Name = "lb_parrains";
            this.lb_parrains.Size = new System.Drawing.Size(280, 17);
            this.lb_parrains.TabIndex = 37;
            this.lb_parrains.Text = "Ce chien remercie tous ses parrains :";
            // 
            // rtb_listeparrain
            // 
            this.rtb_listeparrain.Location = new System.Drawing.Point(375, 64);
            this.rtb_listeparrain.Name = "rtb_listeparrain";
            this.rtb_listeparrain.Size = new System.Drawing.Size(125, 96);
            this.rtb_listeparrain.TabIndex = 36;
            this.rtb_listeparrain.Text = "";
            //this.rtb_listeparrain.TextChanged += new System.EventHandler(this.rtb_listeparrain_TextChanged);
            // 
            // tb_NumUtilisateur
            // 
            this.tb_NumUtilisateur.Location = new System.Drawing.Point(125, 309);
            this.tb_NumUtilisateur.Name = "tb_NumUtilisateur";
            this.tb_NumUtilisateur.Size = new System.Drawing.Size(128, 22);
            this.tb_NumUtilisateur.TabIndex = 34;
            // 
            // lb_NumTelUtilisateur
            // 
            this.lb_NumTelUtilisateur.AutoSize = true;
            this.lb_NumTelUtilisateur.Location = new System.Drawing.Point(6, 312);
            this.lb_NumTelUtilisateur.Name = "lb_NumTelUtilisateur";
            this.lb_NumTelUtilisateur.Size = new System.Drawing.Size(113, 17);
            this.lb_NumTelUtilisateur.TabIndex = 33;
            this.lb_NumTelUtilisateur.Text = "N° telephone :";
            // 
            // lb_numChienDesc
            // 
            this.lb_numChienDesc.AutoSize = true;
            this.lb_numChienDesc.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numChienDesc.Location = new System.Drawing.Point(179, 0);
            this.lb_numChienDesc.Name = "lb_numChienDesc";
            this.lb_numChienDesc.Size = new System.Drawing.Size(40, 16);
            this.lb_numChienDesc.TabIndex = 32;
            this.lb_numChienDesc.Text = "Chien";
            // 
            // tb_AdresseUtilisateur
            // 
            this.tb_AdresseUtilisateur.Location = new System.Drawing.Point(286, 277);
            this.tb_AdresseUtilisateur.Name = "tb_AdresseUtilisateur";
            this.tb_AdresseUtilisateur.Size = new System.Drawing.Size(155, 22);
            this.tb_AdresseUtilisateur.TabIndex = 31;
            // 
            // mtb_CodePostalUtil
            // 
            this.mtb_CodePostalUtil.Location = new System.Drawing.Point(120, 277);
            this.mtb_CodePostalUtil.Mask = "99999";
            this.mtb_CodePostalUtil.Name = "mtb_CodePostalUtil";
            this.mtb_CodePostalUtil.Size = new System.Drawing.Size(47, 22);
            this.mtb_CodePostalUtil.TabIndex = 30;
            // 
            // tb_prenomUtil
            // 
            this.tb_prenomUtil.Location = new System.Drawing.Point(286, 240);
            this.tb_prenomUtil.Name = "tb_prenomUtil";
            this.tb_prenomUtil.Size = new System.Drawing.Size(100, 22);
            this.tb_prenomUtil.TabIndex = 29;
            // 
            // lb_AdresseUtil
            // 
            this.lb_AdresseUtil.AutoSize = true;
            this.lb_AdresseUtil.Location = new System.Drawing.Point(203, 280);
            this.lb_AdresseUtil.Name = "lb_AdresseUtil";
            this.lb_AdresseUtil.Size = new System.Drawing.Size(77, 17);
            this.lb_AdresseUtil.TabIndex = 28;
            this.lb_AdresseUtil.Text = "Adresse :";
            // 
            // lb_CodePostalUtil
            // 
            this.lb_CodePostalUtil.AutoSize = true;
            this.lb_CodePostalUtil.Location = new System.Drawing.Point(4, 280);
            this.lb_CodePostalUtil.Name = "lb_CodePostalUtil";
            this.lb_CodePostalUtil.Size = new System.Drawing.Size(110, 17);
            this.lb_CodePostalUtil.TabIndex = 27;
            this.lb_CodePostalUtil.Text = "Code Postal : ";
            // 
            // lb_prenomUtil
            // 
            this.lb_prenomUtil.AutoSize = true;
            this.lb_prenomUtil.Location = new System.Drawing.Point(208, 243);
            this.lb_prenomUtil.Name = "lb_prenomUtil";
            this.lb_prenomUtil.Size = new System.Drawing.Size(72, 17);
            this.lb_prenomUtil.TabIndex = 26;
            this.lb_prenomUtil.Text = "prénom :";
            // 
            // bt_parrainer
            // 
            this.bt_parrainer.Location = new System.Drawing.Point(314, 391);
            this.bt_parrainer.Name = "bt_parrainer";
            this.bt_parrainer.Size = new System.Drawing.Size(94, 35);
            this.bt_parrainer.TabIndex = 25;
            this.bt_parrainer.Text = "Parrainer";
            this.bt_parrainer.UseVisualStyleBackColor = true;
            this.bt_parrainer.Click += new System.EventHandler(this.bt_parrainer_Click);
            // 
            // cb_chx
            // 
            this.cb_chx.FormattingEnabled = true;
            this.cb_chx.Items.AddRange(new object[] {
            "Adopter",
            "Parrainer"});
            this.cb_chx.Location = new System.Drawing.Point(238, 348);
            this.cb_chx.Name = "cb_chx";
            this.cb_chx.Size = new System.Drawing.Size(121, 24);
            this.cb_chx.TabIndex = 24;
            // 
            // lb_chx
            // 
            this.lb_chx.AutoSize = true;
            this.lb_chx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chx.Location = new System.Drawing.Point(3, 348);
            this.lb_chx.Name = "lb_chx";
            this.lb_chx.Size = new System.Drawing.Size(204, 20);
            this.lb_chx.TabIndex = 23;
            this.lb_chx.Text = "Que voulez vous faire :";
            // 
            // lb_nomUtil
            // 
            this.lb_nomUtil.AutoSize = true;
            this.lb_nomUtil.Location = new System.Drawing.Point(6, 243);
            this.lb_nomUtil.Name = "lb_nomUtil";
            this.lb_nomUtil.Size = new System.Drawing.Size(48, 17);
            this.lb_nomUtil.TabIndex = 22;
            this.lb_nomUtil.Text = "nom :";
            // 
            // mtb_somme
            // 
            this.mtb_somme.Location = new System.Drawing.Point(171, 397);
            this.mtb_somme.Mask = "9999999999999999";
            this.mtb_somme.Name = "mtb_somme";
            this.mtb_somme.Size = new System.Drawing.Size(119, 22);
            this.mtb_somme.TabIndex = 19;
            // 
            // lb_somme
            // 
            this.lb_somme.AutoSize = true;
            this.lb_somme.Location = new System.Drawing.Point(35, 400);
            this.lb_somme.Name = "lb_somme";
            this.lb_somme.Size = new System.Drawing.Size(130, 17);
            this.lb_somme.TabIndex = 17;
            this.lb_somme.Text = "Somme du don  :";
            // 
            // lb_coordonnees
            // 
            this.lb_coordonnees.AutoSize = true;
            this.lb_coordonnees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_coordonnees.Location = new System.Drawing.Point(3, 214);
            this.lb_coordonnees.Name = "lb_coordonnees";
            this.lb_coordonnees.Size = new System.Drawing.Size(166, 20);
            this.lb_coordonnees.TabIndex = 16;
            this.lb_coordonnees.Text = "Vos coordonnées :";
            // 
            // tb_nomUtilisateur
            // 
            this.tb_nomUtilisateur.Location = new System.Drawing.Point(63, 240);
            this.tb_nomUtilisateur.Name = "tb_nomUtilisateur";
            this.tb_nomUtilisateur.Size = new System.Drawing.Size(119, 22);
            this.tb_nomUtilisateur.TabIndex = 14;
            // 
            // bt_validerChx
            // 
            this.bt_validerChx.Location = new System.Drawing.Point(375, 343);
            this.bt_validerChx.Name = "bt_validerChx";
            this.bt_validerChx.Size = new System.Drawing.Size(90, 32);
            this.bt_validerChx.TabIndex = 12;
            this.bt_validerChx.Text = "Valider";
            this.bt_validerChx.UseVisualStyleBackColor = true;
            this.bt_validerChx.Click += new System.EventHandler(this.bt_validerChx_Click);
            // 
            // rtb_resultat
            // 
            this.rtb_resultat.Location = new System.Drawing.Point(26, 21);
            this.rtb_resultat.Name = "rtb_resultat";
            this.rtb_resultat.Size = new System.Drawing.Size(268, 162);
            this.rtb_resultat.TabIndex = 11;
            this.rtb_resultat.Text = "";
            // 
            // bt_cliquer
            // 
            this.bt_cliquer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.bt_cliquer.Location = new System.Drawing.Point(1136, 12);
            this.bt_cliquer.Name = "bt_cliquer";
            this.bt_cliquer.Size = new System.Drawing.Size(89, 36);
            this.bt_cliquer.TabIndex = 26;
            this.bt_cliquer.Text = "Quitter";
            this.bt_cliquer.UseVisualStyleBackColor = true;
            this.bt_cliquer.Click += new System.EventHandler(this.bt_cliquer_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.button1.Location = new System.Drawing.Point(1136, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Accueil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_Description_Chien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Refuge_chien.Properties.Resources.fond;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1237, 708);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_cliquer);
            this.Controls.Add(this.gb_description);
            this.Controls.Add(this.pbChien);
            this.Controls.Add(this.bt_Quitter);
            this.Controls.Add(this.lb_sousTitre);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.lb_titre);
            this.Controls.Add(this.lb_logo);
            this.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Description_Chien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Description_Chien";
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChien)).EndInit();
            this.gb_description.ResumeLayout(false);
            this.gb_description.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_logo;
        private System.Windows.Forms.Label lb_titre;
        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Label lb_sousTitre;
        private System.Windows.Forms.Button bt_Quitter;
        private System.Windows.Forms.PictureBox pbChien;
        private System.Windows.Forms.GroupBox gb_description;
        private System.Windows.Forms.TextBox tb_NumUtilisateur;
        private System.Windows.Forms.Label lb_NumTelUtilisateur;
        private System.Windows.Forms.Label lb_numChienDesc;
        private System.Windows.Forms.TextBox tb_AdresseUtilisateur;
        private System.Windows.Forms.MaskedTextBox mtb_CodePostalUtil;
        private System.Windows.Forms.TextBox tb_prenomUtil;
        private System.Windows.Forms.Label lb_AdresseUtil;
        private System.Windows.Forms.Label lb_CodePostalUtil;
        private System.Windows.Forms.Label lb_prenomUtil;
        private System.Windows.Forms.Button bt_parrainer;
        private System.Windows.Forms.ComboBox cb_chx;
        private System.Windows.Forms.Label lb_chx;
        private System.Windows.Forms.Label lb_nomUtil;
        private System.Windows.Forms.MaskedTextBox mtb_somme;
        private System.Windows.Forms.Label lb_somme;
        private System.Windows.Forms.Label lb_coordonnees;
        private System.Windows.Forms.TextBox tb_nomUtilisateur;
        private System.Windows.Forms.Button bt_validerChx;
        private System.Windows.Forms.RichTextBox rtb_resultat;
        private System.Windows.Forms.Button bt_cliquer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_parrains;
        private System.Windows.Forms.RichTextBox rtb_listeparrain;
    }
}