using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosProva.cs
{
    public class Cardapio
    {
        public void escolher()
        {

            double qt, total;
            int opcao;
            Console.WriteLine("=================================");
            Console.WriteLine("|(100)|Cachorro quente|R$ 1,10   |");
            Console.WriteLine("|(101)|Bauru Simples  |R$ 1,30   |");
            Console.WriteLine("|(102)|Bauru c/ovo    |R$ 1,50   |");
            Console.WriteLine("|(103)|Hamburguer     |R$ 1,10   |");
            Console.WriteLine("|(104)|Cheeseburguer  |R$ 1,30   |");
            Console.WriteLine("|(105)|Refrigerante   |R$ 1,0    |");
            Console.WriteLine("=================================");
            Console.WriteLine("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 100:
                    Console.WriteLine("Qual a quantidade?");
                    qt = double.Parse(Console.ReadLine());


                    total = qt * 1.10;
                    Console.WriteLine("Total a pagar " + total.ToString("F2"));


                    break;
                case 101:
                    Console.WriteLine("Qual a quantidade?");
                    qt = double.Parse(Console.ReadLine());
                    total = qt * 1.30;
                    Console.WriteLine("Total a pagar " + total.ToString("F2"));
                    break;
                case 102:
                    Console.WriteLine("Qual a quantidade?");
                    qt = double.Parse(Console.ReadLine());
                    total = qt * 1.50;
                    Console.WriteLine("Total a pagar " + total.ToString("F2"));
                    break;
                case 103:
                    Console.WriteLine("Qual a quantidade?");
                    qt = double.Parse(Console.ReadLine());
                    total = qt * 1.10;
                    Console.WriteLine("Total a pagar " + total.ToString("F2"));
                    break;
                case 104:
                    Console.WriteLine("Qual a quantidade?");
                    qt = double.Parse(Console.ReadLine());
                    total = qt * 1.30;
                    Console.WriteLine("Total a pagar " + total.ToString("F2"));
                    break;
                case 105:
                    Console.WriteLine("Qual a quantidade?");
                    qt = double.Parse(Console.ReadLine());
                    total = qt * 1.10;
                    Console.WriteLine("Total a pagar " + total.ToString("F2"));
                    break;
                default:



                    Console.WriteLine("Opcao invalida!");



                    break;

            }
        }
    }
}
