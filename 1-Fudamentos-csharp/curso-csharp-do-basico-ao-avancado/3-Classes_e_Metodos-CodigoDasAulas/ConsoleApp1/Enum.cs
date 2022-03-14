using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia}
    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class Enum
    {

        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);
            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Matrix";
            filmeParaFamilia.GeneroDoFilme = Genero.Acao;

            Console.WriteLine("{0} é {1}", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}
