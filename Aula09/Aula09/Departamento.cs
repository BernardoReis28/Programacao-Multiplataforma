using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09
{
    public class Departamento
    {
        public string Designacao { get; private set; }
        public string NDocentes { get; private set; }

        public Departamento(string designacao, string ndocentes)
        {
            Designacao = designacao;
            NDocentes = ndocentes;  
        }
    }
}
