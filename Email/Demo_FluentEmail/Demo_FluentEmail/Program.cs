using FluentEmail.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using FluentEmail.Core;

namespace Demo_FluentEmail
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Testando fluentEmail");
            Console.ReadKey();
            var sender = new SmtpSender(() => new SmtpClient("localhost")
            {
                EnableSsl = false,
                DeliveryFormat = (SmtpDeliveryFormat)SmtpDeliveryMethod.SpecifiedPickupDirectory, //forma de envio para uma pasta
                PickupDirectoryLocation = @"c:\Dados\Email"
            });
            Email.DefaultSender = sender;
            var email = await Email.From("faugusto.chaves@gmail.com")
                .To("f04a07s19c93@gmail.com")
                .Subject("FluentEmail - Testado...")
                .Body("Testando o fluentEmail")
                .SendAsync();
            if (email.Successful)
                Console.WriteLine("Email enviado com sucesso.");
            else
                Console.WriteLine("Falha ao enviar o email");
            Console.ReadKey();
        }
    }
}
