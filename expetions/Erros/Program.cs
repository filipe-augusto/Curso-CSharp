using System;

namespace Erros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        var arr = new int[3];
Console.Clear();
try{
/*         for(var index = 0; index < 10; index++){
            Console.WriteLine(arr[index]);

        } */
        Cadastrar("");
        
}catch(IndexOutOfRangeException ex){
   // Console.WriteLine(ex);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Não encontrei o indice");

}catch (ArgumentNullException ex){
    Console.WriteLine(ex.Message);   
}
/* catch(Exception ex){
Console.WriteLine(ex.Message);
 Console.WriteLine("Não encontrei o indice");
} */
        }
        static void Cadastrar(string texto){
            if(string.IsNullOrEmpty(texto)){
              //  throw new Exception("o texto não pode ser nulo ou vazio.");
              throw new MinhaExption(DateTime.Now);
            }
        }
}
public class MinhaExption : Exception{
    
    public MinhaExption(DateTime date){
        QuandoAconteceu = date;
    }
        public DateTime QuandoAconteceu { get; set; }
}
}
