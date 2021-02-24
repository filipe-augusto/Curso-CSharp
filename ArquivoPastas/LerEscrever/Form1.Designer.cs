
namespace LerEscrever
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
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.btnEscrever = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.btnLerBinario = new System.Windows.Forms.Button();
            this.btnBinario = new System.Windows.Forms.Button();
            this.comboTeste = new System.Windows.Forms.ComboBox();
            this.btnTEste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtConteudo
            // 
            this.txtConteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConteudo.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtConteudo.Location = new System.Drawing.Point(53, 27);
            this.txtConteudo.Multiline = true;
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(675, 240);
            this.txtConteudo.TabIndex = 0;
            // 
            // btnEscrever
            // 
            this.btnEscrever.Location = new System.Drawing.Point(105, 290);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(194, 53);
            this.btnEscrever.TabIndex = 1;
            this.btnEscrever.Text = "Escrever";
            this.btnEscrever.UseVisualStyleBackColor = true;
            this.btnEscrever.Click += new System.EventHandler(this.btnEscrever_Click);
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(105, 352);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(194, 53);
            this.btnLer.TabIndex = 2;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // btnLerBinario
            // 
            this.btnLerBinario.Location = new System.Drawing.Point(500, 309);
            this.btnLerBinario.Name = "btnLerBinario";
            this.btnLerBinario.Size = new System.Drawing.Size(194, 53);
            this.btnLerBinario.TabIndex = 3;
            this.btnLerBinario.Text = "Ler Binario";
            this.btnLerBinario.UseVisualStyleBackColor = true;
            this.btnLerBinario.Click += new System.EventHandler(this.btnLerBinario_Click);
            // 
            // btnBinario
            // 
            this.btnBinario.Location = new System.Drawing.Point(500, 368);
            this.btnBinario.Name = "btnBinario";
            this.btnBinario.Size = new System.Drawing.Size(194, 53);
            this.btnBinario.TabIndex = 4;
            this.btnBinario.Text = "Escrever Binario";
            this.btnBinario.UseVisualStyleBackColor = true;
            this.btnBinario.Click += new System.EventHandler(this.btnBinario_Click);
            // 
            // comboTeste
            // 
            this.comboTeste.FormattingEnabled = true;
            this.comboTeste.Items.AddRange(new object[] {
            "filipe",
            "augusto",
            "santos"});
            this.comboTeste.Location = new System.Drawing.Point(347, 309);
            this.comboTeste.Name = "comboTeste";
            this.comboTeste.Size = new System.Drawing.Size(121, 21);
            this.comboTeste.TabIndex = 5;
            // 
            // btnTEste
            // 
            this.btnTEste.Location = new System.Drawing.Point(335, 352);
            this.btnTEste.Name = "btnTEste";
            this.btnTEste.Size = new System.Drawing.Size(142, 53);
            this.btnTEste.TabIndex = 6;
            this.btnTEste.Text = "Ler";
            this.btnTEste.UseVisualStyleBackColor = true;
            this.btnTEste.Click += new System.EventHandler(this.btnTEste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTEste);
            this.Controls.Add(this.comboTeste);
            this.Controls.Add(this.btnBinario);
            this.Controls.Add(this.btnLerBinario);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.btnEscrever);
            this.Controls.Add(this.txtConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button btnEscrever;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.Button btnLerBinario;
        private System.Windows.Forms.Button btnBinario;
        private System.Windows.Forms.ComboBox comboTeste;
        private System.Windows.Forms.Button btnTEste;
    }
}

