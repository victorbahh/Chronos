using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class formEquipes : Form
    {
        // Especifica o folder no qual será armazenado as informações salvas
        static string equipes_dataPath = @"./ChronosData/Equipes";
        // Essa variável especifica o arquivo no qual será armazenado as informações salvas
       string equipes_filePath = Path.Combine(equipes_dataPath, "lista_de_equipes.txt");

        public formEquipes()
        {
            this.Location = new Point(510, 150);
            InitializeComponent();
            if (!Directory.Exists(equipes_dataPath)){
                Directory.CreateDirectory(equipes_dataPath);
            }
            if (!File.Exists(equipes_filePath)){
                using (File.Create(equipes_filePath)){}
            }

            // Preenche a tabela com as equipes já cadastradas
            List<string> linhas = File.ReadLines(equipes_filePath).ToList();
            foreach (string linha in linhas)
            {
                string[] fields = linha.Split(';');
                dgv_tabelaEquipes.Rows.Add(dgv_tabelaEquipes.Rows.Count + 1, fields[0], fields[1]);
            }
        }

        string calouro=""; // string que vai ser usada para controlar o que tá marcado nos radiobuttons
            
        private void button_adicionar_Click(object sender, EventArgs e)
        {
            if (calouro!="" && tbox_nomeEquipe.Text!="") // checa se tem algo marcado nos radiobuttons e texto na textbox
            {
                dgv_tabelaEquipes.Rows.Add(dgv_tabelaEquipes.Rows.Count + 1, tbox_nomeEquipe.Text, calouro);
                tbox_nomeEquipe.Clear();
                tbox_nomeEquipe.Focus(); // coloca o cursor na textbox
            }
            dgv_tabelaEquipes.ClearSelection();
        }

        private void rButton_sim_CheckedChanged(object sender, EventArgs e)
        {
            calouro = "Sim";
        }

        private void rButton_nao_CheckedChanged(object sender, EventArgs e)
        {
            calouro = "Não";
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            if (dgv_tabelaEquipes.SelectedRows.Count!=0) // confere se tem alguma linha selecionada
            {
                DataGridViewRow selectedRow = dgv_tabelaEquipes.SelectedRows[0];
                dgv_tabelaEquipes.Rows.Remove(selectedRow);

                                            // o foreach abaixo faz com que os índices das linhas se
                                            //    reorganizem depois que alguma linha foi excluida
                int contador = 1;
                foreach (DataGridViewRow row in dgv_tabelaEquipes.Rows)
                {
                    row.Cells[0].Value = contador;
                    contador++;
                }
                dgv_tabelaEquipes.ClearSelection();
            }


        }

        private void button_resetar_Click(object sender, EventArgs e)
        {
            dgv_tabelaEquipes.Rows.Clear();
        }

        private void picbox_fechar_MouseEnter(object sender, EventArgs e)
        {
            picbox_fechar.BackgroundImage = Properties.Resources.x_branco;
        }

        private void picbox_fechar_MouseLeave(object sender, EventArgs e)
        {
            picbox_fechar.BackgroundImage = Properties.Resources.x_azul;
        }

        private void picbox_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_tabelaEquipes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

        }

        private void button_salvar_Click(object sender, EventArgs e)
        {
            using (StreamWriter file = new StreamWriter(equipes_filePath))
            {
                foreach (DataGridViewRow row in dgv_tabelaEquipes.Rows)
                {
                    string celulaEquipe = row.Cells[1].Value.ToString();
                    string celulaCalouro = row.Cells[2].Value.ToString();
                    // Arazena o conteúdo da tabela de equipes no arquivo especificado por equipes_dataPath
                    file.WriteLine(celulaEquipe + ";" + celulaCalouro + ";");
                }
            }
        }
    }
}
