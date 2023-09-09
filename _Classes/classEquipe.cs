using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface._Classes
{
    class ClasseEquipe
    {
        public ClasseEquipe(string _identificador, string _nome, string _calouro)
        {
            this.Identificador = _identificador;
            this.Nome = _nome;
            this.Calouro = _calouro;
        }

        public string Nome { get; private set; }

        public string Identificador { get; private set; }

        public string Calouro { get; private set; }
    }
}