using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsenEnergy
{
    internal class Fournisseur
    {
        private bool isFournisseur { get; set; }
        private string nomEntreprise { get; set; }
        private string nomPropriétaire { get; set; }
        private string adresse { get; set; }
        private string email { get; set; }
        string nifstat { get; set; }
        private int solde { get; set; }
        private string motDePasse { get; set; }

        public Fournisseur(bool isFournisseur, string nomEntreprise, string nomPropriétaire, string adresse, string email, string nifstat, int solde, string motDePasse)
        {
            this.isFournisseur = isFournisseur;
            this.nomEntreprise = nomEntreprise;
            this.nomPropriétaire = nomPropriétaire;
            this.adresse = adresse;
            this.email = email;
            this.nifstat = nifstat;
            this.solde = solde;
            this.motDePasse = motDePasse;
        }
    }
}
