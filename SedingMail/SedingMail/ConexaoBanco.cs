using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedingMail
{
    class ConexaoBanco
    {
        static string strConection = @"Data Source=FILIPE-HPRPE60;Initial Catalog=PrimeiroBanco;Integrated Security=True";
        // string stringConectJob = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=treino;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        string stringConectJob = @"Data Source=TI-2021\SQLEXPRESS; Initial Catalog=treino; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private SqlConnection AbrirConexao()
        {
            return new SqlConnection(strConection);
        }
        public ArrayList BuscandoBanco()
        {
            DataSet dataset = new DataSet();
          //  Dictionary<string, double> items = new Dictionary<string, double>();
            ArrayList lista = new ArrayList();
            try
            {
            
                string cmdatasetQL = "SELECT * FROM itensFaturamento";
                using (SqlConnection con = new SqlConnection(strConection))
                {
                    using (SqlCommand cmd = new SqlCommand(cmdatasetQL, con))
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dataset);
                        foreach (DataRow dtrow in dataset.Tables[0].Rows)
                        {
                            lista.Add(dtrow);
                            //items.Add(dtrow.ItemArray[0].ToString(), (double)dtrow.ItemArray[1]);
                            //exibe os registros no listbox
                           // lstDataSetArrayList.Items.Add(dtrow.ItemArray[0] + " # " + dtrow.ItemArray[1] + " # " + dtrow.ItemArray[2]);
                        }
                    }
                }
           //     return lista;
            }catch (Exception e)
            {
                //throw e.Message;
            }
            return lista;
        }



    }
}
