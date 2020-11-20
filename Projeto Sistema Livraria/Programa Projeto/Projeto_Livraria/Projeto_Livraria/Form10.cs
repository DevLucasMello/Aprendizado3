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
    public partial class Form10 : Form
    {
        long recebecpf;
        public Form10(long cpf)
        {
            InitializeComponent();
            recebecpf = cpf;
        }        

        private void buttonConsultarConta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form12 login7 = new Form12(recebecpf);
            login7.ShowDialog();
        }

        private void buttonAtualizarConta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form13 login7 = new Form13(recebecpf);
            login7.ShowDialog();
        }

        private void buttonExcluirConta_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form14 login5 = new Form14(recebecpf);
            login5.ShowDialog();
        }

        private void buttonFazerCompra_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                Form70 login7 = new Form70(recebecpf);
                login7.ShowDialog();
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

        private void Form5_FormClosing(object sender, FormClosingEventArgs e)
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
