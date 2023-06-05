using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigosProva.cs
{
    public class Notas
    {
        public void notaAlunos() 
        {
            int nota1,nota2,nota3,nota4;
            double soma, media;
            Console.WriteLine("Informe nota 1:");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe nota 2:");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe nota 3:");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe nota 4:");
            nota4 = int.Parse(Console.ReadLine());

            soma = nota1 + nota2 + nota3 + nota4;
            media = soma / 4;
            if (media >= 6)
            {
                Console.WriteLine("Parabens, aluno Aprovado!\n");
                Console.WriteLine("Resultado da média: " +media);

            }
            else
            {
                Console.WriteLine("Aluno Reprovado!\n");
                Console.WriteLine("Resultado da média: " + media);

            }



        }
        
    }
}
