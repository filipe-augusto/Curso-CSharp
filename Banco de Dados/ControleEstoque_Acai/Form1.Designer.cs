﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabVenda = new System.Windows.Forms.TabControl();
            this.tabVendas = new System.Windows.Forms.TabPage();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnVenda = new System.Windows.Forms.Button();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblValorTotal2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewCardapio = new System.Windows.Forms.DataGridView();
            this.a1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.a2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxTiposDePagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewVendas = new System.Windows.Forms.DataGridView();
            this.idProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicional1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adicional2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdicional1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAdicional2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excluir = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker_INICIO = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker_FIM = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_vendas = new System.Windows.Forms.DataGridView();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabVenda.SuspendLayout();
            this.tabVendas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCardapio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVendas)).BeginInit();
            this.tabEstoque.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEstoque)).BeginInit();
            this.gBoxRecarregar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabFaturamento.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vendas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabVenda
            // 
            this.tabVenda.Controls.Add(this.tabVendas);
            this.tabVenda.Controls.Add(this.tabEstoque);
            this.tabVenda.Controls.Add(this.tabFaturamento);
            this.tabVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabVenda.Location = new System.Drawing.Point(12, 3);
            this.tabVenda.Name = "tabVenda";
            this.tabVenda.SelectedIndex = 0;
            this.tabVenda.Size = new System.Drawing.Size(980, 644);
            this.tabVenda.TabIndex = 2;
            this.tabVenda.Tag = "Venda";
            this.tabVenda.SelectedIndexChanged += new System.EventHandler(this.tabVenda_SelectedIndexChanged);
            // 
            // tabVendas
            // 
            this.tabVendas.Controls.Add(this.txtNomeCliente);
            this.tabVendas.Controls.Add(this.label9);
            this.tabVendas.Controls.Add(this.btnVenda);
            this.tabVendas.Controls.Add(this.lblValorTotal);
            this.tabVendas.Controls.Add(this.lblValorTotal2);
            this.tabVendas.Controls.Add(this.label7);
            this.tabVendas.Controls.Add(this.dataGridViewCardapio);
            this.tabVendas.Controls.Add(this.label8);
            this.tabVendas.Controls.Add(this.comboBoxTiposDePagamento);
            this.tabVendas.Controls.Add(this.label6);
            this.tabVendas.Controls.Add(this.dataGridViewVendas);
            this.tabVendas.Location = new System.Drawing.Point(4, 29);
            this.tabVendas.Name = "tabVendas";
            this.tabVendas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVendas.Size = new System.Drawing.Size(972, 611);
            this.tabVendas.TabIndex = 0;
            this.tabVendas.Text = "Vendas";
            this.tabVendas.UseVisualStyleBackColor = true;
            this.tabVendas.Enter += new System.EventHandler(this.tabVendas_Enter);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(6, 576);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(279, 29);
            this.txtNomeCliente.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(6, 553);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cliente";
            // 
            // btnVenda
            // 
            this.btnVenda.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVenda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVenda.Location = new System.Drawing.Point(829, 535);
            this.btnVenda.Name = "btnVenda";
            this.btnVenda.Size = new System.Drawing.Size(132, 70);
            this.btnVenda.TabIndex = 17;
            this.btnVenda.Text = "Confirmar venda";
            this.btnVenda.UseVisualStyleBackColor = false;
            this.btnVenda.Click += new System.EventHandler(this.btnVenda_Click);
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblValorTotal.Location = new System.Drawing.Point(726, 558);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(25, 25);
            this.lblValorTotal.TabIndex = 16;
            this.lblValorTotal.Text = "0";
            // 
            // lblValorTotal2
            // 
            this.lblValorTotal2.AutoSize = true;
            this.lblValorTotal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblValorTotal2.Location = new System.Drawing.Point(926, 11);
            this.lblValorTotal2.Name = "lblValorTotal2";
            this.lblValorTotal2.Size = new System.Drawing.Size(25, 25);
            this.lblValorTotal2.TabIndex = 15;
            this.lblValorTotal2.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(24, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Cardapio";
            // 
            // dataGridViewCardapio
            // 
            this.dataGridViewCardapio.AllowUserToAddRows = false;
            this.dataGridViewCardapio.AllowUserToOrderColumns = true;
            this.dataGridViewCardapio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCardapio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewCardapio.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewCardapio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewCardapio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCardapio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCardapio.ColumnHeadersHeight = 30;
            this.dataGridViewCardapio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.a1,
            this.a2});
            this.dataGridViewCardapio.Location = new System.Drawing.Point(23, 304);
            this.dataGridViewCardapio.Name = "dataGridViewCardapio";
            this.dataGridViewCardapio.RowHeadersVisible = false;
            this.dataGridViewCardapio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCardapio.Size = new System.Drawing.Size(938, 213);
            this.dataGridViewCardapio.TabIndex = 13;
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
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(296, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tipos de pagamento";
            // 
            // comboBoxTiposDePagamento
            // 
            this.comboBoxTiposDePagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTiposDePagamento.FormattingEnabled = true;
            this.comboBoxTiposDePagamento.Location = new System.Drawing.Point(300, 576);
            this.comboBoxTiposDePagamento.Name = "comboBoxTiposDePagamento";
            this.comboBoxTiposDePagamento.Size = new System.Drawing.Size(344, 28);
            this.comboBoxTiposDePagamento.TabIndex = 10;
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
            this.dataGridViewVendas.AllowUserToAddRows = false;
            this.dataGridViewVendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MidnightBlue;
            this.dataGridViewVendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewVendas.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewVendas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewVendas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVendas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVendas.ColumnHeadersHeight = 30;
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
            this.dataGridViewVendas.GridColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewVendas.Location = new System.Drawing.Point(23, 54);
            this.dataGridViewVendas.Name = "dataGridViewVendas";
            this.dataGridViewVendas.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewVendas.RowHeadersVisible = false;
            this.dataGridViewVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVendas.Size = new System.Drawing.Size(938, 219);
            this.dataGridViewVendas.TabIndex = 0;
            this.dataGridViewVendas.Tag = "";
            this.dataGridViewVendas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVendas_CellContentClick);
            // 
            // idProduto
            // 
            this.idProduto.HeaderText = "ID";
            this.idProduto.Name = "idProduto";
            this.idProduto.ReadOnly = true;
            this.idProduto.Visible = false;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // tamanho
            // 
            this.tamanho.HeaderText = "Tamanho";
            this.tamanho.Name = "tamanho";
            this.tamanho.ReadOnly = true;
            // 
            // valor
            // 
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            // 
            // adicional1
            // 
            this.adicional1.HeaderText = "Adicional 1";
            this.adicional1.Name = "adicional1";
            this.adicional1.ReadOnly = true;
            // 
            // adicional2
            // 
            this.adicional2.HeaderText = "Adicional 2";
            this.adicional2.Name = "adicional2";
            this.adicional2.ReadOnly = true;
            // 
            // idAdicional1
            // 
            this.idAdicional1.HeaderText = "idAdicional1";
            this.idAdicional1.Name = "idAdicional1";
            this.idAdicional1.ReadOnly = true;
            this.idAdicional1.Visible = false;
            // 
            // idAdicional2
            // 
            this.idAdicional2.HeaderText = "idAdicional2";
            this.idAdicional2.Name = "idAdicional2";
            this.idAdicional2.ReadOnly = true;
            this.idAdicional2.Visible = false;
            // 
            // excluir
            // 
            this.excluir.HeaderText = "Excluir";
            this.excluir.Name = "excluir";
            this.excluir.ReadOnly = true;
            this.excluir.Text = "Excluir";
            this.excluir.UseColumnTextForButtonValue = true;
            // 
            // tabEstoque
            // 
            this.tabEstoque.Controls.Add(this.groupBox1);
            this.tabEstoque.Controls.Add(this.dataGridViewEstoque);
            this.tabEstoque.Controls.Add(this.gBoxRecarregar);
            this.tabEstoque.Location = new System.Drawing.Point(4, 29);
            this.tabEstoque.Name = "tabEstoque";
            this.tabEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstoque.Size = new System.Drawing.Size(972, 611);
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
            this.groupBox1.Location = new System.Drawing.Point(19, 441);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(673, 146);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar novo item";
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(517, 95);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(118, 37);
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
            this.txtaMaximaNovo.Size = new System.Drawing.Size(174, 26);
            this.txtaMaximaNovo.TabIndex = 4;
            this.txtaMaximaNovo.Text = "0";
            // 
            // txtQuantidadeProdutoNovo
            // 
            this.txtQuantidadeProdutoNovo.Location = new System.Drawing.Point(16, 106);
            this.txtQuantidadeProdutoNovo.Name = "txtQuantidadeProdutoNovo";
            this.txtQuantidadeProdutoNovo.Size = new System.Drawing.Size(211, 26);
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
            this.txtNomeProdutoNovo.Size = new System.Drawing.Size(619, 26);
            this.txtNomeProdutoNovo.TabIndex = 0;
            // 
            // dataGridViewEstoque
            // 
            this.dataGridViewEstoque.AllowUserToAddRows = false;
            this.dataGridViewEstoque.AllowUserToDeleteRows = false;
            this.dataGridViewEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEstoque.Location = new System.Drawing.Point(9, 7);
            this.dataGridViewEstoque.Name = "dataGridViewEstoque";
            this.dataGridViewEstoque.ReadOnly = true;
            this.dataGridViewEstoque.RowHeadersVisible = false;
            this.dataGridViewEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEstoque.Size = new System.Drawing.Size(944, 312);
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
            this.gBoxRecarregar.Location = new System.Drawing.Point(9, 325);
            this.gBoxRecarregar.Name = "gBoxRecarregar";
            this.gBoxRecarregar.Size = new System.Drawing.Size(944, 97);
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
            this.maximo.Size = new System.Drawing.Size(19, 20);
            this.maximo.TabIndex = 7;
            this.maximo.Text = "0";
            this.maximo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(706, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "g";
            // 
            // lblQuantidadeRecarregada
            // 
            this.lblQuantidadeRecarregada.AutoSize = true;
            this.lblQuantidadeRecarregada.ForeColor = System.Drawing.Color.DarkRed;
            this.lblQuantidadeRecarregada.Location = new System.Drawing.Point(664, 59);
            this.lblQuantidadeRecarregada.Name = "lblQuantidadeRecarregada";
            this.lblQuantidadeRecarregada.Size = new System.Drawing.Size(19, 20);
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
            this.panel1.Size = new System.Drawing.Size(496, 43);
            this.panel1.TabIndex = 5;
            // 
            // btnSimulacao
            // 
            this.btnSimulacao.Location = new System.Drawing.Point(405, 11);
            this.btnSimulacao.Name = "btnSimulacao";
            this.btnSimulacao.Size = new System.Drawing.Size(75, 29);
            this.btnSimulacao.TabIndex = 5;
            this.btnSimulacao.Text = "Simular";
            this.btnSimulacao.UseVisualStyleBackColor = true;
            this.btnSimulacao.Click += new System.EventHandler(this.btnSimulacao_Click);
            // 
            // txtSimulacao
            // 
            this.txtSimulacao.Location = new System.Drawing.Point(21, 9);
            this.txtSimulacao.Name = "txtSimulacao";
            this.txtSimulacao.Size = new System.Drawing.Size(272, 26);
            this.txtSimulacao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "gramas";
            // 
            // btnRecarregar
            // 
            this.btnRecarregar.Location = new System.Drawing.Point(792, 68);
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
            this.lblProduto.Size = new System.Drawing.Size(71, 20);
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
            this.progressProduto.Size = new System.Drawing.Size(806, 18);
            this.progressProduto.Step = 1;
            this.progressProduto.TabIndex = 0;
            // 
            // tabFaturamento
            // 
            this.tabFaturamento.Controls.Add(this.panel2);
            this.tabFaturamento.Controls.Add(this.dataGridView_vendas);
            this.tabFaturamento.Location = new System.Drawing.Point(4, 29);
            this.tabFaturamento.Name = "tabFaturamento";
            this.tabFaturamento.Padding = new System.Windows.Forms.Padding(3);
            this.tabFaturamento.Size = new System.Drawing.Size(972, 611);
            this.tabFaturamento.TabIndex = 2;
            this.tabFaturamento.Text = "Faturamento";
            this.tabFaturamento.UseVisualStyleBackColor = true;
            this.tabFaturamento.Enter += new System.EventHandler(this.tabFaturamento_Enter);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dateTimePicker_INICIO);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.dateTimePicker_FIM);
            this.panel2.Location = new System.Drawing.Point(29, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(921, 110);
            this.panel2.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(447, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "a";
            // 
            // dateTimePicker_INICIO
            // 
            this.dateTimePicker_INICIO.Location = new System.Drawing.Point(7, 28);
            this.dateTimePicker_INICIO.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_INICIO.MinDate = new System.DateTime(2021, 4, 14, 0, 0, 0, 0);
            this.dateTimePicker_INICIO.Name = "dateTimePicker_INICIO";
            this.dateTimePicker_INICIO.Size = new System.Drawing.Size(397, 26);
            this.dateTimePicker_INICIO.TabIndex = 2;
            this.dateTimePicker_INICIO.Value = new System.DateTime(2021, 4, 15, 0, 0, 0, 0);
            this.dateTimePicker_INICIO.ValueChanged += new System.EventHandler(this.dateTimePicker_INICIO_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(511, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Fim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Inicio";
            // 
            // dateTimePicker_FIM
            // 
            this.dateTimePicker_FIM.Location = new System.Drawing.Point(502, 28);
            this.dateTimePicker_FIM.Name = "dateTimePicker_FIM";
            this.dateTimePicker_FIM.Size = new System.Drawing.Size(392, 26);
            this.dateTimePicker_FIM.TabIndex = 3;
            this.dateTimePicker_FIM.Value = new System.DateTime(2021, 4, 15, 0, 0, 0, 0);
            this.dateTimePicker_FIM.ValueChanged += new System.EventHandler(this.dateTimePicker_FIM_ValueChanged);
            // 
            // dataGridView_vendas
            // 
            this.dataGridView_vendas.AllowUserToAddRows = false;
            this.dataGridView_vendas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.BlueViolet;
            this.dataGridView_vendas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView_vendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_vendas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView_vendas.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView_vendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_vendas.Location = new System.Drawing.Point(29, 146);
            this.dataGridView_vendas.Name = "dataGridView_vendas";
            this.dataGridView_vendas.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.BlueViolet;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_vendas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView_vendas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_vendas.Size = new System.Drawing.Size(921, 448);
            this.dataGridView_vendas.TabIndex = 0;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1004, 659);
            this.Controls.Add(this.tabVenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.tabFaturamento.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_vendas)).EndInit();
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
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblValorTotal2;
        private System.Windows.Forms.Button btnVenda;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanho;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn adicional1;
        private System.Windows.Forms.DataGridViewTextBoxColumn adicional2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdicional1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAdicional2;
        private System.Windows.Forms.DataGridViewButtonColumn excluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker_INICIO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FIM;
        private System.Windows.Forms.DataGridView dataGridView_vendas;
    }
}

