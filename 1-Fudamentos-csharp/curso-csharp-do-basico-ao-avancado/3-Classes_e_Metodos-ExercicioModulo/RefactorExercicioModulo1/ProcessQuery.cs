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
            SqlCommand command = new SqlCommand(Query, ConnectSQLServer.Connect(1));
            command.ExecuteNonQuery();
            ConnectSQLServer.Connect(0);

        }

        public void Consultar()
        {
            SqlCommand command = new SqlCommand(Query, ConnectSQLServer.Connect(1));
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.Write(String.Format("ID {0} - ", reader[0]));
                Console.Write(String.Format("NOME: {0}\n", reader[1]));
            }
            ConnectSQLServer.Connect(0);

        }

        public void Deletar()
        {
            SqlCommand command = new SqlCommand(Query, ConnectSQLServer.Connect(1));
            command.ExecuteNonQuery();
            ConnectSQLServer.Connect(0);
        }

        public bool FazerLogin()
        {

            SqlCommand command = new SqlCommand(Query, ConnectSQLServer.Connect(1));
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                
                return false;
            }
            //try
            //{
            //    SqlCommand command = new SqlCommand(Query, ConnectSQLServer.Connect(1));
            //    ConnectSQLServer.Connect(0);
            //    return true;
            //}
            //catch
            //{
            //    Console.WriteLine("** Erro **  - Encerrando");
            //    return false;
            //}
        }

        public string RetornarPessoaNome()
        {
            SqlCommand command = new SqlCommand(Query, ConnectSQLServer.Connect(1));
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string nome = (string)reader[1];
            ConnectSQLServer.Connect(0);
            return nome;     
        }

        public float RetornarPessoaSaldo()
        {
            SqlCommand command = new SqlCommand(Query, ConnectSQLServer.Connect(1));
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            float saldo = Convert.ToSingle(reader[9]);
            ConnectSQLServer.Connect(0);
            return saldo;
        }

        public int RetornarPessoaIdentificador()
        {
            SqlCommand command = new SqlCommand(Query, ConnectSQLServer.Connect(1));
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            int identificador = (int)reader[7];
            ConnectSQLServer.Connect(0);
            return identificador;
        }
    }
}
