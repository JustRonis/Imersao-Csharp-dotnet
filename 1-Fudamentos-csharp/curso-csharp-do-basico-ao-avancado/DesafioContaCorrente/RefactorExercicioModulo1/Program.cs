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
            if (Consultar.FazerLogin() == true)
            {

                string nome = Consultar.RetornarPessoaNome();
                float saldo = Consultar.RetornarPessoaSaldo();
                int identificador = Consultar.RetornarPessoaIdentificador();
                menuPessoa(nome, saldo, identificador);
     
            }   
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n** Erro **  - Senha ou identificador inválido - Encerrando sessão");
                Console.ForegroundColor = ConsoleColor.White;
                Environment.Exit(1);
            }



        }
        static void menuPessoa(string nome, float saldo, int identificador)
        {
            Console.Clear();
            Console.WriteLine("******** | Bem-vindo ao pior banco do mundo | ******** \n\n");
            Console.WriteLine("Escolha uma opção abaixo: \n");
            Console.WriteLine("1) Depositar");
            Console.WriteLine("2) Transferir");
            Console.WriteLine("3) Sacar\n");
            Console.Write("Digite: ");
            int choiceMenu = int.Parse(Console.ReadLine());
            switch (choiceMenu)
            {
                case 1:
                    menuDepositar(nome, saldo, identificador);
                    break;
                case 2:
                    menuTransferir(nome, saldo, identificador);
                    break;
                case 3:
                    menuSacar(nome, saldo, identificador);
                    break;

            }
        }
        static void menuDepositar(string nome, float saldo, int identificador)
        {
            Console.Clear();
            Console.WriteLine("******** | DEPOSITAR | ******** \n\n");
            Console.WriteLine("{0}, seu saldo é: R$ {1}\n\n", nome, saldo);
            Console.Write("Valor que deseja depositar: ");
            float inputValorDepsito = float.Parse(Console.ReadLine());
            saldo = saldo + inputValorDepsito;
            string sqlQuery = $"UPDATE pessoa SET saldo = {saldo} WHERE identificador = {identificador}";
            var Consultar = new ProcessQuery(sqlQuery);
            Consultar.Inserir();


            ConsoleSpinner spinner = new ConsoleSpinner();
            spinner.Delay = 500;
            int cont = 0;
            while (cont <= 10)
            {
                spinner.Turn(displayMsg: "Depositando ", sequenceCode: 4);
                cont++;
               
            }
            Console.Clear();
            Console.Write(" ******** |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" DEPOSITO REALIZADO COM SUCESSO ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("| ******** \n\n");
            Console.WriteLine("{0}, seu saldo atual é: R$: {1}\n\n", nome, saldo);


        }
        static void menuSacar(string nome, float saldo, int identificador)
        {
            Console.Clear();
            Console.WriteLine("******** | SACAR | ******** \n\n");
            Console.WriteLine("{0}, seu saldo é: R$ {1}\n\n", nome, saldo);
            Console.Write("Valor que deseja sacar: ");
            float inputValorDepsito = float.Parse(Console.ReadLine());
            saldo = saldo -= inputValorDepsito;
            string sqlQuery = $"UPDATE pessoa SET saldo = {saldo} WHERE identificador = {identificador}";
            var Consultar = new ProcessQuery(sqlQuery);
            Consultar.Inserir();

            ConsoleSpinner spinner = new ConsoleSpinner();
            spinner.Delay = 500;
            int cont = 0;
            while (cont <= 10)
            {
                spinner.Turn(displayMsg: "Sacando ", sequenceCode: 4);
                cont++;

            }
            Console.Clear();
            Console.Write(" ******** |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" SAQUE REALIZADO COM SUCESSO ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("| ******** \n\n");
            Console.WriteLine("{0}, seu saldo atual é: R$: {1}\n\n", nome, saldo);


        }
        static void menuTransferir(string nome, float saldo, int identificador)
        {
            Console.Clear();
            Console.WriteLine("******** | TRANSFERIR | ******** \n\n");
            Console.WriteLine("{0}, seu saldo é: R$ {1}\n\n", nome, saldo);
            Console.Write("Valor que deseja transferir: ");
            float inputValorTransferencia = float.Parse(Console.ReadLine());
            Console.Write("Identificador de quem voce deseja transferir: ");
            int inputDestinatario = int.Parse(Console.ReadLine());
            
            saldo = saldo -= inputValorTransferencia;
            string sqlQuery = $"UPDATE pessoa SET saldo = {saldo} WHERE identificador = {identificador}";
            var Consultar = new ProcessQuery(sqlQuery);
            Consultar.Inserir();

            string sqlQueryDois = $"SELECT * FROM pessoa where identificador = {inputDestinatario}";
            var ConsultarDois = new ProcessQuery(sqlQueryDois);
            float saldoDestinatario = ConsultarDois.RetornarPessoaSaldo();

            saldoDestinatario += inputValorTransferencia;
            var sqlQueryTres = $"UPDATE pessoa SET saldo = {saldoDestinatario} WHERE identificador = {inputDestinatario}";
            var ConsultarTres = new ProcessQuery(sqlQueryTres);
            ConsultarTres.Inserir();


            ConsoleSpinner spinner = new ConsoleSpinner();
            spinner.Delay = 500;
            int cont = 0;
            while (cont <= 10)
            {
                spinner.Turn(displayMsg: "Transferindo ", sequenceCode: 4);
                cont++;

            }
            Console.Clear();
            Console.Write(" ******** |");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" TRANSFERENCIA REALIZADA COM SUCESSO ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("| ******** \n\n");
            Console.WriteLine("{0}, seu saldo atual é: R$: {1}\n\n", nome, saldo);


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
            pessoa.Saldo = 0;
            strBuilder.Append("INSERT INTO Pessoa(nome, idade, sexo, nomeMae, nomePai, numeroCpf, identificador, senha, saldo) VALUES");
            strBuilder.Append($"('{pessoa.Nome}',{pessoa.Idade},'{pessoa.Sexo}','{pessoa.NomeMae}','{pessoa.NomePai}','{pessoa.Cpf}','{pessoa.Identificador}','{pessoa.Senha}','{pessoa.Saldo}')");
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
