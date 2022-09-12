using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");
            Console.Clear();

            //ARRAY
            #region   ARRAY  
/*             var meuArray = new int[5]{1,2,3,4,5};
            Console.WriteLine(meuArray[0]);
             Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
             Console.WriteLine(meuArray[3]);
            Console.WriteLine(meuArray[4]); */
            #endregion
          //  var meuArray = new int [5]{1,2,3,4,5};
     //   meuArray[0] = 12;
       #region percorrendo com for e foreach
     //   Console.WriteLine("posicoes " + meuArray.Length);
  /*       for(var index = 0; index < meuArray.Length; index++){
            Console.WriteLine(meuArray[index]);
        } */
  /*       foreach( var item in meuArray){
            Console.WriteLine(item);
        } */
       #endregion
   
            var arr = new int[4];
            var arrb = arr; //só a referencia do endereço. nao é outro array
            
            arr[0] = 23;

            Console.WriteLine(arrb[0]);
       
        }
    }
}
