using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using SERIES.Modelo;

namespace SERIES.Controle
{
    class controle_serie
    {
        public string cadastra_serie(serie s)
        {
            string sql = "insert into serie(nome_serie, horario, sinopse, cod_tipo, cod_canal) values"
                + " (@nome_serie, @horario, @sinopse, @cod_tipo, @cod_canal);";
            
            conexoes con = new conexoes();
            SqlConnection conn = con.obterConexao();
            SqlCommand comm = new SqlCommand(sql, conn);

            try
            {
                //comando.Parameters.AddWithValue adiciona o valor a ser gravado no
                //banco copiando diretamente do atributo na classe modelo
                comm.Parameters.AddWithValue("@nome_serie", s.get_nome_serie());
                comm.Parameters.AddWithValue("@horario", s.get_horario());
                comm.Parameters.AddWithValue("@sinopse", s.get_sinopse());
                comm.Parameters.AddWithValue("@cod_tipo", s.get_cod_tipo());
                comm.Parameters.AddWithValue("@cod_canal", s.get_cod_canal());

                comm.ExecuteNonQuery();
                return "SÉRIE CADASTRADA COM SUCESSO!";
            }

            catch (SqlException ex)
            {
                return ex.ToString();
            }

        }//fim do método

        public SqlDataReader pesquisa_serie(string nome_serie)
        {
            string sql = "select s.nome_serie, s.horario, s.sinopse, ts.tipo_serie, c.nome_canal from serie s"
            + " inner join tipo_serie ts on s.cod_tipo = ts.codigo inner join canal c on s.cod_canal = c.codigo"
            + " where s.nome_serie like '" + nome_serie + "%';" ;

            conexoes con = new conexoes();
            SqlConnection conn = con.obterConexao();
            SqlCommand comm = new SqlCommand(sql, conn);

            SqlDataReader dados = comm.ExecuteReader();
            return dados;
        }
    }
}
