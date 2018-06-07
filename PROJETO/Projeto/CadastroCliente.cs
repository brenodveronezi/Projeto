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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        public cl_Cliente cliente_carrega;
        cl_Cliente cliente = new cl_Cliente();

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void frmCadastroCliente_Load(object sender, EventArgs e)
        {


            cmbSexo.DataSource = cliente.ListaSexos();
            cmbSexo.DisplayMember = "nome";
            cmbSexo.ValueMember = "ID_SEXO";
            cmbSexo.SelectedValue = -1;

            cmbUF.DataSource = cliente.ListaUF();
            cmbUF.DisplayMember = "UF";
            cmbUF.ValueMember = "ID";
            cmbUF.SelectedValue = -1;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            cliente.Nome = txtNome.Text;
            cliente.Dt_Nascimento = Convert.ToDateTime(dtpDataNascimento.Text);
            cliente.Endereco = txtEndereco.Text;
            cliente.Complemento = txtComplemento.Text;
            cliente.Bairro = txtBairro.Text;
            cliente.Cidade = cmbCidade.Text;
            cliente.Cep = mtdCep.Text;
            cliente.Cpf = mtdCPF.Text;
            cliente.Rg = txtRG.Text;
            cliente.Telefone_res = mtbFoneResidencial.Text;
            cliente.Telefone_cel = mtbFoneCelular.Text;
            cliente.Email = txtEmail.Text;
            cliente.Sexo = Convert.ToInt16(cmbSexo.SelectedValue);
            //cliente.Salario = txtSalario.Text;

            txtID.Text = Convert.ToString(cliente.Adicionar());

            //this.Close();
        }

        private void frmCadastroCliente_Shown(object sender, EventArgs e)
        {
            if (cliente_carrega != null)
            {
                txtID.Text = cliente_carrega.IdCliente.ToString();
                txtNome.Text = cliente_carrega.Nome;
                dtpDataNascimento.Text = cliente_carrega.Dt_Nascimento.ToShortDateString();
                txtEndereco.Text = cliente_carrega.Endereco;
                txtComplemento.Text = cliente_carrega.Complemento;
                txtBairro.Text = cliente_carrega.Bairro;
                cmbCidade.Text = cliente_carrega.Cidade;
                mtdCep.Text = cliente_carrega.Cep;
                mtdCPF.Text = cliente_carrega.Cpf;
                txtRG.Text = cliente_carrega.Rg;
                mtbFoneResidencial.Text = cliente_carrega.Telefone_res;
                mtbFoneCelular.Text = cliente_carrega.Telefone_cel;
                txtEmail.Text = cliente_carrega.Email;

                //nudSalario.Text = cliente_carrega.Salario.ToString();

                if (cliente_carrega.Sexo != null)
                {
                    cmbSexo.SelectedValue = cliente_carrega.Sexo;
                }

                if (txtID.Text != "")
                {
                    btnSalvar.Text = "Atualizar";
                }
            }
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void cmbUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUF.SelectedIndex != 0)
            {
                cmbCidade.DataSource = cliente.ListaCidadecomUF(Convert.ToInt16(cmbUF.SelectedValue));
                cmbCidade.DisplayMember = "nome";
                cmbCidade.ValueMember = "ID";
                cmbCidade.SelectedValue = -1;
            }
        }

        private void frmCadastroCliente_Shown_1(object sender, EventArgs e)
        {
            if (cliente_carrega != null)
            {
                txtID.Text = cliente_carrega.IdCliente.ToString();
                txtNome.Text = cliente_carrega.Nome;

                if (txtID.Text != "")
                {
                    btnSalvar.Text = "Atualizar";
                }
            }
        }
    }
}
