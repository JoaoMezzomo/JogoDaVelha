namespace JogoDaVelha
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.btnUmJogador = new System.Windows.Forms.Button();
            this.btnDoisJogadores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxOpcoes = new System.Windows.Forms.GroupBox();
            this.comboSimbolo2 = new System.Windows.Forms.ComboBox();
            this.comboSimbolo1 = new System.Windows.Forms.ComboBox();
            this.btnNovoJogo = new System.Windows.Forms.Button();
            this.txtJogador2Nome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtJogador1Nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUmJogador
            // 
            this.btnUmJogador.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUmJogador.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnUmJogador.FlatAppearance.BorderSize = 3;
            this.btnUmJogador.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnUmJogador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUmJogador.Font = new System.Drawing.Font("Comic Sans MS", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUmJogador.ForeColor = System.Drawing.Color.White;
            this.btnUmJogador.Location = new System.Drawing.Point(130, 105);
            this.btnUmJogador.Name = "btnUmJogador";
            this.btnUmJogador.Size = new System.Drawing.Size(150, 40);
            this.btnUmJogador.TabIndex = 0;
            this.btnUmJogador.TabStop = false;
            this.btnUmJogador.Text = "1P X CPU";
            this.btnUmJogador.UseVisualStyleBackColor = false;
            this.btnUmJogador.Click += new System.EventHandler(this.btnUmJogador_Click);
            // 
            // btnDoisJogadores
            // 
            this.btnDoisJogadores.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDoisJogadores.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnDoisJogadores.FlatAppearance.BorderSize = 3;
            this.btnDoisJogadores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue;
            this.btnDoisJogadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoisJogadores.Font = new System.Drawing.Font("Comic Sans MS", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoisJogadores.ForeColor = System.Drawing.Color.White;
            this.btnDoisJogadores.Location = new System.Drawing.Point(130, 151);
            this.btnDoisJogadores.Name = "btnDoisJogadores";
            this.btnDoisJogadores.Size = new System.Drawing.Size(150, 40);
            this.btnDoisJogadores.TabIndex = 1;
            this.btnDoisJogadores.TabStop = false;
            this.btnDoisJogadores.Text = "1P X 2P";
            this.btnDoisJogadores.UseVisualStyleBackColor = false;
            this.btnDoisJogadores.Click += new System.EventHandler(this.btnDoisJogadores_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Impact", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = "Jogo da Velha";
            // 
            // groupBoxOpcoes
            // 
            this.groupBoxOpcoes.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxOpcoes.Controls.Add(this.comboSimbolo2);
            this.groupBoxOpcoes.Controls.Add(this.comboSimbolo1);
            this.groupBoxOpcoes.Controls.Add(this.btnNovoJogo);
            this.groupBoxOpcoes.Controls.Add(this.txtJogador2Nome);
            this.groupBoxOpcoes.Controls.Add(this.label3);
            this.groupBoxOpcoes.Controls.Add(this.txtJogador1Nome);
            this.groupBoxOpcoes.Controls.Add(this.label2);
            this.groupBoxOpcoes.Enabled = false;
            this.groupBoxOpcoes.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOpcoes.ForeColor = System.Drawing.Color.White;
            this.groupBoxOpcoes.Location = new System.Drawing.Point(13, 203);
            this.groupBoxOpcoes.Name = "groupBoxOpcoes";
            this.groupBoxOpcoes.Size = new System.Drawing.Size(389, 160);
            this.groupBoxOpcoes.TabIndex = 3;
            this.groupBoxOpcoes.TabStop = false;
            this.groupBoxOpcoes.Text = "Opções";
            // 
            // comboSimbolo2
            // 
            this.comboSimbolo2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboSimbolo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSimbolo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSimbolo2.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSimbolo2.FormattingEnabled = true;
            this.comboSimbolo2.Items.AddRange(new object[] {
            "X",
            "O"});
            this.comboSimbolo2.Location = new System.Drawing.Point(331, 73);
            this.comboSimbolo2.Name = "comboSimbolo2";
            this.comboSimbolo2.Size = new System.Drawing.Size(51, 27);
            this.comboSimbolo2.TabIndex = 4;
            this.comboSimbolo2.SelectedIndexChanged += new System.EventHandler(this.comboSimbolo2_SelectedIndexChanged);
            // 
            // comboSimbolo1
            // 
            this.comboSimbolo1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.comboSimbolo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSimbolo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboSimbolo1.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSimbolo1.FormattingEnabled = true;
            this.comboSimbolo1.Items.AddRange(new object[] {
            "X",
            "O"});
            this.comboSimbolo1.Location = new System.Drawing.Point(331, 40);
            this.comboSimbolo1.Name = "comboSimbolo1";
            this.comboSimbolo1.Size = new System.Drawing.Size(51, 27);
            this.comboSimbolo1.TabIndex = 2;
            this.comboSimbolo1.SelectedIndexChanged += new System.EventHandler(this.comboSimbolo1_SelectedIndexChanged);
            // 
            // btnNovoJogo
            // 
            this.btnNovoJogo.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNovoJogo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.btnNovoJogo.FlatAppearance.BorderSize = 3;
            this.btnNovoJogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnNovoJogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovoJogo.Font = new System.Drawing.Font("Comic Sans MS", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoJogo.ForeColor = System.Drawing.Color.White;
            this.btnNovoJogo.Location = new System.Drawing.Point(117, 111);
            this.btnNovoJogo.Name = "btnNovoJogo";
            this.btnNovoJogo.Size = new System.Drawing.Size(150, 40);
            this.btnNovoJogo.TabIndex = 5;
            this.btnNovoJogo.Text = "Novo Jogo";
            this.btnNovoJogo.UseVisualStyleBackColor = false;
            this.btnNovoJogo.Click += new System.EventHandler(this.btnNovoJogo_Click);
            // 
            // txtJogador2Nome
            // 
            this.txtJogador2Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJogador2Nome.Location = new System.Drawing.Point(117, 73);
            this.txtJogador2Nome.MaxLength = 10;
            this.txtJogador2Nome.Name = "txtJogador2Nome";
            this.txtJogador2Nome.Size = new System.Drawing.Size(208, 27);
            this.txtJogador2Nome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "2P - Nome:";
            // 
            // txtJogador1Nome
            // 
            this.txtJogador1Nome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJogador1Nome.Location = new System.Drawing.Point(117, 40);
            this.txtJogador1Nome.MaxLength = 10;
            this.txtJogador1Nome.Name = "txtJogador1Nome";
            this.txtJogador1Nome.Size = new System.Drawing.Size(208, 27);
            this.txtJogador1Nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "1P - Nome:";
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::JogoDaVelha.Properties.Resources.Mesa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 375);
            this.Controls.Add(this.groupBoxOpcoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoisJogadores);
            this.Controls.Add(this.btnUmJogador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Velha";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelaInicial_KeyPress);
            this.groupBoxOpcoes.ResumeLayout(false);
            this.groupBoxOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUmJogador;
        private System.Windows.Forms.Button btnDoisJogadores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxOpcoes;
        private System.Windows.Forms.TextBox txtJogador1Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJogador2Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNovoJogo;
        private System.Windows.Forms.ComboBox comboSimbolo1;
        private System.Windows.Forms.ComboBox comboSimbolo2;
    }
}

