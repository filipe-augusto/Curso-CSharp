
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
            this.btnEscrever.Location = new System.Drawing.Point(63, 352);
            this.btnEscrever.Name = "btnEscrever";
            this.btnEscrever.Size = new System.Drawing.Size(194, 53);
            this.btnEscrever.TabIndex = 1;
            this.btnEscrever.Text = "Escrever";
            this.btnEscrever.UseVisualStyleBackColor = true;
            this.btnEscrever.Click += new System.EventHandler(this.btnEscrever_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscrever);
            this.Controls.Add(this.txtConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button btnEscrever;
    }
}

