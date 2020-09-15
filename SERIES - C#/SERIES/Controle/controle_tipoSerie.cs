using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using SERIES.Modelo;

namespace SERIES.Controle
{
    class controle_tipoSerie
    {

        public string cadastra_tipo_serie(tipoSerie ts)
        {
            string sql = "insert into tipo_serie(tipo_serie) values (@tipo_serie);";

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
                comm.Parameters.AddWithValue("@tipo_serie",ts.get_tipo_serie());
               
                comm.ExecuteNonQuery();
                return "TIPO DE SERIE SALVO COM SUCESSO!";
            }

            catch (SqlException ex)
            {
                return ex.ToString();
            }

        }

        //---------------- MÉTODO QUE PESQUISA TODOS OS TIPOS ---------------------//

        public SqlDataReader pesquisa_tipoSerie(string tipo_serie)
        {
            string sql = "select codigo, tipo_serie from tipo_serie;";
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
