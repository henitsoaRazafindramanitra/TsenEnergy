using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace tsenEnergy.Class
{
    internal class ConnexionbasedeDonne
    {
        private NpgsqlConnection connection;
        private readonly string connectionString = "Server=localhost;Port=5432;Database=GestionsDesAbonnes;User Id=postgres;Password=ronyandrihanina;";

        public ConnexionbasedeDonne()
        {
            connection = new NpgsqlConnection(connectionString);
        }

        public NpgsqlConnection Connection
        {
            get { return connection; }
            set { connection = value; }
        }

        public void Connect()
        {
            try
            {
                connection.Open();
                Console.WriteLine("Connexion à la base de données réussie!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la connexion à la base de données : " + ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Déconnexion à la base de données réussie !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la déconnexion à la base de données : " + ex.Message);
            }
        }
    }
}
