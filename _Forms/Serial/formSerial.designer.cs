
namespace Interface
{
    partial class FormSerial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerial));
            this.button_conectar = new System.Windows.Forms.Button();
            this.ComSelector = new System.Windows.Forms.ComboBox();
            this.textBox_receber = new System.Windows.Forms.TextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerCronometro = new System.Windows.Forms.Timer(this.components);
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelLargada = new System.Windows.Forms.Label();
            this.labelCheck1 = new System.Windows.Forms.Label();
            this.labelCheck2 = new System.Windows.Forms.Label();
            this.labelCheck3 = new System.Windows.Forms.Label();
            this.labelCheck4 = new System.Windows.Forms.Label();
            this.labelCheck5 = new System.Windows.Forms.Label();
            this.labelCheck6 = new System.Windows.Forms.Label();
            this.labelCheck7 = new System.Windows.Forms.Label();
            this.labelCheck8 = new System.Windows.Forms.Label();
            this.labelChegada = new System.Windows.Forms.Label();
            this.buttonLargada = new System.Windows.Forms.Button();
            this.buttonCheck1 = new System.Windows.Forms.Button();
            this.buttonCheck2 = new System.Windows.Forms.Button();
            this.buttonCheck3 = new System.Windows.Forms.Button();
            this.buttonCheck4 = new System.Windows.Forms.Button();
            this.buttonCheck5 = new System.Windows.Forms.Button();
            this.buttonCheck6 = new System.Windows.Forms.Button();
            this.buttonCheck7 = new System.Windows.Forms.Button();
            this.buttonCheck8 = new System.Windows.Forms.Button();
            this.buttonChegada = new System.Windows.Forms.Button();
            this.EquipeSelector = new System.Windows.Forms.ComboBox();
            this.TentativaSelector = new System.Windows.Forms.ComboBox();
            this.labelSeletorEquipe = new System.Windows.Forms.Label();
            this.labelSeletorTentativa = new System.Windows.Forms.Label();
            this.LabelEquipe = new System.Windows.Forms.Label();
            this.labelTentativa = new System.Windows.Forms.Label();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonEncerrar = new System.Windows.Forms.Button();
            this.TitleExibir = new System.Windows.Forms.TextBox();
            this.TitleExbirLabel = new System.Windows.Forms.Label();
            this.ShowExibirTitle = new System.Windows.Forms.Button();
            this.SelectEquipeButton = new System.Windows.Forms.Button();
            this.buttonCarregarPlacar = new System.Windows.Forms.Button();
            this.buttonCriarPlacar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_conectar
            // 
            this.button_conectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_conectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.button_conectar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_conectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_conectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_conectar.ForeColor = System.Drawing.Color.White;
            this.button_conectar.Location = new System.Drawing.Point(984, 22);
            this.button_conectar.Name = "button_conectar";
            this.button_conectar.Size = new System.Drawing.Size(154, 32);
            this.button_conectar.TabIndex = 21;
            this.button_conectar.Text = "Conectar";
            this.button_conectar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_conectar.UseVisualStyleBackColor = false;
            this.button_conectar.Click += new System.EventHandler(this.Button_conectar_Click);
            // 
            // ComSelector
            // 
            this.ComSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComSelector.FormattingEnabled = true;
            this.ComSelector.Location = new System.Drawing.Point(984, 63);
            this.ComSelector.Name = "ComSelector";
            this.ComSelector.Size = new System.Drawing.Size(154, 24);
            this.ComSelector.TabIndex = 22;
            this.ComSelector.Click += new System.EventHandler(this.ComSelector_Click);
            // 
            // textBox_receber
            // 
            this.textBox_receber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBox_receber.BackColor = System.Drawing.Color.LightGray;
            this.textBox_receber.Location = new System.Drawing.Point(952, 97);
            this.textBox_receber.Multiline = true;
            this.textBox_receber.Name = "textBox_receber";
            this.textBox_receber.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_receber.Size = new System.Drawing.Size(210, 124);
            this.textBox_receber.TabIndex = 25;
            this.textBox_receber.Click += new System.EventHandler(this.textBox_receber_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialDataReceived);
            // 
            // timerCronometro
            // 
            this.timerCronometro.Enabled = true;
            this.timerCronometro.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(954, 693);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(216, 35);
            this.buttonReset.TabIndex = 29;
            this.buttonReset.Text = "Resetar";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.Reset);
            // 
            // labelTimer
            // 
            this.labelTimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 120F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.White;
            this.labelTimer.Location = new System.Drawing.Point(4, 144);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(891, 227);
            this.labelTimer.TabIndex = 26;
            this.labelTimer.Text = "0:00:000";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLargada
            // 
            this.labelLargada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelLargada.AutoSize = true;
            this.labelLargada.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLargada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelLargada.Location = new System.Drawing.Point(37, 361);
            this.labelLargada.Name = "labelLargada";
            this.labelLargada.Size = new System.Drawing.Size(442, 52);
            this.labelLargada.TabIndex = 30;
            this.labelLargada.Text = "Largada: -:--.----:--.--";
            // 
            // labelCheck1
            // 
            this.labelCheck1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCheck1.AutoSize = true;
            this.labelCheck1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelCheck1.Location = new System.Drawing.Point(37, 435);
            this.labelCheck1.Name = "labelCheck1";
            this.labelCheck1.Size = new System.Drawing.Size(436, 52);
            this.labelCheck1.TabIndex = 31;
            this.labelCheck1.Text = "Checkpoint 1: -:--.---";
            this.labelCheck1.TextChanged += new System.EventHandler(this.Checkpoint_TextChanged);
            // 
            // labelCheck2
            // 
            this.labelCheck2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCheck2.AutoSize = true;
            this.labelCheck2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelCheck2.Location = new System.Drawing.Point(37, 514);
            this.labelCheck2.Name = "labelCheck2";
            this.labelCheck2.Size = new System.Drawing.Size(436, 52);
            this.labelCheck2.TabIndex = 32;
            this.labelCheck2.Text = "Checkpoint 2: -:--.---";
            this.labelCheck2.TextChanged += new System.EventHandler(this.Checkpoint_TextChanged);
            // 
            // labelCheck3
            // 
            this.labelCheck3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCheck3.AutoSize = true;
            this.labelCheck3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelCheck3.Location = new System.Drawing.Point(37, 593);
            this.labelCheck3.Name = "labelCheck3";
            this.labelCheck3.Size = new System.Drawing.Size(436, 52);
            this.labelCheck3.TabIndex = 33;
            this.labelCheck3.Text = "Checkpoint 3: -:--.---";
            this.labelCheck3.TextChanged += new System.EventHandler(this.Checkpoint_TextChanged);
            // 
            // labelCheck4
            // 
            this.labelCheck4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCheck4.AutoSize = true;
            this.labelCheck4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelCheck4.Location = new System.Drawing.Point(37, 673);
            this.labelCheck4.Name = "labelCheck4";
            this.labelCheck4.Size = new System.Drawing.Size(436, 52);
            this.labelCheck4.TabIndex = 34;
            this.labelCheck4.Text = "Checkpoint 4: -:--.---";
            this.labelCheck4.TextChanged += new System.EventHandler(this.Checkpoint_TextChanged);
            // 
            // labelCheck5
            // 
            this.labelCheck5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCheck5.AutoSize = true;
            this.labelCheck5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelCheck5.Location = new System.Drawing.Point(503, 361);
            this.labelCheck5.Name = "labelCheck5";
            this.labelCheck5.Size = new System.Drawing.Size(436, 52);
            this.labelCheck5.TabIndex = 35;
            this.labelCheck5.Text = "Checkpoint 5: -:--.---";
            this.labelCheck5.TextChanged += new System.EventHandler(this.Checkpoint_TextChanged);
            // 
            // labelCheck6
            // 
            this.labelCheck6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCheck6.AutoSize = true;
            this.labelCheck6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelCheck6.Location = new System.Drawing.Point(503, 435);
            this.labelCheck6.Name = "labelCheck6";
            this.labelCheck6.Size = new System.Drawing.Size(436, 52);
            this.labelCheck6.TabIndex = 36;
            this.labelCheck6.Text = "Checkpoint 6: -:--.---";
            this.labelCheck6.TextChanged += new System.EventHandler(this.Checkpoint_TextChanged);
            // 
            // labelCheck7
            // 
            this.labelCheck7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCheck7.AutoSize = true;
            this.labelCheck7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelCheck7.Location = new System.Drawing.Point(503, 514);
            this.labelCheck7.Name = "labelCheck7";
            this.labelCheck7.Size = new System.Drawing.Size(436, 52);
            this.labelCheck7.TabIndex = 37;
            this.labelCheck7.Text = "Checkpoint 7: -:--.---";
            this.labelCheck7.TextChanged += new System.EventHandler(this.Checkpoint_TextChanged);
            // 
            // labelCheck8
            // 
            this.labelCheck8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelCheck8.AutoSize = true;
            this.labelCheck8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelCheck8.Location = new System.Drawing.Point(503, 593);
            this.labelCheck8.Name = "labelCheck8";
            this.labelCheck8.Size = new System.Drawing.Size(436, 52);
            this.labelCheck8.TabIndex = 38;
            this.labelCheck8.Text = "Checkpoint 8: -:--.---";
            this.labelCheck8.TextChanged += new System.EventHandler(this.Checkpoint_TextChanged);
            // 
            // labelChegada
            // 
            this.labelChegada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelChegada.AutoSize = true;
            this.labelChegada.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChegada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.labelChegada.Location = new System.Drawing.Point(503, 673);
            this.labelChegada.Name = "labelChegada";
            this.labelChegada.Size = new System.Drawing.Size(443, 52);
            this.labelChegada.TabIndex = 39;
            this.labelChegada.Text = "Chegada: -:--.----:--.-";
            this.labelChegada.TextChanged += new System.EventHandler(this.Checkpoint_TextChanged);
            // 
            // buttonLargada
            // 
            this.buttonLargada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLargada.BackColor = System.Drawing.Color.Transparent;
            this.buttonLargada.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLargada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLargada.Location = new System.Drawing.Point(18, 372);
            this.buttonLargada.Name = "buttonLargada";
            this.buttonLargada.Size = new System.Drawing.Size(27, 31);
            this.buttonLargada.TabIndex = 42;
            this.buttonLargada.Text = "0";
            this.buttonLargada.UseVisualStyleBackColor = false;
            this.buttonLargada.Click += new System.EventHandler(this.CheckControl);
            // 
            // buttonCheck1
            // 
            this.buttonCheck1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheck1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheck1.Location = new System.Drawing.Point(16, 445);
            this.buttonCheck1.Name = "buttonCheck1";
            this.buttonCheck1.Size = new System.Drawing.Size(27, 29);
            this.buttonCheck1.TabIndex = 43;
            this.buttonCheck1.Text = "1";
            this.buttonCheck1.UseVisualStyleBackColor = true;
            this.buttonCheck1.Click += new System.EventHandler(this.CheckControl);
            // 
            // buttonCheck2
            // 
            this.buttonCheck2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheck2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheck2.Location = new System.Drawing.Point(16, 525);
            this.buttonCheck2.Name = "buttonCheck2";
            this.buttonCheck2.Size = new System.Drawing.Size(27, 29);
            this.buttonCheck2.TabIndex = 44;
            this.buttonCheck2.Text = "2";
            this.buttonCheck2.UseVisualStyleBackColor = true;
            this.buttonCheck2.Click += new System.EventHandler(this.CheckControl);
            // 
            // buttonCheck3
            // 
            this.buttonCheck3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheck3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheck3.Location = new System.Drawing.Point(16, 605);
            this.buttonCheck3.Name = "buttonCheck3";
            this.buttonCheck3.Size = new System.Drawing.Size(27, 29);
            this.buttonCheck3.TabIndex = 45;
            this.buttonCheck3.Text = "3";
            this.buttonCheck3.UseVisualStyleBackColor = true;
            this.buttonCheck3.Click += new System.EventHandler(this.CheckControl);
            // 
            // buttonCheck4
            // 
            this.buttonCheck4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheck4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheck4.Location = new System.Drawing.Point(16, 686);
            this.buttonCheck4.Name = "buttonCheck4";
            this.buttonCheck4.Size = new System.Drawing.Size(27, 29);
            this.buttonCheck4.TabIndex = 46;
            this.buttonCheck4.Text = "4";
            this.buttonCheck4.UseVisualStyleBackColor = true;
            this.buttonCheck4.Click += new System.EventHandler(this.CheckControl);
            // 
            // buttonCheck5
            // 
            this.buttonCheck5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheck5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheck5.Location = new System.Drawing.Point(481, 372);
            this.buttonCheck5.Name = "buttonCheck5";
            this.buttonCheck5.Size = new System.Drawing.Size(27, 29);
            this.buttonCheck5.TabIndex = 47;
            this.buttonCheck5.Text = "5";
            this.buttonCheck5.UseVisualStyleBackColor = true;
            this.buttonCheck5.Click += new System.EventHandler(this.CheckControl);
            // 
            // buttonCheck6
            // 
            this.buttonCheck6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheck6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheck6.Location = new System.Drawing.Point(483, 448);
            this.buttonCheck6.Name = "buttonCheck6";
            this.buttonCheck6.Size = new System.Drawing.Size(27, 29);
            this.buttonCheck6.TabIndex = 48;
            this.buttonCheck6.Text = "6";
            this.buttonCheck6.UseVisualStyleBackColor = true;
            this.buttonCheck6.Click += new System.EventHandler(this.CheckControl);
            // 
            // buttonCheck7
            // 
            this.buttonCheck7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheck7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheck7.Location = new System.Drawing.Point(482, 527);
            this.buttonCheck7.Name = "buttonCheck7";
            this.buttonCheck7.Size = new System.Drawing.Size(27, 29);
            this.buttonCheck7.TabIndex = 49;
            this.buttonCheck7.Text = "7";
            this.buttonCheck7.UseVisualStyleBackColor = true;
            this.buttonCheck7.Click += new System.EventHandler(this.CheckControl);
            // 
            // buttonCheck8
            // 
            this.buttonCheck8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonCheck8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonCheck8.Location = new System.Drawing.Point(483, 606);
            this.buttonCheck8.Name = "buttonCheck8";
            this.buttonCheck8.Size = new System.Drawing.Size(27, 29);
            this.buttonCheck8.TabIndex = 50;
            this.buttonCheck8.Text = "8";
            this.buttonCheck8.UseVisualStyleBackColor = true;
            this.buttonCheck8.Click += new System.EventHandler(this.CheckControl);
            // 
            // buttonChegada
            // 
            this.buttonChegada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonChegada.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonChegada.Location = new System.Drawing.Point(483, 686);
            this.buttonChegada.Name = "buttonChegada";
            this.buttonChegada.Size = new System.Drawing.Size(27, 29);
            this.buttonChegada.TabIndex = 51;
            this.buttonChegada.Text = "9";
            this.buttonChegada.UseVisualStyleBackColor = true;
            this.buttonChegada.Click += new System.EventHandler(this.CheckControl);
            // 
            // EquipeSelector
            // 
            this.EquipeSelector.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EquipeSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.EquipeSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EquipeSelector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EquipeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EquipeSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EquipeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EquipeSelector.FormattingEnabled = true;
            this.EquipeSelector.Location = new System.Drawing.Point(954, 307);
            this.EquipeSelector.MaxDropDownItems = 30;
            this.EquipeSelector.Name = "EquipeSelector";
            this.EquipeSelector.Size = new System.Drawing.Size(211, 28);
            this.EquipeSelector.TabIndex = 52;
            // 
            // TentativaSelector
            // 
            this.TentativaSelector.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TentativaSelector.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TentativaSelector.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TentativaSelector.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TentativaSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TentativaSelector.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TentativaSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TentativaSelector.FormattingEnabled = true;
            this.TentativaSelector.Items.AddRange(new object[] {
            "Tentativa 1",
            "Tentativa 2"});
            this.TentativaSelector.Location = new System.Drawing.Point(952, 368);
            this.TentativaSelector.Name = "TentativaSelector";
            this.TentativaSelector.Size = new System.Drawing.Size(175, 28);
            this.TentativaSelector.TabIndex = 54;
            // 
            // labelSeletorEquipe
            // 
            this.labelSeletorEquipe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSeletorEquipe.BackColor = System.Drawing.Color.Transparent;
            this.labelSeletorEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeletorEquipe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSeletorEquipe.Location = new System.Drawing.Point(1004, 272);
            this.labelSeletorEquipe.Name = "labelSeletorEquipe";
            this.labelSeletorEquipe.Size = new System.Drawing.Size(96, 29);
            this.labelSeletorEquipe.TabIndex = 56;
            this.labelSeletorEquipe.Text = "Equipe:";
            // 
            // labelSeletorTentativa
            // 
            this.labelSeletorTentativa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSeletorTentativa.BackColor = System.Drawing.Color.Transparent;
            this.labelSeletorTentativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeletorTentativa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSeletorTentativa.Location = new System.Drawing.Point(1002, 336);
            this.labelSeletorTentativa.Name = "labelSeletorTentativa";
            this.labelSeletorTentativa.Size = new System.Drawing.Size(117, 29);
            this.labelSeletorTentativa.TabIndex = 58;
            this.labelSeletorTentativa.Text = "Tentativa:";
            // 
            // LabelEquipe
            // 
            this.LabelEquipe.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LabelEquipe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelEquipe.BackColor = System.Drawing.Color.Transparent;
            this.LabelEquipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEquipe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LabelEquipe.Location = new System.Drawing.Point(53, 4);
            this.LabelEquipe.Name = "LabelEquipe";
            this.LabelEquipe.Size = new System.Drawing.Size(747, 114);
            this.LabelEquipe.TabIndex = 59;
            this.LabelEquipe.Text = "Equipe";
            this.LabelEquipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTentativa
            // 
            this.labelTentativa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTentativa.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTentativa.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTentativa.Location = new System.Drawing.Point(272, 118);
            this.labelTentativa.Name = "labelTentativa";
            this.labelTentativa.Size = new System.Drawing.Size(304, 56);
            this.labelTentativa.TabIndex = 64;
            this.labelTentativa.Text = "Tentativa x";
            this.labelTentativa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(172)))), ((int)(((byte)(206)))));
            this.buttonSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.ForeColor = System.Drawing.Color.White;
            this.buttonSalvar.Location = new System.Drawing.Point(954, 648);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(105, 40);
            this.buttonSalvar.TabIndex = 66;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = false;
            this.buttonSalvar.Click += new System.EventHandler(this.ButtonSalvarClick);
            // 
            // buttonEncerrar
            // 
            this.buttonEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEncerrar.BackColor = System.Drawing.Color.Firebrick;
            this.buttonEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEncerrar.ForeColor = System.Drawing.Color.White;
            this.buttonEncerrar.Location = new System.Drawing.Point(1065, 648);
            this.buttonEncerrar.Name = "buttonEncerrar";
            this.buttonEncerrar.Size = new System.Drawing.Size(105, 40);
            this.buttonEncerrar.TabIndex = 67;
            this.buttonEncerrar.Text = "Parar";
            this.buttonEncerrar.UseVisualStyleBackColor = false;
            this.buttonEncerrar.Click += new System.EventHandler(this.ButtonEncerrar_Click);
            // 
            // TitleExibir
            // 
            this.TitleExibir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TitleExibir.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.TitleExibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleExibir.Location = new System.Drawing.Point(954, 596);
            this.TitleExibir.Name = "TitleExibir";
            this.TitleExibir.Size = new System.Drawing.Size(175, 23);
            this.TitleExibir.TabIndex = 68;
            this.TitleExibir.Text = "CoRA 10ª Edição - Dia 1 - Bateria 1";
            this.TitleExibir.Visible = false;
            // 
            // TitleExbirLabel
            // 
            this.TitleExbirLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TitleExbirLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleExbirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleExbirLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleExbirLabel.Location = new System.Drawing.Point(960, 564);
            this.TitleExbirLabel.Name = "TitleExbirLabel";
            this.TitleExbirLabel.Size = new System.Drawing.Size(210, 29);
            this.TitleExbirLabel.TabIndex = 70;
            this.TitleExbirLabel.Text = "Título de exibição:";
            this.TitleExbirLabel.Visible = false;
            // 
            // ShowExibirTitle
            // 
            this.ShowExibirTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ShowExibirTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowExibirTitle.BackgroundImage")));
            this.ShowExibirTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowExibirTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowExibirTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowExibirTitle.Location = new System.Drawing.Point(1135, 595);
            this.ShowExibirTitle.Name = "ShowExibirTitle";
            this.ShowExibirTitle.Size = new System.Drawing.Size(30, 25);
            this.ShowExibirTitle.TabIndex = 69;
            this.ShowExibirTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ShowExibirTitle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ShowExibirTitle.UseVisualStyleBackColor = true;
            this.ShowExibirTitle.Visible = false;
            this.ShowExibirTitle.Click += new System.EventHandler(this.ShowExibirTitle_Click);
            // 
            // SelectEquipeButton
            // 
            this.SelectEquipeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SelectEquipeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SelectEquipeButton.BackgroundImage")));
            this.SelectEquipeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelectEquipeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectEquipeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectEquipeButton.Location = new System.Drawing.Point(1138, 369);
            this.SelectEquipeButton.Name = "SelectEquipeButton";
            this.SelectEquipeButton.Size = new System.Drawing.Size(30, 28);
            this.SelectEquipeButton.TabIndex = 65;
            this.SelectEquipeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SelectEquipeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.SelectEquipeButton.UseVisualStyleBackColor = true;
            this.SelectEquipeButton.Click += new System.EventHandler(this.SelectEquipeButton_Click);
            // 
            // buttonCarregarPlacar
            // 
            this.buttonCarregarPlacar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCarregarPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCarregarPlacar.Location = new System.Drawing.Point(952, 413);
            this.buttonCarregarPlacar.Name = "buttonCarregarPlacar";
            this.buttonCarregarPlacar.Size = new System.Drawing.Size(218, 35);
            this.buttonCarregarPlacar.TabIndex = 77;
            this.buttonCarregarPlacar.Text = "Carregar Placar";
            this.buttonCarregarPlacar.UseVisualStyleBackColor = true;
            this.buttonCarregarPlacar.Click += new System.EventHandler(this.buttonCarregarPlacarClick);
            // 
            // buttonCriarPlacar
            // 
            this.buttonCriarPlacar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonCriarPlacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCriarPlacar.Location = new System.Drawing.Point(954, 463);
            this.buttonCriarPlacar.Name = "buttonCriarPlacar";
            this.buttonCriarPlacar.Size = new System.Drawing.Size(218, 35);
            this.buttonCriarPlacar.TabIndex = 78;
            this.buttonCriarPlacar.Text = "Criar Placar";
            this.buttonCriarPlacar.UseVisualStyleBackColor = true;
            this.buttonCriarPlacar.Click += new System.EventHandler(this.buttonCriarPlacarClick);
            // 
            // FormSerial
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(36)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1182, 743);
            this.Controls.Add(this.buttonCriarPlacar);
            this.Controls.Add(this.buttonCarregarPlacar);
            this.Controls.Add(this.ShowExibirTitle);
            this.Controls.Add(this.TitleExibir);
            this.Controls.Add(this.buttonEncerrar);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.SelectEquipeButton);
            this.Controls.Add(this.labelTentativa);
            this.Controls.Add(this.LabelEquipe);
            this.Controls.Add(this.labelSeletorTentativa);
            this.Controls.Add(this.labelSeletorEquipe);
            this.Controls.Add(this.TentativaSelector);
            this.Controls.Add(this.EquipeSelector);
            this.Controls.Add(this.buttonChegada);
            this.Controls.Add(this.buttonCheck8);
            this.Controls.Add(this.buttonCheck7);
            this.Controls.Add(this.buttonCheck6);
            this.Controls.Add(this.buttonCheck5);
            this.Controls.Add(this.buttonCheck4);
            this.Controls.Add(this.buttonCheck3);
            this.Controls.Add(this.buttonCheck2);
            this.Controls.Add(this.buttonCheck1);
            this.Controls.Add(this.buttonLargada);
            this.Controls.Add(this.labelChegada);
            this.Controls.Add(this.labelCheck8);
            this.Controls.Add(this.labelCheck7);
            this.Controls.Add(this.labelCheck6);
            this.Controls.Add(this.labelCheck5);
            this.Controls.Add(this.labelCheck4);
            this.Controls.Add(this.labelCheck3);
            this.Controls.Add(this.labelCheck2);
            this.Controls.Add(this.labelCheck1);
            this.Controls.Add(this.labelLargada);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.textBox_receber);
            this.Controls.Add(this.ComSelector);
            this.Controls.Add(this.button_conectar);
            this.Controls.Add(this.TitleExbirLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 790);
            this.Name = "FormSerial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Monitor Serial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSerial_FormClosed);
            this.Load += new System.EventHandler(this.FormSerial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_conectar;
        private System.Windows.Forms.ComboBox ComSelector;
        private System.Windows.Forms.TextBox textBox_receber;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerCronometro;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelLargada;
        private System.Windows.Forms.Label labelCheck1;
        private System.Windows.Forms.Label labelCheck2;
        private System.Windows.Forms.Label labelCheck3;
        private System.Windows.Forms.Label labelCheck4;
        private System.Windows.Forms.Label labelCheck5;
        private System.Windows.Forms.Label labelCheck6;
        private System.Windows.Forms.Label labelCheck7;
        private System.Windows.Forms.Label labelCheck8;
        private System.Windows.Forms.Label labelChegada;
        private System.Windows.Forms.Button buttonLargada;
        private System.Windows.Forms.Button buttonCheck1;
        private System.Windows.Forms.Button buttonCheck2;
        private System.Windows.Forms.Button buttonCheck3;
        private System.Windows.Forms.Button buttonCheck4;
        private System.Windows.Forms.Button buttonCheck5;
        private System.Windows.Forms.Button buttonCheck6;
        private System.Windows.Forms.Button buttonCheck7;
        private System.Windows.Forms.Button buttonCheck8;
        private System.Windows.Forms.Button buttonChegada;
        private System.Windows.Forms.ComboBox EquipeSelector;
        private System.Windows.Forms.ComboBox TentativaSelector;
        private System.Windows.Forms.Label labelSeletorEquipe;
        private System.Windows.Forms.Label labelSeletorTentativa;
        private System.Windows.Forms.Label LabelEquipe;
        private System.Windows.Forms.Label labelTentativa;
        private System.Windows.Forms.Button SelectEquipeButton;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonEncerrar;
        private System.Windows.Forms.TextBox TitleExibir;
        private System.Windows.Forms.Button ShowExibirTitle;
        private System.Windows.Forms.Label TitleExbirLabel;
        private System.Windows.Forms.Button buttonCarregarPlacar;
        private System.Windows.Forms.Button buttonCriarPlacar;
    }
}