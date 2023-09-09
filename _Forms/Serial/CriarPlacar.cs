using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class CriarPlacar : Form
    {
        // Declarando os diretorios
        private const string diretorioPastaEquipes = @"./ChronosData/Equipes";
        private const string diretorioArquivoEquipes = @"./ChronosData/Equipes/Equipes.csv";
        private const string diretorioPastaPlacar = @"./ChronosData/Placar";
        string categoria = "Avançado";
        public string diretorioArquivoPlacar { get; set; }
        public CriarPlacar()
        {
            InitializeComponent();

        }
        private void InicializarDiretorios()
        {
            // Inicializando os diretorios
            if (!Directory.Exists(diretorioArquivoEquipes)) Directory.CreateDirectory(diretorioPastaEquipes);
            if (!Directory.Exists(diretorioPastaPlacar)) Directory.CreateDirectory(diretorioPastaPlacar);
            if (!File.Exists(diretorioArquivoEquipes))
            {
                MessageBox.Show("O arquivo de equipes não foi encontrado!");
                Close();
            }
        }


        private void buttonSalvarClick(object sender, EventArgs e)
        {
            string nomeArquivo = $"Placar {categoria} {BateriaSelector.Text}.csv";
            diretorioArquivoPlacar = Path.Combine(@"./ChronosData/Placar/", nomeArquivo);

            // Preenchendo a tabela com as equipes ja cadastradas
            InicializarDiretorios();
            List<string> linhasArquivoEquipes = File.ReadLines(diretorioArquivoEquipes).ToList();
            // Pulando o cabecalho
            if (linhasArquivoEquipes.Count() > 0 && linhasArquivoEquipes[0] == "Equipe,Instituição,Categoria") linhasArquivoEquipes = linhasArquivoEquipes.Skip(1).ToList();
            using (StreamWriter sw = File.CreateText(diretorioArquivoPlacar))
            {
                sw.WriteLine("Equipe,Instituição,Colocação,Checkpoints,Tempo");
                // Iterador para a colocacao no placar
                int colocacao = 1;
                foreach (string linhaArquivoEquipes in linhasArquivoEquipes)
                {
                    // Separando as colunas
                    string[] colunasArquivoEquipes = linhaArquivoEquipes.Split(',');
                    //Pula as equipes de categoria indesejada
                    if (colunasArquivoEquipes[2] != categoria) continue;
                    // Monta a linha de dados separando por vírgulas
                    string linhaDados = $"{colunasArquivoEquipes[0]},{colunasArquivoEquipes[1]},{colocacao},0,0:00:000";

                    // Escreve a linha de dados no arquivo
                    sw.WriteLine(linhaDados);
                    colocacao++;
                }

            }
            Close();

        }

        private void MirimButton_CheckedChanged(object sender, EventArgs e)
        {

            if (MirimButton.Checked == true)
            {
                categoria = "Mirim";
                BateriaSelector.DataSource = new List<string> { "Arrancada", "Bateria 1", "Bateria 2", "Final" };
            }
            else
            {
                categoria = "Avançado";
                BateriaSelector.DataSource = new List<string> { "Arrancada", "Bateria 1", "Bateria 2", "Bateria 3", "Repescagem", "Final" };
            }
        }
        private void buttonCancelarClick(object sender, EventArgs e)
        {
            Close();
        }

        private void CriarPlacar_Load(object sender, EventArgs e)
        {
            InicializarDiretorios();
            BateriaSelector.SelectedIndex = -1;
        }
    }
}
