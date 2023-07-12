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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace tsenEnergy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_inscription_Click(object sender, RoutedEventArgs e)
        {
            //InscriptionForm inscriptionForm = new InscriptionForm();
            //inscriptionForm.Show();

            //this.Hide();

        }

        private void bt_identifier_Click(object sender, RoutedEventArgs e)
        {
            // LoginForm loginForm = new LoginForm();
            //loginForm.Show();

           
           // this.Hide();
        }
    }
}
