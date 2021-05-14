
namespace BotTelegramConnect
{
    partial class FrmEnvioImagemWeb
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mensagem";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(15, 44);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(692, 110);
            this.txtMensagem.TabIndex = 1;
            this.txtMensagem.TextChanged += new System.EventHandler(this.txtMensagem_TextChanged);
            // 
            // txtURL
            // 
            this.txtURL.BackColor = System.Drawing.SystemColors.Info;
            this.txtURL.Location = new System.Drawing.Point(15, 184);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(692, 20);
            this.txtURL.TabIndex = 2;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "URL da Imagem";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(561, 222);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(139, 41);
            this.btnEnviar.TabIndex = 4;
            this.btnEnviar.Text = "Enviar Mensagem";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // FrmEnvioImagemWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 283);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEnvioImagemWeb";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envio de Mensagem com imagem da Web";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
    }
}