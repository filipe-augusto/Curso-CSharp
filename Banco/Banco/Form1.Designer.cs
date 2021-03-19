
namespace Banco
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cadastro = new System.Windows.Forms.TabPage();
            this.consulta = new System.Windows.Forms.TabPage();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.NumericUpDown();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dataView = new System.Windows.Forms.DataGridView();
            this.cbProfissao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.cadastro.SuspendLayout();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.cadastro);
            this.tabControl1.Controls.Add(this.consulta);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "Cadastro";
            // 
            // cadastro
            // 
            this.cadastro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cadastro.Controls.Add(this.dataView);
            this.cadastro.Controls.Add(this.btnNovo);
            this.cadastro.Controls.Add(this.panelAdd);
            this.cadastro.Location = new System.Drawing.Point(4, 22);
            this.cadastro.Name = "cadastro";
            this.cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.cadastro.Size = new System.Drawing.Size(768, 400);
            this.cadastro.TabIndex = 0;
            this.cadastro.Text = "Cadastro";
            this.cadastro.UseVisualStyleBackColor = true;
            // 
            // consulta
            // 
            this.consulta.Location = new System.Drawing.Point(4, 22);
            this.consulta.Name = "consulta";
            this.consulta.Padding = new System.Windows.Forms.Padding(3);
            this.consulta.Size = new System.Drawing.Size(768, 400);
            this.consulta.TabIndex = 1;
            this.consulta.Text = "Consulta";
            this.consulta.UseVisualStyleBackColor = true;
            // 
            // panelAdd
            // 
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.cbProfissao);
            this.panelAdd.Controls.Add(this.btnAdicionar);
            this.panelAdd.Controls.Add(this.label2);
            this.panelAdd.Controls.Add(this.txtSalario);
            this.panelAdd.Controls.Add(this.txtIdade);
            this.panelAdd.Controls.Add(this.label1);
            this.panelAdd.Controls.Add(this.txtNome);
            this.panelAdd.Controls.Add(this.nome);
            this.panelAdd.Location = new System.Drawing.Point(24, 31);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(720, 102);
            this.panelAdd.TabIndex = 0;
            this.panelAdd.Visible = false;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome.Location = new System.Drawing.Point(17, 10);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(55, 20);
            this.nome.TabIndex = 0;
            this.nome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(79, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(621, 26);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Idade";
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(79, 67);
            this.txtIdade.Maximum = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.txtIdade.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(120, 26);
            this.txtIdade.TabIndex = 3;
            this.txtIdade.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(214, 66);
            this.txtSalario.Mask = "00000";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(133, 26);
            this.txtSalario.TabIndex = 4;
            this.txtSalario.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(616, 69);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(97, 26);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNovo.Location = new System.Drawing.Point(24, 2);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(0);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 26);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dataView
            // 
            this.dataView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataView.Location = new System.Drawing.Point(24, 140);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(720, 250);
            this.dataView.TabIndex = 2;
            // 
            // cbProfissao
            // 
            this.cbProfissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfissao.FormattingEnabled = true;
            this.cbProfissao.Location = new System.Drawing.Point(371, 67);
            this.cbProfissao.Name = "cbProfissao";
            this.cbProfissao.Size = new System.Drawing.Size(189, 26);
            this.cbProfissao.TabIndex = 7;
            this.cbProfissao.Text = "Selecione uma profissão";
            this.cbProfissao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profissão";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.cadastro.ResumeLayout(false);
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cadastro;
        private System.Windows.Forms.TabPage consulta;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtSalario;
        private System.Windows.Forms.NumericUpDown txtIdade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label nome;
        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProfissao;
        private System.Windows.Forms.Button btnAdicionar;
    }
}

