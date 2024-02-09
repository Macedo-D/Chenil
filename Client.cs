using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Refuge_chien
{
    [Serializable]
    class Client
    {
        private string nom;
        private string prenom;
        private int codePostal;
        private string adresse;
        private string numTel;
        private int chienParraine;

        public Client(string unNom, string unPrenom, int unCp, string uneAdresse, string unNumTel, int unchienParraine)
        {
            this.nom = unNom;
            this.prenom = unPrenom;
            this.codePostal = unCp;
            this.adresse = uneAdresse;
            this.numTel = unNumTel;
            this.chienParraine = unchienParraine;
        }
        public string NomClient
        {
            get { return nom; }
            set { nom = value; }
        }
        public string NumTelClient
        {
            get { return numTel; }
            set { numTel = value; }
        }
        public string PrenomClient
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string AdresseClient
        {
            get { return adresse; }
            set { adresse = value; }
        }
        public int CpClient
        {
            get { return codePostal; }
            set { codePostal = value; }
        }
        public int Parrain
        {
            get { return chienParraine; }
            set { chienParraine = value; }
        }
    }
}
