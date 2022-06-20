using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)


        {
            try
            {
                ContaCorrente conta = new ContaCorrente(0, 0);

                //Console.WriteLine(ContaCorrente.TaxaOperacao);

                Console.ReadLine();

            }catch(ArgumentException ex){
                Console.WriteLine("Erro no paramentro: "+ex.ParamName);
                Console.WriteLine(ex.Message);
                //Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
                

                Console.ReadLine();

            }
        }
        
    }
}
