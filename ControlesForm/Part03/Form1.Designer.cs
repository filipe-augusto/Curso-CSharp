
namespace Part03
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
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblTela = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensagem.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensagem.ForeColor = System.Drawing.Color.GreenYellow;
            this.txtMensagem.Location = new System.Drawing.Point(15, 191);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMensagem.Size = new System.Drawing.Size(685, 229);
            this.txtMensagem.TabIndex = 0;
            this.txtMensagem.TextChanged += new System.EventHandler(this.txtMensagem_TextChanged);
            // 
            // lblTela
            // 
            this.lblTela.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTela.Location = new System.Drawing.Point(12, 45);
            this.lblTela.Name = "lblTela";
            this.lblTela.Size = new System.Drawing.Size(670, 112);
            this.lblTela.TabIndex = 1;
            this.lblTela.Text = "ASCI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(284, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ASCI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTela);
            this.Controls.Add(this.txtMensagem);
            this.ForeColor = System.Drawing.Color.YellowGreen;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblTela;
        private System.Windows.Forms.Label label1;
    }
}

