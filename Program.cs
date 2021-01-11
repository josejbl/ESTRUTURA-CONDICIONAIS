using System;

namespace Condinais
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            float nota1, nota2, nota3, media;
            string nomeCompleto;
            string nomeDaEscola;

            Console.WriteLine("Digite o nome da Escola");
            nomeDaEscola = Console.ReadLine();

            Console.WriteLine("Digite o nome Completo do aluno");
            nomeCompleto = Console.ReadLine();    

            Console.WriteLine("Digite a primira nota:");
            nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a seguda nota:");
            nota2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota:");
            nota3 = float.Parse(Console.ReadLine());

            //processamento

            media = (nota1+nota2+nota3)/4;

            //exibir resultado

            if(media>5){
                //Valor verdadeior

                Console.WriteLine("O aluno está Aprovado " +nomeCompleto+" "+nomeDaEscola+" "+media);
            }else{
                //Valor falso
                Console.WriteLine("O aluno astá Reprovado " +nomeCompleto+" "+nomeDaEscola+" "+media);
            }

            



        }
    }
}
