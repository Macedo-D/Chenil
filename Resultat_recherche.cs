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

namespace Refuge_chien
{
    public partial class Form_Resultat_recherche : Form
    {
        private static Refuge refuge = new Refuge();
        public Form_Resultat_recherche(string race, string sexe)
        {
            InitializeComponent();
            clb_selectionChien.Items.Clear();

            ArrayList listeChien = Charger<ArrayList>("chien_refuge.txt");
            foreach (Chien chien in listeChien)
            {              
                if (chien.Race == race && chien.Sexe == sexe)
                {
                    lb_resuRaceNom.Text = "Race : " + chien.Race + " Sexe : " + chien.Sexe;
                    clb_selectionChien.Items.Add(chien.Numero);
                }
            };
        }

        private void bt_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_validerChoixSelectionChien_Click(object sender, EventArgs e)
        {
            if (clb_selectionChien.Text != "")
            {
                int numChien = Convert.ToInt16(clb_selectionChien.SelectedItem.ToString());
                ArrayList listeChien = Charger<ArrayList>("chien_refuge.txt");
                foreach (Chien chien in listeChien)
                {
                    if (chien.Numero == numChien)
                    {
                        this.Visible = false;
                        Form_Description_Chien Generer = new Form_Description_Chien(chien.Taille, chien.Poids, chien.Race, chien.Sexe, chien.Age, chien.Nom, chien.Numero);
                        Generer.Show();
                    }
                };
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un chien.");
            }
        }
        //Sérialisation
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
        //Désérialisation
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

        private void Form_Resultat_recherche_Load(object sender, EventArgs e)
        {
            this.Hide();
            Form_RefugeChien generer = new Form_RefugeChien();
            generer.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_RefugeChien generer = new Form_RefugeChien();
            generer.Show();
        }
    }
}
