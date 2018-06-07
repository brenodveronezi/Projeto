using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projeto
{
    public partial class frmProduto : Form
    {
        public frmProduto()
        {
            InitializeComponent();
        }

        public cl_Produto produto_carrega;

        string caminho_imagem = "";

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cl_Produto produto = new cl_Produto();
            produto.Nome = txtNome.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Preco = Convert.ToDouble(txtPreco.Text);
            byte[] dadosDaImagem = ConverterImagemParaBytes(caminho_imagem);
            produto.Imagem = dadosDaImagem;

            txtIDP.Text = Convert.ToString(produto.Adicionar());

            //this.Close();
        }

        private void btnCIMG_Click(object sender, EventArgs e)
        {
            this.Ofd.Multiselect = true;
            this.Ofd.Title = "Selecionar Fotos";
            Ofd.InitialDirectory = @"C:\";
            Ofd.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG;";
            Ofd.CheckFileExists = true;
            Ofd.CheckPathExists = true;
            Ofd.FilterIndex = 2;
            Ofd.RestoreDirectory = true;
            Ofd.ReadOnlyChecked = true;
            Ofd.ShowReadOnly = true;

            DialogResult dr = this.Ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String arquivo in Ofd.FileNames)
                {
                    //lblArquivo.Text += arquivo;
                    try
                    {
                        pbImg.Image = new Bitmap(Ofd.OpenFile());
                        Image Imagem = Image.FromFile(arquivo);
                        pbImg.SizeMode = PictureBoxSizeMode.StretchImage;
                        pbImg.Width = 170;
                        pbImg.Height = 153;
                        pbImg.Image = Imagem;
                        caminho_imagem = arquivo;
                    }
                    catch (Exception)
                    {
                    }

                }
            }
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void frmProduto_Shown(object sender, EventArgs e)
        {
            if (produto_carrega != null)
            {
                txtIDP.Text = produto_carrega.Id_Produto.ToString();
                txtNome.Text = produto_carrega.Nome;
                txtDescricao.Text = produto_carrega.Descricao;
                txtPreco.Text = produto_carrega.Preco.ToString();
                //pbImg = produto_carrega.Imagem();


                if (txtIDP.Text != "")
                {
                    btnSalvar.Text = "Atualizar";
                }
            }
        }

        public byte[] ConverterImagemParaBytes(string caminhoImagem)
        {
            byte[] arraybytes = null;

            FileInfo informacoesFicnheiro = new FileInfo(caminhoImagem);
            long numeroBytes = informacoesFicnheiro.Length;

            FileStream fStream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);

            arraybytes = br.ReadBytes((int)numeroBytes);

            return arraybytes;
        }
    }
}