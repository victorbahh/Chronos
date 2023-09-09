
﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Interface
{
    public partial class formEquipes : Form
    {
        // Declarando os diretorios
        private const string diretorioPasta = @"./ChronosData/Equipes";
        private const string diretorioArquivo = @"./ChronosData/Equipes/Equipes.csv";
        public formEquipes()
        {
            InitializeComponent();

            // Preenchendo a tabela com as equipes ja cadastradas
            if (!Directory.Exists(diretorioPasta)) Directory.CreateDirectory(diretorioPasta);
            if (File.Exists(diretorioArquivo))
            {
                List<string> linhas = File.ReadLines(diretorioArquivo).ToList();

                // Pulando o cabecalho
                if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Categoria") linhas = linhas.Skip(1).ToList();

                foreach (string linha in linhas)
                {
                    string[] colunas = linha.Split(',');
                    tabelaEquipes.Rows.Add(colunas[0], colunas[1], colunas[2]);
                }
            }
        }

        private void buttonAdicionarCLick(object sender, EventArgs e)
        {
            //Checando a categoria
            string Categoria = "Avançado";
            if (MirimButton.Checked == true) Categoria = "Mirim";

            tabelaEquipes.ClearSelection();

            if (!string.IsNullOrEmpty(tboxNomeEquipe.Text) && !string.IsNullOrEmpty(tboxInst.Text))
            {
                tabelaEquipes.Rows.Add(tboxNomeEquipe.Text, tboxInst.Text, Categoria);
                tboxNomeEquipe.Clear();
                tboxInst.Clear();
                tboxNomeEquipe.Focus(); // Coloca o cursor na textbox
            }
            else MessageBox.Show("Os campos não foram preenchidos corretamente!");

        }

        private void buttonExcluirClick(object sender, EventArgs e)
        {
            if (tabelaEquipes.SelectedRows.Count!=0) // confere se ha alguma linha selecionada
            {
                DataGridViewRow selectedRow = tabelaEquipes.SelectedRows[0];
                tabelaEquipes.Rows.Remove(selectedRow);
                tabelaEquipes.ClearSelection();
            }
        }

        private void buttonResetarClick(object sender, EventArgs e)
        {
            tabelaEquipes.Rows.Clear();
        }

        private void buttonSalvarClick(object sender, EventArgs e)
        {
            if (!Directory.Exists(diretorioPasta)) Directory.CreateDirectory(diretorioPasta);
            using (StreamWriter sw = File.CreateText(diretorioArquivo))
            {
                // Escrevendo o cabecalho
                sw.WriteLine("Equipe,Instituição,Categoria");
                foreach(DataGridViewRow linha in tabelaEquipes.Rows)
                {
                    // Obtem os valores das colunas da linha
                    string equipe = linha.Cells[0].Value.ToString();
                    string instituicao = linha.Cells[1].Value.ToString();
                    string categoria = linha.Cells[2].Value.ToString();

                    // Monta a linha de dados separando por vírgulas
                    string linhaDados = $"{equipe},{instituicao},{categoria}";

                    // Escreve a linha de dados no arquivo
                    sw.WriteLine(linhaDados);
                }
            }
        }
        private void formEquipes_Load(object sender, EventArgs e)
        {
            tabelaEquipes.ClearSelection();
        }
    }
}
