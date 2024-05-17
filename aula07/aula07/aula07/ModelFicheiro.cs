using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace aula07
{  
    public class ModelFicheiro //alterar sempre a classe para public
    {
        //estado da aplicaçao
        public string Texto { get; private set; }

        //declaraçoes dos events
        public event MetodosSemParametros LeituraTerminada;
        public event MetodosSemParametros EscritaTermindada;

        //metodo invocado pela view (camada de Apresentaçao)
        public void AbrirFicheiro(string fich)
        {
            StreamReader sr = new StreamReader(fich); 
            Texto = sr.ReadToEnd();
            sr.Close();

            // notificaçoes de alteraçao de estado
            //lançamento do event
            if (LeituraTerminada != null)
            {
                LeituraTerminada();
            }
        }

        public void GuardarFicheiro(string fich, string conteudo)
        {
            StreamWriter sw = new StreamWriter(fich);
            sw.Write(conteudo);
            sw.Close();

            // notificaçoes de alteraçao de estado
            if (EscritaTermindada != null)
            {
                EscritaTermindada();
            }
        }
    }
}
