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
    public partial class dgRelatorio : Form
    {
        public dgRelatorio()
        {
            InitializeComponent();
        }

        private void dgRelatorio_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'PROJETODataSet.CLIENTE'. Você pode movê-la ou removê-la conforme necessário.
            this.CLIENTETableAdapter.Fill(this.PROJETODataSet.CLIENTE);

            this.reportViewer1.RefreshReport();
        }
    }
}
