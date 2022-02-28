using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RefactorExercicioModulo1
{
    public class ConnectSQLServer
    {

        public void ProcessarQuery(string query, int ident)
        {
            Connect(query, ident);
        }
        public void Connect(string query, int ident)
        {
            var server = @"DESKTOP-1J31FV2\SQLEXPRESS";
            var database = "FichaPessoa";
            var username = "ronis";
            var password = "teste";


            string connString = @"Data Source=" + server + ";Initial Catalog=" + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                Console.WriteLine("Abrindo conexão");
                conn.Open();
                Console.WriteLine("Conexão estabelecida");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            
      

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Query Executada.");

            }

            if (ident == 1)
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader =
                        command.ExecuteReader(CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Console.Write(String.Format("ID {0} - ", reader[0]));
                        Console.Write(String.Format("NOME: {0}\n", reader[1]));
                    }
                }
            }
        }
    }
}
