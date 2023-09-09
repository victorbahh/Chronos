using Chronos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using Label = System.Windows.Forms.Label;

namespace Interface._Forms.Tela
{
    public partial class formTela : Form
    {
        private bool showEquipeStatus = true;
        private FormSerial Serial;
        private Label[] Checkpoints;
        private PictureBox[] VisualCheckpoints;
        public Placar PlacarCoRA;
        private readonly Dictionary<string, Label> labelDictionary;
        private const string diretorioArquivoResultadoParcialMirim = @"./ChronosData/Placar/Resultado Parcial Mirim.csv";
        private const string diretorioArquivoResultadoParcialAvancado = @"./ChronosData/Placar/Resultado Parcial Avançado.csv";

        public formTela()
        {
            InitializeComponent();
            PlacarCoRA = placar1;
            VisualCheckpoints = new PictureBox[9] { CarCheck1, CarCheck2, CarCheck3, CarCheck4, CarCheck5, CarCheck6, CarCheck7, CarCheck8, CarCheck9 };
            Checkpoints = new Label[9] { Checkpoint1, Checkpoint2, Checkpoint3, Checkpoint4, Checkpoint5, Checkpoint6, Checkpoint7, Checkpoint8, Chegada };
            //Labels com texto alteravel
            labelDictionary = new Dictionary<string, Label>
            {
                // Adicionar pares de nome e Label ao dicionário
                { "Equipe", Equipe },
                { "Tentativa", Tentativa },
                { "Tittle", Tittle }
            };


        }
        public void ChangeText(string text, string labelname)   //Controla o texto de cada Label do form
        {
            if (labelDictionary.ContainsKey(labelname))
            {
                Label label = labelDictionary[labelname];
                label.Text = text;
                ResizeText(label);
            }
        }
        public void TimerSegundaTentativa(string text)
        {
                Tentativa.Text = text;
        }
        public void ResizeTimerSegundaTentativa()
        {
            ResizeText(Tentativa);
        }
        //Controlando o texto dos Timers
        public void TimersText(string text)
        {
           
            if(Char.IsDigit(text[6]))
            {
                Checkpoints[(int)Char.GetNumericValue(text[6]) - 1].Text = text;
                VisualCheckpoints[(int)Char.GetNumericValue(text[6]) - 1].Image = Chronos.Properties.Resources.carrinhoVerdeCheckpoint;
            }
            else
            {
                Checkpoints[8].Text = text;
                VisualCheckpoints[8].Image = Chronos.Properties.Resources.carrinhoVerdeCheckpoint;
            }
        }
        public void ResetTimers()
        {
            for (int i = 0; i < 8; i++)
            {
                Checkpoints[i].Text = "Checkpoint " + (i+1).ToString() + ": -:--.-- - ";
                VisualCheckpoints[i].Image = Chronos.Properties.Resources.carrinhoCheckpoint;
            }
            Checkpoints[8].Text = "Chegada: -:--.----:--.-";
            VisualCheckpoints[8].Image = Chronos.Properties.Resources.carrinhoCheckpoint;
        }
        private void ToggleFullScreen(){
            if (WindowState == FormWindowState.Maximized && FormBorderStyle == FormBorderStyle.None)
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
        }
        private void formTela_Load(object sender, EventArgs e)  //Comunica com o monitor Serial que a tela esta aberta
        {
            //Interagindo com o form serial
            if (Application.OpenForms.OfType<FormSerial>().Count() > 0)
            {
                Serial = Application.OpenForms.OfType<FormSerial>().First();
                Serial.ToggleExibir(this);
            }
            else
            {
                 MessageBox.Show("A tela Serial não está aberta!");
            }
        }

        private void FormTela_SizeChanged(object sender, EventArgs e)   //Chamar funções para controlar o tamanho de todos os elementos
        {
            //Ajustando os elementos para o tamanho da tela
            if (WindowState != FormWindowState.Minimized)
            {
                ResizeText(Tittle);
                ResizeText(Equipe);
                ResizeText(Tentativa);
                ResizeCheckpoints();
            }
        }
        private void ResizeCheckpoints()
        {
            ResizeText(Checkpoint1);
            Checkpoint2.Font = Checkpoint1.Font;
            Checkpoint3.Font = Checkpoint1.Font;
            Checkpoint4.Font = Checkpoint1.Font;
            Checkpoint5.Font = Checkpoint1.Font;
            Checkpoint6.Font = Checkpoint1.Font;
            Checkpoint7.Font = Checkpoint1.Font;
            Checkpoint8.Font = Checkpoint1.Font;
            Chegada.Font = Checkpoint1.Font;
        }
        //Muda dinamicamente o tamanho do texto
        private void ResizeText(System.Windows.Forms.Label label)
        {
            int maxHeight = label.Height - 5; // Define a altura máxima com base na altura do label
            int maxWidth = label.Width - 10; // Define a altura máxima com base na largura do label
            float fontSize = 1f; // Tamanho inicial da fonte (pode ser ajustado conforme necessário)

            using (Graphics g = label.CreateGraphics())
            {
                while (g.MeasureString(label.Text, new Font(label.Font.FontFamily, fontSize, label.Font.Style)).Height < maxHeight && g.MeasureString(label.Text, new Font(label.Font.FontFamily, fontSize, label.Font.Style)).Width < maxWidth)
                {
                    fontSize++;
                }
            }
            fontSize -= 2f;
            if (fontSize < 1f) fontSize = 1f;
            label.Font = new Font(label.Font.FontFamily, fontSize, label.Font.Style);
        }

        private void formTela_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serial?.ToggleExibir(this);
        }
        private void ShowStatusEquipe()//Mostra apenas o placar quando chamada
        {
            // Obtém o estilo da primeira coluna
            ColumnStyle columnStyle1 = LayoutTelaDeExibição.ColumnStyles[0];

            // Verifica se o tipo de tamanho da coluna é Percent
            if (columnStyle1.SizeType == SizeType.Percent)
            {
                // Alterna a largura da coluna entre 0% e 60%
                if (showEquipeStatus)
                {
                    LayoutTelaDeExibição.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 0f);
                }
                else
                {
                    LayoutTelaDeExibição.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 35f);
                    ResizeText(Equipe);
                    ResizeText(Tentativa);
                    ResizeCheckpoints();
                }

                // Inverte o valor do toggle
                showEquipeStatus = !showEquipeStatus;
            }
        }


        // Tudo sobre o resultado parcial
        //Dicionario dos competidores por nome
        private Dictionary<string, CompetidorResultadoParcial> competidores = new Dictionary<string, CompetidorResultadoParcial>();
        private void ToggleResultadoParcialAvancado()
        {
            panelPrincipal.Visible = !panelPrincipal.Visible;
            panelResultadoParcial.Visible = !panelResultadoParcial.Visible;
            if (panelResultadoParcial.Visible == true) CarregarArquivoResultadoParcialAvancado();
        }
        private void ToggleResultadoParcialMirim()
        {
            panelPrincipal.Visible = !panelPrincipal.Visible;
            panelResultadoParcial.Visible = !panelResultadoParcial.Visible;
            if (panelResultadoParcial.Visible == true) CarregarArquivoResultadoParcialMirim();
        }
        private void CarregarArquivoResultadoParcialMirim()
        {
            // Conferindo se o diretorio e valido
            if (!string.IsNullOrEmpty(diretorioArquivoResultadoParcialMirim) && File.Exists(diretorioArquivoResultadoParcialMirim))
            {
                // Limpando o form da tela de exibicao 
                ClearCompetidoresResultadoParcial();
                List<string> linhas = File.ReadLines(diretorioArquivoResultadoParcialMirim).ToList();

                // Pulando o cabecalho
                if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Apresentação") linhas = linhas.Skip(1).ToList();

                // Ordenando Lista
                // Sim esse codigo e genial, e sim foi feito pelo chatgpt
                var listaOrdenada = linhas
                    .Select(str =>
                    {
                        var colunas = str.Split(',');
                        var valores = colunas.Skip(2).Take(3).Select(int.Parse).ToList();
                        int soma = valores.Sum();
                        colunas = colunas.Concat(new[] { soma.ToString() }).ToArray();
                        return string.Join(",", colunas);
                    })
                    .OrderByDescending(str =>
                    {
                        int soma;
                        if (int.TryParse(str.Split(',').Last(), out soma))
                        {
                            return soma;
                        }
                        return 0;
                    })
                    .ToList();

                foreach (string elemento in listaOrdenada)
                {
                    string[] colunas = elemento.Split(',');
                    AddCompetidorResultadoParcial(colunas[0], colunas[1], colunas.Last());
                }
            }
        }
        private void CarregarArquivoResultadoParcialAvancado()
        {
            // Conferindo se o diretorio e valido
            if (!string.IsNullOrEmpty(diretorioArquivoResultadoParcialAvancado) && File.Exists(diretorioArquivoResultadoParcialAvancado))
            {
                // Limpando o form da tela de exibicao 
                ClearCompetidoresResultadoParcial();
                List<string> linhas = File.ReadLines(diretorioArquivoResultadoParcialAvancado).ToList();

                // Pulando o cabecalho
                if (linhas.Count() > 0 && linhas[0] == "Equipe,Instituição,Pontuação Bateria 1,Pontuação Bateria 2,Pontuação Bateria 3,Pontuação Apresentação") linhas = linhas.Skip(1).ToList();

                // Ordenando Lista
                // Sim esse codigo e genial, e sim foi feito pelo chatgpt
                var listaOrdenada = linhas
                    .Select(str =>
                    {
                        var colunas = str.Split(',');
                        var valores = colunas.Skip(2).Take(4).Select(int.Parse).ToList();
                        int soma = valores.Sum();
                        colunas = colunas.Concat(new[] { soma.ToString() }).ToArray();
                        return string.Join(",", colunas);
                    })
                    .OrderByDescending(str =>
                    {
                        int soma;
                        if (int.TryParse(str.Split(',').Last(), out soma))
                        {
                            return soma;
                        }
                        return 0;
                    })
                    .ToList();

                foreach(string elemento in listaOrdenada)
                {
                    string[] colunas = elemento.Split(',');
                    AddCompetidorResultadoParcial(colunas[0], colunas[1], colunas.Last());
                }
            }
        }
        private void panelCompetidores_SizeChanged(object sender, EventArgs e)
        {
            if (panelPrincipal.Visible == false) return;
            ResizeText(InstTittle);
            EquipeTittle.Font = InstTittle.Font;
            PontuacaoTittle.Font = InstTittle.Font;
            //Ajustando tamanho dos competidores
            int top = 0;
            foreach (Control control in panelCompetidoresResultadoParcial.Controls)
            {
                if (control is CompetidorResultadoParcial competidor)
                {
                    competidor.Height = (int)(panelCompetidoresResultadoParcial.Width * 0.044);
                    competidor.Width = panelCompetidoresResultadoParcial.Width;
                    competidor.Top = top;
                    top += competidor.Height + 5;
                }
            }
        }
        public void ClearCompetidoresResultadoParcial()
        {
            panelCompetidoresResultadoParcial.Controls.Clear();
            competidores.Clear();
        }
        public void AddCompetidorResultadoParcial(string nomeEquipe, string nomeInstituicao, string pontuacaoTotal)
        {
            CompetidorResultadoParcial competidor = new CompetidorResultadoParcial
            {
                Width = panelCompetidoresResultadoParcial.Width,
                Height = (int)(panelCompetidoresResultadoParcial.Width * 0.044), // Define a altura como 4.4% da largura
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right,
                Position = (panelCompetidoresResultadoParcial.Controls.Count + 1).ToString(),
                Equipe = nomeEquipe,
                Inst = nomeInstituicao,
                Pontuacao = pontuacaoTotal,
            };
            panelCompetidoresResultadoParcial.Controls.Add(competidor);
            competidores.Add(nomeEquipe, competidor);

            if (panelCompetidoresResultadoParcial.Controls.Count > 1)
            {
                competidor.Top = panelCompetidoresResultadoParcial.Controls[panelCompetidoresResultadoParcial.Controls.Count - 2].Bottom + 5;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)    //Coloca o form em tela cheia quando F11 ou Alt + Return é pressionado (Ela nao necessita de referencia!)
        {
            if (keyData == Keys.F11 || (keyData == (Keys.Alt | Keys.Enter)))
            {
                ToggleFullScreen();
                return true;
            }
            if (keyData == (Keys.Control | Keys.T))
            {
                ShowStatusEquipe();
                return true;
            }
            if (keyData == (Keys.Control | Keys.R))
            {
                ToggleResultadoParcialAvancado();
                return true;
            }
            if (keyData == (Keys.Control | Keys.F))
            {
                ToggleResultadoParcialMirim();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void EquipeTittle_Click(object sender, EventArgs e)
        {
            CarregarArquivoResultadoParcialAvancado();
        }
    }
}
