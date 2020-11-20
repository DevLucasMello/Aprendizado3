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
    public partial class Form3 : Form
    {
        //Criando as Variáveis           
        public Form3()
        {
            InitializeComponent();                      
        }
        private void buttonCadastrarLivros_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 login5 = new Form4();
            login5.ShowDialog();
        }   

        private void buttonConsultarLivros_Click(object sender, EventArgs e)
        {           
            this.Visible = false;
            Form6 login5 = new Form6();
            login5.ShowDialog();
        }        

        private void buttonAtualizarLivros_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form7 login5 = new Form7();
            login5.ShowDialog();
        }        

        private void buttonExcluirLivros_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form8 login5 = new Form8();
            login5.ShowDialog();
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

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonEmitirRelatorio_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 login5 = new Form9();
            login5.ShowDialog();
        }
    }
}
