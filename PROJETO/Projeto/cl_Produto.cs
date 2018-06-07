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
    public class cl_Produto
    {
        private int id_Produto;
        private string nome;
        private string descricao;
        private double preco;
        private byte[] imagem;

        conectaBD BD = new conectaBD();

        public int Id_Produto
        {
            get { return id_Produto; }
            set { id_Produto = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public byte[] Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }

        public int Adicionar()
        {
            int id = 0;
            try
            {
                BD._sql = String.Format(new CultureInfo("en-US"), "INSERT INTO PRODUTO (NOME,DESCRICAO,PRECO,IMAGEM) " +
                                        " values ('{0}','{1}','{2}','{3}')", nome, descricao, preco, (object)imagem) + "; SELECT SCOPE_IDENTITY();";


                BD.ExecutaComando(false, out id);

                if (id > 0)
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Cadastro com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
           // throw new System.NotImplementedException();
        }

        public void Deletar()
        {
            try
            {
                int exOK = 0;
                BD._sql = String.Format("DELETE FROM CLIENTE WHERE ID_CLIENTE = '{0}'", id_Produto);

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

        public DataTable PesquisaPorNome()
        {
            try
            {
                BD._sql = "SELECT C.ID_PRODUTO as 'Id', C.NOME as 'Nome', C.DESCRICAO as 'Descricao', " +
                                 " C.PRECO as 'Preco' " +
                "  FROM PRODUTO C " +
                "  WHERE C.NOME LIKE '%" + nome + "%'";

                return BD.ExecutaSelect();
            }
            catch (Exception)
            {
            }

            return null;

        }

        public void Listar()
        {
           // throw new System.NotImplementedException();
        }
    }
}
