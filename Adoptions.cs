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
    public partial class Adoptions : Form
    {
        private static Refuge refuge = new Refuge();
        public Adoptions()
        {
            InitializeComponent();
            ArrayList listeAdoptions = Charger<ArrayList>("chien_adopte.txt");
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Dylan\Desktop\Projet_Chien\Refuge_chien\Refuge_chien\bin\Debug\chien_adopte.txt");
            foreach (string line in lines)
            {
                rtb_listeAdoptions.Text = "\t" + line;
            }
        }

        private void gb_lesAdoptions_Enter(object sender, EventArgs e)
        {
            

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
                if (flux != null)
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
                if (flux != null)
                    flux.Close();
            }

        }
    }
}
