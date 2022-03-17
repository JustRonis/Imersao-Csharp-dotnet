using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RefactorExercicioModulo1
{
    public class ValidadorDeDados
    {
        public bool ValidaNome(string nome)
        {
            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("** ERRO ** - Campo nome nao pode ser vazio");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                return false;
            }
            if (Regex.IsMatch(nome, @"^[0-9]+$"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("** ERRO ** Campo nome nao pode conter numeros");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                return false;

            }
            else
            {
                return true;
            }
        }
        public bool ValidaIdade(int idade)
        {
            if(idade == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("** ERRO ** Campo idade nao pode ser 0 e também não pode conter letras");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ValidaSexo(string sexo)
        {
            System.Globalization.CultureInfo cultureinfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            sexo = cultureinfo.TextInfo.ToTitleCase(sexo);

            if (string.IsNullOrEmpty(sexo))
            {
                Console.WriteLine("\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("** Erro ** - Campo sexo não pode ser vazio");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                return false;
            }

            bool verificaSexoMasc = sexo != "Masculino" ? true : false;
            bool verificaSexoFem = sexo != "Feminino" ? true : false;

            if (verificaSexoMasc == true && verificaSexoFem == true)
            {
                Console.WriteLine("\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("** Erro **  - Sexo preenchido errado, apenas: masculino ou feminino");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool ValidaCpf(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
            {
                Console.WriteLine("\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("** Erro ** - Campo CPF não pode ser vazio");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                return false;
            }
            if (Regex.IsMatch(cpf, @"(^\d{3}\.\d{3}\.\d{3}\-\d{2}$)"))
            {
                return true;
            }
            else
            {
                Console.WriteLine("\t");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("** Erro ** - CPF Preenchido errado - Preencha seguindo o Exemplo: (999.999.999-00)");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(2000);
                return false;
            }
        }
             
    }
}
