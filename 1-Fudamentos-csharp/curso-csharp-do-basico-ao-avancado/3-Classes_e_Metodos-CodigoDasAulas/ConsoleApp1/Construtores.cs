using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;
        public Carro(string fabricante, string modelo, int ano) // crinado construtor
        {
            Fabricante = fabricante;
            Modelo = modelo;
            Ano = ano;
        }
        
        public Carro() { } //Criano o construtor padrão, pois quando um outro construtor é criado, perdemos o construtor padrão, mas podemos recria-lo
    }
    class Construtores
    {
        public void Executar()
        {
            var carro1 = new Carro(); //construtor padrão
            carro1.Fabricante = "BMW";
            carro1.Modelo = "325i";
            carro1.Ano = 2017;

            Console.WriteLine($"{carro1.Fabricante} {carro1.Modelo} {carro1.Ano}");


            var carro2 = new Carro("Ford", "Ka", 2012); // Instanciando um objeto utilizando o construtor
            Console.WriteLine($"{carro2.Fabricante} {carro2.Modelo} {carro2.Ano}");
        }
    }
}
