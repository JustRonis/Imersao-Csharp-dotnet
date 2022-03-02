using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() { }

        public double CalcularDesconto()
        {
            return Preco - Preco * Desconto;
        }
    }
    class AtributosEstaticos
    {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.5, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 5.3,
                Desconto = 0.1
            };

            var produto3 = new Produto();
            produto3.Nome = "Lapis";
            produto3.Preco = 1.0;
            produto3.Desconto = 0.1;

            Console.WriteLine("Preço com desconto: {0}", produto1.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto2.CalcularDesconto());
            Console.WriteLine("Preço com desconto: {0}", produto3.CalcularDesconto());

        }
    }
}
