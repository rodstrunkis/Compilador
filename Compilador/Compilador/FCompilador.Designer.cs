namespace Compilador
{
    partial class FCompilador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCompilador));
            this.splitCPrincipal = new System.Windows.Forms.SplitContainer();
            this.toolSBotoes = new System.Windows.Forms.ToolStrip();
            this.buttonProcurar = new System.Windows.Forms.ToolStripButton();
            this.buttonLimpar = new System.Windows.Forms.ToolStripButton();
            this.buttonExecutar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSintatico = new System.Windows.Forms.Label();
            this.labelResultadoSintatico = new System.Windows.Forms.Label();
            this.dataGridTabelaLexico = new System.Windows.Forms.DataGridView();
            this.openFileDialogProcurar = new System.Windows.Forms.OpenFileDialog();
            this.textBCodigo = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitCPrincipal)).BeginInit();
            this.splitCPrincipal.Panel1.SuspendLayout();
            this.splitCPrincipal.Panel2.SuspendLayout();
            this.splitCPrincipal.SuspendLayout();
            this.toolSBotoes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabelaLexico)).BeginInit();
            this.SuspendLayout();
            // 
            // splitCPrincipal
            // 
            this.splitCPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitCPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCPrincipal.IsSplitterFixed = true;
            this.splitCPrincipal.Location = new System.Drawing.Point(0, 0);
            this.splitCPrincipal.Name = "splitCPrincipal";
            // 
            // splitCPrincipal.Panel1
            // 
            this.splitCPrincipal.Panel1.Controls.Add(this.textBCodigo);
            this.splitCPrincipal.Panel1.Controls.Add(this.toolSBotoes);
            // 
            // splitCPrincipal.Panel2
            // 
            this.splitCPrincipal.Panel2.Controls.Add(this.panel1);
            this.splitCPrincipal.Panel2.Controls.Add(this.dataGridTabelaLexico);
            this.splitCPrincipal.Size = new System.Drawing.Size(615, 388);
            this.splitCPrincipal.SplitterDistance = 307;
            this.splitCPrincipal.TabIndex = 0;
            // 
            // toolSBotoes
            // 
            this.toolSBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonProcurar,
            this.buttonLimpar,
            this.buttonExecutar});
            this.toolSBotoes.Location = new System.Drawing.Point(0, 0);
            this.toolSBotoes.Name = "toolSBotoes";
            this.toolSBotoes.Size = new System.Drawing.Size(305, 25);
            this.toolSBotoes.TabIndex = 1;
            this.toolSBotoes.Text = "Botões do compilador.";
            // 
            // buttonProcurar
            // 
            this.buttonProcurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonProcurar.Image = global::Compilador.Properties.Resources.Rafiqul_Hassan_Blogger_Search;
            this.buttonProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonProcurar.Name = "buttonProcurar";
            this.buttonProcurar.Size = new System.Drawing.Size(23, 22);
            this.buttonProcurar.Text = "Procurar arquivo do código.";
            this.buttonProcurar.Click += new System.EventHandler(this.buttonProcurar_Click);
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonLimpar.Image = global::Compilador.Properties.Resources.Icons8_Windows_8_Editing_Delete;
            this.buttonLimpar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(23, 22);
            this.buttonLimpar.Text = "Limpar compilador.";
            // 
            // buttonExecutar
            // 
            this.buttonExecutar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonExecutar.Image = global::Compilador.Properties.Resources.Iconsmind_Outline_Play_Music;
            this.buttonExecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonExecutar.Name = "buttonExecutar";
            this.buttonExecutar.Size = new System.Drawing.Size(23, 22);
            this.buttonExecutar.Text = "Executar compilador.";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelSintatico);
            this.panel1.Controls.Add(this.labelResultadoSintatico);
            this.panel1.Location = new System.Drawing.Point(0, 346);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 41);
            this.panel1.TabIndex = 3;
            // 
            // labelSintatico
            // 
            this.labelSintatico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSintatico.AutoSize = true;
            this.labelSintatico.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelSintatico.Location = new System.Drawing.Point(191, 10);
            this.labelSintatico.Name = "labelSintatico";
            this.labelSintatico.Size = new System.Drawing.Size(78, 17);
            this.labelSintatico.TabIndex = 4;
            this.labelSintatico.Text = "Sucesso!";
            // 
            // labelResultadoSintatico
            // 
            this.labelResultadoSintatico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultadoSintatico.AutoSize = true;
            this.labelResultadoSintatico.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultadoSintatico.Location = new System.Drawing.Point(3, 10);
            this.labelResultadoSintatico.Name = "labelResultadoSintatico";
            this.labelResultadoSintatico.Size = new System.Drawing.Size(182, 17);
            this.labelResultadoSintatico.TabIndex = 3;
            this.labelResultadoSintatico.Text = "Resultado Sintático:";
            // 
            // dataGridTabelaLexico
            // 
            this.dataGridTabelaLexico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridTabelaLexico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTabelaLexico.Location = new System.Drawing.Point(0, 0);
            this.dataGridTabelaLexico.Name = "dataGridTabelaLexico";
            this.dataGridTabelaLexico.Size = new System.Drawing.Size(303, 340);
            this.dataGridTabelaLexico.TabIndex = 0;
            // 
            // openFileDialogProcurar
            // 
            this.openFileDialogProcurar.DefaultExt = "txt";
            this.openFileDialogProcurar.Filter = " txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.openFileDialogProcurar.Title = "Arquivo a ser compilado";
            // 
            // textBCodigo
            // 
            this.textBCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBCodigo.Location = new System.Drawing.Point(0, 25);
            this.textBCodigo.Name = "textBCodigo";
            this.textBCodigo.Size = new System.Drawing.Size(305, 361);
            this.textBCodigo.TabIndex = 2;
            this.textBCodigo.Text = "";
            // 
            // FCompilador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 388);
            this.Controls.Add(this.splitCPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FCompilador";
            this.Text = "Compilador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitCPrincipal.Panel1.ResumeLayout(false);
            this.splitCPrincipal.Panel1.PerformLayout();
            this.splitCPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitCPrincipal)).EndInit();
            this.splitCPrincipal.ResumeLayout(false);
            this.toolSBotoes.ResumeLayout(false);
            this.toolSBotoes.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTabelaLexico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitCPrincipal;
        private System.Windows.Forms.ToolStrip toolSBotoes;
        private System.Windows.Forms.ToolStripButton buttonProcurar;
        private System.Windows.Forms.ToolStripButton buttonLimpar;
        private System.Windows.Forms.ToolStripButton buttonExecutar;
        private System.Windows.Forms.DataGridView dataGridTabelaLexico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSintatico;
        private System.Windows.Forms.Label labelResultadoSintatico;
        private System.Windows.Forms.OpenFileDialog openFileDialogProcurar;
        private System.Windows.Forms.RichTextBox textBCodigo;
    }
}

