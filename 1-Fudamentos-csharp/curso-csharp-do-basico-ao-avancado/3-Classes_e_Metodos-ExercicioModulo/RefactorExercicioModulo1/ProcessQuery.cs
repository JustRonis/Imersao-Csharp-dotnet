using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RefactorExercicioModulo1
{
    public class ProcessQuery
    {
        public string Query { get; set; }
        public ProcessQuery(string query)
        {
            Query = query;
        }

        public void Inserir()
        {
            SqlCommand command = new SqlCommand(Query, ConnectSQLServer.Connect());
            command.ExecuteNonQuery();
        }

        public void Consultar()
        {

            SqlCommand command = new SqlCommand(Query,ConnectSQLServer.Connect());
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(String.Format("ID {0} - ", reader[0]));
                Console.Write(String.Format("NOME: {0}\n", reader[1]));
            }

        }

    }
}
