
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProfissao = new System.Windows.Forms.ComboBox();
            this.btnAdicionarEditar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.MaskedTextBox();
            this.txtIdade = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.nome = new System.Windows.Forms.Label();
            this.consulta = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnExcluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1.SuspendLayout();
            this.cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.panelAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).BeginInit();
            this.consulta.SuspendLayout();
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
            // dataView
            // 
            this.dataView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataView.BackgroundColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnExcluir,
            this.editar});
            this.dataView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataView.Location = new System.Drawing.Point(24, 140);
            this.dataView.Name = "dataView";
            this.dataView.RowHeadersWidth = 15;
            this.dataView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataView.Size = new System.Drawing.Size(720, 250);
            this.dataView.TabIndex = 2;
            this.dataView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataView_CellContentClick);
            this.dataView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataView_DataBindingComplete);
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
            // panelAdd
            // 
            this.panelAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAdd.Controls.Add(this.label3);
            this.panelAdd.Controls.Add(this.cbProfissao);
            this.panelAdd.Controls.Add(this.btnAdicionarEditar);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Profissão";
            // 
            // cbProfissao
            // 
            this.cbProfissao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProfissao.FormattingEnabled = true;
            this.cbProfissao.Location = new System.Drawing.Point(326, 70);
            this.cbProfissao.Name = "cbProfissao";
            this.cbProfissao.Size = new System.Drawing.Size(245, 26);
            this.cbProfissao.TabIndex = 7;
            this.cbProfissao.Text = "Selecione uma profissão";
            this.cbProfissao.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnAdicionarEditar
            // 
            this.btnAdicionarEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAdicionarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarEditar.Location = new System.Drawing.Point(598, 41);
            this.btnAdicionarEditar.Name = "btnAdicionarEditar";
            this.btnAdicionarEditar.Size = new System.Drawing.Size(102, 51);
            this.btnAdicionarEditar.TabIndex = 6;
            this.btnAdicionarEditar.Text = "Adicionar    Editar";
            this.btnAdicionarEditar.UseVisualStyleBackColor = true;
            this.btnAdicionarEditar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Salario";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(159, 69);
            this.txtSalario.Mask = "00000";
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(133, 26);
            this.txtSalario.TabIndex = 4;
            this.txtSalario.ValidatingType = typeof(int);
            // 
            // txtIdade
            // 
            this.txtIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(21, 69);
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
            this.txtIdade.ValueChanged += new System.EventHandler(this.txtIdade_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Idade";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(79, 9);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(621, 26);
            this.txtNome.TabIndex = 1;
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
            // consulta
            // 
            this.consulta.Controls.Add(this.txtBusca);
            this.consulta.Controls.Add(this.label5);
            this.consulta.Location = new System.Drawing.Point(4, 22);
            this.consulta.Name = "consulta";
            this.consulta.Padding = new System.Windows.Forms.Padding(3);
            this.consulta.Size = new System.Drawing.Size(768, 400);
            this.consulta.TabIndex = 1;
            this.consulta.Text = "Consulta";
            this.consulta.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Procurar";
            // 
            // txtBusca
            // 
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(132, 22);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(545, 31);
            this.txtBusca.TabIndex = 7;
            this.txtBusca.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::Banco.Properties.Resources.editar;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.ToolTipText = "Clique para excluir";
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::Banco.Properties.Resources.editar;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 30;
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.btnExcluir.HeaderText = "";
           this.btnExcluir.Image = global::Banco.Properties.Resources.excluir;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnExcluir.ToolTipText = "Clique para excluir";
            this.btnExcluir.Width = 30;
            // 
            // editar
            // 
            this.editar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.editar.HeaderText = "";
            this.editar.Image = global::Banco.Properties.Resources.editar;
            this.editar.Name = "editar";
            this.editar.Width = 30;
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.cadastro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.panelAdd.ResumeLayout(false);
            this.panelAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIdade)).EndInit();
            this.consulta.ResumeLayout(false);
            this.consulta.PerformLayout();
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
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProfissao;
        private System.Windows.Forms.Button btnAdicionarEditar;
        public System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn btnExcluir;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
    }
}

