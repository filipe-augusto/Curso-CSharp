
namespace ControleEstoque_Acai
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
            this.tabVenda = new System.Windows.Forms.TabControl();
            this.tabVendas = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewCardapio = new System.Windows.Forms.DataGridView();
            this.a1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.a2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTiposDePagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.tabEstoque = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtaMaximaNovo = new System.Windows.Forms.TextBox();
            this.txtQuantidadeProdutoNovo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeProdutoNovo = new System.Windows.Forms.TextBox();
            this.dataGridViewEstoque = new System.Windows.Forms.DataGridView();
            this.gBoxRecarregar = new System.Windows.Forms.GroupBox();
            this.maximo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblQuantidadeRecarregada = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSimulacao = new System.Windows.Forms.Button();
            this.txtSimulacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRecarregar = new System.Windows.Forms.Button();
            this.lblProduto = new System.Windows.Forms.Label();
            this.progressProduto = new System.Windows.Forms.ProgressBar();
            this.tabFaturamento = new System.Windows.Forms.TabPage();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicional1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicional2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdicional1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdicional2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabVenda.SuspendLayout();
            this.tabVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCardapio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.tabEstoque.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.gBoxRecarregar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVenda
            // 
            this.tabVenda.Controls.Add(this.tabVendas);
            this.tabVenda.Controls.Add(this.tabEstoque);
            this.tabVenda.Controls.Add(this.tabFaturamento);
            this.tabVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVenda.Location = new System.Drawing.Point(12, 3);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.SelectedIndex = 0;
            this.tabVenda.Size = new System.Drawing.Size(776, 496);
            this.tabVenda.TabIndex = 2;
            this.tabVenda.Tag = "Venda";
            this.tabVenda.SelectedIndexChanged += new System.EventHandler(this.tabVenda_SelectedIndexChanged);
            // 
            // tabVendas
            // 
            this.tabVendas.Controls.Add(this.label7);
            this.tabVendas.Controls.Add(this.dataGridViewCardapio);
            this.tabVendas.Controls.Add(this.label8);
            this.tabVendas.Controls.Add(this.comboBoxTiposDePagamento);
            this.tabVendas.Controls.Add(this.label6);
            this.tabVendas.Controls.Add(this.dataGridViewVendas);
            this.tabVendas.Location = new System.Drawing.Point(4, 27);
            this.tabVendas.Name = "tabVendas";
            this.tabVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendas.Size = new System.Drawing.Size(768, 465);
            this.tabVendas.TabIndex = 0;
            this.tabVendas.Text = "Vendas";
            this.tabVendas.UseVisualStyleBackColor = true;
            this.tabVendas.Enter += new System.EventHandler(this.tabVendas_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(29, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cardapio";
            // 
            // dataGridViewCardapio
            // 
            this.dataGridViewCardapio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCardapio.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewCardapio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCardapio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a1,
            this.a2});
            this.dataGridViewCardapio.Location = new System.Drawing.Point(23, 201);
            this.dataGridViewCardapio.Name = "dataGridViewCardapio";
            this.dataGridViewCardapio.RowHeadersVisible = false;
            this.dataGridViewCardapio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCardapio.Size = new System.Drawing.Size(716, 149);
            this.dataGridViewCardapio.TabIndex = 13;
            this.dataGridViewCardapio.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCardapio_CellContentClick);
            this.dataGridViewCardapio.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCardapio_CellDoubleClick);
            // 
            // a1
            // 
            this.a1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.a1.FillWeight = 98.47716F;
            this.a1.HeaderText = "Adicional 1";
            this.a1.MinimumWidth = 50;
            this.a1.Name = "a1";
            // 
            // a2
            // 
            this.a2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.a2.FillWeight = 101.5228F;
            this.a2.HeaderText = "Adicional 2";
            this.a2.MinimumWidth = 100;
            this.a2.Name = "a2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 18);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tipos de pagamento";
            // 
            // comboBoxTiposDePagamento
            // 
            this.comboBoxTiposDePagamento.FormattingEnabled = true;
            this.comboBoxTiposDePagamento.Location = new System.Drawing.Point(461, 401);
            this.comboBoxTiposDePagamento.Name = "comboBoxTiposDePagamento";
            this.comboBoxTiposDePagamento.Size = new System.Drawing.Size(278, 26);
            this.comboBoxTiposDePagamento.TabIndex = 10;
            this.comboBoxTiposDePagamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxTiposDePagamento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(29, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Carrinho";
            // 
            // dataGridViewVendas
            // 
            this.dataGridViewVendas.AllowDrop = true;
            this.dataGridViewVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVendas.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProduto,
            this.nome,
            this.tamanho,
            this.valor,
            this.adicional1,
            this.adicional2,
            this.idAdicional1,
            this.idAdicional2,
            this.excluir});
            this.dataGridViewVendas.Location = new System.Drawing.Point(23, 39);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVendas.Size = new System.Drawing.Size(716, 131);
            this.dataGridViewVendas.TabIndex = 0;
            this.dataGridViewVendas.Tag = "";
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.groupBox1);
            this.tabEstoque.Controls.Add(this.dataGridViewEstoque);
            this.tabEstoque.Controls.Add(this.gBoxRecarregar);
            this.tabEstoque.Location = new System.Drawing.Point(4, 27);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoque.Size = new System.Drawing.Size(768, 465);
            this.tabEstoque.TabIndex = 1;
            this.tabEstoque.Text = "Estoque";
            this.tabEstoque.UseVisualStyleBackColor = true;
            this.tabEstoque.Enter += new System.EventHandler(this.tabEstoque_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnAdicionar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtaMaximaNovo);
            this.groupBox1.Controls.Add(this.txtQuantidadeProdutoNovo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNomeProdutoNovo);
            this.groupBox1.Location = new System.Drawing.Point(9, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar novo item";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(327, 23);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(87, 37);
            this.BtnAdicionar.TabIndex = 6;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantidade maxima";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade em gramas";
            // 
            // txtaMaximaNovo
            // 
            this.txtaMaximaNovo.Location = new System.Drawing.Point(249, 106);
            this.txtaMaximaNovo.Name = "txtaMaximaNovo";
            this.txtaMaximaNovo.Size = new System.Drawing.Size(174, 24);
            this.txtaMaximaNovo.TabIndex = 4;
            this.txtaMaximaNovo.Text = "0";
            // 
            // txtQuantidadeProdutoNovo
            // 
            this.txtQuantidadeProdutoNovo.Location = new System.Drawing.Point(16, 106);
            this.txtQuantidadeProdutoNovo.Name = "txtQuantidadeProdutoNovo";
            this.txtQuantidadeProdutoNovo.Size = new System.Drawing.Size(211, 24);
            this.txtQuantidadeProdutoNovo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nome";
            // 
            // txtNomeProdutoNovo
            // 
            this.txtNomeProdutoNovo.Location = new System.Drawing.Point(16, 46);
            this.txtNomeProdutoNovo.Name = "txtNomeProdutoNovo";
            this.txtNomeProdutoNovo.Size = new System.Drawing.Size(288, 24);
            this.txtNomeProdutoNovo.TabIndex = 0;
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Location = new System.Drawing.Point(9, 7);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.RowHeadersVisible = false;
            this.dataGridViewEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(753, 178);
            this.dataGridViewEstoque.TabIndex = 2;
            this.dataGridViewEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEstoque_CellContentClick);
            this.dataGridViewEstoque.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewEstoque_RowPrePaint);
            // 
            // gBoxRecarregar
            // 
            this.gBoxRecarregar.Controls.Add(this.maximo);
            this.gBoxRecarregar.Controls.Add(this.label2);
            this.gBoxRecarregar.Controls.Add(this.lblQuantidadeRecarregada);
            this.gBoxRecarregar.Controls.Add(this.panel1);
            this.gBoxRecarregar.Controls.Add(this.btnRecarregar);
            this.gBoxRecarregar.Controls.Add(this.lblProduto);
            this.gBoxRecarregar.Controls.Add(this.progressProduto);
            this.gBoxRecarregar.Location = new System.Drawing.Point(9, 191);
            this.gBoxRecarregar.Name = "gBoxRecarregar";
            this.gBoxRecarregar.Size = new System.Drawing.Size(753, 97);
            this.gBoxRecarregar.TabIndex = 0;
            this.gBoxRecarregar.TabStop = false;
            this.gBoxRecarregar.Text = "Recarregar Produto";
            this.gBoxRecarregar.Visible = false;
            // 
            // maximo
            // 
            this.maximo.AutoSize = true;
            this.maximo.Location = new System.Drawing.Point(26, 68);
            this.maximo.Name = "maximo";
            this.maximo.Size = new System.Drawing.Size(16, 18);
            this.maximo.TabIndex = 7;
            this.maximo.Text = "0";
            this.maximo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "g";
            // 
            // lblQuantidadeRecarregada
            // 
            this.lblQuantidadeRecarregada.AutoSize = true;
            this.lblQuantidadeRecarregada.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQuantidadeRecarregada.Location = new System.Drawing.Point(532, 61);
            this.lblQuantidadeRecarregada.Name = "lblQuantidadeRecarregada";
            this.lblQuantidadeRecarregada.Size = new System.Drawing.Size(16, 18);
            this.lblQuantidadeRecarregada.TabIndex = 6;
            this.lblQuantidadeRecarregada.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSimulacao);
            this.panel1.Controls.Add(this.txtSimulacao);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(81, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 43);
            this.panel1.TabIndex = 5;
            // 
            // btnSimulacao
            // 
            this.btnSimulacao.Location = new System.Drawing.Point(215, 8);
            this.btnSimulacao.Name = "btnSimulacao";
            this.btnSimulacao.Size = new System.Drawing.Size(75, 29);
            this.btnSimulacao.TabIndex = 5;
            this.btnSimulacao.Text = "Simular";
            this.btnSimulacao.UseVisualStyleBackColor = true;
            this.btnSimulacao.Click += new System.EventHandler(this.btnSimulacao_Click);
            // 
            // txtSimulacao
            // 
            this.txtSimulacao.Location = new System.Drawing.Point(21, 6);
            this.txtSimulacao.Name = "txtSimulacao";
            this.txtSimulacao.Size = new System.Drawing.Size(110, 24);
            this.txtSimulacao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "gramas";
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Location = new System.Drawing.Point(620, 64);
            this.btnRecarregar.Name = "btnRecarregar";
            this.btnRecarregar.Size = new System.Drawing.Size(116, 26);
            this.btnRecarregar.TabIndex = 2;
            this.btnRecarregar.Text = "Recarregar ";
            this.btnRecarregar.UseVisualStyleBackColor = true;
            this.btnRecarregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(23, 28);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(59, 18);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "produto";
            // 
            // progressProduto
            // 
            this.progressProduto.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.progressProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.progressProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.progressProduto.Location = new System.Drawing.Point(102, 28);
            this.progressProduto.Name = "progressProduto";
            this.progressProduto.Size = new System.Drawing.Size(634, 18);
            this.progressProduto.Step = 1;
            this.progressProduto.TabIndex = 0;
            // 
            // tabFaturamento
            // 
            this.tabFaturamento.Location = new System.Drawing.Point(4, 27);
            this.tabFaturamento.Name = "tabFaturamento";
            this.tabFaturamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabFaturamento.Size = new System.Drawing.Size(768, 465);
            this.tabFaturamento.TabIndex = 2;
            this.tabFaturamento.Text = "Faturamento";
            this.tabFaturamento.UseVisualStyleBackColor = true;
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "ID";
            this.idProduto.Name = "idProduto";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // tamanho
            // 
            this.tamanho.HeaderText = "Tamanho";
            this.tamanho.Name = "tamanho";
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            // 
            // adicional1
            // 
            this.adicional1.HeaderText = "Adicional 1";
            this.adicional1.Name = "adicional1";
            // 
            // adicional2
            // 
            this.adicional2.HeaderText = "Adicional 2";
            this.adicional2.Name = "adicional2";
            // 
            // idAdicional1
            // 
            this.idAdicional1.HeaderText = "idAdicional1";
            this.idAdicional1.Name = "idAdicional1";
            this.idAdicional1.Visible = false;
            // 
            // idAdicional2
            // 
            this.idAdicional2.HeaderText = "idAdicional2";
            this.idAdicional2.Name = "idAdicional2";
            this.idAdicional2.Visible = false;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            this.excluir.Text = "Excluir";
            this.excluir.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.tabVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Açai Store";
            this.tabVenda.ResumeLayout(false);
            this.tabVendas.ResumeLayout(false);
            this.tabVendas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCardapio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).EndInit();
            this.tabEstoque.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).EndInit();
            this.gBoxRecarregar.ResumeLayout(false);
            this.gBoxRecarregar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabVenda;
        private System.Windows.Forms.TabPage tabVendas;
        private System.Windows.Forms.TabPage tabEstoque;
        private System.Windows.Forms.GroupBox gBoxRecarregar;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.ProgressBar progressProduto;
        private System.Windows.Forms.TabPage tabFaturamento;
        private System.Windows.Forms.DataGridView dataGridViewEstoque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSimulacao;
        private System.Windows.Forms.Button btnRecarregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblQuantidadeRecarregada;
        private System.Windows.Forms.Button btnSimulacao;
        private System.Windows.Forms.Label maximo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtaMaximaNovo;
        private System.Windows.Forms.TextBox txtQuantidadeProdutoNovo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeProdutoNovo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewVendas;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxTiposDePagamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewCardapio;
        private System.Windows.Forms.DataGridViewComboBoxColumn a1;
        private System.Windows.Forms.DataGridViewComboBoxColumn a2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn adicional1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adicional2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdicional1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdicional2;
        private System.Windows.Forms.DataGridViewButtonColumn excluir;
    }
}

