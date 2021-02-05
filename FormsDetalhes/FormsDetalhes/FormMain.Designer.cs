
namespace FormsDetalhes
{
    partial class FormMain
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSecond = new System.Windows.Forms.Button();
            this.btnSecondFormWithThread = new System.Windows.Forms.Button();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mFilNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mfileSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.sobtrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpDev = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelpVesion = new System.Windows.Forms.ToolStripMenuItem();
            this.comboMenu = new System.Windows.Forms.ToolStripComboBox();
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.mPesquisar = new System.Windows.Forms.ToolStripTextBox();
            this.btnControleCodigoFont = new System.Windows.Forms.Button();
            this.MenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 41);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(638, 131);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Principal";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSecond
            // 
            this.btnSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecond.Location = new System.Drawing.Point(42, 323);
            this.btnSecond.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSecond.Name = "btnSecond";
            this.btnSecond.Size = new System.Drawing.Size(250, 66);
            this.btnSecond.TabIndex = 1;
            this.btnSecond.Text = "Segunda";
            this.btnSecond.UseVisualStyleBackColor = true;
            this.btnSecond.Click += new System.EventHandler(this.btnSecond_Click);
            // 
            // btnSecondFormWithThread
            // 
            this.btnSecondFormWithThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecondFormWithThread.Location = new System.Drawing.Point(314, 323);
            this.btnSecondFormWithThread.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnSecondFormWithThread.Name = "btnSecondFormWithThread";
            this.btnSecondFormWithThread.Size = new System.Drawing.Size(250, 66);
            this.btnSecondFormWithThread.TabIndex = 2;
            this.btnSecondFormWithThread.Text = "Segunda Form Thread";
            this.btnSecondFormWithThread.UseVisualStyleBackColor = true;
            this.btnSecondFormWithThread.Click += new System.EventHandler(this.btnSecondFormWithThread_Click);
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFilNovo,
            this.mFileAbrir,
            this.toolStripSeparator1,
            this.mfileSair});
            this.menuFile.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(52, 23);
            this.menuFile.Text = "File";
            // 
            // mFilNovo
            // 
            this.mFilNovo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mFilNovo.Image = global::FormsDetalhes.Properties.Resources.new_file;
            this.mFilNovo.Name = "mFilNovo";
            this.mFilNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mFilNovo.Size = new System.Drawing.Size(183, 24);
            this.mFilNovo.Text = "Novo";
            this.mFilNovo.ToolTipText = "Nova Janela";
            this.mFilNovo.Click += new System.EventHandler(this.mFilNovo_Click);
            // 
            // mFileAbrir
            // 
            this.mFileAbrir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mFileAbrir.Image = global::FormsDetalhes.Properties.Resources.open_archive;
            this.mFileAbrir.Name = "mFileAbrir";
            this.mFileAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mFileAbrir.Size = new System.Drawing.Size(183, 24);
            this.mFileAbrir.Text = "Abrir";
            this.mFileAbrir.Click += new System.EventHandler(this.mFileAbrir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.Highlight;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(180, 6);
            // 
            // mfileSair
            // 
            this.mfileSair.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mfileSair.Image = global::FormsDetalhes.Properties.Resources.exit;
            this.mfileSair.Name = "mfileSair";
            this.mfileSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mfileSair.Size = new System.Drawing.Size(183, 24);
            this.mfileSair.Text = "Sair";
            this.mfileSair.Click += new System.EventHandler(this.mfileSair_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobtrToolStripMenuItem});
            this.menuHelp.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(54, 23);
            this.menuHelp.Text = "Help";
            // 
            // sobtrToolStripMenuItem
            // 
            this.sobtrToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mHelpDev,
            this.mHelpVesion});
            this.sobtrToolStripMenuItem.Name = "sobtrToolStripMenuItem";
            this.sobtrToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.sobtrToolStripMenuItem.Text = "Sobre";
            this.sobtrToolStripMenuItem.Click += new System.EventHandler(this.sobtrToolStripMenuItem_Click);
            // 
            // mHelpDev
            // 
            this.mHelpDev.Name = "mHelpDev";
            this.mHelpDev.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mHelpDev.Size = new System.Drawing.Size(248, 22);
            this.mHelpDev.Text = "Desenvolvedor";
            this.mHelpDev.Click += new System.EventHandler(this.mHelpDev_Click);
            // 
            // mHelpVesion
            // 
            this.mHelpVesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mHelpVesion.Name = "mHelpVesion";
            this.mHelpVesion.Size = new System.Drawing.Size(248, 22);
            this.mHelpVesion.Text = "Versão";
            this.mHelpVesion.Click += new System.EventHandler(this.mHelpVesion_Click);
            // 
            // comboMenu
            // 
            this.comboMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboMenu.Items.AddRange(new object[] {
            "Inglês",
            "Português"});
            this.comboMenu.Name = "comboMenu";
            this.comboMenu.Size = new System.Drawing.Size(199, 23);
            this.comboMenu.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
            // 
            // MenuBar
            // 
            this.MenuBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuHelp,
            this.comboMenu,
            this.mPesquisar});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this.MenuBar.Size = new System.Drawing.Size(844, 29);
            this.MenuBar.TabIndex = 3;
            this.MenuBar.Text = "menuStrip1";
            // 
            // mPesquisar
            // 
            this.mPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mPesquisar.Name = "mPesquisar";
            this.mPesquisar.Size = new System.Drawing.Size(414, 23);
            this.mPesquisar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnPesquisar_KeyUp);
            // 
            // btnControleCodigoFont
            // 
            this.btnControleCodigoFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControleCodigoFont.Location = new System.Drawing.Point(574, 323);
            this.btnControleCodigoFont.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnControleCodigoFont.Name = "btnControleCodigoFont";
            this.btnControleCodigoFont.Size = new System.Drawing.Size(250, 66);
            this.btnControleCodigoFont.TabIndex = 4;
            this.btnControleCodigoFont.Text = "Controle Codigo Font";
            this.btnControleCodigoFont.UseVisualStyleBackColor = true;
            this.btnControleCodigoFont.Click += new System.EventHandler(this.btnControleCodigoFont_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 434);
            this.Controls.Add(this.btnControleCodigoFont);
            this.Controls.Add(this.btnSecondFormWithThread);
            this.Controls.Add(this.btnSecond);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.MenuBar);
            this.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.MenuBar;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMain";
            this.Text = "Main Form";
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSecond;
        private System.Windows.Forms.Button btnSecondFormWithThread;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem mFilNovo;
        private System.Windows.Forms.ToolStripMenuItem mFileAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mfileSair;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.ToolStripMenuItem sobtrToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mHelpDev;
        private System.Windows.Forms.ToolStripMenuItem mHelpVesion;
        private System.Windows.Forms.ToolStripComboBox comboMenu;
        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripTextBox mPesquisar;
        private System.Windows.Forms.Button btnControleCodigoFont;
    }
}

