using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERIES.Modelo
{
    class usuario
    {
        private int codigo;
        private string nome_usuario;
        private string login;
        private string senha;

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

        #region nome_usuario
        public string get_nome_usuario()
        {
            return this.nome_usuario;
        }
        public void set_nome_usuario(string nome_usuario)
        {
            this.nome_usuario = nome_usuario;  
        }
        #endregion

        #region login
        public string get_login()
        {
            return this.login;
        }
        public void set_login(string login)
        {
            this.login = login;
        }
        #endregion  

        #region senha
        public string get_senha()
        {
            return this.senha;
        }
        public void set_senha(string senha)
        {
            this.senha = senha;
        }
        #endregion

    }
}
