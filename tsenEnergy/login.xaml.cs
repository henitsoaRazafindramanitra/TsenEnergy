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
using tsenEnergy.Class;

namespace tsenEnergy
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        //ConnexionbasedeDonne con = new ConnexionbasedeDonne();
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textMotdepasse.Text) || !string.IsNullOrEmpty(textEmail.Text))
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Database=GestionsDesAbonnes;Username=postgres;Password=ronyandrihanina"))
                {
                    connection.Open();

                    using (var cmd = new NpgsqlCommand("select * from Utilisateur where Email='" + textEmail.Text + "' and MotdePasse='" + textMotdepasse.Text + "'", connection))
                    {
                        cmd.Parameters.AddWithValue("Email", textMotdepasse.Text);
                        cmd.Parameters.AddWithValue("MotdePasse", textEmail.Text);

                        using (var dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {

                                this.Hide();
                                Home home = new Home();
                                home.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("l'email et le mot de passe ne correspondent à aucun compte", "Erreur");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer une valeur dans tous les champs.", "Erreur");
            }
        }
    }
}
