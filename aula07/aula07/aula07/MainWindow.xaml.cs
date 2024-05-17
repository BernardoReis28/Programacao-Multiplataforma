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

using Microsoft.Win32;

namespace aula07
{
    /// variavel que representa acesso à camada de "interligaçao" (app)
    
    public partial class MainWindow : Window
    {
        private App app;
        public MainWindow()
        {
            InitializeComponent();
            ///instancia da camada de "interligaçao" (app)
            app =  App.Current as App;

            //subscriçao de metodo da view em event do model
            app.Model_Ficheiro.LeituraTerminada += Model_Ficheiro_LeituraTerminada;
            app.Model_Ficheiro.EscritaTermindada += Model_Ficheiro_EscritaTermindada;
        }

        private void Model_Ficheiro_EscritaTermindada()
        {
            MessageBox.Show("Ficheiro Guardado com sucesso!!");
        }

        private void Model_Ficheiro_LeituraTerminada()
        {
            tbficheiro.Text = app.Model_Ficheiro.Texto;
        }

        private void btnAbrir_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Ficheiros dw texto| *.txt | Todos os ficheiros |*.*";
             if(dlg.ShowDialog() == true)
            {
                //ligaçao view->model (invocaçao de metodo do model)
                app.Model_Ficheiro.AbrirFicheiro(dlg.FileName);
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Ficheiros de texto | *.txt | Todos os ficheiros |*.*";

            if (dlg.ShowDialog() == true)
            {
                app.Model_Ficheiro.GuardarFicheiro(dlg.FileName, tbficheiro.Text);
            }
        }
    }
}


