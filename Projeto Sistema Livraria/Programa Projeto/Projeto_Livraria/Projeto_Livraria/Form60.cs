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
    public partial class Form60 : Form
    {
        ClienteDAO bdCli;
        private long validaCPF, CPFBd;
        private string validaSenha, senhaBd, nomeBd, recebe;
        public string num3, num6, num9, num11;

        public Form60()
        {
            InitializeComponent();
            bdCli = new ClienteDAO();
            ConsultaValidaCPF = 0;
            ConsultaValidaSenha = "";
            ConsultaNomeBD = "";
            ConsultaCPFBD = 0;
            RecebeRec = "";
        }

        public long ConsultaValidaCPF
        {
            get { return validaCPF; }
            set { validaCPF = value; }
        }
        public string ConsultaValidaSenha
        {
            get { return validaSenha; }
            set { validaSenha = value; }
        }
        public long ConsultaCPFBD
        {
            get { return CPFBd; }
            set { CPFBd = value; }
        }
        public string ConsultaSenhaBD
        {
            get { return senhaBd; }
            set { senhaBd = value; }
        }
        public string ConsultaNomeBD
        {
            get { return nomeBd; }
            set { nomeBd = value; }
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

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaValidaCPF = Convert.ToInt64(ReceberCPF());
                ConsultaValidaSenha = maskedTextBoxSenha.Text;
                ConsultaCPFBD = bdCli.ConsultarCPF(Convert.ToInt64(ReceberCPF()));
                ConsultaSenhaBD = bdCli.ConsultarSenha(Convert.ToInt64(ReceberCPF()));
                ConsultaNomeBD = bdCli.ConsultarNome(Convert.ToInt64(ReceberCPF()));

                if ((ConsultaValidaCPF == ConsultaCPFBD) && (ConsultaValidaSenha == ConsultaSenhaBD))
                {
                    this.Visible = false;
                    Form10 login8 = new Form10(ConsultaValidaCPF);
                    login8.ShowDialog();
                }
                else
                {
                    MessageBox.Show("CPF ou Senha Inválidos!");
                }
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

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
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

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form11 login5 = new Form11();
            login5.ShowDialog();
        }
        public string ReceberCPF()
        {
            RecebeRec = maskedTextBoxCPFouCNPJ.Text;//000.000.000-00
            num3 = RecebeRec.Substring(0, 3);
            num6 = RecebeRec.Substring(4, 3);
            num9 = RecebeRec.Substring(8, 3);
            num11 = RecebeRec.Substring(12, 2);
            return RecebeRec = num3 + num6 + num9 + num11;
        }        
    }
}
