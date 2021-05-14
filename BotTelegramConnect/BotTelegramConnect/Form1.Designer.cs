
namespace BotTelegramConnect
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.envioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioMensagemSimplesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComImagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemDaWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imagemLocalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComEmojiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envioDeMensagemComTemporizadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.envioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.toolStripMenuItem1.Text = "Sair";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // envioToolStripMenuItem
            // 
            this.envioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.envioMensagemSimplesToolStripMenuItem,
            this.envioDeMensagemComImagemToolStripMenuItem,
            this.envioDeMensagemComEmojiToolStripMenuItem,
            this.envioDeMensagemComTemporizadorToolStripMenuItem});
            this.envioToolStripMenuItem.Name = "envioToolStripMenuItem";
            this.envioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.envioToolStripMenuItem.Text = "Envio";
            // 
            // envioMensagemSimplesToolStripMenuItem
            // 
            this.envioMensagemSimplesToolStripMenuItem.Name = "envioMensagemSimplesToolStripMenuItem";
            this.envioMensagemSimplesToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.envioMensagemSimplesToolStripMenuItem.Text = "Envio Mensagem Simples";
            this.envioMensagemSimplesToolStripMenuItem.Click += new System.EventHandler(this.envioMensagemSimplesToolStripMenuItem_Click);
            // 
            // envioDeMensagemComImagemToolStripMenuItem
            // 
            this.envioDeMensagemComImagemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagemDaWebToolStripMenuItem,
            this.imagemLocalToolStripMenuItem});
            this.envioDeMensagemComImagemToolStripMenuItem.Name = "envioDeMensagemComImagemToolStripMenuItem";
            this.envioDeMensagemComImagemToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.envioDeMensagemComImagemToolStripMenuItem.Text = "Envio de Mensagem com Imagem";
            // 
            // imagemDaWebToolStripMenuItem
            // 
            this.imagemDaWebToolStripMenuItem.Name = "imagemDaWebToolStripMenuItem";
            this.imagemDaWebToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.imagemDaWebToolStripMenuItem.Text = "Imagem da Web";
            this.imagemDaWebToolStripMenuItem.Click += new System.EventHandler(this.imagemDaWebToolStripMenuItem_Click);
            // 
            // imagemLocalToolStripMenuItem
            // 
            this.imagemLocalToolStripMenuItem.Name = "imagemLocalToolStripMenuItem";
            this.imagemLocalToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.imagemLocalToolStripMenuItem.Text = "Imagem local";
            this.imagemLocalToolStripMenuItem.Click += new System.EventHandler(this.imagemLocalToolStripMenuItem_Click);
            // 
            // envioDeMensagemComEmojiToolStripMenuItem
            // 
            this.envioDeMensagemComEmojiToolStripMenuItem.Name = "envioDeMensagemComEmojiToolStripMenuItem";
            this.envioDeMensagemComEmojiToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.envioDeMensagemComEmojiToolStripMenuItem.Text = "Envio de Mensagem com Emoji";
            this.envioDeMensagemComEmojiToolStripMenuItem.Click += new System.EventHandler(this.envioDeMensagemComEmojiToolStripMenuItem_Click);
            // 
            // envioDeMensagemComTemporizadorToolStripMenuItem
            // 
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Name = "envioDeMensagemComTemporizadorToolStripMenuItem";
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Size = new System.Drawing.Size(283, 22);
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Text = "Envio de Mensagem com Temporizador";
            this.envioDeMensagemComTemporizadorToolStripMenuItem.Click += new System.EventHandler(this.envioDeMensagemComTemporizadorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Formulario Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem envioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioMensagemSimplesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComImagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemDaWebToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imagemLocalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComEmojiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envioDeMensagemComTemporizadorToolStripMenuItem;
    }
}

