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

namespace Aula09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variável que representa apontador para App (camada de Interligação)
        private App app;
        public MainWindow()
        {
            InitializeComponent();

            //Obtenção do apontador para a classe App (Camada de Interligação)
            app = App.Current as App;

            //Subscrição do método da View em event do Model
            app.M_escola.IncializacaoTerminada += M_escola_IncializacaoTerminada;
        }

        private void M_escola_IncializacaoTerminada()
        {
            tbEscola.Text = app.M_escola.Escola;

            foreach(Departamento dep in app.M_escola)
            {
                cbDepartamentos.Items.Add(dep.Designacao);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Invocação de método do Model por parte da View
            //Pedido alteração estado da aplicação (carregar dados no Model)
            app.M_escola.Inicializar();
        }

        private void cbDepartamentos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Invocação de método do Model por parte da View
            //Pedido de docentes de determinado departamento selecionado pelo utilizador
            sbiNDocentes.Content = "Nº Docentes: " + app.M_escola.ObterDocentes(cbDepartamentos.SelectedIndex);
        }
    }
}
