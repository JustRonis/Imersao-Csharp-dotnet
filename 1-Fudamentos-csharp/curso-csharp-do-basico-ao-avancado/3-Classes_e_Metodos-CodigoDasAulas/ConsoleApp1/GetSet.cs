using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada;

        public Moto(string marca, string modelo, int cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }
        public Moto() { }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
          Modelo = modelo;
        }

        public int GetCilindrada()
        {
            return Cilindrada;
        }
        public void SetCilindrada(int cilindrada)
        {
            //if (cilicindrada > 0)
            //    Cilindrada = cilicindrada;

            Cilindrada = Math.Abs(cilindrada);

        }
    }
    class GetSet
    {
        public static void Executar()
        {
            var moto1 = new Moto("Kawasaki", "Nija", 363);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            Moto moto2 = new Moto();

            moto2.SetMarca("Honda");
            moto2.SetModelo("CG");
            moto2.SetCilindrada(-160);

            Console.WriteLine(moto2.GetMarca());
            Console.WriteLine(moto2.GetModelo());
            Console.WriteLine(moto2.GetCilindrada());



        }
    }
}
