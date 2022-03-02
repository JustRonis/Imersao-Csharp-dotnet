using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RefactorExercicioModulo1
{
    public static class ConnectSQLServer
    {
        public static SqlConnection Connect(int ident)
        {
            var server = @"DESKTOP-1J31FV2\SQLEXPRESS";
            var database = "FichaPessoa";
            var username = "ronis";
            var password = "teste";

            string connString = @"Data Source=" + server + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            
            if(ident == 1)
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }

            if(ident == 0)
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
        
            return conn;

        }
                
    }
}

