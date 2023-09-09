using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace Chronos
{
    public partial class Placar : UserControl
    {

        //Dicionario dos competidores por nome
        private Dictionary<string, Competidor> competidores = new Dictionary<string, Competidor>();
        public Placar()
        {
            InitializeComponent();

        }

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
        public void ClearCompetidores()
        {
            panelCompetidores.Controls.Clear();
            competidores.Clear();
        }
        public void AddCompetidor(string nomeEquipe, string nomeInstituicao)
        {
            Competidor competidor = new Competidor
            {
                Width = panelCompetidores.Width,
                Height = (int)(panelCompetidores.Width * 0.044), // Define a altura como 4.4% da largura
                Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right,
                Position = (panelCompetidores.Controls.Count + 1).ToString(),
                Equipe = nomeEquipe,
                Inst = nomeInstituicao
            };
            panelCompetidores.Controls.Add(competidor);
            competidores.Add(nomeEquipe, competidor);

            if (panelCompetidores.Controls.Count > 1)
            {
                competidor.Top = panelCompetidores.Controls[panelCompetidores.Controls.Count - 2].Bottom + 5;
            }
        }

        private void Placar_SizeChanged(object sender, EventArgs e)
        {
            ResizeText(ChecksTittle);
            EquipeTittle.Font = ChecksTittle.Font;
            InstTittle.Font = ChecksTittle.Font;
            TempoTittle.Font = ChecksTittle.Font;
            //Ajustando tamanho dos competidores
            int top = 0;
            foreach (Control control in panelCompetidores.Controls)
            {
                if (control is Competidor competidor)
                {
                    competidor.Height = (int)(panelCompetidores.Width * 0.044);
                    competidor.Width = panelCompetidores.Width;
                    competidor.Top = top;
                    top += competidor.Height + 5;
                }
            }
        }

        public void AtualizarTempoCompetidor(string nomeCompetidor, string novoTempo = null, uint checks = 0, int colocação = 0)
        {

            if (competidores.ContainsKey(nomeCompetidor))
            {
                Competidor competidor = competidores[nomeCompetidor];
                if (novoTempo != null) competidor.Tempo = novoTempo;
                if (checks != 0) competidor.Checkpoints = checks.ToString();
                if (novoTempo == "0:00:000") competidor.Checkpoints = "0";
            }
        }

        // Controle de ultrapassagens
        private bool isOvertakingInProgress = false;
        private Queue<Tuple<string, string>> filaOvertaking = new Queue<Tuple<string, string>>();

        public void Overtaking(string nomeCompetidor1, string nomeCompetidor2) //Adiciona uma ultrapassagem a fila
        {
            filaOvertaking.Enqueue(new Tuple<string, string>(nomeCompetidor1, nomeCompetidor2));
            ExecutarProximoOvertaking();
        }

        private void ExecutarProximoOvertaking()        // Remove uma ultrapassagem da fila
        {
            if (isOvertakingInProgress) return;
            if (filaOvertaking.Count > 0)
            {
                var proximoOvertaking = filaOvertaking.Dequeue();
                OvertakingAsync(proximoOvertaking.Item1, proximoOvertaking.Item2);
            }
            else
            {
                isOvertakingInProgress = false;
            }
        }
        private void OvertakingAsync(string nomeCompetidor1, string nomeCompetidor2)
        {
            // Marque que uma execução está em andamento.
            isOvertakingInProgress = true;

            if (competidores.ContainsKey(nomeCompetidor1) && competidores.ContainsKey(nomeCompetidor2))
            {
                Competidor competidor1 = competidores[nomeCompetidor1];
                Competidor competidor2 = competidores[nomeCompetidor2];

                int index1 = panelCompetidores.Controls.IndexOf(competidor1);
                int index2 = panelCompetidores.Controls.IndexOf(competidor2);

                if (index1 != -1 && index2 != -1)
                {
                    // Cria uma transição com duração de 200 milissegundos
                    Transition transition = new Transition(new TransitionType_Linear(200));
                    // Aguarda a transicao terminar para chammar a proxima
                    transition.TransitionCompletedEvent += (s, e) => {
                        isOvertakingInProgress = false;
                        ExecutarProximoOvertaking();
                    };

                    // Anima a posição dos competidores no painel
                    transition.add(competidor1, "Top", competidor2.Top);
                    transition.add(competidor2, "Top", competidor1.Top);

                    // Inicia a transição
                    transition.run();

                    // Troca a posição dos competidores no painel
                    panelCompetidores.Controls.SetChildIndex(competidor1, index2);
                    panelCompetidores.Controls.SetChildIndex(competidor2, index1);

                    // Atualizar a colocação
                    string colocação1 = competidor1.Position;
                    string colocação2 = competidor2.Position;

                    competidor1.Position = colocação2;
                    competidor2.Position = colocação1;

                    // Atualizar a propriedade Top dos competidores para refletir a nova ordem
                    int top1 = competidor1.Top;
                    int top2 = competidor2.Top;

                    competidor1.Top = top2;
                    competidor2.Top = top1;
                }
            }

        }
    }
}
