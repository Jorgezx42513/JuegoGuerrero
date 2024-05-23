using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JuegoGuerrero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        managerMision managerMision;
        public MainWindow()
        {
            InitializeComponent();
            managerMision  = new managerMision();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnArmor_MouseDown(object sender, MouseButtonEventArgs e)
        {
            consola.Text = $"Vida;{managerMision.Player.vida}" + "\n" +
                $"Nivel:{managerMision.Player.nivel}"+ "\n" +
                $"Puntos de daño:{managerMision.Player.puntos_de_daño}";
        }

        private void btnGun_MouseDown(object sender, MouseButtonEventArgs e)
        {
            consola.Text = $"Arma;Volter" + "\n" + $"Municion:";
        }

        private void btnItems_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            consola.Text = managerMision.InicarMision();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}