using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RefactorExercicioModulo1
{
    public class FichaPessoa
    {
        public int Id { get; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public string NomeMae { get; set; }
        public string NomePai { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
   
        //public FichaPessoa(int id, string nome, int idade, string sexo, string nomeMae, string nomePai, string rg, string cpf)
        //{
        //    if(id < 0)
        //        throw new InvalidOperationException();

        //    if(idade < 0)
        //        throw new InvalidOperationException();

        //    if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(sexo) || string.IsNullOrEmpty(nomeMae) || string.IsNullOrEmpty(nomePai))
        //    {
        //        throw new InvalidOperationException();
        //    }

        //    if (!Regex.IsMatch(rg, @"(^\d{1,2}).?(\d{3}).?(\d{3})-?(\d{1}|X|x$)"))
        //    {
        //        throw new InvalidOperationException();
        //    }

        //    if (!Regex.IsMatch(cpf, @"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)"))
        //    {
        //        throw new InvalidOperationException();
        //    }
        //}

    }

}
