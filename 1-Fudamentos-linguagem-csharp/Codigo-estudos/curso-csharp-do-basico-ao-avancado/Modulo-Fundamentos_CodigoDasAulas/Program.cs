// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace Fundamentos
{
    class Program{
        static void Main(string [] args){
            var a = "EU VIM DE UMA VARIAVEl";
            Console.WriteLine($"Interpolação de string {a}. FIM ");

            Console.WriteLine($" 1 + 1 = {1+1}");
            conversoes();
        }

        static void EhPar(){
            Console.WriteLine("Digite um número: ");
            var numero = Console.Read();
            if(numero % 2 == 0){
                Console.WriteLine("O número é par");
            }else{
                Console.WriteLine("O número é impar");
            }

            EhPar2(6);
        }

        static void EhPar2(int n1){
            string resposta = n1 % 2 == 0 ? "O número é par" : "o número é impar";
            Console.WriteLine(resposta);

            FormatandoNumeros();
        }

        static void FormatandoNumeros(){
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1")); // formatar para apenas uma casa decimal
            Console.WriteLine(valor.ToString("C")); // formatar para 'coin' | moeda 
            Console.WriteLine(valor.ToString("P")); // formatar para percentual
            Console.WriteLine(valor.ToString("#.##")); // formatar para duas casas decimais, seria o mesmo que 'valor.ToString("F2");

            var cultura =  new CultureInfo("pt-BR");
             Console.WriteLine(valor.ToString("C", cultura)); // formatar para 'coin' | moeda  - usando o padrão de moeda brasileiro

             teste();
            
        }

        static void teste(){
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 4; j >i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            
            Console.ReadKey();
            teste2();
        }

        static void teste2(){
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("*");
                Console.WriteLine("\n");
            }
            for(int j = 0; j < 6; j++)
            {
                Console.WriteLine("*");
                Console.WriteLine("\n");
            }
        }


        static void conversoes()
        {
            //conversao implicita - Feita quando nao ha possibilidade de perca de informacao
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);


            //conversao explicita - Feita quando ha possibilidade de perca de informacao. O programador deve confirmar que deseja realizar a conversao de forma explicita, atraves o casting por exemplo.
            double nota = 9.7;
            int notaTruncada = (int) nota;  //casting 
            Console.WriteLine(notaTruncada);

            Console.WriteLine("Digite sua idade");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida:{0}", idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeInteiro);

            Console.WriteLine("Digite um número");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse(palavra, out numero);
            Console.WriteLine("Resultado 1: {0}", numero);

            //Codigo mais clean
            Console.Write("Digite um número:");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resultado 2: {0}", numero2);

        }
        
        static void potencia()
        {
            double peso = 91.2;
            double altura = 1.74;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc}");

        }
        
    }
}



// Exercicio: 

/* Escrever um metodo que