namespace Interface
{
    partial class CriarPlacar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriarPlacar));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.MirimButton = new System.Windows.Forms.RadioButton();
            this.AvançadoButton = new System.Windows.Forms.RadioButton();
            this.labelSeletorBateria = new System.Windows.Forms.Label();
            this.BateriaSelector = new System.Windows.Forms.ComboBox();
            this.categoriaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.ForeColor = System.Drawing.Color.White;
            this.buttonCancelar.Location = new System.Drawing.Point(134, 201);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(124, 55);
            this.buttonCancelar.TabIndex = 87;
            this.buttonCancelar.Text = "Cancel";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelarClick);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(10, 201);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(118, 55);
            this.buttonSalvar.TabIndex = 86;
            this.buttonSalvar.Text = "Criar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvarClick);
            // 
            // MirimButton
            // 
            this.MirimButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.MirimButton.AutoSize = true;
            this.MirimButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MirimButton.ForeColor = System.Drawing.SystemColors.Control;
            this.MirimButton.Location = new System.Drawing.Point(150, 67);
            this.MirimButton.Name = "MirimButton";
            this.MirimButton.Size = new System.Drawing.Size(72, 24);
            this.MirimButton.TabIndex = 85;
            this.MirimButton.Text = "Mirim";
            this.MirimButton.UseVisualStyleBackColor = true;
            this.MirimButton.CheckedChanged += new System.EventHandler(this.MirimButton_CheckedChanged);
            // 
            // AvançadoButton
            // 
            this.AvançadoButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.AvançadoButton.AutoSize = true;
            this.AvançadoButton.Checked = true;
            this.AvançadoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvançadoButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AvançadoButton.Location = new System.Drawing.Point(42, 67);
            this.AvançadoButton.Name = "AvançadoButton";
            this.AvançadoButton.Size = new System.Drawing.Size(103, 24);
            this.AvançadoButton.TabIndex = 84;
            this.AvançadoButton.TabStop = true;
            this.AvançadoButton.Text = "Avançado";
            this.AvançadoButton.UseVisualStyleBackColor = true;
            // 
            // labelSeletorBateria
            // 
            this.labelSeletorBateria.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSeletorBateria.BackColor = System.Drawing.Color.Transparent;
            this.labelSeletorBateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeletorBateria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSeletorBateria.Location = new System.Drawing.Point(87, 105);
            this.labelSeletorBateria.Name = "labelSeletorBateria";
            this.labelSeletorBateria.Size = new System.Drawing.Size(95, 29);
            this.labelSeletorBateria.TabIndex = 82;
            this.labelSeletorBateria.Text = "Bateria:";
            // 
            // BateriaSelector
            // 
            this.BateriaSelector.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BateriaSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.BateriaSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BateriaSelector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BateriaSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BateriaSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BateriaSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BateriaSelector.FormattingEnabled = true;
            this.BateriaSelector.Items.AddRange(new object[] {
            "Arrancada",
            "Bateria 1",
            "Bateria 2",
            "Bateria 3",
            "Repescagem",
            "Final"});
            this.BateriaSelector.Location = new System.Drawing.Point(25, 155);
            this.BateriaSelector.Name = "BateriaSelector";
            this.BateriaSelector.Size = new System.Drawing.Size(211, 28);
            this.BateriaSelector.TabIndex = 81;
            // 
            // categoriaLabel
            // 
            this.categoriaLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.categoriaLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoriaLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.categoriaLabel.Location = new System.Drawing.Point(69, 22);
            this.categoriaLabel.Name = "categoriaLabel";
            this.categoriaLabel.Size = new System.Drawing.Size(127, 29);
            this.categoriaLabel.TabIndex = 88;
            this.categoriaLabel.Text = "Categoria:";
            // 
            // CriarPlacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(267, 268);
            this.Controls.Add(this.categoriaLabel);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.MirimButton);
            this.Controls.Add(this.AvançadoButton);
            this.Controls.Add(this.labelSeletorBateria);
            this.Controls.Add(this.BateriaSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriarPlacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CriarPlacar";
            this.Load += new System.EventHandler(this.CriarPlacar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.RadioButton MirimButton;
        private System.Windows.Forms.RadioButton AvançadoButton;
        private System.Windows.Forms.Label labelSeletorBateria;
        private System.Windows.Forms.ComboBox BateriaSelector;
        private System.Windows.Forms.Label categoriaLabel;
    }
}