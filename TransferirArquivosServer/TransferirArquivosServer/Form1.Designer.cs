
namespace TransferirArquivosServer
{
    partial class form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnderecoIp = new System.Windows.Forms.TextBox();
            this.btnEstabelecerConexao = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.NumericUpDown();
            this.btnPararServidor = new System.Windows.Forms.Button();
            this.listaLogs = new System.Windows.Forms.ListBox();
            this.txtPasta = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Servidor para Compartilhamento Arquivo";
            // 
            // txtEnderecoIp
            // 
            this.txtEnderecoIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnderecoIp.Location = new System.Drawing.Point(43, 133);
            this.txtEnderecoIp.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEnderecoIp.Name = "txtEnderecoIp";
            this.txtEnderecoIp.Size = new System.Drawing.Size(368, 31);
            this.txtEnderecoIp.TabIndex = 1;
            this.txtEnderecoIp.Text = "127.0.0.1";
            // 
            // btnEstabelecerConexao
            // 
            this.btnEstabelecerConexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstabelecerConexao.Location = new System.Drawing.Point(43, 192);
            this.btnEstabelecerConexao.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnEstabelecerConexao.Name = "btnEstabelecerConexao";
            this.btnEstabelecerConexao.Size = new System.Drawing.Size(368, 44);
            this.btnEstabelecerConexao.TabIndex = 2;
            this.btnEstabelecerConexao.Text = "Estabelecer Conexão";
            this.btnEstabelecerConexao.UseVisualStyleBackColor = true;
            this.btnEstabelecerConexao.Click += new System.EventHandler(this.btnEstabelecerConexao_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(431, 133);
            this.txtPorta.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtPorta.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(105, 31);
            this.txtPorta.TabIndex = 4;
            this.txtPorta.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btnPararServidor
            // 
            this.btnPararServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPararServidor.Location = new System.Drawing.Point(431, 192);
            this.btnPararServidor.Margin = new System.Windows.Forms.Padding(6);
            this.btnPararServidor.Name = "btnPararServidor";
            this.btnPararServidor.Size = new System.Drawing.Size(380, 44);
            this.btnPararServidor.TabIndex = 5;
            this.btnPararServidor.Text = "Parar Servidor";
            this.btnPararServidor.UseVisualStyleBackColor = true;
            this.btnPararServidor.Click += new System.EventHandler(this.btnPararServidor_Click);
            // 
            // listaLogs
            // 
            this.listaLogs.BackColor = System.Drawing.SystemColors.InfoText;
            this.listaLogs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaLogs.ForeColor = System.Drawing.Color.Lime;
            this.listaLogs.FormattingEnabled = true;
            this.listaLogs.ItemHeight = 24;
            this.listaLogs.Location = new System.Drawing.Point(43, 298);
            this.listaLogs.Name = "listaLogs";
            this.listaLogs.Size = new System.Drawing.Size(768, 148);
            this.listaLogs.TabIndex = 6;
            // 
            // txtPasta
            // 
            this.txtPasta.Location = new System.Drawing.Point(48, 256);
            this.txtPasta.Name = "txtPasta";
            this.txtPasta.Size = new System.Drawing.Size(763, 39);
            this.txtPasta.TabIndex = 7;
            this.txtPasta.TabStop = true;
            this.txtPasta.Text = "Clique para selecionar a pasta";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 468);
            this.Controls.Add(this.txtPasta);
            this.Controls.Add(this.listaLogs);
            this.Controls.Add(this.btnPararServidor);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.btnEstabelecerConexao);
            this.Controls.Add(this.txtEnderecoIp);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form1";
            this.ShowInTaskbar = false;
            this.Text = "listaLog";
            this.Load += new System.EventHandler(this.txtPasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPorta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnderecoIp;
        private System.Windows.Forms.Button btnEstabelecerConexao;
        private System.Windows.Forms.NumericUpDown txtPorta;
        private System.Windows.Forms.Button btnPararServidor;
        private System.Windows.Forms.ListBox listaLogs;
        private System.Windows.Forms.LinkLabel txtPasta;
    }
}

