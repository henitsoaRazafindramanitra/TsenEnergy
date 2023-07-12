using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tsenEnergy
{
    internal class ConnectionDB
    {
        private NpgsqlConnection connection;
        private readonly string connectionString = "Server=localhost;Port=5432;Database=DataBaseAbones;User Id=postgres;Password=postgre";

        public ConnectionDB()
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
                Console.WriteLine("Connexion réussie !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la connexion : " + ex.Message);
            }
        }

        public void Disconnect()
        {
            try
            {
                connection.Close();
                Console.WriteLine("Déconnexion réussie !");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la déconnexion : " + ex.Message);
            }
        }
    }
}