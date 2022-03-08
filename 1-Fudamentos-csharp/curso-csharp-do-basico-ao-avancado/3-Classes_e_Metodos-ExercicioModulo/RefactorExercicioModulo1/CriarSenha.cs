using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace RefactorExercicioModulo1
{
    public static class CriarSenha
    {
        public static string Criar()
        {
            ConsoleKeyInfo keyInfo;
            var password = "";
            Console.Write("Digite sua senha: ");
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                {
                    password += keyInfo.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
                    {

                        password = password.Substring(0, (password.Length - 1));
                        Console.Write("b b");
                    }
                }
            }while (keyInfo.Key != ConsoleKey.Enter);

            return password;
        }

        public static bool ValidarSenha(string pass)
        {
            ConsoleKeyInfo keyInfo;
            Console.WriteLine("\n");
            Console.Write("Confirme sua senha: ");
            string confirmacaoSenha = "";
            do
            {
                keyInfo = Console.ReadKey(true);
                if (keyInfo.Key != ConsoleKey.Backspace && keyInfo.Key != ConsoleKey.Enter)
                {
                    confirmacaoSenha += keyInfo.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    if (keyInfo.Key == ConsoleKey.Backspace && confirmacaoSenha.Length > 0)
                    {

                        confirmacaoSenha = confirmacaoSenha.Substring(0, (confirmacaoSenha.Length - 1));
                        Console.Write("b b");
                    }
                }
            } while (keyInfo.Key != ConsoleKey.Enter);

            if(string.Equals(pass, confirmacaoSenha))
            {
                return true;
            } 
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n");
                Console.WriteLine("** ERRO ** - Senhas não coincidem");
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.White;
                System.Threading.Thread.Sleep(1000);
                return false;
            }


        }

    }
}
