/*

1º
Criar um novo projeto console .net core 5.0  (Conhecimento de plataforma)
------------------------------------------------------------------------------------------------------------------------------------------------------
2º

Criar uma classe que recebe a ficha de uma pessoa  

Nome;
Idade;
Sexo;
Mae;
Pai;
RG;
CPF;
------------------------------------------------------------------------------------------------------------------------------------------------------
3º
Ao instanciar a classe da ficha, os dados inseridos devem ser persistidos no banco de dados SQL Server



4º
Criar um metodo que realize o processamento com base nos dados preenchidos na ficha

Se Alguma informação estiver vázia(exceto nomes dos pais), reiniciar o preenchimento da ficha e exibir uma mensagem de erro
------------------------------------------------------------------------------------------------------------------------------------------------------
Certificar todas as inciais do [nome] comecem com letra maiscula  
------------------------------------------------------------------------------------------------------------------------------------------------------
Se a idade for maior que 18 - Pode tirar habilitação;
Se o sexo for masculino - Apresentação obrigatória no exercito;
------------------------------------------------------------------------------------------------------------------------------------------------------
Se o nome do pai e da mãe forem declarados = Pais presente
Se o nome da mãe mas não do pai for declarado = Mae presente, Pai ausente
Se o nome do pai mas não da mãe for declarado = Pai presente, Mae ausente
Se nem o nome da mãe nem do pai forem declarados = Orfão;
------------------------------------------------------------------------------------------------------------------------------------------------------
Idade + 10 = Idade daqui 10 anos
Idade / decadas vividas = Decadas vividas
------------------------------------------------------------------------------------------------------------------------------------------------------
Some + 1 no último número do cpf;
------------------------------------------------------------------------------------------------------------------------------------------------------

Criar um menu que inicializa junto com o programa, que fornece as seguintes opções:

1- Registrar uma nova pessoa
2- Consultar pessoas registradas
3- Deletar uma pessoa

Determinida ação escolhida, deve reflir na base de dados

*/


using System;
using System.Data.SqlClient;
using System.Text;

namespace RefactorExercicioModulo1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("******** | Bem-vindo | ******** ");
            Console.WriteLine("\n\n");
            Console.WriteLine("Selecione a opção desejada:");
            Console.WriteLine("1) Registrar uma nova pessoa");
            Console.WriteLine("2) Consultar pessoas registradas");
            Console.WriteLine("3) Deletar uma pessoa\n");
            Console.Write("Opção: ");
            int escolhaMenu;
            escolhaMenu = int.Parse(Console.ReadLine());
            switch (escolhaMenu)
            {
                case 1:
                    registrarNovaPessoa();
                    break;

                case 2:
                    consultarPessoas();
                    break;
                case 3:
                    //deletarPessoa();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            static void registrarNovaPessoa()
            {
                Console.Clear();
                Console.WriteLine("******** | CADASTRAR NOVA PESSOA | ******** ");
                FichaPessoa pessoa = new FichaPessoa();
                ValidadorDeDados validador = new ValidadorDeDados();

                do
                {
                    Console.Write("Nome: ");
                    pessoa.Nome = Console.ReadLine();
                } while (!validador.ValidaNome(pessoa.Nome));

                do
                {
                    try
                    {
                        Console.Write("Idade: ");
                        pessoa.Idade = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        
                    }

                } while (!validador.ValidaIdade(pessoa.Idade));

                do
                {
                    Console.Write("Sexo: ");
                    pessoa.Sexo = Console.ReadLine();
                } while (!validador.ValidaSexo(pessoa.Sexo));


                do
                {
                    Console.Write("Nome Mae: ");
                    pessoa.NomeMae = Console.ReadLine();
                } while (!validador.ValidaNome(pessoa.NomeMae));

                do
                {
                    Console.Write("Nome Pai: ");
                    pessoa.NomePai = Console.ReadLine();
                    validador.ValidaNome(pessoa.NomePai);
                } while (!validador.ValidaNome(pessoa.NomePai));

                do
                {
                    Console.Write("Numero RG: ");
                    pessoa.Rg = Console.ReadLine();
                } while (!validador.ValidaRg(pessoa.Rg));

                do
                {
                Console.Write("Numero CPF: ");
                pessoa.Cpf = Console.ReadLine();
                } while (!validador.ValidaCpf(pessoa.Cpf));


                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append("INSERT INTO Pessoa(nome, idade, sexo, nomeMae, nomePai, numeroRg, numeroCpf) VALUES");
                strBuilder.Append($"('{pessoa.Nome}',{pessoa.Idade},'{pessoa.Sexo}','{pessoa.NomeMae}','{pessoa.NomePai}','{pessoa.Rg}','{pessoa.Cpf}')");

                string sqlQuery = strBuilder.ToString();

                Console.WriteLine(sqlQuery);
                Console.ReadKey();

                var InserirSql = new ProcessQuery(sqlQuery);    
                

            }

            static void consultarPessoas()
            {
                Console.Clear();
                Console.WriteLine("******** | CONSULTAR CADASTROS | ******** ");
                string sqlQuery = "SELECT * FROM pessoa";
                var Consultar = new ProcessQuery(sqlQuery);
                Consultar.Consultar();
            }

            //static void deletarPessoa()
            //{
            //    Console.Clear();
            //    Console.WriteLine("******** | DELETAR CADASTRO | ******** ");
            //    Console.WriteLine("\n");
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.Write("Digite o Id da pessoa que deseja remover: ");
            //    Console.ForegroundColor = ConsoleColor.White;
            //    int idPessoa = int.Parse(Console.ReadLine());
            //    var connec = new ConnectSQLServer();
            //    int ident = 2;
            //    string sqlQuery = $"DELETE FROM pessoa WHERE Id = {idPessoa}";
            //    connec.ProcessarQuery(sqlQuery, ident);
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("** SUCESSO ** CADASTRO REMOVIDO");
            //    Console.ForegroundColor = ConsoleColor.White;
            //}

        }


    }
}
