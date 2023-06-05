using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosProva.cs
{
    public  class Principal
    {
        public static void Main()
        {
            int opcao;
            do 
            { 
           
              Console.WriteLine("========================================== ");
              Console.WriteLine("|Exercicio (1) Lanchonete                 |");
              Console.WriteLine("|Exercicio (2) Salario dos Professores    |");
              Console.WriteLine("|Exercicio (3) Aluno aprovado ou reprovado|");
              Console.WriteLine("|Sair      (0)                            |");
              Console.WriteLine("========================================== ");
              Console.WriteLine("Escolha uma Opção:");
              opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Cardapio obj1 = new Cardapio();
                        obj1.escolher();

                        break;
                    case 2:
                        PagamentoProf obj2 = new PagamentoProf();
                        obj2.pagamento();
                        break;
                    case 3:
                        Notas obj3 = new Notas();
                        obj3.notaAlunos();
                        break;
                    case 0:
                        Console.WriteLine("Sair do programa");
                        break;
                    default:
                        Console.WriteLine("Opção Invalida!");
                        break;
                }
                

            }while (opcao != 0) ;
            


        }

            

        
        
    }
}
