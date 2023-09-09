using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Interface
{
    public partial class formSorteio : Form
    {
        //// Especifica o folder no qual será armazenado as informações salvas
        //static string equipes_dataPath = @"./ChronosData/Equipes";
        //// Essa variável especifica o arquivo no qual será armazenado as informações salvas
        //string equipes_filePath = Path.Combine(equipes_dataPath, "Equipes.txt");
        public formSorteio()
        {
        //    InitializeComponent();

        //    //if (!Directory.Exists(equipes_dataPath))
        //    //{
        //    //    Directory.CreateDirectory(equipes_dataPath);
        //    //}
        //    //if (!File.Exists(equipes_filePath))
        //    //{
        //    //    using (File.Create(equipes_filePath)) { }
        //    //}

        //    // Preenche a tabela com as equipes já cadastradas
        //    //List<string> linhas = File.ReadLines(equipes_filePath).ToList();


        //    foreach (string linha in linhas)
        //    {
                
        //        string[] fields = linha.Split(';');
        //        dgv_selecioneEquipes.Rows.Add(fields[0], fields[1]);
        //    }
        //}

        //private void button_selecionarTodas_Click(object sender, EventArgs e)
        //{
        //    foreach (DataGridViewRow row in dgv_selecioneEquipes.Rows)
        //    {
        //        row.Cells[2].Value = true;
                
        //    }
        //}
        //private void button_apagarSelecao_Click(object sender, EventArgs e)
        //{
        //    foreach (DataGridViewRow row in dgv_selecioneEquipes.Rows)
        //    {
        //        row.Cells[2].Value = false;
        //    }
        //}
        //private void button_sortear_Click(object sender, EventArgs e)
        //{
        //    List<DataGridViewRow> listaEquipesSelecionadas = new List<DataGridViewRow>();
        //    int numSorteado;
        //    List<int> listaSorteados = new List<int>();
        //    Random random = new Random();

        //    dgv_resultadoSorteio.Rows.Clear();

        //    //cria uma coleção de linhas apenas com as linhas selecionadas da tabela de seleção
        //    foreach (DataGridViewRow row in dgv_selecioneEquipes.Rows)
        //    {
                
        //            listaEquipesSelecionadas.Add(row);
                
        //    }

        //    //cria a ordem aleatória do sorteio 
        //    for (int i = 0; i < listaEquipesSelecionadas.Count; i++)
        //    {
        //        do
        //        {
        //            numSorteado = random.Next(listaEquipesSelecionadas.Count);
        //        } while (listaSorteados.Contains(numSorteado));

        //        listaSorteados.Add(numSorteado);
        //    }

        //    //imprime o resultado do sorteio
        //    for(int j = 0; j < listaSorteados.Count; j++)
        //    {
        //        dgv_resultadoSorteio.Rows.Add(listaEquipesSelecionadas[listaSorteados[j]].Cells[1].Value.ToString(), (dgv_resultadoSorteio.Rows.Count + 1).ToString()+"ª"); ;
        //    }
            
        }
    }
}
