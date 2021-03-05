
namespace EmissaoNFS
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
            this.btnCriarXML = new System.Windows.Forms.Button();
            this.btnLerXML = new System.Windows.Forms.Button();
            this.dgvXML = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnEscreverSerialization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCriarXML
            // 
            this.btnCriarXML.Location = new System.Drawing.Point(51, 352);
            this.btnCriarXML.Name = "btnCriarXML";
            this.btnCriarXML.Size = new System.Drawing.Size(230, 36);
            this.btnCriarXML.TabIndex = 0;
            this.btnCriarXML.Text = "Escrever";
            this.btnCriarXML.UseVisualStyleBackColor = true;
            this.btnCriarXML.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLerXML
            // 
            this.btnLerXML.Location = new System.Drawing.Point(530, 368);
            this.btnLerXML.Name = "btnLerXML";
            this.btnLerXML.Size = new System.Drawing.Size(230, 55);
            this.btnLerXML.TabIndex = 1;
            this.btnLerXML.Text = "Ler";
            this.btnLerXML.UseVisualStyleBackColor = true;
            this.btnLerXML.Click += new System.EventHandler(this.btnLerXML_Click);
            // 
            // dgvXML
            // 
            this.dgvXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXML.Location = new System.Drawing.Point(51, 21);
            this.dgvXML.Name = "dgvXML";
            this.dgvXML.Size = new System.Drawing.Size(709, 189);
            this.dgvXML.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSize);
            this.panel1.Controls.Add(this.btnProcurar);
            this.panel1.Controls.Add(this.txtPath);
            this.panel1.Location = new System.Drawing.Point(51, 246);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 100);
            this.panel1.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(19, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(528, 29);
            this.txtPath.TabIndex = 0;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackgroundImage = global::EmissaoNFS.Properties.Resources.lupapng;
            this.btnProcurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProcurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcurar.Image = global::EmissaoNFS.Properties.Resources.lupapng;
            this.btnProcurar.Location = new System.Drawing.Point(562, 15);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(81, 57);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(32, 58);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(0, 13);
            this.lblSize.TabIndex = 2;
            // 
            // btnEscreverSerialization
            // 
            this.btnEscreverSerialization.Location = new System.Drawing.Point(51, 402);
            this.btnEscreverSerialization.Name = "btnEscreverSerialization";
            this.btnEscreverSerialization.Size = new System.Drawing.Size(230, 36);
            this.btnEscreverSerialization.TabIndex = 4;
            this.btnEscreverSerialization.Text = "Serial Escrever";
            this.btnEscreverSerialization.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEscreverSerialization);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvXML);
            this.Controls.Add(this.btnLerXML);
            this.Controls.Add(this.btnCriarXML);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXML)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCriarXML;
        private System.Windows.Forms.Button btnLerXML;
        private System.Windows.Forms.DataGridView dgvXML;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Button btnEscreverSerialization;
    }
}

