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

namespace Aula06
{
    /// <summary>
    /// Interaction logic for WindowListarAvaliacoes.xaml
    /// </summary>
    public partial class WindowListarAvaliacoes : Window
    {
        //Apontador para a class App
        private App app;
        public WindowListarAvaliacoes()
        {
            InitializeComponent();

            //Obtem instância da class da App
            app = App.Current as App;

            //Subscrição de método da View no Event do Model
            app.Model_Avaliacoes.Inserido += Model_Avaliacoes_Inserido;
        }

        private void Model_Avaliacoes_Inserido(int dados)
        {
            if(dados >= 10)
            {
                lvAvaliacoes.Items.Add("Aprovado (" + dados + ")");
            }
            else
            {
                lvAvaliacoes.Items.Add("Reprovado (" + dados + ")");
            }
        }
    }
}
