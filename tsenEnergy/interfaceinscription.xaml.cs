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
    /// Interaction logic for interfaceinscription.xaml
    /// </summary>
    public partial class interfaceinscription : Window
    {
        string connectionString = "Host=localhost;Port=5432;Database=Energie;User Id=postgres;Password=postgre;";
        public interfaceinscription()
        {
            InitializeComponent();
        }

        private void bt_ajout_Click(object sender, RoutedEventArgs e)
        {
            {

                string nom = textbox_nom.Text;
                string prenom = textbox_prenom.Text;
                string genre = textbox_genre.Text;
                string adresse = textbox_adresse.Text;
                string date = "1999-10-10";
                string telephone = textbox_tel.Text;
                string email = textbox_mail.Text;
                string role = "client";
                string cin = textbox_cin.Text;
                string mdp = textbox_mdp.Text;
                //  int cinit = int.Parse(cin);


                using (var conn = new NpgsqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "INSERT INTO public.client  VALUES (2,1,'an', 'p','g', 'a', '1999-05-06' , '125', 'e', 'r', 12 ,  'a')";

                    using (var cmd = new NpgsqlCommand(query, conn))
                    {


                        cmd.ExecuteNonQuery();

                    }
                }
            }
        }
    }
}
