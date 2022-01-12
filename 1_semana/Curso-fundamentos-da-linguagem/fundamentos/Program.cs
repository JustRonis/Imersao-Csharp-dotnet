// See https://aka.ms/new-console-template for more information

using System.Globalization;

namespace Fundamentos{
    class Program{
        static void Main(string [] args){
            var a = "EU VIM DE UMA VARIAVEl";
            Console.WriteLine($"Interpolação de string {a}. FIM ");

            Console.WriteLine($" 1 + 1 = {1+1}");
            EhPar();
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
        
        
    }
}