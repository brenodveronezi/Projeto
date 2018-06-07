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
    public partial class frmPesquisaCliente : Form
    {
        public frmPesquisaCliente()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            cl_Cliente cliente = new cl_Cliente();
            //Mapeia a origen dos dados, pegando o retorno do PesquisaPorNome, que será um Datatable
            cliente.Nome = txtCliente.Text;
            dgCliente.DataSource = cliente.PesquisaPorNome();
            //dgCliente.Columns[6].Visible = false;
            dgCliente.AutoResizeColumns();
        }

        private void dgCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha_selecionada = dgCliente.SelectedRows;

            if (linha_selecionada.Count != 1)
            {
                MessageBox.Show("Selecione pelo menos 1 registro para ser removido.");
            }
            else
            {
                cl_Cliente cliente = new cl_Cliente();
                cliente.IdCliente = Convert.ToInt32(linha_selecionada[0].Cells[0].Value.ToString());
                cliente.Deletar();
                txtCliente_TextChanged(sender, e);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgCliente.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 cliente para editar", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cl_Cliente cliente = new cl_Cliente();
            cliente.IdCliente = Convert.ToInt32(linha[0].Cells[0].Value);
            /*
            cliente.Nome = linha[0].Cells[1].Value.ToString();
            cliente.Dt_Nascimento = Convert.ToDateTime(linha[0].Cells[3].Value.ToString());
            cliente.Endereco = linha[0].Cells[3].Value.ToString();
            cliente.Complemento = linha[0].Cells[4].Value.ToString();
            cliente.Bairro = linha[0].Cells[5].Value.ToString();
            cliente.Cidade = linha[0].Cells[6].Value.ToString();
            cliente.Cep = linha[0].Cells[7].Value.ToString();
            cliente.Cpf = linha[0].Cells[8].Value.ToString();
            cliente.Rg = linha[0].Cells[9].Value.ToString();
            cliente.Telefone_res = linha[0].Cells[10].Value.ToString();
            cliente.Telefone_cel = linha[0].Cells[11].Value.ToString();
            cliente.Email = linha[0].Cells[12].Value.ToString();
            cliente.Sexo = Convert.ToInt16(linha[0].Cells[13].Value.ToString());
            */
            //cliente.Salario = Convert.ToDouble(linha[0].Cells[14].Value.ToString());

            frmCadastroCliente formulario = new frmCadastroCliente();
            formulario.cliente_carrega = cliente;
            formulario.ShowDialog();
            txtCliente_TextChanged(sender, e);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            frmCadastroCliente formulario = new frmCadastroCliente();
            formulario.ShowDialog();
        }

        private void frmPesquisaCliente_Load(object sender, EventArgs e)
        {

        }

        private void dgCliente_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection linha = dgCliente.SelectedRows;

            if (linha.Count != 1)
            {
                MessageBox.Show("Selecione 1 cliente para editar", "Cliente não selecionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cl_Cliente cliente = new cl_Cliente();
            cliente.IdCliente = Convert.ToInt32(linha[0].Cells[0].Value);
            cliente.Nome = linha[0].Cells[1].Value.ToString();

            frmCadastroCliente formulario = new frmCadastroCliente();
            formulario.cliente_carrega = cliente;
            formulario.ShowDialog();
            txtCliente_TextChanged(sender, e);
        }
    }
}
