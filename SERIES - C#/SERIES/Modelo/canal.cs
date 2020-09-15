using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERIES
{
    class canal
    {
        private int codigo;
        private string nome_canal;
        private int numero;

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

        #region nome_canal
        public string get_nome_canal()
        {
            return this.nome_canal;
        }

        public void set_nome_canal(string nome_canal)
        {
            this.nome_canal = nome_canal;
        }
        #endregion

        #region numero
        public int get_numero()
        {
            return this.numero;
        }

        public void set_numero(int numero)
        {
            this.numero = numero;
        }
        #endregion

    }
}
