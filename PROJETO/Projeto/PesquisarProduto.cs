using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class frmPesquisarProduto : Form
    {
        public frmPesquisarProduto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPesquisarProduto_Load(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {
            cl_Produto produto = new cl_Produto();
            //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
            produto.Nome = txtProduto.Text;
            dgProduto.DataSource = produto.PesquisaPorNome();
            //dgCliente.Columns[6].Visible = false;
            dgProduto.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgProduto_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgProduto.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 cliente para editar", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cl_Produto produto = new cl_Produto();
            produto.Id_Produto = Convert.ToInt32(linha[0].Cells[0].Value);
            produto.Nome = linha[0].Cells[1].Value.ToString();
            produto.Descricao = linha[0].Cells[2].Value.ToString();
            produto.Preco = Convert.ToDouble(linha[0].Cells[3].Value.ToString() );
           // produto.Imagem =

            frmProduto formulario = new frmProduto();
            formulario.produto_carrega = produto;
            formulario.ShowDialog();
            txtProduto_TextChanged(sender, e);
        }
    }
}
