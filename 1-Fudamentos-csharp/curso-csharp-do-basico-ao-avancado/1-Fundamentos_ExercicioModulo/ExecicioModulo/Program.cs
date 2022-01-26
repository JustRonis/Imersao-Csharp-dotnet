/*
Exercicio criado por mim para me desafiar em relação ao conteudo ministrado no modulo - Fundamentos C#;

1º 

Criar um novo projeto console .net core 5.0  (Conhecimento de plataforma)

------------------------------------------------------------------------------------------------------------------------------------------------------

2º

Criar uma classe que contenha um metodo que recebe a ficha de uma pessoa  (Variáveis, constantes, inferência, Leitura de dados no console )

Nome;
Inf - Idade;
Sexo;
Inf - Cor;
Mae;
Pai;
Inf - RG;
CPF;

------------------------------------------------------------------------------------------------------------------------------------------------------

3º

Se Alguma informação estiver vázia(exceto nomes dos pais), reiniciar o preenchimento da ficha e exibir uma mensagem de erro (Lógica)

------------------------------------------------------------------------------------------------------------------------------------------------------

4º

Certificar todas as inciais do [nome] comecem com letra maiscula  (notação ponto)

------------------------------------------------------------------------------------------------------------------------------------------------------

5º

Se a idade for maior que 18 - Pode tirar habilitação(ternario)

Se o sexo for masculino - Apresentação obrigatória no exercito; (ternario)


------------------------------------------------------------------------------------------------------------------------------------------------------

6º(operadores lógicos)

Se o nome do pai e da mãe forem declarados = Pais presente

Se o nome da mãe mas não do pai for declarado = Mae presente, Pai ausente

Se o nome do pai mas não da mãe for declarado = Pai presente, Mae ausente

Se nem o nome da mãe nem do pai forem declarados = Orfão;

------------------------------------------------------------------------------------------------------------------------------------------------------

7º

Idade + 10 = Idade daqui 10 anos
Idade / decadas vividas = Decadas vividas

------------------------------------------------------------------------------------------------------------------------------------------------------

9º 

Some + 1 no último número do cpf;

------------------------------------------------------------------------------------------------------------------------------------------------------

End \o/ 

*/



using System;

namespace ExecicioModulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ficha();
        }

        static void ficha()
        {
            Console.WriteLine("#### FICHA ####");
            Console.WriteLine("");
            Console.WriteLine("Digite as informações solicitadas abaixo");
            Console.WriteLine("");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Idade: ");
            int idade = Console.Read();

            Console.Write("Sexo: ");
            string sexo;
            sexo = Console.ReadLine();

            Console.Write("Nome mae: ");
            string nomeMae = Console.ReadLine();

            Console.Write("Nome pai: ");
            string nomePai = Console.ReadLine();
            
            Console.Write("Numero RG: ");
            int numeroRG = Console.Read();           

            Console.Write("Numero CPF: ");
            int numeroCPF = Console.Read();
 

            //process(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF);
        }

        static void process(string nome, int idade, string sexo, string nomeMae, string nomePai, int numeroRG, int numeroCPF)
        {
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Erro - Nome vazio. - Preencha a ficha novamente");
                ficha();
            }
            if (idade == 0 ) 
            {
                Console.WriteLine("Erro - Idade vazia. - Preencha a ficha novamente");
                ficha();
            }
            if (string.IsNullOrEmpty(sexo))
            {
                Console.WriteLine("Erro - Sexo vazio. - Preencha a ficha novamente");
                ficha();
            }

            bool verificaSexo = sexo != "masuculino" ? true : false || sexo != "feminino" ? true : false;

            if (verificaSexo == false)
            {
                Console.WriteLine("Erro - Sexo preenchido errado - Preencha a ficha novamente");
                ficha();
            }

            if (numeroRG == 0)
            {
                Console.WriteLine("Erro - RG vazio. - Preencha a ficha novamente");
                ficha();
            }
            if (numeroCPF == 0)
            {
                Console.WriteLine("Erro - CPF vazio. - Preencha a ficha novamente");
                ficha();
            }

             
            Console.WriteLine("Fim");

        }

        
    }
}

