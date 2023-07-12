using Npgsql;
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

namespace tsenEnergy
{
    /// <summary>
    /// Logique d'interaction pour InterfaceValidInscriptionFournisseur.xaml
    /// </summary>
    public partial class InterfaceValidInscriptionFournisseur : Window
    {
        string nom, adresse, telephone, mail, nifstat, formjurid;

        private void btRejeter_Click(object sender, RoutedEventArgs e)
        {
            dashboardTest.Show();
            this.Close();
        }

        DashboardAccuueil dashboardTest = new DashboardAccuueil();
        public InterfaceValidInscriptionFournisseur()
        {
            InitializeComponent();
            nom = textBoxNom.Text = "RAFANO";
            adresse = textBoxAdresse.Text = "Antatnanarivo";
            telephone = textBoxTelephone.Text = "0345558742";
            mail = textBoxEmail.Text = "exemple@mail.com";
            nifstat = textBoxNifStat.Text = "53658521545885";
            formjurid = textBoxFJurid.Text = "dsjghoziuaipusdkjdskjlbnljghpzeruighezrghdsfjkghlsdkjghuhzepgh";
        }

        private void btValider_Click(object sender, RoutedEventArgs e)
        {
            NpgsqlConnection con = connexionBD();

            try
            {

                string insertQuery = "INSERT INTO public.utilisateur(" +
                    "nom, adresse, telephone, email, nif, stat, formejuridique)" +
                    "VALUES ('" + nom + "', '" + adresse + "', '" + telephone + "', '" + mail + "', '" + nifstat + "', '" + nifstat + "', '" + formjurid + "');";

                NpgsqlCommand command = new NpgsqlCommand(insertQuery, con);

                // Exécuter la commande
                command.ExecuteNonQuery();


                dashboardTest.Show();
                this.Close();
            }
            catch (Exception ee)
            {
                Console.WriteLine("Erreur de connexion avec la base de données : " + ee.Message);
            }
        }

        public static NpgsqlConnection connexionBD()
        {
            // Chaîne de connexion à la base de données
            string connectionString = "Host=localhost;Port=5432;Database=GestionAbonnes;Username=postgres;Password=postgres";

            // Établir une connexion à la base de données
            NpgsqlConnection connexion = new NpgsqlConnection(connectionString);
            connexion.Open();
            return connexion;
        }
    }
}
