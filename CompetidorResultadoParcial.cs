using System;
using System.Drawing;
using System.Windows.Forms;

namespace Chronos
{
    public partial class CompetidorResultadoParcial : UserControl
    {
        public CompetidorResultadoParcial()
        {
            InitializeComponent();
        }
        public string Position
        {
            get { return Colocação.Text; }
            set { Colocação.Text = value; }
        }
        public string Equipe
        {
            get { return NomeEquipe.Text; }
            set { NomeEquipe.Text = value; }
        }
        public string Inst
        {
            get { return InstEquipe.Text; }
            set { InstEquipe.Text = value; }
        }
        public string Pontuacao
        {
            get { return PontuacaoEquipe.Text; }
            set { PontuacaoEquipe.Text = value; }
        }
        private void ResizeText(System.Windows.Forms.Label label)
        {
            string maiorNome = "Parafuso Semicondutor";
            int maxHeight = label.Height - 5; // Define a altura máxima com base na altura do label
            int maxWidth = label.Width - 10; // Define a altura máxima com base na largura do label
            float fontSize = 1f; // Tamanho inicial da fonte (pode ser ajustado conforme necessário)

            using (Graphics g = label.CreateGraphics())
            {
                while (g.MeasureString(maiorNome, new Font(label.Font.FontFamily, fontSize, label.Font.Style)).Height < maxHeight && g.MeasureString(label.Text, new Font(label.Font.FontFamily, fontSize, label.Font.Style)).Width < maxWidth)
                {
                    fontSize++;
                }
            }
            fontSize -= 2f;
            if (fontSize < 1f) fontSize = 1f;
            label.Font = new Font(label.Font.FontFamily, fontSize, label.Font.Style);
        }
        private void Competidor_SizeChanged(object sender, EventArgs e)
        {
            ResizeText(NomeEquipe);
            Colocação.Font = NomeEquipe.Font;
            InstEquipe.Font = NomeEquipe.Font;
            PontuacaoEquipe.Font = NomeEquipe.Font;
        }
    }
}

