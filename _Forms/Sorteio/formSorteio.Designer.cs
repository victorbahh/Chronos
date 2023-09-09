//namespace Interface
//{
//    partial class formSorteio
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSorteio));
//            this.dgv_selecioneEquipes = new System.Windows.Forms.DataGridView();
//            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.nomeEquipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Selecione = new System.Windows.Forms.DataGridViewCheckBoxColumn();
//            this.button_sortear = new System.Windows.Forms.Button();
//            this.dgv_resultadoSorteio = new System.Windows.Forms.DataGridView();
//            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Ordem = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.comboBox1 = new System.Windows.Forms.ComboBox();
//            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecioneEquipes)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultadoSorteio)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dgv_selecioneEquipes
//            // 
//            this.dgv_selecioneEquipes.AllowUserToAddRows = false;
//            this.dgv_selecioneEquipes.AllowUserToDeleteRows = false;
//            this.dgv_selecioneEquipes.AllowUserToResizeColumns = false;
//            this.dgv_selecioneEquipes.AllowUserToResizeRows = false;
//            this.dgv_selecioneEquipes.Anchor = System.Windows.Forms.AnchorStyles.Top;
//            this.dgv_selecioneEquipes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dgv_selecioneEquipes.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
//            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
//            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
//            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
//            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.dgv_selecioneEquipes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
//            this.dgv_selecioneEquipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgv_selecioneEquipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.codigo,
//            this.nomeEquipe,
//            this.Selecione});
//            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
//            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
//            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
//            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.dgv_selecioneEquipes.DefaultCellStyle = dataGridViewCellStyle2;
//            this.dgv_selecioneEquipes.Location = new System.Drawing.Point(-401, 176);
//            this.dgv_selecioneEquipes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.dgv_selecioneEquipes.Name = "dgv_selecioneEquipes";
//            this.dgv_selecioneEquipes.RowHeadersVisible = false;
//            this.dgv_selecioneEquipes.RowHeadersWidth = 51;
//            this.dgv_selecioneEquipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
//            this.dgv_selecioneEquipes.ShowEditingIcon = false;
//            this.dgv_selecioneEquipes.Size = new System.Drawing.Size(237, 229);
//            this.dgv_selecioneEquipes.TabIndex = 18;
//            this.dgv_selecioneEquipes.Visible = false;
//            // 
//            // codigo
//            // 
//            this.codigo.FillWeight = 46.04317F;
//            this.codigo.HeaderText = "Código";
//            this.codigo.MinimumWidth = 6;
//            this.codigo.Name = "codigo";
//            this.codigo.ReadOnly = true;
//            this.codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
//            // 
//            // nomeEquipe
//            // 
//            this.nomeEquipe.FillWeight = 150.396F;
//            this.nomeEquipe.HeaderText = "Nome da equipe";
//            this.nomeEquipe.MinimumWidth = 6;
//            this.nomeEquipe.Name = "nomeEquipe";
//            this.nomeEquipe.ReadOnly = true;
//            this.nomeEquipe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
//            // 
//            // Selecione
//            // 
//            this.Selecione.HeaderText = "Selecione";
//            this.Selecione.MinimumWidth = 6;
//            this.Selecione.Name = "Selecione";
//            this.Selecione.Resizable = System.Windows.Forms.DataGridViewTriState.False;
//            // 
//            // button_sortear
//            // 
//            this.button_sortear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
//            this.button_sortear.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.button_sortear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.button_sortear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.button_sortear.ForeColor = System.Drawing.Color.White;
//            this.button_sortear.Location = new System.Drawing.Point(29, 15);
//            this.button_sortear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.button_sortear.Name = "button_sortear";
//            this.button_sortear.Size = new System.Drawing.Size(243, 37);
//            this.button_sortear.TabIndex = 19;
//            this.button_sortear.Text = "Sortear";
//            this.button_sortear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.button_sortear.UseVisualStyleBackColor = false;
//            this.button_sortear.Click += new System.EventHandler(this.button_sortear_Click);
//            // 
//            // dgv_resultadoSorteio
//            // 
//            this.dgv_resultadoSorteio.AllowUserToAddRows = false;
//            this.dgv_resultadoSorteio.AllowUserToDeleteRows = false;
//            this.dgv_resultadoSorteio.AllowUserToResizeColumns = false;
//            this.dgv_resultadoSorteio.AllowUserToResizeRows = false;
//            this.dgv_resultadoSorteio.Anchor = System.Windows.Forms.AnchorStyles.Left;
//            this.dgv_resultadoSorteio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.dgv_resultadoSorteio.BackgroundColor = System.Drawing.SystemColors.Menu;
//            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
//            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
//            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
//            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.dgv_resultadoSorteio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
//            this.dgv_resultadoSorteio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgv_resultadoSorteio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.dataGridViewTextBoxColumn2,
//            this.Ordem});
//            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
//            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
//            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
//            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
//            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.dgv_resultadoSorteio.DefaultCellStyle = dataGridViewCellStyle5;
//            this.dgv_resultadoSorteio.GridColor = System.Drawing.SystemColors.ActiveBorder;
//            this.dgv_resultadoSorteio.Location = new System.Drawing.Point(29, 59);
//            this.dgv_resultadoSorteio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.dgv_resultadoSorteio.Name = "dgv_resultadoSorteio";
//            this.dgv_resultadoSorteio.RowHeadersVisible = false;
//            this.dgv_resultadoSorteio.RowHeadersWidth = 51;
//            this.dgv_resultadoSorteio.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.dgv_resultadoSorteio.RowTemplate.Height = 30;
//            this.dgv_resultadoSorteio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
//            this.dgv_resultadoSorteio.ShowEditingIcon = false;
//            this.dgv_resultadoSorteio.Size = new System.Drawing.Size(499, 892);
//            this.dgv_resultadoSorteio.TabIndex = 22;
//            // 
//            // dataGridViewTextBoxColumn2
//            // 
//            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
//            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
//            this.dataGridViewTextBoxColumn2.FillWeight = 186.8437F;
//            this.dataGridViewTextBoxColumn2.HeaderText = "Nome da equipe";
//            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
//            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
//            this.dataGridViewTextBoxColumn2.ReadOnly = true;
//            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
//            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
//            // 
//            // Ordem
//            // 
//            this.Ordem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
//            this.Ordem.FillWeight = 63.55228F;
//            this.Ordem.HeaderText = "Ordem";
//            this.Ordem.MinimumWidth = 6;
//            this.Ordem.Name = "Ordem";
//            this.Ordem.ReadOnly = true;
//            this.Ordem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
//            // 
//            // comboBox1
//            // 
//            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.comboBox1.FormattingEnabled = true;
//            this.comboBox1.Items.AddRange(new object[] {
//            "Bateria 1",
//            "Bateria 2",
//            "Bateria 3",
//            "Repescagem",
//            "Final",
//            "Arrancada"});
//            this.comboBox1.Location = new System.Drawing.Point(280, 15);
//            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.comboBox1.Name = "comboBox1";
//            this.comboBox1.Size = new System.Drawing.Size(247, 37);
//            this.comboBox1.TabIndex = 23;
//            // 
//            // formSorteio
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
//            this.ClientSize = new System.Drawing.Size(544, 977);
//            this.Controls.Add(this.comboBox1);
//            this.Controls.Add(this.dgv_resultadoSorteio);
//            this.Controls.Add(this.button_sortear);
//            this.Controls.Add(this.dgv_selecioneEquipes);
//            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
//            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
//            this.Name = "formSorteio";
//            this.Text = "Sorteio";
//            ((System.ComponentModel.ISupportInitialize)(this.dgv_selecioneEquipes)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultadoSorteio)).EndInit();
//            this.ResumeLayout(false);

//        }

//        #endregion
//        private System.Windows.Forms.DataGridView dgv_selecioneEquipes;
//        private System.Windows.Forms.Button button_sortear;
//        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
//        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEquipe;
//        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecione;
//        private System.Windows.Forms.DataGridView dgv_resultadoSorteio;
//        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
//        private System.Windows.Forms.DataGridViewTextBoxColumn Ordem;
//        private System.Windows.Forms.ComboBox comboBox1;
//    }
//}