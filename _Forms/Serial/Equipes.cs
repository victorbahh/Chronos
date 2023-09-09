using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Equipe
    {
        public string Nome { get; set; }
        public string Instituicao { get; set; }
        public uint Colocacao { get; set; }
        public uint Checkpoints { get; set; }
        public TimeSpan Tempo { get; set; }

        // Construtor para inicializar uma equipe
        public Equipe(string nome, string instituicao, uint colocacao, uint checkpoints, TimeSpan tempo)
        {
            Nome = nome;
            Instituicao = instituicao;
            Colocacao = colocacao;
            Checkpoints = checkpoints;
            Tempo = tempo;

        }
    }
}
