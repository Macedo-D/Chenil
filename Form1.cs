using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //pour pouvoir utiliser un fichier
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary; // pour la serialization binaire.
using System.Net;
using System.Net.Mail;

namespace Refuge_chien
{
    public partial class Form_RefugeChien : Form
    {
        private static Refuge refuge = new Refuge();
        public Form_RefugeChien()
        {
            InitializeComponent();
            lb_accueil.Text = lb_accueil.Text + " la Fondation CSF de Massy vous propose" + "\n" + " de nombreuses fiches d adoption de chien de refuge." + "\n" + " De nombreuses races sont à disposition." + "\n" + " Adoptez votre futur animal de compagnie en utilisant les différents critères" + "\n" + " du moteur de recherche.";

            //Désérialisation : on charge les chiens
            ArrayList listeChien = Charger<ArrayList>("chien_refuge.txt");
            //if (listeChien == null)
            //{
            //    listeChien = refuge.GetListeChien();
            //    Chien chien_1 = new Chien("Moyen", 27, "labrador", "Femelle", "4 ans", "Jump", 1);
            //    refuge.SetListeChien(chien_1);
            //    Chien chien_2 = new Chien("Grand", 20, "husky", "Male", "3 ans", "Jorky", 2);
            //    refuge.SetListeChien(chien_2);
            //    Chien chien_3 = new Chien("Petit", 10, "dalmatien", "Male", "11 mois", "Lox", 3);
            //    refuge.SetListeChien(chien_3);
            //    Chien chien_4 = new Chien("Moyen", 8, "akita", "Male", "1 ans", "Dior", 4);
            //    refuge.SetListeChien(chien_4);
            //    Chien chien_5 = new Chien("Petit", 10, "labrador", "Femelle", "1 ans", "Pongo", 5);
            //    refuge.SetListeChien(chien_5);
            //    Chien chien_6 = new Chien("Grand", 25, "bergerAllemand", "Femelle", "4 ans", "Tina", 6);
            //    refuge.SetListeChien(chien_6);
            //    Chien chien_7 = new Chien("Moyen", 15, "husky", "Femelle", "2 ans", "Jolia", 7);
            //    refuge.SetListeChien(chien_7);
            //    Chien chien_8 = new Chien("Petit", 9, "caniche", "Femelle", "2 ans", "Luna", 8);
            //    refuge.SetListeChien(chien_8);
            //}
            //Sérialisation 

            //Enregistrer(listeChien, "chien_refuge.txt");

            foreach (Chien chien in listeChien)
            {
                if (!cb_race.Items.Contains(chien.Race))
                {
                    cb_race.Items.Add(chien.Race);
                }
            };
            ////On stocke le chemin et le nom de la classe afin de pouvoir les utiliser par la suite.
            //string chemin = ComboBoxClasses.Text.ToString();
            //string nomClasse = chemin.Substring(8, 5);
            ////Instanciation du mail et du serveur SMTP afin de pouvoir procéder à l'envoi du message
            ////Instanciation du mail et du serveur SMTP afin de pouvoir procéder à l'envoi du message
            //MailMessage mail = new MailMessage();
            //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            ////Adresse de l'expéditeur
            //mail.From = new MailAddress("noreplyvilgenis@gmail.com");
            ////Adresse du destinataire
            ////Si l'adresse est valide, on ne touche pas à la valeur de estValide, sinon on la met en false afin d'arrêter la tentative d'envoi.
            //bool estValide = true;

            //// Si estValide est vrai, alors on peut procéder à l'envoi.
            //if (estValide == true)
            //{
            //    mail.To.Add("adopteur@free.fr");
            //    //L'objet du mail
            //    mail.Subject = "Refuge de MAssy ";
            //    //Le contenu du mail
            //    mail.Body = "Bonjour, nous voulions vous remercier pour votre adoptions. ";
            //    //Selection de la pièce jointe
            //    System.Net.Mail.Attachment pieceJointe;
            //    pieceJointe = new System.Net.Mail.Attachment(chemin);
            //    //Ajout de la pièce jointe dans le message
            //    mail.Attachments.Add(pieceJointe);
            //    //Le port pour gmail est 587.
            //    SmtpServer.Port = 587;
            //    SmtpServer.Credentials = new System.Net.NetworkCredential("noreplyvilgenis@gmail.com", "tototata");
            //    //La connexion doit être chiffrée pour que le mail puisse être envoyé
            //    SmtpServer.EnableSsl = true;
            //    // On envoie.
            //    SmtpServer.Send(mail);
            //    // On affiche une fenêtre de dialogue pour notifier l'utilisateur.
            //    System.Windows.Forms.MessageBox.Show("La liste a été envoyée à " + TxtBoxMail.Text, "Envoi réussi", System.Windows.Forms.MessageBoxButtons.OK);
            //}

        }

        private void bt_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_valider_Click(object sender, EventArgs e)
        {
            try
            {
                string race = cb_race.SelectedItem.ToString();
                string sexe = cb_sexe.SelectedItem.ToString();
                bool chienExiste = false;
                ArrayList listeChien = Charger<ArrayList>("chien_refuge.txt");
                foreach (Chien chien in listeChien)
                {
                    if (chien.Race == race && chien.Sexe == sexe)
                    {
                        chienExiste = true;
                    }                                                                                   
                    
                };
                if (chienExiste == false)
                {
                    MessageBox.Show("Nous n'avons pas ce type de chien.");
                }
                else 
                {
                    this.Visible = false;
                    Form_Resultat_recherche Generer = new Form_Resultat_recherche(race,sexe);
                    Generer.Show();
                }
            }
            catch //(Exception ex)
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
            }
        }

        private static void Enregistrer(object unObject, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream flux = null;
            try
            {
                flux = new FileStream(path, FileMode.Create, FileAccess.Write);
                formatter.Serialize(flux, unObject);
                flux.Flush();//On s'assure que le tout soit écrit dans le fichier.
            }
            catch { }
            finally
            {
                //on ferme le flux.
                if(flux != null)
                    flux.Close();
            }
        }

        private static T Charger<T>(string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream flux = null;
            try
            {
                //si le fichier n'existe pas, une exception sera levée.
                flux = new FileStream(path, FileMode.Open, FileAccess.Read);

                return (T)formatter.Deserialize(flux);
            }
            catch
            {
                //On retourne la valeur par défaut du type T.
                return default(T);
            }
            finally
            {
                if(flux != null)
                    flux.Close();
            }

        }

        private void btVoirAdoption_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adoptions generer = new Adoptions();
            generer.Show();
        }

    }
}
