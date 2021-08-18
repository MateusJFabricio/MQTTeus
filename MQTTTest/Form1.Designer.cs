
namespace Test
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtEnderecoConexao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gp1 = new System.Windows.Forms.GroupBox();
            this.btnDesinscrever = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbEnderecosDesinscrever = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIncrever = new System.Windows.Forms.Button();
            this.txtEnderecoSubscribe = new System.Windows.Forms.TextBox();
            this.gp2 = new System.Windows.Forms.GroupBox();
            this.cbEnderecoEnvio = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMensagemEnvio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.gp3 = new System.Windows.Forms.GroupBox();
            this.btnLimparRecebido = new System.Windows.Forms.Button();
            this.rtbRecebimento = new System.Windows.Forms.RichTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.gp1.SuspendLayout();
            this.gp2.SuspendLayout();
            this.gp3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(235, 25);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(80, 22);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtEnderecoConexao
            // 
            this.txtEnderecoConexao.Location = new System.Drawing.Point(80, 26);
            this.txtEnderecoConexao.Name = "txtEnderecoConexao";
            this.txtEnderecoConexao.Size = new System.Drawing.Size(149, 20);
            this.txtEnderecoConexao.TabIndex = 3;
            this.txtEnderecoConexao.Text = "127.0.0.1";
            this.txtEnderecoConexao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnderecoConexao_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Endereco:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDesconectar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Controls.Add(this.txtEnderecoConexao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexao";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Enabled = false;
            this.btnDesconectar.Location = new System.Drawing.Point(235, 55);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(80, 22);
            this.btnDesconectar.TabIndex = 5;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Red;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(0, 491);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(359, 26);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Desconectado";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gp1
            // 
            this.gp1.Controls.Add(this.btnDesinscrever);
            this.gp1.Controls.Add(this.label4);
            this.gp1.Controls.Add(this.cbEnderecosDesinscrever);
            this.gp1.Controls.Add(this.label3);
            this.gp1.Controls.Add(this.btnIncrever);
            this.gp1.Controls.Add(this.txtEnderecoSubscribe);
            this.gp1.Enabled = false;
            this.gp1.Location = new System.Drawing.Point(12, 101);
            this.gp1.Name = "gp1";
            this.gp1.Size = new System.Drawing.Size(331, 95);
            this.gp1.TabIndex = 7;
            this.gp1.TabStop = false;
            this.gp1.Text = "Subscribe\\Unscribe";
            // 
            // btnDesinscrever
            // 
            this.btnDesinscrever.Location = new System.Drawing.Point(235, 60);
            this.btnDesinscrever.Name = "btnDesinscrever";
            this.btnDesinscrever.Size = new System.Drawing.Size(80, 22);
            this.btnDesinscrever.TabIndex = 10;
            this.btnDesinscrever.Text = "Desinscrever";
            this.btnDesinscrever.UseVisualStyleBackColor = true;
            this.btnDesinscrever.Click += new System.EventHandler(this.btnDesinscrever_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Endereco:";
            // 
            // cbEnderecosDesinscrever
            // 
            this.cbEnderecosDesinscrever.FormattingEnabled = true;
            this.cbEnderecosDesinscrever.Location = new System.Drawing.Point(80, 61);
            this.cbEnderecosDesinscrever.Name = "cbEnderecosDesinscrever";
            this.cbEnderecosDesinscrever.Size = new System.Drawing.Size(149, 21);
            this.cbEnderecosDesinscrever.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereco:";
            // 
            // btnIncrever
            // 
            this.btnIncrever.Location = new System.Drawing.Point(235, 19);
            this.btnIncrever.Name = "btnIncrever";
            this.btnIncrever.Size = new System.Drawing.Size(80, 22);
            this.btnIncrever.TabIndex = 5;
            this.btnIncrever.Text = "Inscrever";
            this.btnIncrever.UseVisualStyleBackColor = true;
            this.btnIncrever.Click += new System.EventHandler(this.btnIncrever_Click);
            // 
            // txtEnderecoSubscribe
            // 
            this.txtEnderecoSubscribe.Location = new System.Drawing.Point(80, 20);
            this.txtEnderecoSubscribe.Name = "txtEnderecoSubscribe";
            this.txtEnderecoSubscribe.Size = new System.Drawing.Size(149, 20);
            this.txtEnderecoSubscribe.TabIndex = 6;
            // 
            // gp2
            // 
            this.gp2.Controls.Add(this.cbEnderecoEnvio);
            this.gp2.Controls.Add(this.label6);
            this.gp2.Controls.Add(this.txtMensagemEnvio);
            this.gp2.Controls.Add(this.label5);
            this.gp2.Controls.Add(this.btnEnviar);
            this.gp2.Enabled = false;
            this.gp2.Location = new System.Drawing.Point(12, 202);
            this.gp2.Name = "gp2";
            this.gp2.Size = new System.Drawing.Size(331, 104);
            this.gp2.TabIndex = 6;
            this.gp2.TabStop = false;
            this.gp2.Text = "Envio";
            // 
            // cbEnderecoEnvio
            // 
            this.cbEnderecoEnvio.FormattingEnabled = true;
            this.cbEnderecoEnvio.Location = new System.Drawing.Point(80, 27);
            this.cbEnderecoEnvio.Name = "cbEnderecoEnvio";
            this.cbEnderecoEnvio.Size = new System.Drawing.Size(149, 21);
            this.cbEnderecoEnvio.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mensagem:";
            // 
            // txtMensagemEnvio
            // 
            this.txtMensagemEnvio.Location = new System.Drawing.Point(80, 52);
            this.txtMensagemEnvio.Name = "txtMensagemEnvio";
            this.txtMensagemEnvio.Size = new System.Drawing.Size(149, 20);
            this.txtMensagemEnvio.TabIndex = 5;
            this.txtMensagemEnvio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMensagemEnvio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Endereco:";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(235, 25);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(80, 47);
            this.btnEnviar.TabIndex = 0;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // gp3
            // 
            this.gp3.Controls.Add(this.btnLimparRecebido);
            this.gp3.Controls.Add(this.rtbRecebimento);
            this.gp3.Enabled = false;
            this.gp3.Location = new System.Drawing.Point(12, 312);
            this.gp3.Name = "gp3";
            this.gp3.Size = new System.Drawing.Size(331, 128);
            this.gp3.TabIndex = 6;
            this.gp3.TabStop = false;
            this.gp3.Text = "Recebimento";
            // 
            // btnLimparRecebido
            // 
            this.btnLimparRecebido.Location = new System.Drawing.Point(256, 102);
            this.btnLimparRecebido.Name = "btnLimparRecebido";
            this.btnLimparRecebido.Size = new System.Drawing.Size(57, 23);
            this.btnLimparRecebido.TabIndex = 1;
            this.btnLimparRecebido.Text = "Limpar";
            this.btnLimparRecebido.UseVisualStyleBackColor = true;
            this.btnLimparRecebido.Click += new System.EventHandler(this.btnLimparRecebido_Click);
            // 
            // rtbRecebimento
            // 
            this.rtbRecebimento.Location = new System.Drawing.Point(6, 19);
            this.rtbRecebimento.Name = "rtbRecebimento";
            this.rtbRecebimento.Size = new System.Drawing.Size(309, 81);
            this.rtbRecebimento.TabIndex = 0;
            this.rtbRecebimento.Text = "";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 517);
            this.Controls.Add(this.gp3);
            this.Controls.Add(this.gp2);
            this.Controls.Add(this.gp1);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "MQTTeus";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gp1.ResumeLayout(false);
            this.gp1.PerformLayout();
            this.gp2.ResumeLayout(false);
            this.gp2.PerformLayout();
            this.gp3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtEnderecoConexao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox gp1;
        private System.Windows.Forms.Button btnDesinscrever;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEnderecosDesinscrever;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIncrever;
        private System.Windows.Forms.TextBox txtEnderecoSubscribe;
        private System.Windows.Forms.GroupBox gp2;
        private System.Windows.Forms.ComboBox cbEnderecoEnvio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMensagemEnvio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.GroupBox gp3;
        private System.Windows.Forms.Button btnLimparRecebido;
        private System.Windows.Forms.RichTextBox rtbRecebimento;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Timer timer;
    }
}

