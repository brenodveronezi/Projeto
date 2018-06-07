using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public class cl_Cliente
    {
        private string bairro;
        private string cep;
        private string cidade;
        private string complemento;
        private string cpf;
        private DateTime dt_Nascimento;
        private string email;
        private string endereco;
        private int sexo;
        private int id_Cliente;
        private string nome;
        private string rg;
        private string telefone_cel;
        private string telefone_res;
        private int uf;


        conectaBD BD = new conectaBD();

        public int IdCliente
        {
            get { return id_Cliente; }
            set { id_Cliente = value; }
        }

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

        public int Uf
        {
            get { return uf; }
            set { uf = value; }
        }



        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO CLIENTE (NOME,DT_NASCIMENTO,ENDERECO,COMPLEMENTO,BAIRRO," +
                                                                  "CIDADE,CEP,CPF,RG,TELEFONE_RES,TELEFONE_CEL,EMAIL,SEXO) " +
                                        " values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}')", nome, dt_Nascimento.ToShortDateString(), endereco, complemento, bairro, cidade, cep, cpf, rg, telefone_res, telefone_cel, email, sexo) + "; SELECT SCOPE_IDENTITY();";


                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Cliente cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return id;

        }

        public void Atualizar()
        {
            try
            {
                int exOK = 0;

                BD._sql = String.Format("UPDATE CLIENTE SET NOME = '{0}', dt_nascimento = '{1}', complemento = '{2}', endereco = '{3}', bairro = '{4}', cidade = '{5}', cep = '{6}', cpf = '{7}', rg = '{8}', telefone_res = '{9}', telefone_cel = '{10}', email = '{11}',  sexo = '{12}' " +
                    " WHERE ID_CLIENTE = {13}", nome, dt_Nascimento.ToShortDateString(), complemento, endereco, bairro, cidade, cep, cpf, rg, telefone_res, telefone_cel, email, sexo, id_Cliente);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao atualizar cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cliente atualizado com sucesso!", "Atualizado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Deletar()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM CLIENTE WHERE ID_CLIENTE = '{0}'", id_Cliente);

                exOK = BD.ExecutaComando(false);

                if (exOK < 0)
                {
                    MessageBox.Show("Erro ao deletar Cliente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente deletado com sucesso!", "Deletado com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro.: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;

        }

        public void Listar()
        {
            //throw new System.NotImplementedException();
        }

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT C.ID_CLIENTE as 'Id', C.NOME as 'Nome', C.CPF as 'CPF', " +
                                 " C.DT_NASCIMENTO as 'Nascimento', C.EMAIL as 'Email' " +
                "  FROM CLIENTE C " +
                "  WHERE C.NOME LIKE '%" + nome + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;

        }

        public DataTable ListaSexos()
        {
            try
            {
                BD._sql = "SELECT ID_SEXO, nome FROM SEXO";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;

        }

        public DataTable ListaUF()
        {
            try
            {


                BD._sql = "SELECT ID, uf FROM ESTADO";


                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }

        public DataTable ListaCidade()
        {
            try

            {
                BD._sql = "SELECT id, NOME FROM CIDADE";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;



        }


        public DataTable ListaCidadecomUF(int id_estado)
        {
            try

            {
                BD._sql = "SELECT id, NOME FROM CIDADE WHERE ESTADO = " + id_estado.ToString();

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }
            return null;
        }
    }
}
