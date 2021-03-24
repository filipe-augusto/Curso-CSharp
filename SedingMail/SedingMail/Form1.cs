using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SedingMail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {


            using(MailMessage mail = new MailMessage())
            {
                try
                {
                    mail.From = new MailAddress("augusto.2021.pix@gmail.com");
                    mail.To.Add("filipe@mxlog.com.br");
                    mail.Subject = "teste seding mail";
                    mail.Body = CorpoEmailAitorizacao_Contrato();
                    mail.IsBodyHtml = true;
                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("augusto.2021.pix@gmail.com", "pix@2021");
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                        label1.Text = "Mail Sent";
                    }
                }
                catch (Exception x)
                {
                    label1.Text = x.Message + x;
                    MessageBox.Show(x.ToString());
                }
            }
        }


        private void btnMail2_Click(object sender, EventArgs e)
        {
            Mail2 f = new Mail2();
            f.ShowDialog();
        }
        private string CorpoEmailAitorizacao_Contrato()
        {
            StringBuilder corpoEmail = new StringBuilder();
            // MessageBox.Show(Nome_cliente + "c: " + CodRelacao + "dI: " + Data_ini + "dT: " + dataTermino);

            corpoEmail.AppendLine("<html>");
            corpoEmail.AppendLine("<head>");
            corpoEmail.AppendLine("<title>Mxlog</title>");
            corpoEmail.Append("<meta charset=\"UTF - 8\">");
            corpoEmail.AppendLine(" <style>");
            corpoEmail.AppendLine("table {font-family: arial, sans-serif;border-collapse: collapse;width: 100%;}");
            corpoEmail.AppendLine("th{background-color:rgb(0, 61, 85);color: white;}");
            corpoEmail.AppendLine(".mxtd, th {border: 1px solid #dddddd;text-align: left;padding: 8px;}");
            corpoEmail.Append("tr:nth-child(even) {background-color: #dddddd;}");
            corpoEmail.AppendLine(" </style>");

            corpoEmail.AppendLine("</head>");
            corpoEmail.AppendLine("<form method =\"post\" action =\"./Autorizacao_Faturamento.aspx\" id =\"form1\">");
            corpoEmail.AppendLine("<div class=\"aspNetHidden\"><input id= \"__VIEWSTATE\" name=\"__VIEWSTATE\" type=\"hidden\" value=\"xjtKMyARrlZVNWQzLVjqmXr+RJ06wphNuWCrDA1cSyFZMvs5SFYR65nC7+DZynF+SouJzgwQT42ERKBLsLd3AEWDzkE1hw7C7ByAR1+mWnRxDryXClDHKJogHmtuVNO1gAyG2a2WEdwNt/WYT4d8qu1NLumlc5byJUUnjhxAlaY=\"/></div>");
            corpoEmail.AppendLine("<div class=\"aspNetHidden\"><input id= \"__VIEWSTATEGENERATOR\" name=\"__VIEWSTATEGENERATOR\" type=\"hidden\" value=\"882D977E\"/> <input id=\"__EVENTVALIDATION\" name=\"__EVENTVALIDATION\" type=\"hidden\" value=\"QdN/zYwtPnEeZOxD2usWE0FyY8S8QJHngrTnVgxCTZ8rA82qWUQuLEhci77A3umurw0Kt8S3YhhKAZvSCSAq/CRAYadMFfSh8IyLPeurvDo7JfoyIi9lF2hW7uoxqHcxwKrRRajOckTs0aU297jojA==\"/></div>");
            corpoEmail.AppendLine("<table class=\"content\" style=\"border-collapse: collapse; width: 550; max-width: 600px;\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" align=\"center\">");
            corpoEmail.AppendLine("<tbody>");
            corpoEmail.AppendLine("<tr style= \"height: 15px;\">");
            corpoEmail.AppendLine("<td style= \"padding: 10px; color: #ffffff; font-family: Arial, sans-serif; font-size: 36px; font-weight: bold; height: 15px;\" align=\"center\" bgcolor=\"#003d55\"><img style = \"display: block;\" src=\"https://www.mxlog.com.br/assets/img/logo_mxlog_inverso_alpha.png\" alt=\"Logo\" width=\"240\"/></td>");
            corpoEmail.AppendLine("</tr>");
            corpoEmail.AppendLine("<tr style= \"height: 4px;\">");
            corpoEmail.AppendLine("<td style=\"padding: 10px; color: #555555; font-family: Arial, sans-serif; font-size: 20px; line-height: 30px; border-bottom: 1px solid #f6f6f6; height: 4px; text-align: center;\" align=\"center\" bgcolor=\"#ffffff\">");
            corpoEmail.AppendLine("<p style = \"text-align: center;\">Autoriza&ccedil;&atilde;o de Faturamento</p>");
           //tabela
            corpoEmail.AppendLine("<table>");
            corpoEmail.AppendLine("<caption>Itens da Nota Fiscal</caption>");
            corpoEmail.AppendLine("<tr><th>Descrição</th><th>Valor</th></tr>");
            for (int i = 0; i < 3; i++)
            {
            corpoEmail.AppendLine($"<tr><td class=\"mxtd\">Moto dia  {i}</td><td class=\"mxtd\">R{i*2}</td></tr>");
            }
            corpoEmail.AppendLine("</table>");

            //fim tabela
            corpoEmail.AppendLine("<p style = \"text-align: center; font-size: 10px;\">");
            if (DateTime.Now.Hour >= 12)
            {
            corpoEmail.AppendLine("Boa Tarde, <strong>@CLIENTE</strong>");
            }
            else
            {
            corpoEmail.AppendLine("Bom Dia, <strong>@CLIENTE</strong> ");
            }
            corpoEmail.AppendLine("</p>");

            corpoEmail.AppendLine("<p style = \"text - align: center; font - size: 10px; \">");
            
            corpoEmail.AppendLine("Segue valores do serviço de contrato para aprovação do faturamento do per&iacute;odo @DT_INICIO a @DT_TERMINO </p>");
            corpoEmail.AppendLine("</tr>");
            corpoEmail.AppendLine("<tr style =\"height: 8.23334px;\">");
            corpoEmail.AppendLine("<td style =\"padding: 15px 10px; color: #555555; font-family: Arial, sans-serif; font-size: 12px; line-height: 18px; height: 8.23334px; width: 57px;\" align =\"center\" bgcolor =\"#e6e9eb\">");
            corpoEmail.AppendLine("<p><strong>Verifique as informa&ccedil;&otilde;es do anexo e aprove seu faturamento.</strong></p>");
            corpoEmail.AppendLine("<p><strong>*Caso precise enviar informa&ccedil;&otilde;es adicionais como documentos, numeros de pedido, ou informa&ccedil;&otilde;es que sejam primordiais para o faturamento, clique em \"Enviar informa&ccedil;&otilde;es\" e posteriormente, aprove o faturamento.<br/></strong></p>");
            corpoEmail.AppendLine("</td>");
            corpoEmail.AppendLine("</tr>");
            corpoEmail.AppendLine("<tr style =\"height: 8.23334px;\">");
            corpoEmail.AppendLine("<td style =\"padding: 10px; color: #555555; font-family: Arial, sans-serif; font-size: 12px; line-height: 18px; height: 8.23334px;\" align =\"center\" bgcolor =\"#ffffff\">");
            corpoEmail.AppendLine("<table style =\"height: 75px; width: 487px;\">");
            corpoEmail.AppendLine("<tbody>");
            corpoEmail.AppendLine("<tr style =\"height: 6px;\">");
            corpoEmail.AppendLine("<td style =\"text-align: center; width: 173; height: 6;\" align =\"center\" bgcolor =\"#003d55\"><strong><a style =\"color: #ffffff; text-align: center; text-decoration: none;\" href =\"https://www.mxlog.com.br/Autorizacao_Faturamento.aspx?Cod_Relacao=@CodRelacao\">Aprovar</a></strong></td>");
            corpoEmail.AppendLine("<td style =\"width: 108; height: 6;\">&nbsp;</td>");
            corpoEmail.AppendLine("<td style =\"text-align: center; width: 181; height: 6;\" align =\"center\" bgcolor =\"#e0a309\">");
            corpoEmail.AppendLine("<p><strong><a style =\"color: #ffffff; text-align: center; text-decoration: none;\"href=\"mailto:financeiro@mxlog.com.br?cc=adm@mxlog.com.br&subject=Informacoes Adicionais - @CLIENTE \">Enviar Informa&ccedil;&otilde;es</a></strong></p>");
            corpoEmail.AppendLine("</td>");
            corpoEmail.AppendLine("</tr>");
            corpoEmail.AppendLine("</tbody>");
            corpoEmail.AppendLine("</table>");
            corpoEmail.AppendLine("</td>");
            corpoEmail.AppendLine("</tr>");
            corpoEmail.AppendLine("<tr style =\"height: 8.23334px;\">");
            corpoEmail.AppendLine("<td style =\"padding: 15px 10px; color: #555555; font-family: Arial, sans-serif; font-size: 12px; line-height: 18px; height: 8.23334px;\" align=\"center\" bgcolor=\"#dddddd\">");
            corpoEmail.AppendLine("<p><strong> MXLOG SERVI&Ccedil;OS DE LOG&Iacute;STICA</strong><br/>Departamento Financeiro: Tel: 5069-5252. Email: financeiro@mxlog.com.br</p>");
            corpoEmail.AppendLine("</td>");
            corpoEmail.AppendLine("</tr>");
            corpoEmail.AppendLine("</tbody>");
            corpoEmail.AppendLine("</table>");
            corpoEmail.AppendLine("</form>");

            corpoEmail.AppendLine("</body>");
            corpoEmail.AppendLine("</html>");

            corpoEmail.Replace("@CLIENTE", "Filipe Augusto");
            corpoEmail.Replace("@CodRelacao", "00065233879");
            corpoEmail.Replace("@DT_INICIO", "04/04/2021");
            corpoEmail.Replace("@DT_TERMINO", "05/04/2014");
            // corpoEmail.Replace("@mes", mes_autorizacao);
            return corpoEmail.ToString();

        }


    }
}
