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
    public partial class Form2 : Form
    {
        //Declarando a classe Administrador
        Administrador adm;
        private string login;
        private string senha;
        //Método Construtor
        public Form2()
        {
            InitializeComponent();
            ReceberLogin = "";
            ReceberSenha = "";
            adm = new Administrador();
        }
        //Métodos Gets e Sets
        public string ReceberLogin
        {
            get { return login; }
            set { login = value; }
        }
        public string ReceberSenha
        {
            get { return senha;}
            set { senha = value; }
        }
        private void maskedTextBoxLogin_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxSenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        //Método para coleta de dados
        public void ColetaDados()
        {
            login = maskedTextBoxLogin.Text;
            senha = maskedTextBoxSenha.Text;
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                ColetaDados();
                if (adm.DadosAcessoAdm(ReceberLogin, ReceberSenha) == true)
                {
                    this.Visible = false;
                    Form3 login4 = new Form3();
                    login4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos! Digite Novamente.");
                }           
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
        }

        private void buttonRetornar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                Form1 login3 = new Form1();
                login3.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
