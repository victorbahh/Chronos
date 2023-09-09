using Interface._Forms.Tela;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace Interface
{
    public partial class FormSerial : Form
    {
        // Declarando os diretorios
        private const string diretorioPastaPlacar = @"./ChronosData/Placar";
        private string diretorioArquivoPlacar = string.Empty;
        private const string diretorioArquivoResultadoParcialMirim = @"./ChronosData/Placar/Resultado Parcial Mirim.csv";
        private const string diretorioArquivoResultadoParcialAvancado = @"./ChronosData/Placar/Resultado Parcial Avançado.csv";

        Stopwatch stopWatch = new Stopwatch();
        int[] sensores = new int[10];   //  Lista dos sensores
        Label[] checkLabels = new Label[10];    //  Lista das labels de checkpoints
        bool formTelaAberto = false;    // Tela de exibição aberta
        private formTela FormDaTela;
        bool AtualizarCompetidor = false;
        List<Equipe> equipes = new List<Equipe>();
        int indiceCompetidorAtual = -1;
        TimeSpan tempoSegundaTentativa = TimeSpan.Zero;
        uint checkpointsSegundaTentativa = 0;
        bool melhorTentativa = false;
        public FormSerial()
        {
            InitializeComponent();
            InicializarDiretorios();
            timerCronometro.Enabled = true;
            checkLabels = new Label[10] { labelLargada, labelCheck1, labelCheck2, labelCheck3, labelCheck4, labelCheck5, labelCheck6, labelCheck7, labelCheck8, labelChegada };
        }
        public void ToggleExibir(formTela formTelaAtual) //Tela de exibiçao
        {
            FormDaTela = formTelaAtual;
            formTelaAberto = !formTelaAberto;
            // Exibicao da escolha de titulo
            TitleExbirLabel.Visible = !TitleExbirLabel.Visible;
            ShowExibirTitle.Visible = !ShowExibirTitle.Visible;
            TitleExibir.Visible = !TitleExibir.Visible;

            // Caregando novamente o arquivo
            CarregarArquivoPlacar();
        }
        private void ComSelector_Click(object sender, EventArgs e) //Atualiza lista de Coms quando clicado
        {
            string[] portNames = SerialPort.GetPortNames();

            if (ComSelector.Items.Count != portNames.Length)
            {
                ComSelector.Items.Clear();
                ComSelector.Items.AddRange(portNames);
            }
        }
        private void Button_conectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = ComSelector.Items[ComSelector.SelectedIndex].ToString();
                    serialPort1.Open();
                }
                catch
                {
                    return;
                }
                if (serialPort1.IsOpen)
                {
                    button_conectar.Text = "Desconectar";
                    ComSelector.Enabled = false;
                    textBox_receber.AppendText("Conexão Iniciada" + "\r\n");
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    ComSelector.Enabled = true;
                    button_conectar.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void Ultrapassagem(int i = 1)
        {
            if (i == 1)
            {
                FormDaTela.PlacarCoRA.Overtaking(equipes[indiceCompetidorAtual].Nome, equipes[indiceCompetidorAtual - 1].Nome);
                equipes[indiceCompetidorAtual].Colocacao--;
                equipes[indiceCompetidorAtual - 1].Colocacao++;
                // Armazene temporariamente um dos elementos
                Equipe elementoTemporario = equipes[indiceCompetidorAtual];

                // Faça a troca
                equipes[indiceCompetidorAtual] = equipes[indiceCompetidorAtual - 1];
                equipes[indiceCompetidorAtual - 1] = elementoTemporario;
                indiceCompetidorAtual--;
            }
            if (i == -1)
            {

                FormDaTela.PlacarCoRA.Overtaking(equipes[indiceCompetidorAtual + 1].Nome, equipes[indiceCompetidorAtual].Nome);
                equipes[indiceCompetidorAtual + 1].Colocacao--;
                equipes[indiceCompetidorAtual].Colocacao++;
                // Armazene temporariamente um dos elementos
                Equipe elementoTemporario = equipes[indiceCompetidorAtual + 1];

                // Faça a troca
                equipes[indiceCompetidorAtual + 1] = equipes[indiceCompetidorAtual];
                equipes[indiceCompetidorAtual] = elementoTemporario;
                indiceCompetidorAtual++;
            }
        }
        private void Timer_Tick(object argumento1 = null, object argumento2 = null) //Timer
        {
            //TODO
            labelTimer.Text = string.Format("{0:m\\:ss\\:fff}", stopWatch.Elapsed);
            if (labelTentativa.Text == "Tentativa 1"|| melhorTentativa)
            {
                if (indiceCompetidorAtual != -1) equipes[indiceCompetidorAtual].Tempo = stopWatch.Elapsed;
                if (AtualizarCompetidor == true)
                {
                    // Atualizando tempo do competidor no placar
                    FormDaTela.PlacarCoRA.AtualizarTempoCompetidor(LabelEquipe.Text, string.Format("{0:m\\:ss\\:fff}", stopWatch.Elapsed));
                    //Ultrapassagem
                    // Se o competidor nao for 1 lugar
                    if (indiceCompetidorAtual > 0)
                    {
                        // Se o numero de checkpoints for maior
                        if (equipes[indiceCompetidorAtual].Checkpoints > equipes[indiceCompetidorAtual - 1].Checkpoints) Ultrapassagem();
                        // Se for igual
                        else if (equipes[indiceCompetidorAtual].Checkpoints == equipes[indiceCompetidorAtual - 1].Checkpoints)
                        {
                            if (equipes[indiceCompetidorAtual].Tempo < equipes[indiceCompetidorAtual - 1].Tempo || equipes[indiceCompetidorAtual - 1].Tempo == TimeSpan.Zero) Ultrapassagem();
                        }
                        
                    }
                    // Se o competidor nao for o ultimo lugar
                    if (indiceCompetidorAtual < equipes.Count - 1)
                    {
                        // Desultrapassagem
                        // Se o numero de checkpoints for menor
                        if (equipes[indiceCompetidorAtual].Checkpoints < equipes[indiceCompetidorAtual + 1].Checkpoints)
                        {
                            Ultrapassagem(-1);
                        }
                        // Se for igual
                        else if (equipes[indiceCompetidorAtual].Checkpoints == equipes[indiceCompetidorAtual + 1].Checkpoints && equipes[indiceCompetidorAtual].Checkpoints != 0)
                        {
                            if (equipes[indiceCompetidorAtual].Tempo > equipes[indiceCompetidorAtual + 1].Tempo)
                            {
                                Ultrapassagem(-1);
                            }
                        }
                    }

                }
            } else if(labelTentativa.Text == "Tentativa 2")
            {
                if(AtualizarCompetidor == true)
                {
                    FormDaTela.TimerSegundaTentativa($"Tentativa 2 - {string.Format("{0:m\\:ss\\:fff}", stopWatch.Elapsed)}");
                }
                // Caso a segunda tentativa seja melhor
                tempoSegundaTentativa = stopWatch.Elapsed;
                if (checkpointsSegundaTentativa > equipes[indiceCompetidorAtual].Checkpoints) { 
                    melhorTentativa = true;
                    AtualizarChecksCompetidor(checkpointsSegundaTentativa);
                    if (AtualizarCompetidor == true) FormDaTela.TimerSegundaTentativa("Tentativa 2");
                }
                else if (checkpointsSegundaTentativa == equipes[indiceCompetidorAtual].Checkpoints && tempoSegundaTentativa < equipes[indiceCompetidorAtual].Tempo)
                {
                    melhorTentativa = true;
                    AtualizarChecksCompetidor(checkpointsSegundaTentativa);
                    if (AtualizarCompetidor == true) FormDaTela.TimerSegundaTentativa("Tentativa 2");
                }
            }

        }
        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e) //Faz o controle dos sensores arduino
        {
            try
            {
                string mensagem = serialPort1.ReadLine();
                //Filtrando as entradas
                if (mensagem[0] == 'S' || mensagem[0] == 'C')
                {
                    //Filtrando para que não tenham saidas iguais
                    //if ((textBox_receber.Lines.Length > 1) && (textBox_receber.Lines[textBox_receber.Lines.Length - 2] == mensagem)) return;
                    textBox_receber.AppendText(mensagem + "\r\n");
                    CheckControl(mensagem, new EventArgs());
                }
            }
            catch (Exception)
            {
                //Tratar erro
            }
        }
        private void AtualizarChecksCompetidor(uint checks)
        {
            if (labelTentativa.Text == "Tentativa 1" || melhorTentativa)
            {
                if (indiceCompetidorAtual != -1) equipes[indiceCompetidorAtual].Checkpoints = checks;
                if (AtualizarCompetidor == true) FormDaTela.PlacarCoRA.AtualizarTempoCompetidor(LabelEquipe.Text, null, checks);
                if (AtualizarCompetidor == true && checks == 0) FormDaTela.PlacarCoRA.AtualizarTempoCompetidor(LabelEquipe.Text, "0:00:000", 0);
            }
            else if (labelTentativa.Text == "Tentativa 2")
            {
                checkpointsSegundaTentativa = checks;
            }
            // Chama o timer para atualizar os dados do competidor
            Timer_Tick();

        }
        private void CheckControl(object sender, EventArgs e)    //Cuida do controle dos Checkpoints
        {
            string mensagem = "";
            if (sender is Button button) mensagem = button.Name;
            else if (sender is string parametro) mensagem = parametro;

            //Caso seja largada
            if ((mensagem == "buttonLargada" || mensagem == "S0"))
            {
                if (indiceCompetidorAtual == -1 && !string.IsNullOrEmpty(diretorioArquivoPlacar)) MessageBox.Show("Nenhum Competidor foi selecionado!");
                if (sensores[0] == 1) return;
                timerCronometro.Start();
                stopWatch.Start();
                textBox_receber.AppendText("Start\r\n");
                checkLabels[0].Text = "Largada: " + string.Format("{0:m\\:ss\\:fff}", stopWatch.Elapsed); ;
                sensores[0] = 1;
                //Atualiza status checkpoint do competidor atual
                AtualizarChecksCompetidor(0);
                // if (exibir == false) MessageBox.Show("A tela de exibição não está aberta!");
                return;
            }
            //Caso seja chegada
            else if ((mensagem == "buttonChegada" || mensagem == "S9"))
            {
                if (sensores[9] == 1 || (sensores[8] != 1)) return;   //Caso já tenha chegado
                //Atualiza status checkpoint do competidor atual
                AtualizarChecksCompetidor(9);
                //Parando Timers
                stopWatch.Stop();
                timerCronometro.Stop();
                //Atualizando Labels
                checkLabels[9].Text = "Chegada: " + labelTimer.Text;
                textBox_receber.AppendText("Finished\r\n");
                sensores[9] = 1;
                return;
            }
            //Demais casos

            uint indice;
            if (mensagem.Length > 2) indice = (uint)Char.GetNumericValue(mensagem[11]);

            else indice = (uint)Char.GetNumericValue(mensagem[1]);
            if (sensores[indice] == 0 && sensores[indice - 1] == 1 && sensores[9] == 0)
            {
                if (sensores[indice] == 1) return;
                textBox_receber.AppendText("Check" + indice.ToString() + "\r\n");
                checkLabels[indice].Text = "Check " + indice.ToString() + ": " + string.Format("{0:m\\:ss\\:fff}", stopWatch.Elapsed);
                sensores[indice] = 1;
                //Atualiza status checkpoint do competidor atual
                AtualizarChecksCompetidor(indice);

            }
            //6 Ativar o 7 tambem
            if (indice == 6) CheckControl("S7", new EventArgs());
        }
        private void SelectEquipeButton_Click(object sender, EventArgs e)
        {
            //TODO
            if (string.IsNullOrEmpty(EquipeSelector.Text) || string.IsNullOrEmpty(TentativaSelector.Text)) return;
            indiceCompetidorAtual = equipes.FindIndex(p => p.Nome == EquipeSelector.Text); // Encontra o competidor atual
            // Limpa os labels do competidor
            LabelEquipe.Text = EquipeSelector.Text;
            labelTentativa.Text = TentativaSelector.Text;
            // Atualiza o form da tela de exibicao
            if (formTelaAberto)
            {
                FormDaTela.ChangeText(EquipeSelector.Text, "Equipe");
                FormDaTela.ChangeText(TentativaSelector.Text, "Tentativa");
                AtualizarCompetidor = true;
            }

            // Limpando dados da segunda tentativa
            tempoSegundaTentativa = TimeSpan.Zero;
            checkpointsSegundaTentativa = 0;
            melhorTentativa = false;
            // Parando os cronometros
            stopWatch.Reset();
            timerCronometro.Stop();
            // Limpando os Labels
            labelTimer.Text = string.Format("{0:m\\:ss\\:fff}", equipes[indiceCompetidorAtual].Tempo);
            sensores[0] = 0; checkLabels[0].Text = "Largada: -:--.----:--.--";
            sensores[9] = 0; checkLabels[9].Text = "Chegada: -:--.----:--.-";
            for (int i = 1; i < 9; i++)
            {
                sensores[i] = 0;
                checkLabels[i].Text = $"Checkpoint {i}: -:--.---";
            }
            if (formTelaAberto)
            {
                FormDaTela.ResetTimers();
                if (labelTentativa.Text == "Tentativa 2")
                {
                    FormDaTela.TimerSegundaTentativa("Tentativa 2 - 0:00:000");
                    FormDaTela.ResizeTimerSegundaTentativa();
                }
            }
        }
        private void ButtonSalvarClick(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.CreateText(diretorioArquivoPlacar))
            {
                // Escrevendo o cabecalho
                sw.WriteLine("Equipe,Instituição,Colocação,Checkpoints,Tempo");
                foreach (Equipe equipeLida in equipes)
                {
                    string linhaDados = $"{equipeLida.Nome},{equipeLida.Instituicao},{equipeLida.Colocacao},{equipeLida.Checkpoints},"+ string.Format("{0:m\\:ss\\:fff}", equipeLida.Tempo);
                    sw.WriteLine(linhaDados);
                }
                if(diretorioArquivoPlacar.Contains("Avançado")) CalcularResultadoParcialAvancado();
                else if(diretorioArquivoPlacar.Contains("Mirim")) CalcularResultadoParcialMirim();
            }
        }
        private void CriarResultadoParcialMirim()
        {
            using (StreamWriter sw = File.CreateText(diretorioArquivoResultadoParcialMirim))
            {
                // Escrevendo o cabecalho
                sw.WriteLine("Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,,Pontuação Apresentação");
                foreach (Equipe equipeLida in equipes)
                {
                    // Monta a linha de dados separando por vírgulas
                    string linhaDados = $"{equipeLida.Nome},{equipeLida.Instituicao},0,0,0";
                    // Escreve a linha de dados no arquivo
                    sw.WriteLine(linhaDados);
                }
            }
        }
        private void CalcularResultadoParcialMirim()
        {
            List<string> linhas;
            if (File.Exists(diretorioArquivoResultadoParcialMirim))
            {
                linhas = File.ReadLines(diretorioArquivoResultadoParcialMirim).ToList();

                // Pulando o cabecalho
                if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Apresentação") linhas = linhas.Skip(1).ToList();
                if (linhas.Count != equipes.Count)
                {
                    DialogResult resultado = MessageBox.Show("Erro no número de equipes. Deseja sobrescrever o resultado parcial?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.No)
                    {
                        // O usuário escolheu não continuar, então você pode encerrar a função aqui
                        MessageBox.Show("O Resultado Parcial não foi salvo!");
                        return;
                    }
                    else
                    {
                        // Chamar funcao para criar novo resultado
                        CriarResultadoParcialMirim();
                        // Pulando o cabecalho
                        linhas = File.ReadLines(diretorioArquivoResultadoParcialMirim).ToList();
                        if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Apresentação") linhas = linhas.Skip(1).ToList();
                    }
                }

            }
            else
            {
                CriarResultadoParcialMirim();
                linhas = File.ReadLines(diretorioArquivoResultadoParcialMirim).ToList();
                // Pulando o cabecalho
                if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Apresentação") linhas = linhas.Skip(1).ToList();
            }
            using (StreamWriter sw = File.CreateText(diretorioArquivoResultadoParcialMirim))
            {
                sw.WriteLine("Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Apresentação");
                //  Calculando cada pontuacao
                foreach (Equipe equipeLida in equipes)
                {
                    int indiceEquipe = -1;
                    for (int i = 0; i < linhas.Count; i++)
                    {
                        if (linhas[i].StartsWith(equipeLida.Nome))
                        {
                            indiceEquipe = i;
                            break; // Saia do loop quando a equipe for encontrada
                        }
                    }
                    string linhaEquipe = linhas[indiceEquipe];
                    string[] colunas = linhaEquipe.Split(',');
                    if (diretorioArquivoPlacar.Contains("Bateria 1"))
                    {
                        // Meus pesames petiano que esta lendo isso
                        if (equipeLida.Colocacao == 1) colunas[2] = "40";
                        else if (equipeLida.Colocacao == 2) colunas[2] = "35";
                        else if (equipeLida.Colocacao == 3) colunas[2] = "30";
                        else if (equipeLida.Colocacao == 4) colunas[2] = "27";
                        else if (equipeLida.Colocacao == 5) colunas[2] = "25";
                        else if (equipeLida.Colocacao == 6) colunas[2] = "22";
                        else if (equipeLida.Colocacao == 7) colunas[2] = "20";
                        else if (equipeLida.Colocacao == 8) colunas[2] = "18";
                        else if (equipeLida.Colocacao == 9) colunas[2] = "16";
                        else if (equipeLida.Colocacao == 10) colunas[2] = "14";
                        else if (equipeLida.Colocacao >= 11 && equipeLida.Colocacao <= 15) colunas[2] = "12";
                        else if (equipeLida.Colocacao >= 16 && equipeLida.Colocacao <= 20) colunas[2] = "10";
                    }
                    else if (diretorioArquivoPlacar.Contains("Bateria 2"))
                    {
                        if (equipeLida.Colocacao == 1) colunas[3] = "50";
                        else if (equipeLida.Colocacao == 2) colunas[3] = "45";
                        else if (equipeLida.Colocacao == 3) colunas[3] = "40";
                        else if (equipeLida.Colocacao == 4) colunas[3] = "37";
                        else if (equipeLida.Colocacao == 5) colunas[3] = "35";
                        else if (equipeLida.Colocacao == 6) colunas[3] = "32";
                        else if (equipeLida.Colocacao == 7) colunas[3] = "30";
                        else if (equipeLida.Colocacao == 8) colunas[3] = "28";
                        else if (equipeLida.Colocacao == 9) colunas[3] = "26";
                        else if (equipeLida.Colocacao == 10) colunas[3] = "24";
                        else if (equipeLida.Colocacao >= 11 && equipeLida.Colocacao <= 15) colunas[3] = "22";
                        else if (equipeLida.Colocacao >= 16 && equipeLida.Colocacao <= 20) colunas[3] = "20";
                    }
                    // Monta a linha de dados separando por vírgulas
                    string linhaDados = $"{colunas[0]},{colunas[1]},{colunas[2]},{colunas[3]},0";

                    // Escreve a linha de dados no arquivo
                    sw.WriteLine(linhaDados);
                }
            }
        }
        private void CriarResultadoParcialAvancado() {
            using (StreamWriter sw = File.CreateText(diretorioArquivoResultadoParcialAvancado))
            {
                // Escrevendo o cabecalho
                sw.WriteLine("Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Bateria 3,Pontuação Apresentação");
                foreach (Equipe equipeLida in equipes)
                {
                    // Monta a linha de dados separando por vírgulas
                    string linhaDados = $"{equipeLida.Nome},{equipeLida.Instituicao},0,0,0,0";
                    // Escreve a linha de dados no arquivo
                    sw.WriteLine(linhaDados);
                }
            }
        }
        private void CalcularResultadoParcialAvancado()
        {
            List<string> linhas;
            if (File.Exists(diretorioArquivoResultadoParcialAvancado))
            {
                linhas = File.ReadLines(diretorioArquivoResultadoParcialAvancado).ToList();

                // Pulando o cabecalho
                if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Bateria 3,Pontuação Apresentação") linhas = linhas.Skip(1).ToList();
                if (linhas.Count != equipes.Count)
                {
                    DialogResult resultado = MessageBox.Show("Erro no número de equipes. Deseja sobrescrever o resultado parcial?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.No)
                    {
                        // O usuário escolheu não continuar, então você pode encerrar a função aqui
                        MessageBox.Show("O Resultado Parcial não foi salvo!");
                        return;
                    }
                    else
                    {
                        // Chamar funcao para criar novo resultado
                        CriarResultadoParcialAvancado();
                        // Pulando o cabecalho
                        linhas = File.ReadLines(diretorioArquivoResultadoParcialAvancado).ToList();
                        if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Bateria 3,Pontuação Apresentação") linhas = linhas.Skip(1).ToList();
                    }
                }

            }
            else
            {
                CriarResultadoParcialAvancado();
                linhas = File.ReadLines(diretorioArquivoResultadoParcialAvancado).ToList();
                // Pulando o cabecalho
                if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Bateria 3,Pontuação Apresentação") linhas = linhas.Skip(1).ToList();
            }
            using (StreamWriter sw = File.CreateText(diretorioArquivoResultadoParcialAvancado))
            {
                sw.WriteLine("Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Bateria 3,Pontuação Apresentação");
                //  Calculando cada pontuacao
                foreach (Equipe equipeLida in equipes)
                {
                    int indiceEquipe = -1;
                    for (int i = 0; i < linhas.Count; i++)
                    {
                        if (linhas[i].StartsWith(equipeLida.Nome))
                        {
                            indiceEquipe = i;
                            break; // Saia do loop quando a equipe for encontrada
                        }
                    }
                    string linhaEquipe = linhas[indiceEquipe];
                    string[] colunas = linhaEquipe.Split(',');
                    if (diretorioArquivoPlacar.Contains("Bateria 1")) {
                        // Meus pesames petiano que esta lendo isso
                        if (equipeLida.Colocacao == 1) colunas[2] = "20";
                        else if (equipeLida.Colocacao == 2) colunas[2] = "17";
                        else if (equipeLida.Colocacao == 3) colunas[2] = "15";
                        else if (equipeLida.Colocacao == 4) colunas[2] = "13";
                        else if(equipeLida.Colocacao == 5) colunas[2] = "12";
                        else if (equipeLida.Colocacao == 6) colunas[2] = "11";
                        else if (equipeLida.Colocacao == 7) colunas[2] = "10";
                        else if (equipeLida.Colocacao == 8) colunas[2] = "9";
                        else if (equipeLida.Colocacao == 9) colunas[2] = "8";
                        else if (equipeLida.Colocacao == 10) colunas[2] = "7";
                        else if (equipeLida.Colocacao >= 11 && equipeLida.Colocacao <= 15) colunas[2] = "6";
                        else if (equipeLida.Colocacao >= 16 && equipeLida.Colocacao <= 20) colunas[2] = "5";
                        else if (equipeLida.Colocacao >= 21 && equipeLida.Colocacao <= 25) colunas[2] = "4";
                        else if (equipeLida.Colocacao >= 26 && equipeLida.Colocacao <= 30) colunas[2] = "6";
                    }
                    else if (diretorioArquivoPlacar.Contains("Bateria 2")) {
                        if (equipeLida.Colocacao == 1) colunas[3] = "30";
                        else if (equipeLida.Colocacao == 2) colunas[3] = "27";
                        else if (equipeLida.Colocacao == 3) colunas[3] = "25";
                        else if (equipeLida.Colocacao == 4) colunas[3] = "22";
                        else if (equipeLida.Colocacao == 5) colunas[3] = "20";
                        else if (equipeLida.Colocacao == 6) colunas[3] = "19";
                        else if (equipeLida.Colocacao == 7) colunas[3] = "18";
                        else if (equipeLida.Colocacao == 8) colunas[3] = "17";
                        else if (equipeLida.Colocacao == 9) colunas[3] = "16";
                        else if (equipeLida.Colocacao == 10) colunas[3] = "15";
                        else if (equipeLida.Colocacao >= 11 && equipeLida.Colocacao <= 15) colunas[3] = "13";
                        else if (equipeLida.Colocacao >= 16 && equipeLida.Colocacao <= 20) colunas[3] = "10";
                        else if (equipeLida.Colocacao >= 21 && equipeLida.Colocacao <= 25) colunas[3] = "7";
                        else if (equipeLida.Colocacao >= 26 && equipeLida.Colocacao <= 30) colunas[3] = "5";
                    }
                    else if (diretorioArquivoPlacar.Contains("Bateria 3")) {
                        if (equipeLida.Colocacao == 1) colunas[4] = "40";
                        else if (equipeLida.Colocacao == 2) colunas[4] = "35";
                        else if (equipeLida.Colocacao == 3) colunas[4] = "30";
                        else if (equipeLida.Colocacao == 4) colunas[4] = "27";
                        else if (equipeLida.Colocacao == 5) colunas[4] = "25";
                        else if (equipeLida.Colocacao == 6) colunas[4] = "23";
                        else if (equipeLida.Colocacao == 7) colunas[4] = "21";
                        else if (equipeLida.Colocacao == 8) colunas[4] = "19";
                        else if (equipeLida.Colocacao == 9) colunas[4] = "17";
                        else if (equipeLida.Colocacao == 10) colunas[4] = "15";
                        else if (equipeLida.Colocacao >= 11 && equipeLida.Colocacao <= 15) colunas[4] = "12";
                        else if (equipeLida.Colocacao >= 16 && equipeLida.Colocacao <= 20) colunas[4] = "10";
                        else if (equipeLida.Colocacao >= 21 && equipeLida.Colocacao <= 25) colunas[4] = "8";
                        else if (equipeLida.Colocacao >= 26 && equipeLida.Colocacao <= 30) colunas[4] = "6";
                    }
                    // Monta a linha de dados separando por vírgulas
                    string linhaDados = $"{colunas[0]},{colunas[1]},{colunas[2]},{colunas[3]},{colunas[4]},0";

                    // Escreve a linha de dados no arquivo
                    sw.WriteLine(linhaDados);
                }
            }    
         }
        private void Reset(object argumento = null, object argumento2 = null)
        {
            //TODO
            if (indiceCompetidorAtual != -1)
            {
                equipes[indiceCompetidorAtual].Checkpoints = 0;
                while (indiceCompetidorAtual < equipes.Count - 1)
                {
                    Ultrapassagem(-1);
                }
            }
            if (AtualizarCompetidor == true && LabelEquipe.Text != "Equipe x") FormDaTela.PlacarCoRA.AtualizarTempoCompetidor(LabelEquipe.Text, "0:00:000", 0);

            // Limpando dados da segunda tentativa
            tempoSegundaTentativa = TimeSpan.Zero;
            checkpointsSegundaTentativa = 0;
            melhorTentativa = false;
            // Parando os cronometros
            stopWatch.Reset();
            timerCronometro.Stop();
            // Limpando os Labels
            labelTimer.Text = "0:00:000";
            sensores[0] = 0; checkLabels[0].Text = "Largada: -:--.----:--.--";
            sensores[9] = 0; checkLabels[9].Text = "Chegada: -:--.----:--.-";
            for (int i = 1; i < 9; i++)
            {
                sensores[i] = 0;
                checkLabels[i].Text = $"Checkpoint {i}: -:--.---";
            }
            if (formTelaAberto) FormDaTela.ResetTimers();
        }
        private void ButtonEncerrar_Click(object sender, EventArgs e)
        {
            if (sensores[9] == 1) return;
            stopWatch.Stop();
            timerCronometro.Stop();
            textBox_receber.AppendText("Stop\r\n");

            for (int i = 8; i >= 0; i--)
            {
                if (sensores[i] == 1)
                {
                    labelTimer.Text = checkLabels[i].Text.Substring(checkLabels[i].Text.Length - 8);
                    if (indiceCompetidorAtual != -1) equipes[indiceCompetidorAtual].Tempo = TimeSpan.ParseExact(labelTimer.Text, "m\\:ss\\:fff", null);
                    if (AtualizarCompetidor == true)
                    {
                        FormDaTela.PlacarCoRA.AtualizarTempoCompetidor(LabelEquipe.Text, labelTimer.Text);
                    }
                    break;
                }
            }
        }
        private void FormSerial_Load(object sender, EventArgs e)    //Comunicação com form de exibição
        {
            //Conferindo se o Form de Exibicao esta aberto
            if (Application.OpenForms.OfType<formTela>().Count() > 0)
            {
                FormDaTela = Application.OpenForms.OfType<formTela>().First();
                ToggleExibir(FormDaTela);
            }
        }
        private void Checkpoint_TextChanged(object sender, EventArgs e) //Comunica a tela de exibição a mudança nos checkpoints
        {
            //TODO
            if (formTelaAberto)
            {
                if (sender is Label label)
                {
                    string labelText = label.Text;
                    FormDaTela.TimersText(labelText);
                }
            }
        }
        private void ShowExibirTitle_Click(object sender, EventArgs e) //Mostra na tela de exibição o título
        {
            FormDaTela.ChangeText(TitleExibir.Text, "Tittle");
        }
        private void FormSerial_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
                serialPort1.Close();
        }
        private void textBox_receber_Click(object sender, EventArgs e) //Limpar Monitor Serial
        {
            textBox_receber.Clear();
        }
        private void InicializarDiretorios()
        {
            // Inicializando os diretorios
            if (!Directory.Exists(diretorioPastaPlacar)) Directory.CreateDirectory(diretorioPastaPlacar);
        }
        private void buttonCriarPlacarClick(object sender, EventArgs e)
        {
            CriarPlacar criarPlacar = new CriarPlacar();
            criarPlacar.ShowDialog();
            diretorioArquivoPlacar = criarPlacar.diretorioArquivoPlacar;
            CarregarArquivoPlacar();
        }
        private void buttonCarregarPlacarClick(object sender, EventArgs e)  //Teste de escolher arquivo
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Selecione um arquivo";
            openFileDialog.Filter = "Arquivos CSV|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                diretorioArquivoPlacar = openFileDialog.FileName;
                CarregarArquivoPlacar();
            }
        }
        private void CarregarArquivoPlacar()
        {
            // Conferindo se o diretorio e valido
            if (!string.IsNullOrEmpty(diretorioArquivoPlacar) && File.Exists(diretorioArquivoPlacar))
            {
                // Limpando os Labels
                Reset();
                LabelEquipe.Text = "Equipe";
                labelTentativa.Text = "Tentativa x";
                TentativaSelector.SelectedIndex = -1;
                //Limpando seletor de equipe
                EquipeSelector.Items.Clear();
                equipes.Clear();
                // Limpando o form da tela de exibicao 
                if (formTelaAberto) FormDaTela.PlacarCoRA.ClearCompetidores();
                List<string> linhas = File.ReadLines(diretorioArquivoPlacar).ToList();

                // Pulando o cabecalho
                if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Colocação,Checkpoints,Tempo") linhas = linhas.Skip(1).ToList();

                foreach (string linha in linhas)
                {
                    string[] colunas = linha.Split(',');
                    Equipe equipeLida = new Equipe
                    (
                        colunas[0],
                        colunas[1],
                        uint.Parse(colunas[2]),
                        uint.Parse(colunas[3]),
                        TimeSpan.ParseExact(colunas[4], "m\\:ss\\:fff", null)
                    );
                    
                    equipes.Add(equipeLida);
                    EquipeSelector.Items.Add(colunas[0]);
                    // Caregando para a tela de exibicao
                    if (formTelaAberto)
                    {
                        FormDaTela.PlacarCoRA.AddCompetidor(colunas[0], colunas[1]);
                        FormDaTela.PlacarCoRA.AtualizarTempoCompetidor(colunas[0], colunas[4], uint.Parse(colunas[3]));
                    }
                }
            }
        }
    }
}
