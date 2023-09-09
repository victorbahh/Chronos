namespace Interface
{
    partial class formIncial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formIncial));
            this.BemVindo = new System.Windows.Forms.Label();
            this.button_iniciar = new System.Windows.Forms.Button();
            this.rodapeCora = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.LogoPetee = new System.Windows.Forms.PictureBox();
            this.ArteChronos = new System.Windows.Forms.PictureBox();
            this.ToolBar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rodapeCora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPetee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArteChronos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBar)).BeginInit();
            this.SuspendLayout();
            // 
            // BemVindo
            // 
            this.BemVindo.AllowDrop = true;
            this.BemVindo.AutoSize = true;
            this.BemVindo.BackColor = System.Drawing.Color.Transparent;
            this.BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindo.ForeColor = System.Drawing.Color.White;
            this.BemVindo.Location = new System.Drawing.Point(56, 97);
            this.BemVindo.Name = "BemVindo";
            this.BemVindo.Size = new System.Drawing.Size(201, 25);
            this.BemVindo.TabIndex = 0;
            this.BemVindo.Text = "Seja bem-vindo(a) ao";
            this.BemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_iniciar
            // 
            this.button_iniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_iniciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_iniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_iniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_iniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_iniciar.ForeColor = System.Drawing.Color.White;
            this.button_iniciar.Location = new System.Drawing.Point(71, 269);
            this.button_iniciar.Name = "button_iniciar";
            this.button_iniciar.Size = new System.Drawing.Size(146, 54);
            this.button_iniciar.TabIndex = 3;
            this.button_iniciar.Text = "Iniciar";
            this.button_iniciar.UseVisualStyleBackColor = false;
            this.button_iniciar.Click += new System.EventHandler(this.button_iniciar_Click);
            // 
            // rodapeCora
            // 
            this.rodapeCora.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rodapeCora.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rodapeCora.BackgroundImage")));
            this.rodapeCora.Enabled = false;
            this.rodapeCora.Location = new System.Drawing.Point(81, 468);
            this.rodapeCora.MaximumSize = new System.Drawing.Size(200, 80);
            this.rodapeCora.MinimumSize = new System.Drawing.Size(129, 40);
            this.rodapeCora.Name = "rodapeCora";
            this.rodapeCora.Size = new System.Drawing.Size(129, 40);
            this.rodapeCora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rodapeCora.TabIndex = 7;
            this.rodapeCora.TabStop = false;
            // 
            // Fechar
            // 
            this.Fechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Fechar.BackgroundImage = global::Chronos.Properties.Resources.x_azul;
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Location = new System.Drawing.Point(257, 12);
            this.Fechar.MaximumSize = new System.Drawing.Size(44, 44);
            this.Fechar.MinimumSize = new System.Drawing.Size(22, 22);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(22, 22);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fechar.TabIndex = 6;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.picbox_fechar_Click);
            this.Fechar.MouseEnter += new System.EventHandler(this.picbox_fechar_MouseEnter);
            this.Fechar.MouseLeave += new System.EventHandler(this.Picbox_fechar_MouseLeave);
            // 
            // LogoPetee
            // 
            this.LogoPetee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoPetee.BackgroundImage")));
            this.LogoPetee.Enabled = false;
            this.LogoPetee.Location = new System.Drawing.Point(128, 34);
            this.LogoPetee.Name = "LogoPetee";
            this.LogoPetee.Size = new System.Drawing.Size(34, 50);
            this.LogoPetee.TabIndex = 4;
            this.LogoPetee.TabStop = false;
            // 
            // ArteChronos
            // 
            this.ArteChronos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ArteChronos.BackgroundImage")));
            this.ArteChronos.Enabled = false;
            this.ArteChronos.Location = new System.Drawing.Point(10, 137);
            this.ArteChronos.Name = "ArteChronos";
            this.ArteChronos.Size = new System.Drawing.Size(270, 112);
            this.ArteChronos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ArteChronos.TabIndex = 1;
            this.ArteChronos.TabStop = false;
            // 
            // ToolBar
            // 
            this.ToolBar.BackColor = System.Drawing.Color.Transparent;
            this.ToolBar.Location = new System.Drawing.Point(10, 4);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(276, 24);
            this.ToolBar.TabIndex = 8;
            this.ToolBar.TabStop = false;
            this.ToolBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            this.ToolBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseMove);
            this.ToolBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseUp);
            // 
            // formIncial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(290, 520);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.rodapeCora);
            this.Controls.Add(this.LogoPetee);
            this.Controls.Add(this.button_iniciar);
            this.Controls.Add(this.ArteChronos);
            this.Controls.Add(this.BemVindo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formIncial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.rodapeCora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPetee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArteChronos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BemVindo;
        private System.Windows.Forms.PictureBox ArteChronos;
        private System.Windows.Forms.Button button_iniciar;
        private System.Windows.Forms.PictureBox LogoPetee;
        private System.Windows.Forms.PictureBox Fechar;
        private System.Windows.Forms.PictureBox rodapeCora;
        private System.Windows.Forms.PictureBox ToolBar;
    }
}

