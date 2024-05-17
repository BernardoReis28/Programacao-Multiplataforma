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

namespace Aula03
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

        private void tbValor2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Limpar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Somar_Click(object sender, RoutedEventArgs e)
        {
            int valor1 = Convert.ToInt32(tbValor1.Text);
            int valor2 = Convert.ToInt32(tbValor2.Text);
            int resultado = valor1 + valor2;

            tbResultado.Text = resultado.ToString();    //tbResultado.Text = Convert.ToString(resultado);

            //ComboBox
            cbResultados.Items.Add(resultado);

            //ListBox
            lbResultados.Items.Add(resultado);

            //ListView
            lvResultados.Items.Add(resultado);

            //TreeView
            tvResultados.Items.Add(resultado);
        }
    }
}
