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
    public partial class Form70 : Form
    {
        LivroDAO bdLiv;
        Livro livroCs;
        ClienteDAO bdCliente;
        long recebecpf;
        bool check = false;
        int codLivro;
        int quantidade;

        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public long Cliente { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }        
        public Form70(long cpf)
        {
            InitializeComponent();
            bdLiv = new LivroDAO();
            livroCs = new Livro();
            bdCliente = new ClienteDAO();
            recebecpf = cpf;
            codLivro = 0;
            quantidade = 0;
            LimparCampos();
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

        private void Form7_Load(object sender, EventArgs e)
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

        private void buttonConsultarTodos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bdLiv.ConsultaTodos());
            check = true;
        }

        private void buttonComprar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(maskedTextBoxAutor.Text) || maskedTextBoxAutor.Text == "Não Encontrado")
            {
                MessageBox.Show("Necessário Consultar Livro");
            }
            else if(Convert.ToInt32(maskedTextBoxQuantidade.Text) > 0 )
            {
                try 
                {                    
                    Codigo = Convert.ToInt32(maskedTextBoxCodigo.Text);
                    Titulo = maskedTextBoxTitulo.Text;
                    Cliente = recebecpf;

                    Nome = bdCliente.ConsultarNome(Cliente);
                    Telefone = bdCliente.ConsultarTelefone(Cliente);
                    Email = bdCliente.ConsultarEmail(Cliente);

                
                    bdLiv.ComprarLivro(Nome, Telefone, Email, Titulo, Codigo);

                    quantidade = bdLiv.ConsultarQuantidade(Codigo) - 1;
                    bdLiv.AtualizarQuantidade(quantidade, Codigo);

                    MessageBox.Show("Olá " + Nome + ", o livro " + Titulo + " foi comprado com sucesso!");
                    Apagar();
                }
                catch
                {
                    MessageBox.Show("Ocorreu um Erro!");
                    Apagar();
                }
            }
            else if(Convert.ToInt32(maskedTextBoxQuantidade.Text) < 0)
            {
                MessageBox.Show("Não disponível para compra. Caso queira reservá-lo, clique em reservar");
            }
        }

        private void buttonReservar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxAutor.Text) || maskedTextBoxAutor.Text == "Não Encontrado")
            {
                MessageBox.Show("Necessário Consultar Livro");
            }
            else
            {
                try
                {
                    Codigo = Convert.ToInt32(maskedTextBoxCodigo.Text);
                    Titulo = maskedTextBoxTitulo.Text;
                    Cliente = recebecpf;

                    Nome = bdCliente.ConsultarNome(Cliente);
                    Telefone = bdCliente.ConsultarTelefone(Cliente);
                    Email = bdCliente.ConsultarEmail(Cliente);


                    bdLiv.ReservarLivro(Nome, Telefone, Email, Titulo, Codigo);

                    MessageBox.Show("Olá " + Nome + ", o livro " + Titulo + " foi reservado com sucesso!");
                    Apagar();
                }
                catch
                {
                    MessageBox.Show("Ocorreu um Erro!");
                    Apagar();
                }
            }
        }

        private void buttonSair_Click(object sender, EventArgs e)
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

        private void buttonConsultaLivro_Click(object sender, EventArgs e)
        {            
            if (!check && string.IsNullOrEmpty(maskedTextBoxCodigo.Text))
            {
                MessageBox.Show("Necessário Consultar Todos para Continuar");                
            }
            else if (check && string.IsNullOrEmpty(maskedTextBoxCodigo.Text))
            {
                MessageBox.Show("Digite o código do livro.");
            }
            else if (check && !string.IsNullOrEmpty(maskedTextBoxCodigo.Text))
            {
                codLivro = Convert.ToInt32(maskedTextBoxCodigo.Text);                
                maskedTextBoxTitulo.Text = livroCs.TituloConsultado(codLivro);
                maskedTextBoxAutor.Text = livroCs.AutorConsultado(codLivro);
                maskedTextBoxGenero.Text = livroCs.GeneroConsultado(codLivro);
                maskedTextBoxValor.Text = livroCs.ValorConsultado(codLivro);
                maskedTextBoxQuantidade.Text = livroCs.QuantidadeConsultado(codLivro);
                TravarCampos();
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Apagar();
        }

        public void TravarCampos()
        {
            maskedTextBoxCodigo.ReadOnly = true;
            maskedTextBoxTitulo.ReadOnly = true;
            maskedTextBoxAutor.ReadOnly = true;
            maskedTextBoxGenero.ReadOnly = true;
            maskedTextBoxValor.ReadOnly = true;
            maskedTextBoxQuantidade.ReadOnly = true;
        }

        public void LimparCampos()
        {
            maskedTextBoxCodigo.ReadOnly = false;
            maskedTextBoxTitulo.ReadOnly = true;
            maskedTextBoxAutor.ReadOnly = true;
            maskedTextBoxGenero.ReadOnly = true;
            maskedTextBoxValor.ReadOnly = true;
            maskedTextBoxQuantidade.ReadOnly = true;
        }

        public void Apagar()
        {
            maskedTextBoxCodigo.Text = string.Empty;
            maskedTextBoxTitulo.Text = livroCs.Limpar();
            maskedTextBoxAutor.Text = livroCs.Limpar();
            maskedTextBoxGenero.Text = livroCs.Limpar();
            maskedTextBoxValor.Text = livroCs.Limpar();
            maskedTextBoxQuantidade.Text = livroCs.Limpar();
            LimparCampos();
            check = false;
        }
    }
}
