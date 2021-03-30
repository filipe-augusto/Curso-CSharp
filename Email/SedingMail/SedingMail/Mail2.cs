using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
//using S22.Imap;


namespace SedingMail
{
    public partial class Mail2 : Form
    {
        static Mail2 f;
        public Mail2()
        {
            InitializeComponent();
            f = this;
        }



        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                var message = new MailMessage(txtMail.Text, txtRecipent.Text);
                message.Subject = txtSubject.Text;
                message.Body = txtBody.Text;

                using (SmtpClient mailer = new SmtpClient("smtp.mail.com", 587))
                {
                    mailer.Credentials = new NetworkCredential(txtMail.Text, txtPass.Text);
                    mailer.EnableSsl = true;
                    mailer.Send(message);
                }
                txtRecipent.Text = null;
                txtSubject.Text = null;
                txtBody.Text = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "-------------------------" +ex.Message);
            }

        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            //StartReceive();
        }

        //private void StartReceive()
        //{
        //    Task.Run(() =>
        //    {
        //        using (ImapClient client = new ImapClient("imap.gmail.com", 993, txtMail.Text,
        //            txtPass.Text, AuthMethod.Login, true))
        //        {
        //            if (client.Supports("IDLE") == false)
        //            {
        //                MessageBox.Show("Server does not support IMAP IDLE");
        //                return;
        //            }
        //            client.NewMessage += new EventHandler<IdleMessageEventArgs>(OnNotifyMessage);
        //            while (true) ;
        //        }
        //    });
        //}
        //static void OnNotifyMessage(object sender, IdleMessageEventArgs e)
        //{
        //    MessageBox.Show("New message received!");
        //    MailMessage m = e.Client.GetMessage(e.MessageUID, FetchOptions.Normal);
        //    f.Invoke((MethodInvoker)delegate
        //    {
        //        f.txtReceive.AppendText("From: " + m.From .DisplayName+ "\n"+
        //                                    "Subject: "+ m.Subject + "\n"+
        //                                    "Body: "+ m.Body + "\n");
        //    });
            
        //}
    }
}
