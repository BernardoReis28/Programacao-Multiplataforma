using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using Aula13Iot;

namespace Aula13WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public ModelSomar M_Somar { get; private set; }

        public App()
        {
            M_Somar = new ModelSomar();
        }
    }
}
