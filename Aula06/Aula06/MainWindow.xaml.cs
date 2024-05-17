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

namespace Aula06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Apontador para App
        private App app;
        public MainWindow()
        {
            InitializeComponent();

            //Obtem apontador para class App
            app = App.Current as App;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //WindowListarNotas dlg1 = new WindowListarNotas();
            //WindowListarAvaliacoes dlg2 = new WindowListarAvaliacoes();

            app.View_ListarNotas.Show();
            app.View_ListarAvaliacoes.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            app.View_ListarNotas.Close();
            app.View_ListarAvaliacoes.Close();
        }

        private void btnInserir_Click(object sender, RoutedEventArgs e)
        {
            //View (camada de Apresentação) invoca o método do Model (Camada Lógica)
            app.Model_Avaliacoes.Inserir(tbNota.Text);
        }
    }
}
