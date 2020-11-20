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
    public partial class Form8 : Form
    {
        //Criando as Variáveis
        LivroDAO bdLiv;
        Livro livroCs;
        private int qtdLivro, codigoLivro;
        private string tituloLivro, autorLivro, generoLivro;
        private double valorLivro;
        public bool consult;

        public Form8()
        {
            InitializeComponent();
            bdLiv = new LivroDAO();
            livroCs = new Livro();
            maskedTextBoxCodigo.ReadOnly = true;
            maskedTextBoxTitulo.ReadOnly = true;
            maskedTextBoxAutor.ReadOnly = true;
            maskedTextBoxGenero.ReadOnly = true;
            maskedTextBoxValor.ReadOnly = true;
            maskedTextBoxQuantidade.ReadOnly = true;
            ConsultaTituloLivro = "";
            ConsultaAutorLivro = "";
            ConsultaGeneroLivro = "";
            ConsultaValorLivro = 0;
            ConsultaQtdLivro = 0;
            consult = false;
        }

        //Criando os Métodos Gets e Sets        
        public int ConsultaCodigoLivro
        {
            get { return codigoLivro; }
            set { codigoLivro = value; }
        }
        public string ConsultaTituloLivro
        {
            get { return tituloLivro; }
            set { tituloLivro = value; }
        }
        public string ConsultaAutorLivro
        {
            get { return autorLivro; }
            set { autorLivro = value; }
        }
        public string ConsultaGeneroLivro
        {
            get { return generoLivro; }
            set { generoLivro = value; }
        }
        public double ConsultaValorLivro
        {
            get { return valorLivro; }
            set { valorLivro = value; }
        }
        public int ConsultaQtdLivro
        {
            get { return qtdLivro; }
            set { qtdLivro = value; }
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

        private void maskedTextBoxGenero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxValor_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxQuantidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            maskedTextBoxCodigo.ReadOnly = true;
            if (consult == true)
            {               
                bdLiv.Excluir(ConsultaCodigoLivro);
                consult = false;
                maskedTextBoxCodigo.ReadOnly = true;
                maskedTextBoxTitulo.ReadOnly = true;
                maskedTextBoxAutor.ReadOnly = true;
                maskedTextBoxGenero.ReadOnly = true;
                maskedTextBoxValor.ReadOnly = true;
                maskedTextBoxQuantidade.ReadOnly = true;
                maskedTextBoxCodigo.Text = livroCs.Limpar();
                maskedTextBoxTitulo.Text = livroCs.Limpar();
                maskedTextBoxAutor.Text = livroCs.Limpar();
                maskedTextBoxGenero.Text = livroCs.Limpar();
                maskedTextBoxValor.Text = livroCs.Limpar();
                maskedTextBoxQuantidade.Text = livroCs.Limpar();
            }
            else
            {
                MessageBox.Show("Precisa Consultar para poder Excluir");
            }
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCodigo.ReadOnly = false;
            maskedTextBoxTitulo.ReadOnly = true;
            maskedTextBoxAutor.ReadOnly = true;
            maskedTextBoxGenero.ReadOnly = true;
            maskedTextBoxValor.ReadOnly = true;
            maskedTextBoxQuantidade.ReadOnly = true;
            if (maskedTextBoxCodigo.Text != "")
            {
                ConsultaExcluir();
                consult = true;
                MessageBox.Show("Cheque os dados e clique em --Excluir--" +
                                "\n\n                                       ou                      " +
                                "\n\nclique em --Cancelar-- para Manter registros");
                maskedTextBoxCodigo.ReadOnly = true;                
            }
            else
            {
                MessageBox.Show("Informa o código para Consulta");
            }
        }
        
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCodigo.ReadOnly = true;
            maskedTextBoxTitulo.ReadOnly = true;
            maskedTextBoxAutor.ReadOnly = true;
            maskedTextBoxGenero.ReadOnly = true;
            maskedTextBoxValor.ReadOnly = true;
            maskedTextBoxQuantidade.ReadOnly = true;
            maskedTextBoxCodigo.Text = livroCs.Limpar();
            maskedTextBoxTitulo.Text = livroCs.Limpar();
            maskedTextBoxAutor.Text = livroCs.Limpar();
            maskedTextBoxGenero.Text = livroCs.Limpar();
            maskedTextBoxValor.Text = livroCs.Limpar();
            maskedTextBoxQuantidade.Text = livroCs.Limpar();
            consult = false;
        }

        private void buttonRetornar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 login5 = new Form3();
            login5.ShowDialog();
        }       

        public void ConsultaExcluir()
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
    }
}
