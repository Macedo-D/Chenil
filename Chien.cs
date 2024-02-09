using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using System.Xml.Serialization;

namespace Refuge_chien
{
    [Serializable]
    class Chien
    {
        private string race;
        private string taille; //string petit, grand, moyen
        private int poids;//Kg
        private string sexe;
        private string age;// string mois, années
        private string nom;
        private int numero;

        public Chien() 
        {
        }
        public Chien(string uneTaille, int unPoids, string uneRace, string unSexe, string unAge, string unNom, int unNumero)
        {
            this.taille = uneTaille;
            this.poids = unPoids;
            this.race = uneRace;
            this.sexe = unSexe;
            this.age = unAge;
            this.nom = unNom;
            this.numero = unNumero;
        }
        public string Taille
        {
            get { return taille; }
            set { taille = value; }
        }
        public int Poids
        {
            get { return poids; }
            set { poids = value; }
        }
        public string Race
        {
            get { return race; }
            set { race = value; }
        }
        public string Sexe
        {
            get { return sexe; }
            set { sexe = value; }
        }
        public string Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public void Aboyer(string uneRace)
        {
            SoundPlayer aboiement = new SoundPlayer();
            aboiement.SoundLocation = @"C:\Users\Dylan\Desktop\Projet_Chien\Aboiement de chien\" + uneRace + ".wav";
            aboiement.Play();
        }
    }
}
