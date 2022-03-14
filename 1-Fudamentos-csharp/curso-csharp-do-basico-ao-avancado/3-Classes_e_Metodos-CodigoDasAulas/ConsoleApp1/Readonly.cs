using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Readonly
    {
        public class Cliente
        {
            public string Nome;
            readonly DateTime Nascimento;

            public Cliente(string nome, DateTime nascimento)
            {
                Nome = nome;
                Nascimento = nascimento;
            }
            public string GetDataDeNacimento()
            {
                return string.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
            }
            
        }
        public static void Executar()
        {
            var novoCliente = new Cliente("Ana Silva", new DateTime(2000, 5, 23));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNacimento());
        }
    }
}
