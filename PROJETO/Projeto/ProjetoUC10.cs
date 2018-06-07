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
    public partial class ProjetoUC10 : Form
    {
        public ProjetoUC10()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PesquisaCliente formulario = new PesquisaCliente();
            //formulario.ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmPesquisarProduto formulario = new frmPesquisarProduto();
            //formulario.ShowDialog();
        }

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPesquisaCliente formulario = new frmPesquisaCliente();
            formulario.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente formulario = new frmCadastroCliente();
            formulario.ShowDialog();
        }

        private void pesquisarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPesquisarProduto formulario = new frmPesquisarProduto();
            formulario.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorio formulario = new frmRelatorio();
            formulario.ShowDialog();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduto formulario = new frmProduto();
            formulario.ShowDialog();
        }
    }
}
