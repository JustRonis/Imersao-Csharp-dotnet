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

// 2º
// Criar metodo que recebe a ficha de uma pessoa  (Variáveis, Leitura de dados no console )
// Nome;
// Inf - Idade;
// Sexo;
// Mae;
// Pai;
// Inf - RG;
// CPF;

using System;
using System.Text.RegularExpressions;

namespace _1_Fundamentos_RefactorExercicioModulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Ficha();
        }


        static void Ficha(){
            
            
            System.Console.Clear();
            int idade = 0;
            ulong numeroRG, numeroCPF = 0;
            string nome, sexo, nomeMae, nomePai = null;
            //bool recebeNome, recebeIdade, recebeSexo, recebeRG, recebeCPF = false;
            bool validaCampos = false;
            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("** Erro ** - Este campo não pode ser vazio");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);
                    System.Console.Clear();
                    validaCampos = false;
                }
                else if (Regex.IsMatch(nome, @"^[0-9]+$"))
                {
                    Console.WriteLine("\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("** ERRO ** Nomes nao podem conter numeros");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);
                    System.Console.Clear();
                    validaCampos = false;
                }
                else
                {
                    validaCampos = true;
                }
        
            }while(validaCampos == false);

            do
            {
                try
                {
                    Console.Write("Idade: ");
                    idade = int.Parse(Console.ReadLine());
                    if (idade != 0)
                    {
                        validaCampos = true;

                    }
                }
                catch
                {
                   
                    Console.WriteLine("\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("** Erro ** - Este campo não pode ser vazio e tambem não aceita letras");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("\t");
                    validaCampos = false;
                }

            } while(validaCampos == false);


            do
            {
                Console.Write("Sexo: ");
                sexo = Console.ReadLine();

                System.Globalization.CultureInfo cultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;
                sexo = cultureinfo.TextInfo.ToTitleCase(sexo);

                if (string.IsNullOrEmpty(sexo))
                {
                    Console.WriteLine("\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("** Erro ** - Este campo não pode ser vazio");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);
                    validaCampos = false;
                }

                bool verificaSexoMasc = sexo != "Masculino" ? true : false;
                bool verificaSexoFem = sexo != "Feminino" ? true : false;

                if (verificaSexoMasc == true && verificaSexoFem == true)
                {
                    Console.WriteLine("\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("** Erro **  - Sexo preenchido errado, apenas: masculino ou feminino");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);
                    validaCampos = false;
                }
                else
                {
                    validaCampos = true;
                }

            } while (validaCampos == false);

            do
            {
                Console.Write("Nome Mae: ");
                nomeMae = Console.ReadLine();

                if (Regex.IsMatch(nomeMae, @"^[0-9]+$"))
                {
                    Console.WriteLine("\t");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("** ERRO ** Nomes nao podem conter numeros");
                    Console.ForegroundColor = ConsoleColor.White;
                    System.Threading.Thread.Sleep(2000);
                    validaCampos = false;
                }

                validaCampos = true;

            } while (validaCampos == false);
            
        }

        static void teste(int teste)
        {
            Console.WriteLine(teste);
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

