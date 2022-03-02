/* --------------------------- TEORIA ----------------------------------------
O que é uma classe?
R: 
Classe é um tipo, tal como um int, uma string, um bool...
Classe define um tipo de uma estrutura de dado
Se eu crio uma classe "pessoa", por exemplo. Já que classe é um tipo, significa que posso criar uma variável do tipo pessoa. Sim!

Exemplo de uma estrura de classe:

Class Pessoa {
    [atributos = dados]
    [metodos = algoritimos]
    Tanto os atributos quanto os metodos são os membros da classe Pessoa.
}

*/




using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Membros teste = new Membros();
            Console.WriteLine(teste.Apresentar());
            teste.Nome = "Ronaldo";
            teste.Idade = 21;
            Console.WriteLine(teste.Apresentar());

            var app = new Construtores();
            app.Executar();

            var calculadora = new CalculadoraComum();
            int resultado;

            resultado = calculadora.Somar(10, 10);
            Console.WriteLine(resultado);

            resultado = calculadora.Subtrair(10, 10);
            Console.WriteLine(resultado);

            resultado = calculadora.Multiplicar(10, 10);
            Console.WriteLine(resultado);

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(3).Imprimir().Limpar().Imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicar(2).Resultado();

            Console.WriteLine(resultado);

            AtributosEstaticos.Executar();
        }
    }
}
