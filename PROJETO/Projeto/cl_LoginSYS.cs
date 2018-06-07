using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class cl_LoginSYS
    {
        private int id_Login;
        private string login;
        private string senha;
        private int id_Funcionario;

        public int Id_Login
        {
            get { return id_Login; }
            set { id_Login = value; }
        }

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int Id_Funcionario
        {
            get { return id_Funcionario; }
            set { id_Funcionario = value; }
        }

        public int Adicionar()
        {
            //throw new System.NotImplementedException();
            return 0;
        }

        public void Atualizar()
        {
            //throw new System.NotImplementedException();
        }

        public void Deletar()
        {
            //throw new System.NotImplementedException();
        }

        public void Listar()
        {
            //throw new System.NotImplementedException();
        }
    }
}
