using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    class cl_Funcionario
    {
        private double salario;
        private int id_Funcionario;
        private int id_Login;
        private string senha;
        private string bairro;
        private string cep;
        private string cidade;
        private string complemento;
        private string cpf;
        private DateTime dt_Nascimento;
        private string email;
        private string endereco;
        private int sexo;
        private string nome;
        private string rg;
        private string telefone_cel;
        private string telefone_res;
        private int uf;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime Dt_Nascimento
        {
            get { return dt_Nascimento; }
            set { dt_Nascimento = value; }
        }

        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public string Cep
        {
            get { return cep; }
            set { cep = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public string Telefone_res
        {
            get { return telefone_res; }
            set { telefone_res = value; }
        }

        public string Telefone_cel
        {
            get { return telefone_cel; }
            set { telefone_cel = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public double Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public int Id_Funcionario
        {
            get { return id_Funcionario; }
            set { id_Funcionario = value; }
        }

        public int Id_Login
        {
            get { return id_Login; }
            set { id_Login = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int Uf
        {
            get { return uf; }
            set { uf = value; }
        }

        public int Adicionar()
        {
            //throw new System.NotImplementedException();
            return 0;
        }

        public void Atualizar()
        {
            // throw new System.NotImplementedException();
        }

        public void Deletar()
        {
            // throw new System.NotImplementedException();
        }

        public void Listar()
        {
            //throw new System.NotImplementedException();
        }
    }
}
