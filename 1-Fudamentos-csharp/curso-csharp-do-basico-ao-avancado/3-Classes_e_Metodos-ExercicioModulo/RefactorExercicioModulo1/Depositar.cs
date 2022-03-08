using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioContaCorrente
{
    public class Depositar
    {
        public int IdentRemente;
        public int IdentDestinatario;
        public float Valor;
        public Depositar(int identRemetente, int identDestinatario, float valor)
        {
            IdentRemente = identRemetente;
            IdentDestinatario = identDestinatario;
            Valor = valor;
        }



    }
}
