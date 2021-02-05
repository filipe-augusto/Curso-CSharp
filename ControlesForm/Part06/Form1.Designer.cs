
namespace Part06
{
    partial class btnCheckQuantidade
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
            this.checkList = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAddGrupo = new System.Windows.Forms.Button();
            this.btnContem = new System.Windows.Forms.Button();
            this.txtContem = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnQuantidadeChecados = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkList
            // 
            this.checkList.CheckOnClick = true;
            this.checkList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkList.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkList.FormattingEnabled = true;
            this.checkList.Location = new System.Drawing.Point(0, 0);
            this.checkList.Name = "checkList";
            this.checkList.Size = new System.Drawing.Size(444, 461);
            this.checkList.TabIndex = 0;
            this.checkList.SelectedIndexChanged += new System.EventHandler(this.checkList_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(376, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(488, 49);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(376, 31);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAddGrupo
            // 
            this.btnAddGrupo.Location = new System.Drawing.Point(488, 86);
            this.btnAddGrupo.Name = "btnAddGrupo";
            this.btnAddGrupo.Size = new System.Drawing.Size(376, 33);
            this.btnAddGrupo.TabIndex = 3;
            this.btnAddGrupo.Text = "addGrupo";
            this.btnAddGrupo.UseVisualStyleBackColor = true;
            this.btnAddGrupo.Click += new System.EventHandler(this.btnAddGrupo_Click);
            // 
            // btnContem
            // 
            this.btnContem.Location = new System.Drawing.Point(488, 136);
            this.btnContem.Name = "btnContem";
            this.btnContem.Size = new System.Drawing.Size(229, 34);
            this.btnContem.TabIndex = 4;
            this.btnContem.Text = "Contem";
            this.btnContem.UseVisualStyleBackColor = true;
            this.btnContem.Click += new System.EventHandler(this.btnContem_Click);
            // 
            // txtContem
            // 
            this.txtContem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContem.Location = new System.Drawing.Point(724, 136);
            this.txtContem.Name = "txtContem";
            this.txtContem.Size = new System.Drawing.Size(140, 31);
            this.txtContem.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(376, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAdd
            // 
            this.txtAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdd.Location = new System.Drawing.Point(724, 215);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(140, 31);
            this.txtAdd.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(488, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(229, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnQuantidadeChecados
            // 
            this.btnQuantidadeChecados.Location = new System.Drawing.Point(488, 255);
            this.btnQuantidadeChecados.Name = "btnQuantidadeChecados";
            this.btnQuantidadeChecados.Size = new System.Drawing.Size(376, 33);
            this.btnQuantidadeChecados.TabIndex = 9;
            this.btnQuantidadeChecados.Text = "Quantidade Checados";
            this.btnQuantidadeChecados.UseVisualStyleBackColor = true;
            this.btnQuantidadeChecados.Click += new System.EventHandler(this.btnQuantidadeChecados_Click);
            // 
            // lblValor
            // 
            this.lblValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Location = new System.Drawing.Point(489, 295);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(375, 23);
            this.lblValor.TabIndex = 10;
            this.lblValor.Text = "label1";
            this.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCheckQuantidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 461);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.btnQuantidadeChecados);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtContem);
            this.Controls.Add(this.btnContem);
            this.Controls.Add(this.btnAddGrupo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkList);
            this.Name = "btnCheckQuantidade";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAddGrupo;
        private System.Windows.Forms.Button btnContem;
        private System.Windows.Forms.TextBox txtContem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnQuantidadeChecados;
        private System.Windows.Forms.Label lblValor;
    }
}

