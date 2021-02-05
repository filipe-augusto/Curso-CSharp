
namespace Part04
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
            this.lista = new System.Windows.Forms.ListBox();
            this.botao = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lista.Dock = System.Windows.Forms.DockStyle.Right;
            this.lista.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista.ForeColor = System.Drawing.Color.Navy;
            this.lista.FormattingEnabled = true;
            this.lista.ItemHeight = 22;
            this.lista.Location = new System.Drawing.Point(418, 0);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(390, 481);
            this.lista.TabIndex = 0;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // botao
            // 
            this.botao.Location = new System.Drawing.Point(12, 58);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(366, 72);
            this.botao.TabIndex = 1;
            this.botao.Text = "add";
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(13, 13);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(365, 31);
            this.txtNome.TabIndex = 2;
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(13, 146);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(366, 72);
            this.btnClean.TabIndex = 3;
            this.btnClean.Text = "limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(366, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "remover item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(366, 72);
            this.button2.TabIndex = 5;
            this.button2.Text = "remover item do indice";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 410);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(366, 72);
            this.button3.TabIndex = 6;
            this.button3.Text = "Quantidade de itens";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 481);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.lista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

