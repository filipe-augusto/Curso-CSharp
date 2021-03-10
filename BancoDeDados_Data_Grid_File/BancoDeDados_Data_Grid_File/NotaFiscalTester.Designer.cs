
namespace BancoDeDados_Data_Grid_File
{
    partial class NotaFiscalTester
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
            this.components = new System.ComponentModel.Container();
            this.gridLista = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notafiscal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nfe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emitir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.fATURAMENTO_UPDATEDataSet = new BancoDeDados_Data_Grid_File.FATURAMENTO_UPDATEDataSet();
            this.fATURAMENTOUPDATEDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fATURAMENTO_UPDATEDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fATURAMENTOUPDATEDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridLista
            // 
            this.gridLista.AccessibleRole = System.Windows.Forms.AccessibleRole.Document;
            this.gridLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLista.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gridLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.notafiscal,
            this.nfe,
            this.nome,
            this.valor,
            this.emitir});
            this.gridLista.Location = new System.Drawing.Point(12, 3);
            this.gridLista.Name = "gridLista";
            this.gridLista.Size = new System.Drawing.Size(776, 396);
            this.gridLista.TabIndex = 0;
            this.gridLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLista_CellContentClick);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codigo.Frozen = true;
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.Width = 121;
            // 
            // notafiscal
            // 
            this.notafiscal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.notafiscal.Frozen = true;
            this.notafiscal.HeaderText = "NOTAFISCAL";
            this.notafiscal.Name = "notafiscal";
            this.notafiscal.Width = 121;
            // 
            // nfe
            // 
            this.nfe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nfe.Frozen = true;
            this.nfe.HeaderText = "NFE";
            this.nfe.Name = "nfe";
            this.nfe.Width = 121;
            // 
            // nome
            // 
            this.nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nome.Frozen = true;
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            this.nome.Width = 121;
            // 
            // valor
            // 
            this.valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.valor.Frozen = true;
            this.valor.HeaderText = "VALOR";
            this.valor.Name = "valor";
            this.valor.Width = 121;
            // 
            // emitir
            // 
            this.emitir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emitir.HeaderText = "emitir";
            this.emitir.Name = "emitir";
            // 
            // fATURAMENTO_UPDATEDataSet
            // 
            this.fATURAMENTO_UPDATEDataSet.DataSetName = "FATURAMENTO_UPDATEDataSet";
            this.fATURAMENTO_UPDATEDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fATURAMENTOUPDATEDataSetBindingSource
            // 
            this.fATURAMENTOUPDATEDataSetBindingSource.DataSource = this.fATURAMENTO_UPDATEDataSet;
            this.fATURAMENTOUPDATEDataSetBindingSource.Position = 0;
            // 
            // NotaFiscalTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 411);
            this.Controls.Add(this.gridLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NotaFiscalTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NotaFiscalTester";
            this.Load += new System.EventHandler(this.NotaFiscalTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fATURAMENTO_UPDATEDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fATURAMENTOUPDATEDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridLista;
        private System.Windows.Forms.BindingSource fATURAMENTOUPDATEDataSetBindingSource;
        private FATURAMENTO_UPDATEDataSet fATURAMENTO_UPDATEDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn notafiscal;
        private System.Windows.Forms.DataGridViewTextBoxColumn nfe;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewButtonColumn emitir;
    }
}