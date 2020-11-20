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
    public partial class Form7 : Form
    {
        //Criando as Variáveis
        LivroDAO bdLiv;
        Livro livroCs;
        private int qtdLivro, codigoLivro;
        private string tituloLivro, autorLivro, generoLivro;
        private double valorLivro;
        public bool consult;
 
        public Form7()
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

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {            
            if (consult == true)
            {
                ConsultaTituloLivro = maskedTextBoxTitulo.Text.ToUpper();
                ConsultaAutorLivro = maskedTextBoxAutor.Text.ToUpper();
                ConsultaGeneroLivro = maskedTextBoxGenero.Text.ToUpper();
                ConsultaValorLivro = Convert.ToDouble(maskedTextBoxValor.Text);
                ConsultaQtdLivro = Convert.ToInt32(maskedTextBoxQuantidade.Text);
                AtualizaIndividual();                
                consult = false;
                maskedTextBoxCodigo.ReadOnly = true;
                maskedTextBoxTitulo.ReadOnly = true;
                maskedTextBoxAutor.ReadOnly = true;
                maskedTextBoxGenero.ReadOnly = true;
                maskedTextBoxValor.ReadOnly = true;
                maskedTextBoxQuantidade.ReadOnly = true;
            }
            else
            {
                MessageBox.Show("Precisa Consultar para poder Atualizar");
            }
        }

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
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
                consult = true;
                if ((maskedTextBoxCodigo.Text != "") && (maskedTextBoxTitulo.Text != "") && (maskedTextBoxAutor.Text != "") && (maskedTextBoxGenero.Text != ""))
                {
                    MessageBox.Show("Modifique os campos de deseja e clique em --Atualizar--" +
                                "\n\n                                       ou                      " +
                                "\n\nclique em --Cancelar-- para Manter registros");
                    maskedTextBoxCodigo.ReadOnly = true;
                    maskedTextBoxTitulo.ReadOnly = false;
                    maskedTextBoxAutor.ReadOnly = false;
                    maskedTextBoxGenero.ReadOnly = false;
                    maskedTextBoxValor.ReadOnly = false;
                    maskedTextBoxQuantidade.ReadOnly = false;
                }
                else
                {
                    MessageBox.Show("Livro não encontrado!");
                }
                    
            }
            else
            {
                MessageBox.Show("Informa o código para Consulta");
            }
        }

        public void AtualizaIndividual()
        {
            try
            {
                if ((maskedTextBoxCodigo.Text == "") || (maskedTextBoxTitulo.Text == "") || (maskedTextBoxAutor.Text == "") || (maskedTextBoxGenero.Text == "") || (maskedTextBoxValor.Text == "") || (maskedTextBoxQuantidade.Text == ""))
                {
                    MessageBox.Show("Um ou mais campos estão vazios!");
                }
                else
                {
                    livroCs.TituloAtualizado(ConsultaTituloLivro, ConsultaCodigoLivro);
                    livroCs.AutorAtualizado(ConsultaAutorLivro, ConsultaCodigoLivro);
                    livroCs.GeneroAtualizado(ConsultaGeneroLivro, ConsultaCodigoLivro);
                    livroCs.ValorAtualizado(ConsultaValorLivro, ConsultaCodigoLivro);
                    livroCs.QuantidadeAtualizado(ConsultaQtdLivro, ConsultaCodigoLivro);                    
                    MessageBox.Show("Dado Atualizado com Sucesso!");
                    maskedTextBoxCodigo.Text = livroCs.Limpar();
                    maskedTextBoxTitulo.Text = livroCs.Limpar();
                    maskedTextBoxAutor.Text = livroCs.Limpar();
                    maskedTextBoxGenero.Text = livroCs.Limpar();
                    maskedTextBoxValor.Text = livroCs.Limpar();
                    maskedTextBoxQuantidade.Text = livroCs.Limpar();
                }
            }
            catch
            {
                MessageBox.Show("Informe o código que deverá ser atualidado e o respectivo campo!");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            maskedTextBoxCodigo.Text = livroCs.Limpar();
            maskedTextBoxTitulo.Text = livroCs.Limpar();
            maskedTextBoxAutor.Text = livroCs.Limpar();
            maskedTextBoxGenero.Text = livroCs.Limpar();
            maskedTextBoxValor.Text = livroCs.Limpar();
            maskedTextBoxQuantidade.Text = livroCs.Limpar();
            maskedTextBoxCodigo.ReadOnly = true;
            maskedTextBoxTitulo.ReadOnly = true;
            maskedTextBoxAutor.ReadOnly = true;
            maskedTextBoxGenero.ReadOnly = true;
            maskedTextBoxValor.ReadOnly = true;
            maskedTextBoxQuantidade.ReadOnly = true;
            consult = false;
        }

        private void buttonRetornar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 login5 = new Form3();
            login5.ShowDialog();
        }       
    }
}
