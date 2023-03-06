namespace Calculadora
{
    partial class Calculadora
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
            this.tbxNumEsquerda = new System.Windows.Forms.TextBox();
            this.tbxNumDireita = new System.Windows.Forms.TextBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxNumEsquerda
            // 
            this.tbxNumEsquerda.Location = new System.Drawing.Point(109, 33);
            this.tbxNumEsquerda.Name = "tbxNumEsquerda";
            this.tbxNumEsquerda.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxNumEsquerda.Size = new System.Drawing.Size(100, 20);
            this.tbxNumEsquerda.TabIndex = 0;
            this.tbxNumEsquerda.Text = "0";
            this.tbxNumEsquerda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumEsquerda_KeyPress);
            // 
            // tbxNumDireita
            // 
            this.tbxNumDireita.Location = new System.Drawing.Point(277, 34);
            this.tbxNumDireita.Name = "tbxNumDireita";
            this.tbxNumDireita.Size = new System.Drawing.Size(100, 20);
            this.tbxNumDireita.TabIndex = 1;
            this.tbxNumDireita.Text = "0";
            this.tbxNumDireita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNumDireita_KeyPress);
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.Location = new System.Drawing.Point(236, 40);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(13, 13);
            this.lblOperacao.TabIndex = 2;
            this.lblOperacao.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(458, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(499, 41);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(50, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "resultado";
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(109, 106);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(100, 23);
            this.btnAdicao.TabIndex = 5;
            this.btnAdicao.Text = "Adição";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(277, 106);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(100, 23);
            this.btnSubtracao.TabIndex = 6;
            this.btnSubtracao.Text = "Subtração";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(277, 160);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(100, 23);
            this.btnMultiplicacao.TabIndex = 7;
            this.btnMultiplicacao.Text = "Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(109, 160);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(100, 23);
            this.btnDivisao.TabIndex = 8;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(109, 212);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(100, 23);
            this.btnIgual.TabIndex = 9;
            this.btnIgual.Text = "Igual";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(277, 212);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 23);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperacao);
            this.Controls.Add(this.tbxNumDireita);
            this.Controls.Add(this.tbxNumEsquerda);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNumEsquerda;
        private System.Windows.Forms.TextBox tbxNumDireita;
        private System.Windows.Forms.Label lblOperacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpar;
    }
}

