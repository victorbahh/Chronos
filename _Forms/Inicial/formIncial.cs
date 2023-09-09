using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface
{
    public partial class formIncial : Form
    {
        private bool isDragging = false;
        private int mouseX;
        private int mouseY;

        public formIncial()
        {
            InitializeComponent();

        }
        private void button_iniciar_Click(object sender, EventArgs e)
        {
            formMenu form2 = new formMenu(this);
            form2.Show();
            this.Hide();
        }
        //Para fechar o form
        private void picbox_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picbox_fechar_MouseEnter(object sender, EventArgs e)
        {
            Fechar.BackgroundImage = Chronos.Properties.Resources.x_branco;
        }
        private void Picbox_fechar_MouseLeave(object sender, EventArgs e)
        {
            Fechar.BackgroundImage = Chronos.Properties.Resources.x_azul;
        }
        //ToolBar para mover o form sem barra
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
