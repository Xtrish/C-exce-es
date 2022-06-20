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
                ContaCorrente conta = new ContaCorrente(8541, 23652);
                conta.Depositar(50);
                Console.WriteLine(conta.Saldo);
                conta.Sacar(500);
                Console.WriteLine(conta.Saldo);
               

                //Console.WriteLine(ContaCorrente.TaxaOperacao);

                Console.ReadLine();

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro no paramentro: " + ex.ParamName);
                Console.WriteLine(ex.Message);
                //Console.WriteLine("Ocorreu um erro do tipo ArgumentException");              
                
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Exceção do tipo SaldoInsuficienteException");
            }
            Console.ReadLine();
        }
        
    }
}
