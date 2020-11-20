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
    public partial class Form11 : Form
    {
        //Criando as Variáveis
        ClienteDAO bdCli;
        private long CPFCliente;
        private string senhaCliente, nomeCliente, ruaCliente, numeroCliente, CEPCliente, cidadeCliente, bairroCliente, UFCliente, paisCliente, telefoneCliente, emailCliente, recebe;
        public string num3, num6, num9, num11;
        
        public Form11()
        {
            InitializeComponent();
            bdCli = new ClienteDAO();
            ConsultaCPFCliente = 0;
            ConsultaSenhaCliente = "";
            ConsultaNomeCliente = "";
            ConsultaRuaCliente = "";
            ConsultaNumeroCliente = "";
            ConsultaCEPCliente = "";
            ConsultaCidadeCliente = "";
            ConsultaBairroCliente = "";
            ConsultaUFCliente = "";
            ConsultaPaisCliente = "";
            ConsultaTelefoneCliente = "";
            ConsultaEmailCliente = "";
            RecebeRec = "";
            num3 = "";
            num6 = "";
            num9 = "";
            num11 = "";
        }

        //Ciando os Métodos Gets e Sets        
        public long ConsultaCPFCliente
        {
            get { return CPFCliente; }
            set { this.CPFCliente = value; }
        }
        public string ConsultaSenhaCliente
        {
            get { return senhaCliente; }
            set { this.senhaCliente = value; }
        }
        public string ConsultaNomeCliente
        {
            get { return nomeCliente; }
            set { this.nomeCliente = value; }
        }
        public string ConsultaRuaCliente
        {
            get { return ruaCliente; }
            set { this.ruaCliente = value; }
        }
        public string ConsultaNumeroCliente
        {
            get { return numeroCliente; }
            set { this.numeroCliente = value; }
        }
        public string ConsultaCEPCliente
        {
            get { return CEPCliente; }
            set { this.CEPCliente = value; }
        }
        public string ConsultaCidadeCliente
        {
            get { return cidadeCliente; }
            set { this.cidadeCliente = value; }
        }
        public string ConsultaBairroCliente
        {
            get { return bairroCliente; }
            set { this.bairroCliente = value; }
        }
        public string ConsultaUFCliente
        {
            get { return UFCliente; }
            set { this.UFCliente = value; }
        }
        public string ConsultaPaisCliente
        {
            get { return paisCliente; }
            set { this.paisCliente = value; }
        }
        public string ConsultaTelefoneCliente
        {
            get { return telefoneCliente; }
            set { this.telefoneCliente = value; }
        }
        public string ConsultaEmailCliente
        {
            get { return emailCliente; }
            set { this.emailCliente = value; }
        }
        public string RecebeRec
        {
            get { return recebe; }
            set { this.recebe = value; }
        }
        private void maskedTextBoxCPFouCNPJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxNome_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxRua_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxBairro_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxCidade_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxUF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxPais_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxTelefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxEmail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaCPFCliente = Convert.ToInt64(ReceberCPF());
                ConsultaSenhaCliente = maskedTextBoxSenha.Text;
                ConsultaNomeCliente = maskedTextBoxNome.Text.ToUpper();
                ConsultaRuaCliente = maskedTextBoxRua.Text.ToUpper();
                ConsultaNumeroCliente = maskedTextBoxNumero.Text;
                ConsultaCEPCliente = maskedTextBoxCEP.Text;
                ConsultaCidadeCliente = maskedTextBoxCidade.Text.ToUpper();
                ConsultaBairroCliente = maskedTextBoxBairro.Text.ToUpper();
                ConsultaUFCliente = maskedTextBoxUF.Text.ToUpper();
                ConsultaPaisCliente = maskedTextBoxPais.Text.ToUpper();
                ConsultaTelefoneCliente = maskedTextBoxTelefone.Text;
                ConsultaEmailCliente = maskedTextBoxEmail.Text;                
                //Método para Cadastrar os dados no Banco de Dados
                bdCli.Cadastrar(ConsultaCPFCliente, ConsultaSenhaCliente, ConsultaNomeCliente, ConsultaRuaCliente, ConsultaNumeroCliente, ConsultaCEPCliente, ConsultaCidadeCliente, ConsultaBairroCliente, ConsultaUFCliente, ConsultaPaisCliente, ConsultaTelefoneCliente, ConsultaEmailCliente);
                Limpar();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Não foi possível inserir os dados!\n\n" + erro);      
                                
            }
        }
        public string ReceberCPF()
        {
            RecebeRec = maskedTextBoxCPFouCNPJ.Text;//000.000.000-00
            num3 = RecebeRec.Substring(0,3);
            num6 = RecebeRec.Substring(4,3);
            num9 = RecebeRec.Substring(8, 3);
            num11 = RecebeRec.Substring(12, 2);
            return RecebeRec = num3 + num6 + num9 + num11;
        }       

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void buttonRetornar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form60 login5 = new Form60();
            login5.ShowDialog();
        }

        private void Form11_FormClosing(object sender, FormClosingEventArgs e)
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
        public void Limpar()
        {
            maskedTextBoxCPFouCNPJ.Text = "";
            maskedTextBoxSenha.Text = "";
            maskedTextBoxNome.Text = "";
            maskedTextBoxRua.Text = "";
            maskedTextBoxNumero.Text = "";
            maskedTextBoxCEP.Text = "";
            maskedTextBoxCidade.Text = "";
            maskedTextBoxBairro.Text = "";
            maskedTextBoxUF.Text = "";
            maskedTextBoxPais.Text = "";
            maskedTextBoxTelefone.Text = "";
            maskedTextBoxEmail.Text = "";
        }
    }
}
