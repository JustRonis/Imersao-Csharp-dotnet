using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CarroOpcional
    {
        private double desconto = 0.1;
        private string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //propriedade autoimplementada
        public double Preco { get; set; }

        // somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //Lambda
        }

        public CarroOpcional() { }

        public CarroOpcional(string nome, double preco)
        {
            // this.nome = nome;
            Nome = nome;
            Preco = preco;
        }
    }
    class Props
    {

        public static void Executar()
        {
            var op1 = new CarroOpcional("Ar condicionado", 3500);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional("Direção Eletrica", 2500);
            Console.WriteLine(op2.Nome);


        }
    }
}
