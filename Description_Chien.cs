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
using System.Media;

namespace Refuge_chien
{
    public partial class Form_Description_Chien : Form
    {
        private Refuge refuge = new Refuge();
        public Form_Description_Chien(string chienTaille, int chienPoids, string chienRace, string chienSexe, string chienAge, string chienNom, int chienNumero)
        {
            InitializeComponent();
            lb_somme.Visible = false;
            mtb_somme.Visible = false;
            bt_parrainer.Visible = false;
            rtb_listeparrain.Visible = false;
            lb_parrains.Visible = false;

            lb_numChienDesc.Text = Convert.ToString(chienNumero);
            FileStream fs = new FileStream(@"C:\Users\Dylan\Desktop\Projet_Chien\Images\chien-" + chienNumero + ".jpg", FileMode.Open);
            pbChien.Image = Image.FromStream(fs);
            fs.Close();
            
            ArrayList listeClient = Charger<ArrayList>("client_refuge.txt");
            if (listeClient == null)
            {
                listeClient = refuge.GetListeClient();
                Client client_1 = new Client("Macedo", "Dylan", 91390, "15 rue Jules Ferry", "0785956585", 0);
                refuge.SetListeClient(client_1);
            }
            string clientPrenom = ""; 
            string clientNom = "";
            foreach (Client unClient in listeClient)
            {
                if (unClient.Parrain == chienNumero)
                {
                    rtb_listeparrain.Visible = true;
                    lb_parrains.Visible = true;
                    clientNom = clientNom +"\n"+ unClient.NomClient;
                    clientPrenom = clientPrenom + "\n" + unClient.PrenomClient;
                }
            }
            rtb_listeparrain.Text = clientNom + " " + clientPrenom + "\n\n";
            Enregistrer(listeClient, "client_refuge.txt");
            rtb_resultat.Text = chienNom + " est un(e) " + chienSexe + " de la race " + chienRace + ". Il(Elle) a " + chienAge + ", pese " + chienPoids + "kg.";

            Chien chienA = new Chien();
            chienA.Aboyer(chienRace);

        }

        private void bt_cliquer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_parrainer_Click(object sender, EventArgs e)
        {
            if (mtb_somme.Text != "" && tb_nomUtilisateur.Text != "" && tb_prenomUtil.Text != "" && mtb_CodePostalUtil.Text != "" && tb_AdresseUtilisateur.Text != "" && lb_NumTelUtilisateur.Text != "")
            {
                string nom_utilisateur = tb_nomUtilisateur.Text;
                string prenom_utilisateur = tb_prenomUtil.Text;
                int cp_utilsisateur = Convert.ToInt32(mtb_CodePostalUtil.Text);
                string adresse_utilisateur = tb_AdresseUtilisateur.Text;
                string numTel_utilisateur = tb_NumUtilisateur.Text;
                int parrain_chien = 0;
                int numChien = (int)Convert.ToInt64(lb_numChienDesc.Text);
                ArrayList listeChien = Charger<ArrayList>("chien_refuge.txt");
                foreach (Chien chien in listeChien)
                {
                    if (chien.Numero == numChien)
                    {
                        ArrayList listeClient = Charger<ArrayList>("client_refuge.txt");
                        Client parrain = new Client(nom_utilisateur, prenom_utilisateur, cp_utilsisateur, adresse_utilisateur, numTel_utilisateur, parrain_chien);
                        refuge.SetParrainage(parrain,chien);
                        Enregistrer(listeClient, "client_refuge.txt");
                    }
                };
                MessageBox.Show("Merci pour votre généreux don." + "\n" + " Nous espérons vous revoir bientôt.");
                tb_AdresseUtilisateur.Clear();
                tb_nomUtilisateur.Clear();
                tb_NumUtilisateur.Clear();
                tb_prenomUtil.Clear();
                mtb_CodePostalUtil.Clear();
                mtb_somme.Clear();
            }
            else
            {
                MessageBox.Show("Veuillez bien remplir toutes vos coordonées et saisir une somme si vous avez l'intention de parrainer ce chien.");
            }
        }

        private void bt_validerChx_Click(object sender, EventArgs e)
        {
            if (cb_chx.Text == "Parrainer")
            {
                lb_somme.Visible = true;
                mtb_somme.Visible = true;
                bt_parrainer.Visible = true;
            }
            else
            {
                if (cb_chx.Text == "Adopter")
                {
                    if (tb_nomUtilisateur.Text != "" && tb_prenomUtil.Text != "" && mtb_CodePostalUtil.Text != "" && tb_AdresseUtilisateur.Text != "" && lb_NumTelUtilisateur.Text != "")
                    {   
                        string nom_utilisateur = tb_nomUtilisateur.Text;
                        string prenom_utilisateur = tb_prenomUtil.Text;
                        int cp_utilsisateur = Convert.ToInt32(mtb_CodePostalUtil.Text);
                        string adresse_utilisateur = tb_AdresseUtilisateur.Text;
                        string numTel_utilisateur = tb_NumUtilisateur.Text;
                        int parrain_chien = 0;
                        string dateAdoption;
                        dateAdoption = Convert.ToString(DateTime.Now);
                        MessageBox.Show("Vous venez d'adopter ce chien. Il vous remercie et est impatient de vous retrouvez !");
                        int numChien = Convert.ToInt16(lb_numChienDesc.Text);
                        ArrayList listeChien = Charger<ArrayList>("chien_refuge.txt");
                        foreach (Chien chien in listeChien)
                        {
                            if (chien.Numero == numChien)
                            {
                                ArrayList listeChienAdopte = Charger<ArrayList>("chien_adopte.txt");
                                listeChienAdopte = refuge.GetListeChienAdopte();
                                
                                Client parrain = new Client(nom_utilisateur, prenom_utilisateur, cp_utilsisateur, adresse_utilisateur, numTel_utilisateur, parrain_chien);
                                refuge.SetAdoption(chien, parrain, dateAdoption, 1);
                                listeChien.Remove(chien);
                                Enregistrer(listeChien, "chien_refuge.txt");
                                break;
                            }
                        };
                        tb_AdresseUtilisateur.Clear();
                        tb_nomUtilisateur.Clear();
                        tb_NumUtilisateur.Clear();
                        tb_prenomUtil.Clear();
                        mtb_CodePostalUtil.Clear();
                        mtb_somme.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Veuillez bien remplir toutes vos coordonnées si vous avez l'intention d'adopter ce chien.");
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs pour continuer.");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_RefugeChien generer = new Form_RefugeChien();
            generer.Show();
        }
        //sérialisation
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
                if (flux != null)
                    flux.Close();
            }
        }
        //désérialisation
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
                if (flux != null)
                    flux.Close();
            }

        }

        
    }
}
