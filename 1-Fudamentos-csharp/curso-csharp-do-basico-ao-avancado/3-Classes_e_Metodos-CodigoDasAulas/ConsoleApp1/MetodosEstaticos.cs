using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CalculadoraEstatica
    {
        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }
    class MetodosEstaticos
    {
        public static void Executar()
        { 
        var resultado = CalculadoraEstatica.Multiplicar(2, 2);
        }
        
    }
}
