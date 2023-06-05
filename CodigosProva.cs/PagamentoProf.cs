using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosProva.cs
{
    public class PagamentoProf
    {
       public void pagamento()
        {
            int opcao;
            double total, horas;

            Console.WriteLine("Nivel (1) ");
            Console.WriteLine("Nivel (2) ");
            Console.WriteLine("nivel (3) ");
            Console.WriteLine("Escolha um Nivel:");
            opcao =int.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1:
                    Console.WriteLine("Informe a quantidade de horas trabalhadas?");
                    horas = double.Parse(Console.ReadLine());
                    total = horas * 12.00*5.25;
                    Console.WriteLine("Valor a ser pago:" + total);

                    break;
                case 2:
                    Console.WriteLine("Informe a quantidade de horas trabalhadas?");
                    horas = double.Parse(Console.ReadLine());
                    total = horas * 17.00*5.25;
                    Console.WriteLine("Valor a ser pago:" + total);
                    break;
                case 3:
                    Console.WriteLine("Informe a quantidade de horas trabalhadas?");
                    horas = double.Parse(Console.ReadLine());
                    total = horas * 25.00*5.25;
                    Console.WriteLine("Valor a ser pago:" + total);

                    break;
                default:
                    Console.WriteLine("Opcao Invalida!");
                    break;
            }



        }
        
    }

   

}
