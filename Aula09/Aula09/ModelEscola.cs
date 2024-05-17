using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Aula09
{
    public class ModelEscola : IEnumerable
    {
        //Propriedade que representa o nome da Escola
        public string Escola { get; private set; }

        //Propriedade que representa a lista de departamentos
        //public List<Departamento> Departamentos { get; private set; }
        private List<Departamento> Departamentos;

        //Declaração de event (notificação da View) associado ao delegate
        public event MetodosSemParametros IncializacaoTerminada;

        public ModelEscola()
        {
            //Inicialização da lista de departamentos
            Departamentos = new List<Departamento>();
        }
        public void Inicializar()
        {
            //Simular leitura de dados de uma fonte de dados
            Escola = "Ciências e Tecnologia";

            Departamentos.Add(new Departamento("Engenharias", "150"));
            Departamentos.Add(new Departamento("Física", "30"));
            Departamentos.Add(new Departamento("Matemática", "60"));

            //Lançamento do event (notificação)
            if (IncializacaoTerminada != null)
                IncializacaoTerminada();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Departamentos.Count; i++)
                yield return Departamentos[i];
        }

        public string ObterDocentes(int index)
        {
            return Departamentos[index].NDocentes;
        }
    }
}
