using System;
using System.Globalization;

namespace datas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data = DateTime.Now;
            #region  Formatacao de data
            /*           var formatada = string.Format("{0:dd/MM/yyyy HH:mm ff}",data);
                      Console.WriteLine(formatada); */
            //FORMATANDO DATAS
            //y Y - ano  string.Format("{0:y}",data); string.Format("{0:yy}",data); string.Format("{0:yyyy}",data);
            //M Mes ("{0:MM}",data); ("{0:M}",data);
            //d - dia  string.Format("{0:d}",data)
            //H - hora 
            //s - Segundo
            //- m minuto
            #endregion
            #region formatacao pronta
            // var formatada = string.Format("{0:g}", data);
            // 16:33 ("{0:t}", data) 
            //22/03/2022  ("{0:d}", data)
            //16:34:36 ("{0:T}", data)
            //terça-feira, 22 de março de 2022 ("{0:D}", data);
            //terça-feira, 22 de março de 2022 16:35  ("{0:f}", data);
            //22/03/2022 16:36 ("{0:g}", data);
            // Console.WriteLine(formatada);
            #endregion

            #region CultureInfo
            var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;
            Console.WriteLine(DateTime.Now.ToString("D", pt));
            Console.WriteLine(DateTime.Now.ToString("D", br));
            Console.WriteLine(DateTime.Now.ToString("D", en));
            Console.WriteLine(DateTime.Now.ToString("D", de));
            Console.WriteLine(DateTime.Now.ToString("D", atual));
            #endregion

        }
    }
}
