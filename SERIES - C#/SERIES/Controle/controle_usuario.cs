using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


namespace SERIES.Controle
{
    class controle_usuario
    {



        public SqlDataReader pesquisa_usuario(string login, string senha)
        {
            string sql = "select * from usuario where login_user = '" + login + "' and senha = '" + senha + "';";
            SqlDataReader dados;//armazena o resultado da consulta sql

            conexoes conecta = new conexoes();//objeto da classe conexoes
            SqlConnection conn = conecta.obterConexao();//conecta ao banco
            SqlCommand com = new SqlCommand(sql, conn);//executa o sql

            try
            {
                dados = com.ExecuteReader();//faz a consulta no BD
                return dados;//envia ao form o resultado da consulta

            }
            catch (SqlException ex)
            {
                return null;
            }

          }
    }
}
