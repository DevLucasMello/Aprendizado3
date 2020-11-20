using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Livraria
{
    class Administrador
    {
        //Declaração de variáveis
        private string loginAdm;
        private string senhaAdm;
        private string checarLogin;
        private string checarSenha;
        public bool statusAdm;

        //Método Construtor
        public Administrador()
        {
            InformarLoginAdm = "admin";
            InformarSenhaAdm = "admin222";
            checarLogin = "";
            checarSenha = "";
            statusAdm = false;
        }

        //Métodos Gets e Sets
        public string InformarLoginAdm
        {
            get { return loginAdm; }
            set { loginAdm = value; }
        }
        public string InformarSenhaAdm
        {
            get { return senhaAdm; }
            set { senhaAdm = value; }
        }
        public string ChecarLoginAdm
        {
            get { return checarLogin; }
            set { checarLogin = value; }
        }
        public string ChecarSenhaAdm
        {
            get { return checarSenha; }
            set { checarSenha = value; }
        }

        //Método para checar dados de acesso
        public bool DadosAcessoAdm(string login, string senha)
        {
            ChecarLoginAdm = login;
            ChecarSenhaAdm = senha;
            if ((ChecarLoginAdm == InformarLoginAdm) && (ChecarSenhaAdm == InformarSenhaAdm))
            {
                statusAdm = true;
            }
            else
            {
                statusAdm = false;
            }
            return statusAdm;
        }
    }
}
