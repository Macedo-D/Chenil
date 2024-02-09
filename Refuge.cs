using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO; //pour pouvoir utiliser un fichier
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary; // pour la serialization binaire.

namespace Refuge_chien
{
    [Serializable]
    class Refuge
    {
        private ArrayList listeChien = new ArrayList();
        private ArrayList listeClient = new ArrayList();
        private ArrayList listeChienAdopte = new ArrayList();

        public ArrayList GetListeChien()
        {
            return listeChien;
        }
        public void SetListeChien(Chien unChien)
        {
            listeChien.Add(unChien);
        }
        public ArrayList GetListeClient()
        {
            return listeClient;
        }
        public void SetListeClient(Client unClient)
        {
            listeClient.Add(unClient);
        }
        public void SetParrainage(Client unClient, Chien unChien)
        {
            listeClient.Remove(unClient);
            unClient.Parrain = unChien.Numero;
            listeClient.Add(unClient);
            Enregistrer(listeClient, "client_refuge.txt");
        }
        public ArrayList GetListeChienAdopte()
        {
            return listeChienAdopte;
        }
        public void SetAdoption(Chien unChien, Client unClient, string dateAdoption, int nbAdoption)
        {
            listeChienAdopte.Add(unChien+unClient.PrenomClient+unClient.NomClient+dateAdoption+1);
            Enregistrer(listeChienAdopte, "chien_adopte.txt");
        }


        //Fonction pour la sérialisation
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
    }
}
