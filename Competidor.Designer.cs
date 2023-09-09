namespace Chronos
{
    partial class Competidor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NomeEquipe = new System.Windows.Forms.Label();
            this.InstEquipe = new System.Windows.Forms.Label();
            this.ChecksEquipe = new System.Windows.Forms.Label();
            this.TempoEquipe = new System.Windows.Forms.Label();
            this.Layout = new System.Windows.Forms.TableLayoutPanel();
            this.Colocação = new ZoomableLabel();
            this.Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomeEquipe
            // 
            this.NomeEquipe.AutoSize = true;
            this.NomeEquipe.BackColor = System.Drawing.Color.Transparent;
            this.NomeEquipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NomeEquipe.Font = new System.Drawing.Font("Ebrima", 20F, System.Drawing.FontStyle.Bold);
            this.NomeEquipe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NomeEquipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NomeEquipe.Location = new System.Drawing.Point(66, 0);
            this.NomeEquipe.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.NomeEquipe.Name = "NomeEquipe";
            this.NomeEquipe.Size = new System.Drawing.Size(394, 59);
            this.NomeEquipe.TabIndex = 66;
            this.NomeEquipe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // InstEquipe
            // 
            this.InstEquipe.AutoSize = true;
            this.InstEquipe.BackColor = System.Drawing.Color.Transparent;
            this.InstEquipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InstEquipe.Font = new System.Drawing.Font("Ebrima", 20F, System.Drawing.FontStyle.Bold);
            this.InstEquipe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.InstEquipe.Location = new System.Drawing.Point(466, 0);
            this.InstEquipe.Name = "InstEquipe";
            this.InstEquipe.Size = new System.Drawing.Size(391, 59);
            this.InstEquipe.TabIndex = 67;
            this.InstEquipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChecksEquipe
            // 
            this.ChecksEquipe.AutoSize = true;
            this.ChecksEquipe.BackColor = System.Drawing.Color.Transparent;
            this.ChecksEquipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChecksEquipe.Font = new System.Drawing.Font("Ebrima", 20F, System.Drawing.FontStyle.Bold);
            this.ChecksEquipe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ChecksEquipe.Location = new System.Drawing.Point(863, 0);
            this.ChecksEquipe.Name = "ChecksEquipe";
            this.ChecksEquipe.Size = new System.Drawing.Size(192, 59);
            this.ChecksEquipe.TabIndex = 68;
            this.ChecksEquipe.Text = "0";
            this.ChecksEquipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TempoEquipe
            // 
            this.TempoEquipe.AutoSize = true;
            this.TempoEquipe.BackColor = System.Drawing.Color.Transparent;
            this.TempoEquipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TempoEquipe.Font = new System.Drawing.Font("Ebrima", 20F, System.Drawing.FontStyle.Bold);
            this.TempoEquipe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TempoEquipe.Location = new System.Drawing.Point(1061, 0);
            this.TempoEquipe.Name = "TempoEquipe";
            this.TempoEquipe.Size = new System.Drawing.Size(260, 59);
            this.TempoEquipe.TabIndex = 69;
            this.TempoEquipe.Text = "0:00.000";
            this.TempoEquipe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Layout
            // 
            this.Layout.ColumnCount = 5;
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999767F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.99948F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.99948F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.99931F));
            this.Layout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.00197F));
            this.Layout.Controls.Add(this.TempoEquipe, 4, 0);
            this.Layout.Controls.Add(this.ChecksEquipe, 3, 0);
            this.Layout.Controls.Add(this.InstEquipe, 2, 0);
            this.Layout.Controls.Add(this.NomeEquipe, 1, 0);
            this.Layout.Controls.Add(this.Colocação, 0, 0);
            this.Layout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Layout.Location = new System.Drawing.Point(0, 0);
            this.Layout.Name = "Layout";
            this.Layout.RowCount = 1;
            this.Layout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.Layout.Size = new System.Drawing.Size(1324, 59);
            this.Layout.TabIndex = 0;
            // 
            // Colocação
            // 
            this.Colocação.AutoSize = true;
            this.Colocação.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Colocação.Font = new System.Drawing.Font("Ebrima", 20F, System.Drawing.FontStyle.Bold);
            this.Colocação.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.Colocação.Image = global::Chronos.Properties.Resources.MolduraColocação;
            this.Colocação.Location = new System.Drawing.Point(3, 0);
            this.Colocação.Name = "Colocação";
            this.Colocação.Size = new System.Drawing.Size(60, 59);
            this.Colocação.TabIndex = 70;
            this.Colocação.Text = "1";
            this.Colocação.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Colocação.ZoomEnabled = true;
            // 
            // Competidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Layout);
            this.Name = "Competidor";
            this.Size = new System.Drawing.Size(1324, 59);
            this.SizeChanged += new System.EventHandler(this.Competidor_SizeChanged);
            this.Layout.ResumeLayout(false);
            this.Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NomeEquipe;
        private System.Windows.Forms.Label InstEquipe;
        private System.Windows.Forms.Label ChecksEquipe;
        private System.Windows.Forms.Label TempoEquipe;
        private new System.Windows.Forms.TableLayoutPanel Layout;
        private ZoomableLabel Colocação;
    }
}
