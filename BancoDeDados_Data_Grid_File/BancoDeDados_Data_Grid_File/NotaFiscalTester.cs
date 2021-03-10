using BancoDeDados_Data_Grid_File.ServiceWeb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeDados_Data_Grid_File
{
    public partial class NotaFiscalTester : Form
    {
        public NotaFiscalTester()
        {
            InitializeComponent();
            carregaGrid();
        }
        string stringconect = "Data Source=192.168.0.253;Initial Catalog=FATURAMENTO_UPDATE;Timeout=100;Persist Security Info=True;User ID=sa; password=m2y6bvMEkls;";
        private IDbConnection AbrirConexao()
        {
            return new SqlConnection(stringconect);
        }

        public DataTable BuscaDadosNFe()
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
                string query = "SELECT  TOP 7 [N_Dsc_CodigoLancto],[N_Dsc_NotaFiscal],[N_Dsc_NFe],[S_Dsc_NomeFantasia],[N_Dsc_ValorNotaFiscal] " +
                    " from [TBL_NotaFiscalFaturamento] ORDER BY N_Dsc_CodigoLancto DESC ";
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, stringconect);
                adaptador.Fill(dados);
                return dados;
            }
        }

        public void carregaGrid()
        {
            try
            {
                gridLista.Rows.Clear();
                foreach (DataRow linha in BuscaDadosNFe().Rows)
                {
                       gridLista.Rows.Add(linha[0], linha[1], linha[2], linha[3], linha[4], "Emitir");//insere a linha na datagriw
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }       
        private void dataGridViewLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int codigoLanc = Convert.ToInt32(gridLista.Rows[e.RowIndex].Cells["codigo"].Value.ToString());
            if (gridLista.Columns[e.ColumnIndex] == gridLista.Columns["emitir"])
            {
                if (MessageBox.Show($"Confirma a emissão  ?",
                                           "Excluir arquivo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("enviado! ");
                    //excluirBanco(id);
                    nfe_Emitir(codigoLanc);
                }
            }
        }

        public DataTable selectNFe(int codigoLanc)
        {
            using (var conexao = AbrirConexao())
            {
                conexao.Open();
               // string query = "SELECT * FROM VIEW_NFE_METROPOLE WHERE Codigo = " + 63722;
               string query = "SELECT NFE.N_Dsc_CodigoLancto, " +
                    "NFE.N_Dsc_AliquotaISS, " +
                    "NFE.S_Dsc_CodigoServico," +
                    " NFE.S_Dsc_CnpjClienteTomador," +
                    " NFE.N_Dsc_IndicadorCnpjCpf," +
                    " NFF.S_Dsc_Email," +
                     " NFF.S_Dsc_Bairro," +
                     " NFF.S_DSc_CEP, " +
                     " NFF.S_Dsc_Cidade, " +
                     " NFF.S_Dsc_Uf, " +
                     " NFF.S_Dsc_NumeroLogradouro," +
                     " NFF.S_Dsc_Ccm, " +
                     " NFF.S_Dsc_RazaoSocial," +
                     " NFF.S_Dsc_FoneContato, " +
                     " NFF.N_Dsc_ValorNotaFiscal, " +
                     " NFF.N_Dsc_ValorCSLL," +
                     " NFF.N_Dsc_ValorCofins, " +
                     " NFF.N_Dsc_ValorBaseINSS, " +
                     " NFF.N_Dsc_ValorIR," +
                     " NFF.N_Dsc_ValorPis " +
                     " FROM TBL_NotaFiscalFaturamento AS NFF " +
                     " INNER JOIN TBL_NFEletronica AS NFE ON " +
                     " NFF.[N_Dsc_CodigoLancto] = NFE.N_Dsc_CodigoLancto " +
                     " WHERE NFE.N_Dsc_CodigoLancto =" + 63722;
             //   MessageBox.Show(query);
                DataTable dados = new DataTable();
                SqlDataAdapter adaptador = new SqlDataAdapter(query, stringconect);
                adaptador.Fill(dados);
                return dados;
            }
            }

            public void nfe_Emitir(int codigoLanc)
        {
            try
            {
                DataTable dadosNFE = selectNFe(codigoLanc);

                MessageBox.Show(Convert.ToString(dadosNFE.Rows[0][3])+"-"+ Convert.ToString(dadosNFE.Rows[0][7]));
                var request = new EmissaoNotaFiscalRequest();

             
                using (var servico = new NotaFiscalEletronicaServicoClient())
                {
                    string atividade = Convert.ToString(dadosNFE.Rows[0][2]);
                    //request.NotaFiscal.Aliquota = Convert.ToDecimal(dadosNFE.Rows[0][1]);
                    request.NotaFiscal.Atividade = atividade;//-----------------
                    request.NotaFiscal.CEPPrestacaoServico = "06243-130";
                    //    request.NotaFiscal.ChaveAutenticacao = 'chave'; //----------------------
                    request.NotaFiscal.CidadePrestacaoServico = "Osasco";
                    // request.NotaFiscal.CodObra = //PARA OBRA
                    request.NotaFiscal.DataRecibo = DateTime.Now;
                    request.NotaFiscal.EnderecoPrestacaoServico = "Rua Bel Jardim,  43";
                    //  request.NotaFiscal.EqptoRecibo = ""; //-------------------------
                    request.NotaFiscal.EstadoPrestacaoServico = "SP";
                    request.NotaFiscal.Homologacao = true;//true para teste
                    request.NotaFiscal.InformacoesAdicionais = "";//--------------------
                    request.NotaFiscal.NotificarTomadorPorEmail = false; //nao, caso nao deseja enviar link da nota
                                                                         // request.NotaFiscal.SubstituicaoTributaria = false;  //-------------------
                    request.NotaFiscal.SemIncidenciaISS = false; //true para estrangeiro      
                                                                 // request.NotaFiscal.SimplesNacional = true; //true para simples nacional -----------------
                    request.NotaFiscal.SubstituicaoTributaria = false; ///-----------
                    request.NotaFiscal.Tomador.CNPJ = Convert.ToString(dadosNFE.Rows[0][3]);
                    request.NotaFiscal.Tomador.CPF = Convert.ToString(dadosNFE.Rows[0][4]);
                    request.NotaFiscal.Tomador.DDD = "11";
                    request.NotaFiscal.Tomador.Email = Convert.ToString(dadosNFE.Rows[0][5]);
                    request.NotaFiscal.Tomador.Endereco.Bairro = Convert.ToString(dadosNFE.Rows[0][6]);
                    request.NotaFiscal.Tomador.Endereco.CEP = Convert.ToString(dadosNFE.Rows[0][7]);
                    request.NotaFiscal.Tomador.Endereco.Cidade = Convert.ToString(dadosNFE.Rows[0][8]);
                    //request.NotaFiscal.Tomador.Endereco.Complemento = "nao tem";
                    request.NotaFiscal.Tomador.Endereco.Estado = Convert.ToString(dadosNFE.Rows[0][9]);             //  request.NotaFiscal.Tomador.Endereco.Logradouro  = nfe.TipoLogradouro;
                    request.NotaFiscal.Tomador.Endereco.Numero = Convert.ToString(dadosNFE.Rows[0][10]);
                    request.NotaFiscal.Tomador.Endereco.Pais = "Brasil";
                    //request.NotaFiscal.Tomador.Endereco.TipoLogradouro = nfe.TipoLogradouro;
                    request.NotaFiscal.Tomador.InscricaoMunicipal = Convert.ToString(dadosNFE.Rows[0][11]); // 10
                    request.NotaFiscal.Tomador.Nome = Convert.ToString(dadosNFE.Rows[0][12]);
                    request.NotaFiscal.Tomador.Telefone = Convert.ToString(dadosNFE.Rows[0][13]);
                    request.NotaFiscal.TomadorEstrangeiro = false; //tre caso seja estrangeiro
                    request.NotaFiscal.Valor = Convert.ToDecimal(dadosNFE.Rows[0][14]);
                    request.NotaFiscal.ValorCSLL = Convert.ToDecimal(dadosNFE.Rows[0][15]);
                    request.NotaFiscal.ValorCofins = Convert.ToDecimal(dadosNFE.Rows[0][16]); //   15
                    request.NotaFiscal.ValorINSS = Convert.ToDecimal(dadosNFE.Rows[0][17]);
                    request.NotaFiscal.ValorIR = Convert.ToDecimal(dadosNFE.Rows[0][18]);
                    // request.NotaFiscal.ValorOutrosImpostos = nfe.valor
                    request.NotaFiscal.ValorPisPasep = Convert.ToDecimal(dadosNFE.Rows[0][19]);
                    // request.NotaFiscal.ValorRepasse = nfe.repasse

                    var response = servico.Emitir(request);
                    if (response.Erro)
                    {
                        MessageBox.Show(response.MensagemErro);
                    }
                    else
                    {
                        MessageBox.Show(
                        string.Format("O número da nota gerada é: {0}",
                        response.NotaFiscalGerada.Numero));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao emitir a nota : " + ex.Message);
            }
        }

        private void NotaFiscalTester_Load(object sender, EventArgs e)
        {

        }
    }
    }

