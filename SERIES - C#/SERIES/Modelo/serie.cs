using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERIES.Modelo
{
    class serie
    {

        private int codigo;
        private string nome_serie;
        private string horario;
        private string sinopse;
        private int cod_canal;
        private int cod_tipo;

        #region codigo
        public int get_codigo()
        {
            return this.codigo;
        }

        public void set_codigo(int codigo)
        {
            this.codigo = codigo;
        }
        #endregion

        #region nome_serie
        public string get_nome_serie()
        {
            return this.nome_serie;
        }

        public void set_nome_serie(string nome_serie)
        {
            this.nome_serie = nome_serie;
        }
        #endregion

        #region horario
        public string get_horario()
        {
            return this.horario;
        }

        public void set_horario(string horario)
        {
            this.horario = horario;
        }
        #endregion

        #region sinopse
        public string get_sinopse()
        {
            return this.sinopse;
        }

        public void set_sinopse(string sinopse)
        {
            this.sinopse = sinopse;
        }
        #endregion

        #region cod_canal
        public int get_cod_canal()
        {
            return this.cod_canal;
        }

        public void set_cod_canal(int cod_canal)
        {
            this.cod_canal = cod_canal;
        }
        #endregion

        #region cod_tipo
        public int get_cod_tipo()
        {
            return this.cod_tipo;
        }

        public void set_cod_tipo(int cod_tipo)
        {
            this.cod_tipo = cod_tipo;
        }
        #endregion

    }
}
