using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class StructVsClasse
    {
        public struct SPonto
        {
            public int X;
            public int Y;
        }

        public class CPonto
        {
            public int X;
            public int Y;
        }
        public static void Executar()
        {
            SPonto ponto1 = new SPonto { X = 1, Y = 3 }; //STRUCT
            SPonto copiaPonto1 = ponto1; //Atribuição por valor
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X:{0}", ponto1.X);
            Console.WriteLine("Copia Ponto 1 X:{0}", copiaPonto1.X);

            CPonto ponto2 = new CPonto { X = 1, Y = 3 }; //CLASSE
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 4; //Atribuição por refencia
            Console.WriteLine("Ponto 2 X:{0}", ponto2.X);
            Console.WriteLine("Copia Ponto 2 X:{0}", copiaPonto2.X);

        }
    }
}
