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

namespace Aula13WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private App app;
        public MainWindow()
        {

            InitializeComponent();

            app = App.Current as App;
            app.M_Somar.SomaTerminada += M_Somar_SomaTerminada1;
        }

        private void M_Somar_SomaTerminada1(string Resultado)
        {
            tbResultado.Text = Resultado;
        }

        private void M_Somar_SomaTerminada(string Resultado)
        {
            tbResultado.Text = Resultado;
        }

        private void btnSomar_Click(object sender, RoutedEventArgs e)
        {
            app.M_Somar.Somar(tbValor1.Text, tbValor2.Text);
        }
    }
}

