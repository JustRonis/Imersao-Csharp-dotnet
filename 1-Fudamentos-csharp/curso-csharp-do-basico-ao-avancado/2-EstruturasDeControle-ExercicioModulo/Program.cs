/*
 Exercicio criado por mim para me desafiar em relação ao conteudo ministrado no modulo - Estruturas de controle C#;

1º 
Dentro de um random de 1 a 50 , exibir apenas os números pares; (for, if, continue)

2º 
Exibir o preenchimento do nome, enquanto verdadeiro (Do while)

3º
Um numero randomico de 1 a 10 que enquanto o usuário não acertar, repete a pergunta. Se acertar finaliza (While - Break)
*/
using System;

namespace _2_EstruturasDeControle_ExercicioModulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();
            int numeroRandom = numero.Next(1, 51);
            char continuar;
            Console.WriteLine("O numero Randomico é: {0}", numeroRandom);
            for(int i = 1; i <= numeroRandom;  i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
            Console.Write("\n\n");
            do
            {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("{0} deseja continuar? Digite (S/N): ", nome);
                string entrada;
                entrada = Console.ReadLine();
                entrada.ToLower();
                char.TryParse(entrada, out continuar);

            } while (continuar == 's');

            Console.Write("\n\n");
            int numeroJogo = numero.Next(1, 11);
            Console.WriteLine("Agora um joguinho: Tente acertar o número entre 1 e 10");
            
            bool a = true;
            int tentativa = 1;
            while (a == true)
            {
                string entradaJogo = Console.ReadLine();
                int.TryParse(entradaJogo, out int chute);
                if (chute != numeroJogo)
                {
                    Console.WriteLine("Tentativa {0} - Errou!", tentativa);
                    tentativa++;
                }
                else
                {
                    Console.WriteLine("Tentativa {0} - Acertou!!!", tentativa);
                    break;
                }
            }
        }
    }
}
