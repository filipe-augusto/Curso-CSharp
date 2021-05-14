
namespace BotTelegramConnect
{
    partial class FrmEnvioImagemLocal
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaminhoImagem = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBscImagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(565, 276);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(139, 41);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar Mensagem";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Caminho da Imagem";
            // 
            // txtCaminhoImagem
            // 
            this.txtCaminhoImagem.BackColor = System.Drawing.SystemColors.Info;
            this.txtCaminhoImagem.Enabled = false;
            this.txtCaminhoImagem.Location = new System.Drawing.Point(12, 212);
            this.txtCaminhoImagem.Name = "txtCaminhoImagem";
            this.txtCaminhoImagem.Size = new System.Drawing.Size(571, 20);
            this.txtCaminhoImagem.TabIndex = 7;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 56);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(692, 110);
            this.txtMensagem.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mensagem";
            // 
            // btnBscImagem
            // 
            this.btnBscImagem.Location = new System.Drawing.Point(612, 209);
            this.btnBscImagem.Name = "btnBscImagem";
            this.btnBscImagem.Size = new System.Drawing.Size(92, 25);
            this.btnBscImagem.TabIndex = 10;
            this.btnBscImagem.Text = "...";
            this.btnBscImagem.UseVisualStyleBackColor = true;
            this.btnBscImagem.Click += new System.EventHandler(this.btnBscImagem_Click);
            // 
            // FrmEnvioImagemLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 329);
            this.Controls.Add(this.btnBscImagem);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaminhoImagem);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioImagemLocal";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mensagem com Imagem Local";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaminhoImagem;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBscImagem;
    }
}