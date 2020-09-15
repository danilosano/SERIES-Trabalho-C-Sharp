using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERIES.Modelo
{
    class tipoSerie
    {
        private int codigo;
        private string tipo_serie;

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

        #region tipo_serie
        public string get_tipo_serie()
        {
            return this.tipo_serie;
        }

        public void set_tipo_serie(string tipo_serie)
        {
            this.tipo_serie = tipo_serie;
        }
        #endregion

    }
}
