
namespace CriptoFile
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
            this.btnCriptoFile = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExportarChavePublica = new System.Windows.Forms.Button();
            this.btnExportarChavePrivada = new System.Windows.Forms.Button();
            this.DescriptoFile = new System.Windows.Forms.Button();
            this.btnObterChavePrivada = new System.Windows.Forms.Button();
            this.btnCriarChaves = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCriptoFile
            // 
            this.btnCriptoFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCriptoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriptoFile.Location = new System.Drawing.Point(12, 344);
            this.btnCriptoFile.Name = "btnCriptoFile";
            this.btnCriptoFile.Size = new System.Drawing.Size(229, 69);
            this.btnCriptoFile.TabIndex = 0;
            this.btnCriptoFile.Text = "Croptografia arquivo";
            this.btnCriptoFile.UseVisualStyleBackColor = true;
            this.btnCriptoFile.Click += new System.EventHandler(this.buttonEncryptFile_Click);
            // 
            // txtKey
            // 
            this.txtKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(217, 260);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(338, 38);
            this.txtKey.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 213);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chave não definida";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExportarChavePublica
            // 
            this.btnExportarChavePublica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportarChavePublica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarChavePublica.Location = new System.Drawing.Point(12, 420);
            this.btnExportarChavePublica.Name = "btnExportarChavePublica";
            this.btnExportarChavePublica.Size = new System.Drawing.Size(229, 69);
            this.btnExportarChavePublica.TabIndex = 3;
            this.btnExportarChavePublica.Text = "Exportar chave publica";
            this.btnExportarChavePublica.UseVisualStyleBackColor = true;
            this.btnExportarChavePublica.Click += new System.EventHandler(this.buttonExportPublicKey_Click);
            // 
            // btnExportarChavePrivada
            // 
            this.btnExportarChavePrivada.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnExportarChavePrivada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarChavePrivada.Location = new System.Drawing.Point(264, 420);
            this.btnExportarChavePrivada.Name = "btnExportarChavePrivada";
            this.btnExportarChavePrivada.Size = new System.Drawing.Size(229, 69);
            this.btnExportarChavePrivada.TabIndex = 5;
            this.btnExportarChavePrivada.Text = "Importar chave publica";
            this.btnExportarChavePrivada.UseVisualStyleBackColor = true;
            this.btnExportarChavePrivada.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // DescriptoFile
            // 
            this.DescriptoFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DescriptoFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptoFile.Location = new System.Drawing.Point(264, 344);
            this.DescriptoFile.Name = "DescriptoFile";
            this.DescriptoFile.Size = new System.Drawing.Size(229, 69);
            this.DescriptoFile.TabIndex = 4;
            this.DescriptoFile.Text = "Descriptografar arquivo";
            this.DescriptoFile.UseVisualStyleBackColor = true;
            this.DescriptoFile.Click += new System.EventHandler(this.buttonDecryptFile_Click);
            // 
            // btnObterChavePrivada
            // 
            this.btnObterChavePrivada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnObterChavePrivada.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObterChavePrivada.Location = new System.Drawing.Point(517, 419);
            this.btnObterChavePrivada.Name = "btnObterChavePrivada";
            this.btnObterChavePrivada.Size = new System.Drawing.Size(229, 69);
            this.btnObterChavePrivada.TabIndex = 7;
            this.btnObterChavePrivada.Text = "Obter chave privada";
            this.btnObterChavePrivada.UseVisualStyleBackColor = true;
            this.btnObterChavePrivada.Click += new System.EventHandler(this.buttonGetPrivateKey_Click);
            // 
            // btnCriarChaves
            // 
            this.btnCriarChaves.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCriarChaves.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarChaves.Location = new System.Drawing.Point(517, 344);
            this.btnCriarChaves.Name = "btnCriarChaves";
            this.btnCriarChaves.Size = new System.Drawing.Size(229, 69);
            this.btnCriarChaves.TabIndex = 6;
            this.btnCriarChaves.Text = "Criar chaves";
            this.btnCriarChaves.UseVisualStyleBackColor = true;
            this.btnCriarChaves.Click += new System.EventHandler(this.buttonCreateAsmKeys_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 516);
            this.Controls.Add(this.btnObterChavePrivada);
            this.Controls.Add(this.btnCriarChaves);
            this.Controls.Add(this.btnExportarChavePrivada);
            this.Controls.Add(this.DescriptoFile);
            this.Controls.Add(this.btnExportarChavePublica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnCriptoFile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCriptoFile;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExportarChavePublica;
        private System.Windows.Forms.Button btnExportarChavePrivada;
        private System.Windows.Forms.Button DescriptoFile;
        private System.Windows.Forms.Button btnObterChavePrivada;
        private System.Windows.Forms.Button btnCriarChaves;
    }
}

