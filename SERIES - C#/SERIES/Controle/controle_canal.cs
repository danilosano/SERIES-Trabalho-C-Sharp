using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SERIES.Modelo;
using System.Data.SqlClient;

namespace SERIES.Controle
{
    class controle_canal
    {
        public string cadastra_canal(canal c)
        {
            string sql = "update canal set nome_canal = @nome_canal, numero = @numero where codigo = @codigo;";

            //objeto que acessa as funções da classe conexoes
            conexoes con = new conexoes();
            
            //conn é uma variável tipo SQLConection que 
            //armazena as informações pra conectar ao banco
            SqlConnection conn = con.obterConexao();
            
            //comm é a váriavel que executa os comandos SQL
            //no banco de dados
            SqlCommand comm = new SqlCommand(sql, conn);

            try
            {
                //comando.Parameters.AddWithValue adiciona o valor a ser gravado no
                //banco copiando diretamente do atributo na classe modelo
                comm.Parameters.AddWithValue("@codigo", c.get_codigo()); 
                comm.Parameters.AddWithValue("@nome_canal", c.get_nome_canal());
                comm.Parameters.AddWithValue("@numero", c.get_numero());
                
                comm.ExecuteNonQuery();
                return "CANAL SALVO COM SUCESSO!";
            }

            catch (SqlException ex)
            {
                return ex.ToString();
                comm.Transaction.Rollback();
            }

        }

        //------ MÉTODO DE PESQUISA DE TODOS OS CANAIS---------------------//

        public SqlDataReader pesquisa_canal(string nome_canal)
        {
            string sql = "select codigo, nome_canal, numero from canal where nome_canal like '" + nome_canal + "%';" ;
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
