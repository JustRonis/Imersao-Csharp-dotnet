using System;
using System.Data.SqlClient;
using System.Security;
using System.Text;

namespace RefactorExercicioModulo1
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("******** | Bem-vindo  | ******** \n\n");
            Console.WriteLine("Escolha uma opção abaixo: \n");
            Console.WriteLine("1) Usuario");
            Console.WriteLine("2) Administrador\n");
            Console.Write("Digite: ");
            int choiceMenu = int.Parse(Console.ReadLine());

            if(choiceMenu == 1)
            {
                pessoaLogin();
            } 
            else if(choiceMenu == 2)
            {
                menuAdm();
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

            //ConsoleSpinner spinner = new ConsoleSpinner();
            //spinner.Delay = 300;
            //while (true)
            //{
            //    spinner.Turn(displayMsg: "Processando ", sequenceCode: 4);
            //}


        }

        static void menuAdm()
        {
            Console.Clear();
            Console.WriteLine("******** | Bem-vindo - ADMINISTRADOR | ******** ");
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
                    deletarPessoa();
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }



        static void pessoaLogin()
        {
            Console.Clear();
            Console.WriteLine("******** | Usuário Login | ******** \n\n");
            Console.Write("Identificador: ");
            int inputIdentificador = int.Parse(Console.ReadLine());
            var inputSenha = "";
            inputSenha = CriarSenha.Criar();
            string sqlQuery = $"SELECT * FROM pessoa where identificador = {inputIdentificador} and senha = '{inputSenha}'";
            var Consultar = new ProcessQuery(sqlQuery);
            System.Threading.Thread.Sleep(700);
            if (Consultar.ConsultarSenha() == true)
            {
                menuPessoa();
            }   
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n** Erro **  - Senha ou identificador inválido - Encerrando sessão");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(1);
            }



        }
        static void menuPessoa()
        {
            Console.Clear();
            Console.WriteLine("******** | Bem-vindo ao pior banco do mundo | ******** \n\n");
            Console.WriteLine("Escolha uma opção abaixo: \n");
            Console.WriteLine("1) Depositar");
            Console.WriteLine("1) Transeferir");
            Console.WriteLine("2) Sacar\n");
            Console.WriteLine("Nome seu saldo é: ");

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
            } while (!validador.ValidaNome(pessoa.NomePai));

            do
            {
                Console.Write("Numero CPF: ");
                pessoa.Cpf = Console.ReadLine();
            } while (!validador.ValidaCpf(pessoa.Cpf));

            pessoa.Identificador = int.Parse(pessoa.Cpf.Substring(0, 3));

            StringBuilder strBuilder = new StringBuilder();

            Console.WriteLine("\n******** | AGUARDE | ******** ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine(" ******** | SEUS DADOS FORAM APROVADOS | ******** ");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Seu identificador é: {0}", pessoa.Identificador);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n");
            var senha = "";
            do
            {
                senha = CriarSenha.Criar();
            } while (!CriarSenha.ValidarSenha(senha));
            pessoa.Senha = senha;

            Console.Clear();
            System.Threading.Thread.Sleep(1500);
            Console.Write(" ******** | SENHA CRIADA COM SUCESSO -");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" CADASTRO APROVADO E ATIVO ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("| ******** ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nLEMBRE-SE: Seu identificador é: {0}", pessoa.Identificador);
            Console.ForegroundColor = ConsoleColor.White;

            strBuilder.Append("INSERT INTO Pessoa(nome, idade, sexo, nomeMae, nomePai, numeroCpf, identificador, senha) VALUES");
            strBuilder.Append($"('{pessoa.Nome}',{pessoa.Idade},'{pessoa.Sexo}','{pessoa.NomeMae}','{pessoa.NomePai}','{pessoa.Cpf}','{pessoa.Identificador}','{pessoa.Senha}')");
            string sqlQuery = strBuilder.ToString();
            var inserir = new ProcessQuery(sqlQuery);
            inserir.Inserir();


        }

        static void consultarPessoas()
        {
            Console.Clear();
            Console.WriteLine("******** | CONSULTAR CADASTROS | ******** ");
            string sqlQuery = "SELECT * FROM pessoa";
            var Consultar = new ProcessQuery(sqlQuery);
            Consultar.Consultar();
        }

        static void deletarPessoa()
        {
            Console.Clear();
            Console.WriteLine("******** | DELETAR CADASTRO | ******** ");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o Id da pessoa que deseja remover: ");
            Console.ForegroundColor = ConsoleColor.White;
            int idPessoa = int.Parse(Console.ReadLine());

            string sqlQuery = $"DELETE FROM pessoa WHERE Id = {idPessoa}";
            var deletar = new ProcessQuery(sqlQuery);
            deletar.Deletar();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("** SUCESSO ** CADASTRO REMOVIDO");
            Console.ForegroundColor = ConsoleColor.White;

        }



    }
}
