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
    public partial class Form4 : Form
    {
        //Criando as Variáveis
        LivroDAO bdLiv;
        Livro livroCs;
        private int qtdLivro;
        private string tituloLivro, autorLivro, generoLivro;
        private double valorLivro;        

        public Form4()
        {
            InitializeComponent();
            bdLiv = new LivroDAO();
            livroCs = new Livro();
            maskedTextBoxCodigo.ReadOnly = true;
            ConsultaTituloLivro = "";
            ConsultaAutorLivro = "";
            ConsultaGeneroLivro = "";
            ConsultaValorLivro = 0;
            ConsultaQtdLivro = 0;            
        }

        //Ciando os Métodos Gets e Sets        
        public string ConsultaTituloLivro
        {
            get { return tituloLivro; }
            set { this.tituloLivro = value; }
        }
        public string ConsultaAutorLivro
        {
            get { return autorLivro; }
            set { this.autorLivro = value; }
        }
        public string ConsultaGeneroLivro
        {
            get { return generoLivro; }
            set { this.generoLivro = value; }
        }
        public double ConsultaValorLivro
        {
            get { return valorLivro; }
            set { this.valorLivro = value; }
        }
        public int ConsultaQtdLivro
        {
            get { return qtdLivro; }
            set { this.qtdLivro = value; }
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

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Form4_Load(object sender, EventArgs e)
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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {                
                ConsultaTituloLivro = maskedTextBoxTitulo.Text.ToUpper();
                ConsultaAutorLivro = maskedTextBoxAutor.Text.ToUpper();
                ConsultaGeneroLivro = maskedTextBoxGenero.Text.ToUpper();
                ConsultaValorLivro = Convert.ToDouble(maskedTextBoxValor.Text);
                ConsultaQtdLivro = Convert.ToInt32(maskedTextBoxQuantidade.Text);
                //Método para Cadastrar os dados no Banco de Dados
                bdLiv.Cadastrar(ConsultaTituloLivro, ConsultaAutorLivro, ConsultaGeneroLivro, ConsultaValorLivro, ConsultaQtdLivro);
                maskedTextBoxCodigo.Text = livroCs.Limpar();
                maskedTextBoxTitulo.Text = livroCs.Limpar();
                maskedTextBoxAutor.Text = livroCs.Limpar();
                maskedTextBoxGenero.Text = livroCs.Limpar();
                maskedTextBoxValor.Text = livroCs.Limpar();
                maskedTextBoxQuantidade.Text = livroCs.Limpar();
            }
            catch
            {
                MessageBox.Show("Não foi possível inserir os dados!");
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
