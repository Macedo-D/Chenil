namespace Refuge_chien
{
    partial class Adoptions
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
            this.gb_lesAdoptions = new System.Windows.Forms.GroupBox();
            this.rtb_listeAdoptions = new System.Windows.Forms.RichTextBox();
            this.gb_lesAdoptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_lesAdoptions
            // 
            this.gb_lesAdoptions.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gb_lesAdoptions.Controls.Add(this.rtb_listeAdoptions);
            this.gb_lesAdoptions.Location = new System.Drawing.Point(23, 12);
            this.gb_lesAdoptions.Name = "gb_lesAdoptions";
            this.gb_lesAdoptions.Size = new System.Drawing.Size(1046, 542);
            this.gb_lesAdoptions.TabIndex = 0;
            this.gb_lesAdoptions.TabStop = false;
            this.gb_lesAdoptions.Text = "Les adoptions du refuge :";
            this.gb_lesAdoptions.Enter += new System.EventHandler(this.gb_lesAdoptions_Enter);
            // 
            // rtb_listeAdoptions
            // 
            this.rtb_listeAdoptions.Location = new System.Drawing.Point(46, 50);
            this.rtb_listeAdoptions.Name = "rtb_listeAdoptions";
            this.rtb_listeAdoptions.Size = new System.Drawing.Size(708, 366);
            this.rtb_listeAdoptions.TabIndex = 37;
            this.rtb_listeAdoptions.Text = "";
            // 
            // Adoptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 615);
            this.Controls.Add(this.gb_lesAdoptions);
            this.Name = "Adoptions";
            this.Text = "Adoptions";
            this.gb_lesAdoptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_lesAdoptions;
        private System.Windows.Forms.RichTextBox rtb_listeAdoptions;
    }
}