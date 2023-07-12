using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Npgsql;
namespace tsenEnergy
{
    /// <summary>
    /// Interaction logic for InscriptionFournisseur.xaml
    /// </summary>
    public partial class InscriptionFournisseur : Window
    {
        NpgsqlConnection connection;
        string connectionString = "Host=localhost;Port=5432;Database=NomDeLaBaseDeDonnees;Username=NomUtilisateur;Password=MotDePasse";

        public InscriptionFournisseur()
        {
            InitializeComponent();

            connection = new NpgsqlConnection(connectionString);

        }

        private void bt_ajout_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            string compagnie = tb_comp.Text;
            string adresse = tb_adresse.Text;
            string forme_juridique = tb_fjurid.Text;
            string telephone = tb_tel.Text;
            string email = tb_mail.Text;
            string mdp = tb_mdp.Text;
            string nif = tb_nif.Text;
            string stat = tb_stat.Text;
            
            string role = "fournisseur";
           



            string requete = "insert into public.fournisseur(nom, adresse, telephone,email, role, nif,stat, formejuridique, motdepasse) VALUES(@compagnie, @adresse,@telephone,@email,@role,@nif,@stat,@forme_juridique,@mdp)";


        connection.Close();
        }
    }
}
