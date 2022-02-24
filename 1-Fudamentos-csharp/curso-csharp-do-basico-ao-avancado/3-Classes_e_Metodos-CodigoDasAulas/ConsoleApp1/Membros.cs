using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Membros
    {
        public string Nome;
        public int Idade;

        public string Apresentar()
        {
            if(Nome != "" && Idade != 0)
            {
                return string.Format($"Ola, sou o {Nome} e tenho {Idade} anos");
            }
            else
            {
                return string.Format("Nome e/ou idade vazio");
            }
        }

    }
}
