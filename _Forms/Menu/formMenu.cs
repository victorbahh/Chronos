using Interface._Forms.Tela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface

{

    public partial class formMenu : Form
    {
        formIncial form1;
        private bool isDragging = false;
        private int mouseX;
        private int mouseY;
        public formMenu(formIncial form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            panel_painel.Hide();
            panel_equipes.Hide();
            panel_sortear.Hide();
            panel_tela.Hide();
            panel_painel.Hide();
            panel_pontuacao.Hide();
            panel_tempo.Hide();
            panel_monitorSerial.Hide();
            panel_relatorios.Hide();
            panel_config.Hide();
        }
        //Animações dos botoes
        private void button_painel_MouseLeave_1(object sender, EventArgs e)
        {
            panel_painel.Hide();
        }

        private void button_equipes_MouseLeave_1(object sender, EventArgs e)
        {
            panel_equipes.Hide();
        }

        private void button_sortear_MouseLeave_1(object sender, EventArgs e)
        {
            panel_sortear.Hide();
        }

        private void button_tela_MouseLeave_1(object sender, EventArgs e)
        {
            panel_tela.Hide();
        }

        private void button_pontuacao_MouseLeave_1(object sender, EventArgs e)
        {
            panel_pontuacao.Hide();
        }

        private void button_tempo_MouseLeave_1(object sender, EventArgs e)
        {
            panel_tempo.Hide();
        }

        private void button_monitorSerial_MouseLeave_1(object sender, EventArgs e)
        {
            panel_monitorSerial.Hide();
        }

        private void button_relatorios_MouseLeave_1(object sender, EventArgs e)
        {
            panel_relatorios.Hide();
        }

        private void button_config_MouseLeave_1(object sender, EventArgs e)
        {
            panel_config.Hide();
        }

        private void picbox_fechar_MouseLeave(object sender, EventArgs e)
        {
            picbox_fechar.BackgroundImage = Chronos.Properties.Resources.x_azul;
        }
        //Botao de fechar
        private void picbox_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
            form1.Show();
        }
        private void Picbox_fechar_MouseEnter(object sender, EventArgs e)
        {
            picbox_fechar.BackgroundImage = Chronos.Properties.Resources.x_branco;
        }
        private void button_painel_MouseEnter(object sender, EventArgs e)
        {
            panel_painel.Show();
        }

        private void button_equipes_MouseEnter(object sender, EventArgs e)
        {
            panel_equipes.Show();
        }

        private void button_sortear_MouseEnter(object sender, EventArgs e)
        {
            panel_sortear.Show();
        }

        private void button_tela_MouseEnter(object sender, EventArgs e)
        {
            panel_tela.Show();
        }

        private void button_pontuacao_MouseEnter(object sender, EventArgs e)
        {
            panel_pontuacao.Show();
        }

        private void button_tempo_MouseEnter(object sender, EventArgs e)
        {
            panel_tempo.Show();
        }

        private void button_monitorSerial_MouseEnter(object sender, EventArgs e)
        {
            panel_monitorSerial.Show();
        }

        private void button_relatorios_MouseEnter(object sender, EventArgs e)
        {
            panel_relatorios.Show();
        }

        private void button_config_MouseEnter(object sender, EventArgs e)
        {
            panel_config.Show();
        }
        //Click dos botoes
        private void button_equipes_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formEquipes>().Count() == 0)
            {
                formEquipes form_equipes = new formEquipes();
                form_equipes.Show();
            }
            else
            {
                Application.OpenForms.OfType<formEquipes>().First().Show();
            }
        }

        private void button_sortear_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formSorteio>().Count() == 0)
            {
                formSorteio form_sorteio = new formSorteio();
                form_sorteio.Show();
            }
            else
            {
                Application.OpenForms.OfType<formSorteio>().First().Show();
            }
        }

        private void button_pontuacao_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formPontuacao>().Count() == 0)
            {
                formPontuacao form_pontuacao = new formPontuacao();
                form_pontuacao.Show();
            }
            else
            {
                Application.OpenForms.OfType<formPontuacao>().First().Show();
            }
        }

        private void button_monitorSerial_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<FormSerial>().Count() == 0)
            {
                FormSerial form_serial = new FormSerial();
                form_serial.Show();
            }
            else
            {
                Application.OpenForms.OfType<FormSerial>().First().Show();
            }
        }

        private void button_tempo_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<cronometro>().Count() == 0)
            {
                cronometro cronometro = new cronometro();
                cronometro.Show();
            }
            else
            {
                Application.OpenForms.OfType<cronometro>().First().Show();
            }
        }
        private void button_tela_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<formTela>().Count() == 0)
            {
                formTela form_tela = new formTela();
                form_tela.Show();
            }
            else
            {
                Application.OpenForms.OfType<formTela>().First().Show();
            }
        }
        private void picbox_fechar_MouseEnter(object sender, EventArgs e)
        {
            picbox_fechar.BackgroundImage = Chronos.Properties.Resources.x_branco;
        }
        //Toolbar controlar posicao do form sem barra
        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void barraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }
        private void barraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}
