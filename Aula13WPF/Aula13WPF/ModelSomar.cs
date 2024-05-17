﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula13Iot
{
    public class ModelSomar
    {
        //Propriedade que representa o estado da aplicação
        public string Resultado { get; private set; }

        //Declaração de event que irá notificar a View de alteração de estado
        public event MetodosComString SomaTerminada;
        public void Somar(string valor1,string valor2)
        {
            Resultado = (Convert.ToInt32(valor1) + Convert.ToInt32(valor2)).ToString();
            
            if(SomaTerminada != null)
                SomaTerminada(Resultado);
        }
    }
}
