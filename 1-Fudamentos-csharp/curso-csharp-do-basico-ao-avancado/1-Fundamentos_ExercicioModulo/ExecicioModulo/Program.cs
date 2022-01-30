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

namespace ExecicioModulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ficha();
        }

        static void Ficha()
        {
            try { 
                Console.WriteLine("#### FICHA ####");
                Console.WriteLine("");
                Console.WriteLine("Digite as informações solicitadas abaixo");
                Console.WriteLine("");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Idade: ");
                string idadeProv = Console.ReadLine();
                int idade = int.Parse(idadeProv);

                Console.Write("Sexo: ");
                string sexo = Console.ReadLine();

                Console.Write("Nome mae: ");
                string nomeMae = Console.ReadLine();

                Console.Write("Nome pai: ");
                string nomePai = Console.ReadLine();

                Console.Write("Numero RG: ");
                string numeroRGProv = Console.ReadLine();
                ulong numeroRG = Convert.ToUInt64(numeroRGProv);

                Console.Write("Numero CPF: ");
                string numeroCPFProv = Console.ReadLine();
                ulong numeroCPF = Convert.ToUInt64(numeroCPFProv);

                ValidaCampos(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF);
            }
            catch 
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Erro - Dado inválido. - Preencha a ficha novamente");
                System.Threading.Thread.Sleep(3000);
                Ficha();
            }
            
        
        }

        static void ValidaCampos(string nome, int idade, string sexo, string nomeMae, string nomePai, ulong numeroRG, ulong numeroCPF)
        {
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Erro - Nome vazio. - Preencha a ficha novamente");
                Ficha();
            }
            if (idade == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Erro - Idade vazia. - Preencha a ficha novamente");
                Ficha();
            }

            if (string.IsNullOrEmpty(sexo))
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Erro - Sexo vazio. - Preencha a ficha novamente");
                Ficha();
            }


            System.Globalization.CultureInfo cultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            sexo = cultureinfo.TextInfo.ToTitleCase(sexo);
            bool verificaSexoMasc = sexo != "Masculino" ? true : false;
            bool verificaSexoFem =  sexo != "Feminino" ? true : false;

            if (verificaSexoMasc == true && verificaSexoFem == true )
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Erro - Sexo preenchido errado - Preencha a ficha novamente - Preencha: masculino ou feminino");
                Ficha();
            }

            ValidaNome(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF);
           
        }

        //static void validaNome(string nome)
        //{
        //    string[] partesNome = nome.Split(' ');

        //    foreach(var parteNome in partesNome)
        //    {
        //        if (char.IsLower(parteNome[0]))
        //        {
        //            nome +=
        //            parteNome.Substring(0, 1).ToUpper(); 
        //            parteNome.Substring(1);

        //        }
        //    }
        //    Console.WriteLine(nome);
        //}

        static void ValidaNome(string nome, int idade, string sexo, string nomeMae, string nomePai, ulong numeroRG, ulong numeroCPF)
        {
            System.Globalization.CultureInfo cultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            nome = cultureinfo.TextInfo.ToTitleCase(nome);
            Console.WriteLine(nome);
            ValidaHabilitacaoESexo(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF);
        }

        static void ValidaHabilitacaoESexo(string nome, int idade, string sexo, string nomeMae, string nomePai, ulong numeroRG, ulong numeroCPF)
        {
            string tirarHabilitacao =  idade >= 18 ? "Pode tirar habilitação" : "Não pode tirar habilitação";
            string irAoExercito = sexo == "Masculino" && idade >= 18 ? "Você precisa comparacer no exercito" : "Você não precisa ir ao exercito";

            ValidaPais(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF, tirarHabilitacao, irAoExercito);

        }

        static void ValidaPais(string nome, int idade, string sexo, string nomeMae, string nomePai, ulong numeroRG, ulong numeroCPF, string tirarHabilitacao, string irAoExercito)
        {
            string situacaoParental;

            if (string.IsNullOrEmpty(nomePai) && string.IsNullOrEmpty(nomeMae))
            {
                situacaoParental = "Orfão";
                ValidaIdade(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF, tirarHabilitacao, irAoExercito, situacaoParental);
            }

            bool validaNomeMae = string.IsNullOrEmpty(nomeMae);
            bool validaNomePai = string.IsNullOrEmpty(nomePai);
            
            if(validaNomeMae == true && validaNomePai == false) 
            {
                situacaoParental = "Mãe ausente";
                ValidaIdade(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF, tirarHabilitacao, irAoExercito, situacaoParental);
            }

            if(validaNomeMae == false && validaNomePai == true) 
            {
                situacaoParental = "Pai ausente";
                ValidaIdade(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF, tirarHabilitacao, irAoExercito, situacaoParental);
            }

            
        }

        static void ValidaIdade(string nome, int idade, string sexo, string nomeMae, string nomePai, ulong numeroRG, ulong numeroCPF, string tirarHabilitacao, string irAoExercito, string situacaoParental)
        {
            int idadeSomaDez = idade + 10;
            int decadasVividas = idade / 10;
            SomaCpf(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF, tirarHabilitacao, irAoExercito, situacaoParental, idadeSomaDez, decadasVividas);
        }

        static void SomaCpf(string nome, int idade, string sexo, string nomeMae, string nomePai, ulong numeroRG, ulong numeroCPF, string tirarHabilitacao, string irAoExercito, string situacaoParental, int idadeSomaDez, int decadasVividas)
        {
            ulong numeroCPFMaisUm = ++numeroCPF;
            ExibeInfoFicha(nome, idade, sexo, nomeMae, nomePai, numeroRG, numeroCPF, tirarHabilitacao, irAoExercito, situacaoParental, idadeSomaDez, decadasVividas, numeroCPFMaisUm);
        }

        static void ExibeInfoFicha(string nome, int idade, string sexo, string nomeMae, string nomePai, ulong numeroRG, ulong numeroCPF, string tirarHabilitacao, string irAoExercito, string situacaoParental, int idadeSomaDez, int decadasVividas, ulong numeroCPFMaisUm)
        {
            System.Console.Clear();
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Nome Mae: {nomeMae}");
            Console.WriteLine($"Nome Pai: {nomePai}");
            Console.WriteLine($"RG: {numeroRG}");
            Console.WriteLine($"CPF: {numeroCPF}");
            Console.WriteLine("------------------------------------------------\t");
            Console.WriteLine(tirarHabilitacao);
            Console.WriteLine(irAoExercito);
            Console.WriteLine(situacaoParental);
            Console.WriteLine($"Idade daqui 10 anos: {idadeSomaDez}");
            Console.WriteLine($"Quantidade de decadas vividas: {decadasVividas}");
            Console.WriteLine($"Somar 1 no CPF: {numeroCPFMaisUm}");

        }



        /*
        Some + 1 no último número do cpf;        
        */

    }
}

