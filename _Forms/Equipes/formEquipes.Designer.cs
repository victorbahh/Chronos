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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEquipes));
            this.label_equipes = new System.Windows.Forms.Label();
            this.label_novoCadastro = new System.Windows.Forms.Label();
            this.label_nomeEquipe = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxNomeEquipe = new System.Windows.Forms.TextBox();
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
            this.label_calouro = new System.Windows.Forms.Label();
            this.AvançadoButton = new System.Windows.Forms.RadioButton();
            this.MirimButton = new System.Windows.Forms.RadioButton();
            this.tboxInst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabelaEquipes = new System.Windows.Forms.DataGridView();
            this.nomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEquipes)).BeginInit();
            this.SuspendLayout();
            // 
            // label_equipes
            // 
            this.label_equipes.AutoSize = true;
            this.label_equipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_equipes.ForeColor = System.Drawing.SystemColors.Control;
            this.label_equipes.Location = new System.Drawing.Point(25, 20);
            this.label_equipes.Name = "label_equipes";
            this.label_equipes.Size = new System.Drawing.Size(195, 36);
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
            this.label_novoCadastro.Size = new System.Drawing.Size(198, 29);
            this.label_novoCadastro.TabIndex = 1;
            this.label_novoCadastro.Text = "Cadastrar equipe";
            // 
            // label_nomeEquipe
            // 
            this.label_nomeEquipe.AutoSize = true;
            this.label_nomeEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomeEquipe.ForeColor = System.Drawing.SystemColors.Control;
            this.label_nomeEquipe.Location = new System.Drawing.Point(35, 97);
            this.label_nomeEquipe.Name = "label_nomeEquipe";
            this.label_nomeEquipe.Size = new System.Drawing.Size(130, 20);
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
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastrar nova equipe";
            // 
            // tbox_nomeEquipe
            // 
            this.tboxNomeEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNomeEquipe.Location = new System.Drawing.Point(39, 120);
            this.tboxNomeEquipe.Name = "tbox_nomeEquipe";
            this.tboxNomeEquipe.Size = new System.Drawing.Size(214, 26);
            this.tboxNomeEquipe.TabIndex = 4;
            // 
            // button_adicionar
            // 
            this.button_adicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adicionar.ForeColor = System.Drawing.Color.White;
            this.button_adicionar.Location = new System.Drawing.Point(52, 241);
            this.button_adicionar.Name = "button_adicionar";
            this.button_adicionar.Size = new System.Drawing.Size(198, 31);
            this.button_adicionar.TabIndex = 8;
            this.button_adicionar.Text = "Adicionar";
            this.button_adicionar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_adicionar.UseVisualStyleBackColor = false;
            this.button_adicionar.Click += new System.EventHandler(this.buttonAdicionarCLick);
            // 
            // label_excluirEquipe
            // 
            this.label_excluirEquipe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_excluirEquipe.AutoSize = true;
            this.label_excluirEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_excluirEquipe.ForeColor = System.Drawing.SystemColors.Control;
            this.label_excluirEquipe.Location = new System.Drawing.Point(26, 280);
            this.label_excluirEquipe.Name = "label_excluirEquipe";
            this.label_excluirEquipe.Size = new System.Drawing.Size(166, 29);
            this.label_excluirEquipe.TabIndex = 9;
            this.label_excluirEquipe.Text = "Excluir equipe";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(28, 306);
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
            this.label3.Size = new System.Drawing.Size(255, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cadastrar nova equipe";
            // 
            // label_excluirEquipe2
            // 
            this.label_excluirEquipe2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_excluirEquipe2.AutoSize = true;
            this.label_excluirEquipe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_excluirEquipe2.ForeColor = System.Drawing.SystemColors.Control;
            this.label_excluirEquipe2.Location = new System.Drawing.Point(23, 314);
            this.label_excluirEquipe2.Name = "label_excluirEquipe2";
            this.label_excluirEquipe2.Size = new System.Drawing.Size(247, 20);
            this.label_excluirEquipe2.TabIndex = 10;
            this.label_excluirEquipe2.Text = "Selecione a equipe e pressione:";
            // 
            // button_excluir
            // 
            this.button_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_excluir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_excluir.ForeColor = System.Drawing.Color.White;
            this.button_excluir.Location = new System.Drawing.Point(51, 336);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(200, 31);
            this.button_excluir.TabIndex = 11;
            this.button_excluir.Text = "Excluir";
            this.button_excluir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_excluir.UseVisualStyleBackColor = false;
            this.button_excluir.Click += new System.EventHandler(this.buttonExcluirClick);
            // 
            // label_listaEquipes
            // 
            this.label_listaEquipes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_listaEquipes.AutoSize = true;
            this.label_listaEquipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listaEquipes.ForeColor = System.Drawing.SystemColors.Control;
            this.label_listaEquipes.Location = new System.Drawing.Point(24, 399);
            this.label_listaEquipes.Name = "label_listaEquipes";
            this.label_listaEquipes.Size = new System.Drawing.Size(190, 29);
            this.label_listaEquipes.TabIndex = 14;
            this.label_listaEquipes.Text = "Lista de equipes";
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(27, 426);
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
            this.label4.Size = new System.Drawing.Size(255, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cadastrar nova equipe";
            // 
            // button_salvar
            // 
            this.button_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.ForeColor = System.Drawing.Color.White;
            this.button_salvar.Location = new System.Drawing.Point(49, 474);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(200, 31);
            this.button_salvar.TabIndex = 15;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Click += new System.EventHandler(this.buttonSalvarClick);
            // 
            // button_resetar
            // 
            this.button_resetar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_resetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_resetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_resetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetar.ForeColor = System.Drawing.Color.White;
            this.button_resetar.Location = new System.Drawing.Point(49, 437);
            this.button_resetar.Name = "button_resetar";
            this.button_resetar.Size = new System.Drawing.Size(200, 31);
            this.button_resetar.TabIndex = 16;
            this.button_resetar.Text = "Resetar";
            this.button_resetar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_resetar.UseVisualStyleBackColor = false;
            this.button_resetar.Click += new System.EventHandler(this.buttonResetarClick);
            // 
            // label_calouro
            // 
            this.label_calouro.AutoSize = true;
            this.label_calouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_calouro.ForeColor = System.Drawing.SystemColors.Control;
            this.label_calouro.Location = new System.Drawing.Point(101, 193);
            this.label_calouro.Name = "label_calouro";
            this.label_calouro.Size = new System.Drawing.Size(81, 20);
            this.label_calouro.TabIndex = 5;
            this.label_calouro.Text = "Categoria";
            // 
            // AvançadoButton
            // 
            this.AvançadoButton.AutoSize = true;
            this.AvançadoButton.Checked = true;
            this.AvançadoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvançadoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AvançadoButton.Location = new System.Drawing.Point(49, 211);
            this.AvançadoButton.Name = "AvançadoButton";
            this.AvançadoButton.Size = new System.Drawing.Size(103, 24);
            this.AvançadoButton.TabIndex = 19;
            this.AvançadoButton.TabStop = true;
            this.AvançadoButton.Text = "Avançado";
            this.AvançadoButton.UseVisualStyleBackColor = true;
            // 
            // MirimButton
            // 
            this.MirimButton.AutoSize = true;
            this.MirimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MirimButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MirimButton.Location = new System.Drawing.Point(160, 212);
            this.MirimButton.Name = "MirimButton";
            this.MirimButton.Size = new System.Drawing.Size(72, 24);
            this.MirimButton.TabIndex = 21;
            this.MirimButton.Text = "Mirim";
            this.MirimButton.UseVisualStyleBackColor = true;
            // 
            // textBoxInst
            // 
            this.tboxInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxInst.Location = new System.Drawing.Point(39, 164);
            this.tboxInst.Name = "textBoxInst";
            this.tboxInst.Size = new System.Drawing.Size(214, 26);
            this.tboxInst.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(35, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nome da Instituição e Cidade";
            // 
            // tabelaEquipes
            // 
            this.tabelaEquipes.AllowUserToAddRows = false;
            this.tabelaEquipes.AllowUserToResizeColumns = false;
            this.tabelaEquipes.AllowUserToResizeRows = false;
            this.tabelaEquipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaEquipes.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelaEquipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelaEquipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaEquipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeEquipe,
            this.Inst,
            this.Categoria});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelaEquipes.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabelaEquipes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tabelaEquipes.Location = new System.Drawing.Point(305, 62);
            this.tabelaEquipes.Name = "tabelaEquipes";
            this.tabelaEquipes.ReadOnly = true;
            this.tabelaEquipes.RowHeadersVisible = false;
            this.tabelaEquipes.RowHeadersWidth = 51;
            this.tabelaEquipes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tabelaEquipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabelaEquipes.ShowEditingIcon = false;
            this.tabelaEquipes.Size = new System.Drawing.Size(451, 440);
            this.tabelaEquipes.TabIndex = 24;
            // 
            // nomeEquipe
            // 
            this.nomeEquipe.FillWeight = 150.396F;
            this.nomeEquipe.HeaderText = "Nome da equipe";
            this.nomeEquipe.MinimumWidth = 6;
            this.nomeEquipe.Name = "nomeEquipe";
            this.nomeEquipe.ReadOnly = true;
            this.nomeEquipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeEquipe.Width = 200;
            // 
            // Inst
            // 
            this.Inst.HeaderText = "Instituição";
            this.Inst.MinimumWidth = 6;
            this.Inst.Name = "Inst";
            this.Inst.ReadOnly = true;
            this.Inst.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // formEquipes
            // 
            this.AcceptButton = this.button_adicionar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.CancelButton = this.button_excluir;
            this.ClientSize = new System.Drawing.Size(780, 520);
            this.Controls.Add(this.tabelaEquipes);
            this.Controls.Add(this.tboxInst);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MirimButton);
            this.Controls.Add(this.AvançadoButton);
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
            this.Controls.Add(this.tboxNomeEquipe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_nomeEquipe);
            this.Controls.Add(this.label_novoCadastro);
            this.Controls.Add(this.label_equipes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(510, 150);
            this.MaximumSize = new System.Drawing.Size(798, 567);
            this.MinimumSize = new System.Drawing.Size(798, 567);
            this.Name = "formEquipes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Equipes";
            this.Load += new System.EventHandler(this.formEquipes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaEquipes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_equipes;
        private System.Windows.Forms.Label label_novoCadastro;
        private System.Windows.Forms.Label label_nomeEquipe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tboxNomeEquipe;
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
        private System.Windows.Forms.Label label_calouro;
        private System.Windows.Forms.RadioButton AvançadoButton;
        private System.Windows.Forms.RadioButton MirimButton;
        private System.Windows.Forms.TextBox tboxInst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tabelaEquipes;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}