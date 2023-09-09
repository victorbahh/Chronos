using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Interface
{
    public partial class cronometro : Form
    {
        private Stopwatch stopWatch;
        public cronometro()
        {
            InitializeComponent();
        }

        private void cronometro_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label1.Text = string.Format("{0:hh\\:mm\\:ss\\:fff}", stopWatch.Elapsed);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picbox_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
