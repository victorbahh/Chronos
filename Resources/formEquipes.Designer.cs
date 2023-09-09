namespace Interface
{
    partial class formEquipes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_equipes = new System.Windows.Forms.Label();
            this.label_novoCadastro = new System.Windows.Forms.Label();
            this.label_nomeEquipe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_nomeEquipe = new System.Windows.Forms.TextBox();
            this.label_calouro = new System.Windows.Forms.Label();
            this.button_adicionar = new System.Windows.Forms.Button();
            this.label_excluirEquipe = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label_excluirEquipe2 = new System.Windows.Forms.Label();
            this.button_excluir = new System.Windows.Forms.Button();
            this.label_listaEquipes = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.button_resetar = new System.Windows.Forms.Button();
            this.dgv_tabelaEquipes = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temCalouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picbox_fechar = new System.Windows.Forms.PictureBox();
            this.rButton_sim = new System.Windows.Forms.RadioButton();
            this.rButton_nao = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelaEquipes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_fechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label_equipes
            // 
            this.label_equipes.AutoSize = true;
            this.label_equipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equipes.ForeColor = System.Drawing.SystemColors.Control;
            this.label_equipes.Location = new System.Drawing.Point(24, 21);
            this.label_equipes.Name = "label_equipes";
            this.label_equipes.Size = new System.Drawing.Size(155, 29);
            this.label_equipes.TabIndex = 0;
            this.label_equipes.Text = "E Q U I P E S";
            // 
            // label_novoCadastro
            // 
            this.label_novoCadastro.AutoSize = true;
            this.label_novoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_novoCadastro.ForeColor = System.Drawing.SystemColors.Control;
            this.label_novoCadastro.Location = new System.Drawing.Point(25, 62);
            this.label_novoCadastro.Name = "label_novoCadastro";
            this.label_novoCadastro.Size = new System.Drawing.Size(153, 24);
            this.label_novoCadastro.TabIndex = 1;
            this.label_novoCadastro.Text = "Cadastrar equipe";
            // 
            // label_nomeEquipe
            // 
            this.label_nomeEquipe.AutoSize = true;
            this.label_nomeEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeEquipe.ForeColor = System.Drawing.SystemColors.Control;
            this.label_nomeEquipe.Location = new System.Drawing.Point(48, 94);
            this.label_nomeEquipe.Name = "label_nomeEquipe";
            this.label_nomeEquipe.Size = new System.Drawing.Size(109, 16);
            this.label_nomeEquipe.TabIndex = 2;
            this.label_nomeEquipe.Text = "Nome da equipe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Location = new System.Drawing.Point(1, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 1);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(-4, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastrar nova equipe";
            // 
            // tbox_nomeEquipe
            // 
            this.tbox_nomeEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_nomeEquipe.Location = new System.Drawing.Point(51, 114);
            this.tbox_nomeEquipe.Name = "tbox_nomeEquipe";
            this.tbox_nomeEquipe.Size = new System.Drawing.Size(199, 22);
            this.tbox_nomeEquipe.TabIndex = 4;
            // 
            // label_calouro
            // 
            this.label_calouro.AutoSize = true;
            this.label_calouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calouro.ForeColor = System.Drawing.SystemColors.Control;
            this.label_calouro.Location = new System.Drawing.Point(49, 148);
            this.label_calouro.Name = "label_calouro";
            this.label_calouro.Size = new System.Drawing.Size(174, 16);
            this.label_calouro.TabIndex = 5;
            this.label_calouro.Text = "Algum integrante é calouro?";
            // 
            // button_adicionar
            // 
            this.button_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adicionar.ForeColor = System.Drawing.Color.White;
            this.button_adicionar.Location = new System.Drawing.Point(52, 217);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(198, 31);
            this.button_adicionar.TabIndex = 8;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_adicionar.UseVisualStyleBackColor = false;
            this.button_adicionar.Click += new System.EventHandler(this.button_adicionar_Click);
            // 
            // label_excluirEquipe
            // 
            this.label_excluirEquipe.AutoSize = true;
            this.label_excluirEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_excluirEquipe.ForeColor = System.Drawing.SystemColors.Control;
            this.label_excluirEquipe.Location = new System.Drawing.Point(26, 273);
            this.label_excluirEquipe.Name = "label_excluirEquipe";
            this.label_excluirEquipe.Size = new System.Drawing.Size(132, 24);
            this.label_excluirEquipe.TabIndex = 9;
            this.label_excluirEquipe.Text = "Excluir equipe";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(28, 299);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 1);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Location = new System.Drawing.Point(1, 207);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 1);
            this.panel4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(-4, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cadastrar nova equipe";
            // 
            // label_excluirEquipe2
            // 
            this.label_excluirEquipe2.AutoSize = true;
            this.label_excluirEquipe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_excluirEquipe2.ForeColor = System.Drawing.SystemColors.Control;
            this.label_excluirEquipe2.Location = new System.Drawing.Point(48, 307);
            this.label_excluirEquipe2.Name = "label_excluirEquipe2";
            this.label_excluirEquipe2.Size = new System.Drawing.Size(202, 16);
            this.label_excluirEquipe2.TabIndex = 10;
            this.label_excluirEquipe2.Text = "Selecione a equipe e pressione:";
            // 
            // button_excluir
            // 
            this.button_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.Color.White;
            this.button_excluir.Location = new System.Drawing.Point(51, 329);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(200, 31);
            this.button_excluir.TabIndex = 11;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // label_listaEquipes
            // 
            this.label_listaEquipes.AutoSize = true;
            this.label_listaEquipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaEquipes.ForeColor = System.Drawing.SystemColors.Control;
            this.label_listaEquipes.Location = new System.Drawing.Point(24, 392);
            this.label_listaEquipes.Name = "label_listaEquipes";
            this.label_listaEquipes.Size = new System.Drawing.Size(147, 24);
            this.label_listaEquipes.TabIndex = 14;
            this.label_listaEquipes.Text = "Lista de equipes";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(27, 419);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(222, 1);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.Location = new System.Drawing.Point(1, 207);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(220, 1);
            this.panel6.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(-4, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cadastrar nova equipe";
            // 
            // button_salvar
            // 
            this.button_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.ForeColor = System.Drawing.Color.White;
            this.button_salvar.Location = new System.Drawing.Point(49, 467);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(200, 31);
            this.button_salvar.TabIndex = 15;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // button_resetar
            // 
            this.button_resetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_resetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_resetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetar.ForeColor = System.Drawing.Color.White;
            this.button_resetar.Location = new System.Drawing.Point(49, 430);
            this.button_resetar.Name = "button_resetar";
            this.button_resetar.Size = new System.Drawing.Size(200, 31);
            this.button_resetar.TabIndex = 16;
            this.button_resetar.Text = "Resetar";
            this.button_resetar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_resetar.UseVisualStyleBackColor = false;
            this.button_resetar.Click += new System.EventHandler(this.button_resetar_Click);
            // 
            // dgv_tabelaEquipes
            // 
            this.dgv_tabelaEquipes.AllowUserToAddRows = false;
            this.dgv_tabelaEquipes.AllowUserToResizeColumns = false;
            this.dgv_tabelaEquipes.AllowUserToResizeRows = false;
            this.dgv_tabelaEquipes.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_tabelaEquipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_tabelaEquipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabelaEquipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nomeEquipe,
            this.temCalouro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabelaEquipes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tabelaEquipes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tabelaEquipes.Location = new System.Drawing.Point(290, 87);
            this.dgv_tabelaEquipes.Name = "dgv_tabelaEquipes";
            this.dgv_tabelaEquipes.ReadOnly = true;
            this.dgv_tabelaEquipes.RowHeadersVisible = false;
            this.dgv_tabelaEquipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabelaEquipes.ShowEditingIcon = false;
            this.dgv_tabelaEquipes.Size = new System.Drawing.Size(406, 411);
            this.dgv_tabelaEquipes.TabIndex = 17;
            this.dgv_tabelaEquipes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tabelaEquipes_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.FillWeight = 46.04317F;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codigo.Width = 80;
            // 
            // nomeEquipe
            // 
            this.nomeEquipe.FillWeight = 150.396F;
            this.nomeEquipe.HeaderText = "Nome da equipe";
            this.nomeEquipe.Name = "nomeEquipe";
            this.nomeEquipe.ReadOnly = true;
            this.nomeEquipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeEquipe.Width = 200;
            // 
            // temCalouro
            // 
            this.temCalouro.FillWeight = 103.5609F;
            this.temCalouro.HeaderText = "Tem calouro?";
            this.temCalouro.Name = "temCalouro";
            this.temCalouro.ReadOnly = true;
            this.temCalouro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.temCalouro.Width = 122;
            // 
            // picbox_fechar
            // 
            this.picbox_fechar.BackgroundImage = global::Interface.Properties.Resources.x_azul;
            this.picbox_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picbox_fechar.Location = new System.Drawing.Point(674, 4);
            this.picbox_fechar.Name = "picbox_fechar";
            this.picbox_fechar.Size = new System.Drawing.Size(22, 22);
            this.picbox_fechar.TabIndex = 18;
            this.picbox_fechar.TabStop = false;
            this.picbox_fechar.Click += new System.EventHandler(this.picbox_fechar_Click);
            this.picbox_fechar.MouseEnter += new System.EventHandler(this.picbox_fechar_MouseEnter);
            this.picbox_fechar.MouseLeave += new System.EventHandler(this.picbox_fechar_MouseLeave);
            // 
            // rButton_sim
            // 
            this.rButton_sim.AutoSize = true;
            this.rButton_sim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton_sim.ForeColor = System.Drawing.SystemColors.Control;
            this.rButton_sim.Location = new System.Drawing.Point(52, 168);
            this.rButton_sim.Name = "rButton_sim";
            this.rButton_sim.Size = new System.Drawing.Size(49, 20);
            this.rButton_sim.TabIndex = 19;
            this.rButton_sim.TabStop = true;
            this.rButton_sim.Text = "Sim";
            this.rButton_sim.UseVisualStyleBackColor = true;
            this.rButton_sim.CheckedChanged += new System.EventHandler(this.rButton_sim_CheckedChanged);
            // 
            // rButton_nao
            // 
            this.rButton_nao.AutoSize = true;
            this.rButton_nao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rButton_nao.ForeColor = System.Drawing.SystemColors.Control;
            this.rButton_nao.Location = new System.Drawing.Point(52, 190);
            this.rButton_nao.Name = "rButton_nao";
            this.rButton_nao.Size = new System.Drawing.Size(52, 20);
            this.rButton_nao.TabIndex = 21;
            this.rButton_nao.TabStop = true;
            this.rButton_nao.Text = "Não";
            this.rButton_nao.UseVisualStyleBackColor = true;
            this.rButton_nao.CheckedChanged += new System.EventHandler(this.rButton_nao_CheckedChanged);
            // 
            // formEquipes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(700, 520);
            this.Controls.Add(this.rButton_nao);
            this.Controls.Add(this.rButton_sim);
            this.Controls.Add(this.picbox_fechar);
            this.Controls.Add(this.dgv_tabelaEquipes);
            this.Controls.Add(this.button_resetar);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label_listaEquipes);
            this.Controls.Add(this.button_excluir);
            this.Controls.Add(this.label_excluirEquipe2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label_excluirEquipe);
            this.Controls.Add(this.button_adicionar);
            this.Controls.Add(this.label_calouro);
            this.Controls.Add(this.tbox_nomeEquipe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_nomeEquipe);
            this.Controls.Add(this.label_novoCadastro);
            this.Controls.Add(this.label_equipes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEquipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Equipes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelaEquipes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_fechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_equipes;
        private System.Windows.Forms.Label label_novoCadastro;
        private System.Windows.Forms.Label label_nomeEquipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbox_nomeEquipe;
        private System.Windows.Forms.Label label_calouro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_adicionar;
        private System.Windows.Forms.Label label_excluirEquipe;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_excluirEquipe2;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Label label_listaEquipes;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Button button_resetar;
        private System.Windows.Forms.DataGridView dgv_tabelaEquipes;
        private System.Windows.Forms.PictureBox picbox_fechar;
        private System.Windows.Forms.RadioButton rButton_sim;
        private System.Windows.Forms.RadioButton rButton_nao;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn temCalouro;
    }
}