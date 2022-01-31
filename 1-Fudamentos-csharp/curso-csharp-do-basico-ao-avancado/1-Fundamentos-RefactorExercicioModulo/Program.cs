/*
Exercicio criado por mim para me desafiar em relação ao conteudo ministrado no modulo - Fundamentos C#;
1º 
Criar um novo projeto console .net core 5.0  (Conhecimento de plataforma)
------------------------------------------------------------------------------------------------------------------------------------------------------
2º
Criar metodo que recebe a ficha de uma pessoa  (Variáveis, Leitura de dados no console )
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
6º
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

namespace _1_Fundamentos_RefactorExercicioModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ficha();
        }


        static void Ficha(){
            
            bool recebeNome = true;
            System.Console.Clear();
            
            do
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                
                if(string.IsNullOrEmpty(nome))
                {
                    recebeNome = false;
                }
                else
                {
                    recebeNome = true;
                }

            }while(recebeNome = false);

            Console.Write("Idade: ");
            Console.ReadKey();  
                
        }
    


    }
}



// 2º
// Criar metodo que recebe a ficha de uma pessoa  (Variáveis, Leitura de dados no console )
// Nome;
// Inf - Idade;
// Sexo;
// Mae;
// Pai;
// Inf - RG;
// CPF;