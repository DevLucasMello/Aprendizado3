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
    public partial class Form9 : Form
    {
        LivroDAO bdLiv;

        public Form9()
        {
            InitializeComponent();
            bdLiv = new LivroDAO();
        }

        private void buttonLivrosVendidos_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bdLiv.RelatorioLivrosComprados());
        }

        private void buttonLivrosReserva_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bdLiv.RelatorioLivrosReservados());
        }

        private void buttonRetornar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Visible = false;
                Form3 login6 = new Form3();
                login6.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
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
    }
}
