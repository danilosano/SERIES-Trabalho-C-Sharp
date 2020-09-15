using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;//usar as funções sql (classe)



namespace SERIES.Controle
{
    class conexoes
    {
        //@server = nome do servidor
        //Database = nome do banco
        //integrated security = forma de conexão
        //true habilita a autenticação via user do Windows

        private static string connString =
        @"server = LAB_03\SQLEXPRESS;
        Database = 2ETIM;
        integrated security = true;";

        public static SqlConnection conn = null;

        public SqlConnection obterConexao()
        {   // vamos criar a conexão
            conn = new SqlConnection(connString);
            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (SqlException ex)
            {
                conn = null;
            }

            return conn;
        }

        public void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }








    }
}
