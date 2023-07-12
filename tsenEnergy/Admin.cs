using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsenenergy
{
    internal class Admin
    {
        string nom { get; set; }
        string email { get; set; }
        string motDePasse { get; set; }

        public Admin(string nom, string email, string motDePasse)
        {
            nom = nom;
            email = email;
            motDePasse = motDePasse;
        }
    }
}
