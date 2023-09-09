
namespace Interface
{
    partial class formPontuacao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPontuacao));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Classificatorias = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_tabelaEquipes = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temCalouro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontuacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage_Final = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_pontuação = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Fatores = new System.Windows.Forms.Label();
            this.numericUpDown_CheckPoint = new System.Windows.Forms.NumericUpDown();
            this.button_resetar = new System.Windows.Forms.Button();
            this.button_salvar = new System.Windows.Forms.Button();
            this.label_CheckPoint = new System.Windows.Forms.Label();
            this.label_Tempo = new System.Windows.Forms.Label();
            this.numericUpDown_Tempo = new System.Windows.Forms.NumericUpDown();
            this.label_Completar = new System.Windows.Forms.Label();
            this.numericUpDown_Completar = new System.Windows.Forms.NumericUpDown();
            this.label_Relatorio = new System.Windows.Forms.Label();
            this.numericUpDown_Relatorio = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label_Calouro = new System.Windows.Forms.Label();
            this.numericUpDown_Calouro = new System.Windows.Forms.NumericUpDown();
            this.tabControl.SuspendLayout();
            this.tabPage_Classificatorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelaEquipes)).BeginInit();
            this.tabPage_Final.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CheckPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Completar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Relatorio)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Calouro)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Classificatorias);
            this.tabControl.Controls.Add(this.tabPage_Final);
            this.tabControl.Location = new System.Drawing.Point(26, 63);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(648, 445);
            this.tabControl.TabIndex = 21;
            // 
            // tabPage_Classificatorias
            // 
            this.tabPage_Classificatorias.Controls.Add(this.label2);
            this.tabPage_Classificatorias.Controls.Add(this.dgv_tabelaEquipes);
            this.tabPage_Classificatorias.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Classificatorias.Name = "tabPage_Classificatorias";
            this.tabPage_Classificatorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Classificatorias.Size = new System.Drawing.Size(640, 416);
            this.tabPage_Classificatorias.TabIndex = 0;
            this.tabPage_Classificatorias.Text = "Classificatórias";
            this.tabPage_Classificatorias.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 36);
            this.label2.TabIndex = 41;
            this.label2.Text = "Classificação";
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
            this.temCalouro,
            this.relatorio,
            this.pontuacao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_tabelaEquipes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_tabelaEquipes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_tabelaEquipes.Location = new System.Drawing.Point(-2, 32);
            this.dgv_tabelaEquipes.Name = "dgv_tabelaEquipes";
            this.dgv_tabelaEquipes.ReadOnly = true;
            this.dgv_tabelaEquipes.RowHeadersVisible = false;
            this.dgv_tabelaEquipes.RowHeadersWidth = 51;
            this.dgv_tabelaEquipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tabelaEquipes.ShowEditingIcon = false;
            this.dgv_tabelaEquipes.Size = new System.Drawing.Size(645, 387);
            this.dgv_tabelaEquipes.TabIndex = 40;
            // 
            // codigo
            // 
            this.codigo.FillWeight = 46.04317F;
            this.codigo.HeaderText = "Código";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.codigo.Width = 80;
            // 
            // nomeEquipe
            // 
            this.nomeEquipe.FillWeight = 150.396F;
            this.nomeEquipe.HeaderText = "Nome da equipe";
            this.nomeEquipe.MinimumWidth = 6;
            this.nomeEquipe.Name = "nomeEquipe";
            this.nomeEquipe.ReadOnly = true;
            this.nomeEquipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nomeEquipe.Width = 240;
            // 
            // temCalouro
            // 
            this.temCalouro.FillWeight = 103.5609F;
            this.temCalouro.HeaderText = "Tem calouro?";
            this.temCalouro.MinimumWidth = 6;
            this.temCalouro.Name = "temCalouro";
            this.temCalouro.ReadOnly = true;
            this.temCalouro.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.temCalouro.Width = 122;
            // 
            // relatorio
            // 
            this.relatorio.HeaderText = "Relatório";
            this.relatorio.MinimumWidth = 6;
            this.relatorio.Name = "relatorio";
            this.relatorio.ReadOnly = true;
            this.relatorio.Width = 125;
            // 
            // pontuacao
            // 
            this.pontuacao.HeaderText = "Pontuação";
            this.pontuacao.MinimumWidth = 6;
            this.pontuacao.Name = "pontuacao";
            this.pontuacao.ReadOnly = true;
            this.pontuacao.Width = 125;
            // 
            // tabPage_Final
            // 
            this.tabPage_Final.Controls.Add(this.label4);
            this.tabPage_Final.Controls.Add(this.dataGridView1);
            this.tabPage_Final.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Final.Name = "tabPage_Final";
            this.tabPage_Final.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Final.Size = new System.Drawing.Size(640, 416);
            this.tabPage_Final.TabIndex = 1;
            this.tabPage_Final.Text = "Final";
            this.tabPage_Final.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 36);
            this.label4.TabIndex = 41;
            this.label4.Text = "Classificação";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(645, 387);
            this.dataGridView1.TabIndex = 40;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 46.04317F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 150.396F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome da equipe";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 240;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 103.5609F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Tem calouro?";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn3.Width = 122;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Relatório";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Pontuação";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // label_pontuação
            // 
            this.label_pontuação.AutoSize = true;
            this.label_pontuação.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pontuação.ForeColor = System.Drawing.SystemColors.Control;
            this.label_pontuação.Location = new System.Drawing.Point(25, 20);
            this.label_pontuação.Name = "label_pontuação";
            this.label_pontuação.Size = new System.Drawing.Size(268, 36);
            this.label_pontuação.TabIndex = 22;
            this.label_pontuação.Text = "P O N T U A Ç Ã O";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(707, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 1);
            this.panel1.TabIndex = 25;
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
            // label_Fatores
            // 
            this.label_Fatores.AutoSize = true;
            this.label_Fatores.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label_Fatores.ForeColor = System.Drawing.SystemColors.Control;
            this.label_Fatores.Location = new System.Drawing.Point(702, 63);
            this.label_Fatores.Name = "label_Fatores";
            this.label_Fatores.Size = new System.Drawing.Size(115, 36);
            this.label_Fatores.TabIndex = 23;
            this.label_Fatores.Text = "Fatores";
            // 
            // numericUpDown_CheckPoint
            // 
            this.numericUpDown_CheckPoint.Location = new System.Drawing.Point(719, 127);
            this.numericUpDown_CheckPoint.Name = "numericUpDown_CheckPoint";
            this.numericUpDown_CheckPoint.Size = new System.Drawing.Size(113, 22);
            this.numericUpDown_CheckPoint.TabIndex = 0;
            // 
            // button_resetar
            // 
            this.button_resetar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_resetar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_resetar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_resetar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_resetar.ForeColor = System.Drawing.Color.White;
            this.button_resetar.Location = new System.Drawing.Point(719, 422);
            this.button_resetar.Name = "button_resetar";
            this.button_resetar.Size = new System.Drawing.Size(200, 31);
            this.button_resetar.TabIndex = 30;
            this.button_resetar.Text = "Resetar";
            this.button_resetar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_resetar.UseVisualStyleBackColor = false;
            // 
            // button_salvar
            // 
            this.button_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_salvar.ForeColor = System.Drawing.Color.White;
            this.button_salvar.Location = new System.Drawing.Point(719, 459);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(200, 31);
            this.button_salvar.TabIndex = 29;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_salvar.UseVisualStyleBackColor = false;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // label_CheckPoint
            // 
            this.label_CheckPoint.AutoSize = true;
            this.label_CheckPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_CheckPoint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_CheckPoint.Location = new System.Drawing.Point(715, 102);
            this.label_CheckPoint.Name = "label_CheckPoint";
            this.label_CheckPoint.Size = new System.Drawing.Size(142, 29);
            this.label_CheckPoint.TabIndex = 40;
            this.label_CheckPoint.Text = "Check Point";
            // 
            // label_Tempo
            // 
            this.label_Tempo.AutoSize = true;
            this.label_Tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_Tempo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Tempo.Location = new System.Drawing.Point(715, 163);
            this.label_Tempo.Name = "label_Tempo";
            this.label_Tempo.Size = new System.Drawing.Size(91, 29);
            this.label_Tempo.TabIndex = 42;
            this.label_Tempo.Text = "Tempo";
            // 
            // numericUpDown_Tempo
            // 
            this.numericUpDown_Tempo.Location = new System.Drawing.Point(719, 188);
            this.numericUpDown_Tempo.Name = "numericUpDown_Tempo";
            this.numericUpDown_Tempo.Size = new System.Drawing.Size(113, 22);
            this.numericUpDown_Tempo.TabIndex = 41;
            // 
            // label_Completar
            // 
            this.label_Completar.AutoSize = true;
            this.label_Completar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_Completar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Completar.Location = new System.Drawing.Point(715, 224);
            this.label_Completar.Name = "label_Completar";
            this.label_Completar.Size = new System.Drawing.Size(125, 29);
            this.label_Completar.TabIndex = 44;
            this.label_Completar.Text = "Completar";
            // 
            // numericUpDown_Completar
            // 
            this.numericUpDown_Completar.Location = new System.Drawing.Point(719, 249);
            this.numericUpDown_Completar.Name = "numericUpDown_Completar";
            this.numericUpDown_Completar.Size = new System.Drawing.Size(113, 22);
            this.numericUpDown_Completar.TabIndex = 43;
            // 
            // label_Relatorio
            // 
            this.label_Relatorio.AutoSize = true;
            this.label_Relatorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_Relatorio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Relatorio.Location = new System.Drawing.Point(715, 285);
            this.label_Relatorio.Name = "label_Relatorio";
            this.label_Relatorio.Size = new System.Drawing.Size(111, 29);
            this.label_Relatorio.TabIndex = 46;
            this.label_Relatorio.Text = "Relatório";
            // 
            // numericUpDown_Relatorio
            // 
            this.numericUpDown_Relatorio.Location = new System.Drawing.Point(719, 310);
            this.numericUpDown_Relatorio.Name = "numericUpDown_Relatorio";
            this.numericUpDown_Relatorio.Size = new System.Drawing.Size(113, 22);
            this.numericUpDown_Relatorio.TabIndex = 45;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(707, 410);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 1);
            this.panel3.TabIndex = 47;
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
            // label_Calouro
            // 
            this.label_Calouro.AutoSize = true;
            this.label_Calouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label_Calouro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Calouro.Location = new System.Drawing.Point(715, 347);
            this.label_Calouro.Name = "label_Calouro";
            this.label_Calouro.Size = new System.Drawing.Size(98, 29);
            this.label_Calouro.TabIndex = 49;
            this.label_Calouro.Text = "Calouro";
            // 
            // numericUpDown_Calouro
            // 
            this.numericUpDown_Calouro.Location = new System.Drawing.Point(719, 372);
            this.numericUpDown_Calouro.Name = "numericUpDown_Calouro";
            this.numericUpDown_Calouro.Size = new System.Drawing.Size(113, 22);
            this.numericUpDown_Calouro.TabIndex = 48;
            // 
            // formPontuacao
            // 
            this.AccessibleDescription = "z";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(950, 520);
            this.Controls.Add(this.label_Calouro);
            this.Controls.Add(this.numericUpDown_Calouro);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label_Relatorio);
            this.Controls.Add(this.numericUpDown_Relatorio);
            this.Controls.Add(this.label_Completar);
            this.Controls.Add(this.numericUpDown_Completar);
            this.Controls.Add(this.label_Tempo);
            this.Controls.Add(this.numericUpDown_Tempo);
            this.Controls.Add(this.label_CheckPoint);
            this.Controls.Add(this.button_resetar);
            this.Controls.Add(this.button_salvar);
            this.Controls.Add(this.numericUpDown_CheckPoint);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_Fatores);
            this.Controls.Add(this.label_pontuação);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(510, 150);
            this.Name = "formPontuacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pontuacao";
            this.tabControl.ResumeLayout(false);
            this.tabPage_Classificatorias.ResumeLayout(false);
            this.tabPage_Classificatorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabelaEquipes)).EndInit();
            this.tabPage_Final.ResumeLayout(false);
            this.tabPage_Final.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CheckPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Tempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Completar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Relatorio)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Calouro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Classificatorias;
        private System.Windows.Forms.TabPage tabPage_Final;
        private System.Windows.Forms.Label label_pontuação;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Fatores;
        private System.Windows.Forms.NumericUpDown numericUpDown_CheckPoint;
        private System.Windows.Forms.Button button_resetar;
        private System.Windows.Forms.Button button_salvar;
        private System.Windows.Forms.Label label_CheckPoint;
        private System.Windows.Forms.Label label_Tempo;
        private System.Windows.Forms.NumericUpDown numericUpDown_Tempo;
        private System.Windows.Forms.Label label_Completar;
        private System.Windows.Forms.NumericUpDown numericUpDown_Completar;
        private System.Windows.Forms.Label label_Relatorio;
        private System.Windows.Forms.NumericUpDown numericUpDown_Relatorio;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_Calouro;
        private System.Windows.Forms.NumericUpDown numericUpDown_Calouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_tabelaEquipes;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEquipe;
        private System.Windows.Forms.DataGridViewTextBoxColumn temCalouro;
        private System.Windows.Forms.DataGridViewTextBoxColumn relatorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontuacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}