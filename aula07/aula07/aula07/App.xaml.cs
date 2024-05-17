using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace aula07
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application //camada de  "interligaçao"
    {
        //camada logica
        public ModelFicheiro Model_Ficheiro { get; private set; }

        //construtor da camada de interligaçao

        public App()
        {
            //instanciaçao dos models
            Model_Ficheiro = new ModelFicheiro();
        }
    }
}
