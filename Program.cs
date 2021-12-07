using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Informe a cotação do dolar: ");
                double dolar = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a cotação do euro: ");
                double euro = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe a cotação do ouro: ");
                double ouro = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor investido: ");
                double invest = double.Parse(Console.ReadLine());


                double invest_dol = invest / dolar;
                double invest_eur = invest / euro;
                double invest_ouro = invest / ouro;


                Console.WriteLine("Valor em dolar: " + invest_dol.ToString("C"));
                Console.WriteLine("Valor em euro: " + invest_eur.ToString("C"));
                Console.WriteLine("Peso ouro: " + invest_ouro);
            }

            catch(DivideByZeroException)
            {
                Console.WriteLine("N teste");
            }

            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }

            finally
            {
                Console.WriteLine("Fim da execução");
            }
            

            Console.ReadKey();

        }
    }
}
