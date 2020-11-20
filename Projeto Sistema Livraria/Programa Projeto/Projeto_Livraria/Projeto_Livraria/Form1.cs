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
    public partial class Form1 : Form
    {
        //Declarando variáveis
        LivroDAO bdLivro;
        public Form1()
        {
            InitializeComponent();
            bdLivro = new LivroDAO();
        }

        private void buttonAcessarAdministrador_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                Form2 login1 = new Form2();
                login1.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
        }

        private void buttonAcessarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                Form60 login2 = new Form60();
                login2.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
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
