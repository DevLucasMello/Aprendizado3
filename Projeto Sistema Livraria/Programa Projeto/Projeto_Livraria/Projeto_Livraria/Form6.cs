using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Livraria
{
    public partial class Form6 : Form
    {
        //Criando as Variáveis
        LivroDAO bdLiv;
        Livro livroCs;
        private int codigoLivro;
          
        
        public Form6()
        {
            InitializeComponent();
            bdLiv = new LivroDAO();
            livroCs = new Livro();
            maskedTextBoxCodigo.ReadOnly = false;
            maskedTextBoxTitulo.ReadOnly = true;
            maskedTextBoxAutor.ReadOnly = true;
            maskedTextBoxGenero.ReadOnly = true;
            maskedTextBoxValor.ReadOnly = true;
            maskedTextBoxQuantidade.ReadOnly = true;
            ConsultaCodigoLivro = 0;            
        }
        //Criando os Métodos Gets e Sets        
        public int ConsultaCodigoLivro
        {
            get { return codigoLivro; }
            set { codigoLivro = value; }
        }     

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
        }

        private void maskedTextBoxCodigo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxTitulo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxAutor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCodigo.Text = livroCs.Limpar();
            maskedTextBoxTitulo.Text = livroCs.Limpar();
            maskedTextBoxAutor.Text = livroCs.Limpar();
            maskedTextBoxGenero.Text = livroCs.Limpar();
            maskedTextBoxValor.Text = livroCs.Limpar();
            maskedTextBoxQuantidade.Text = livroCs.Limpar();
        }

        private void maskedTextBoxGenero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxQuantidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {            
            try
            {
                ConsultaCodigoLivro = Convert.ToInt32(maskedTextBoxCodigo.Text);
                maskedTextBoxTitulo.Text = livroCs.TituloConsultado(ConsultaCodigoLivro);
                maskedTextBoxAutor.Text = livroCs.AutorConsultado(ConsultaCodigoLivro);
                maskedTextBoxGenero.Text = livroCs.GeneroConsultado(ConsultaCodigoLivro);
                maskedTextBoxValor.Text = livroCs.ValorConsultado(ConsultaCodigoLivro);
                maskedTextBoxQuantidade.Text = livroCs.QuantidadeConsultado(ConsultaCodigoLivro);
            }
            catch
            {
                MessageBox.Show("Informe o Código!");
            }
        }
        private void buttonRetornar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 login5 = new Form3();
            login5.ShowDialog();
        }      
    }
}
