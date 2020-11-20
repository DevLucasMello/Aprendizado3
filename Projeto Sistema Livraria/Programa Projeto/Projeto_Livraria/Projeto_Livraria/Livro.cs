using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//Utilizando Métodos da Classe Forms (Formulários - Design)

namespace Projeto_Livraria
{
    class Livro
    {
        /*----------------------------------------------------------------------------------------
         Criando as Variáveis*/
        LivroDAO bdLiv;        
        private int qtd, codigo;
        private string titulo, autor, genero, telaValor;
        private double valor;        
        /*Fim do Criar Variáveis 
        ----------------------------------------------------------------------------------------*/

        /*----------------------------------------------------------------------------------------
         Método Construtor*/
        public Livro()
        {            
            bdLiv = new LivroDAO();
            ConsultaCodigo = 0;
            ConsultaTitulo = "";
            ConsultaAutor = "";
            ConsultaGenero = "";
            ConsultaTelaValor = "";
            ConsultaValor = 0;
            ConsultaQtd = 0;
        }
        /*Fim do Método Construtor 
        ----------------------------------------------------------------------------------------*/

        /*----------------------------------------------------------------------------------------
         Métodos Gets e Sets*/
        public int ConsultaCodigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string ConsultaTitulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string ConsultaAutor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string ConsultaGenero
        {
            get { return genero; }
            set { genero = value; }
        }
        public double ConsultaValor
        {
            get { return valor; }
            set { valor = value; }
        }
        public int ConsultaQtd
        {
            get { return qtd; }
            set { qtd = value; }
        }
        public string ConsultaTelaValor
        {
            get { return telaValor; }
            set { telaValor = value; }
        }
        /*Fim dos Métodos Gets e Sets
        ----------------------------------------------------------------------------------------*/

        /*----------------------------------------------------------------------------------------
         Método para Limpar Campos*/
        public string Limpar()
        {
            return "";
        }
        /*Fim do Método para Limpar Campos
        ----------------------------------------------------------------------------------------*/        

        /*----------------------------------------------------------------------------------------
         Métodos para Consulta dos dados na Base de Dados*/ 
         
        public string TituloConsultado(int codigo)
        {
            ConsultaCodigo = codigo;
            ConsultaTitulo = bdLiv.ConsultarTitulo(ConsultaCodigo);            
            return ConsultaTitulo;
        }
        public string AutorConsultado(int codigo)
        {
            ConsultaCodigo = codigo;            
            ConsultaAutor = bdLiv.ConsultarAutor(ConsultaCodigo);            
            return ConsultaAutor;
        }
        public string GeneroConsultado(int codigo)
        {
            ConsultaCodigo = codigo;            
            ConsultaGenero = bdLiv.ConsultarGenero(ConsultaCodigo);            
            return ConsultaGenero;
        }
        public string ValorConsultado(int codigo)
        {
            ConsultaCodigo = codigo;            
            ConsultaTelaValor = bdLiv.ConsultarValor(ConsultaCodigo);            
            return ConsultaTelaValor;
        }
        public string QuantidadeConsultado(int codigo)
        {
            ConsultaCodigo = codigo;            
            ConsultaQtd = Convert.ToInt32(bdLiv.ConsultarQuantidade(ConsultaCodigo));
            return Convert.ToString(ConsultaQtd);
        }
        /*Fim dos Métodos para Consulta dos dados na Base de Dados 
        ----------------------------------------------------------------------------------------*/

        /*----------------------------------------------------------------------------------------
         Métodos para Atualização dos dados na Base de Dados*/     
        public void TituloAtualizado(string titulo, int codigo)
        {
            ConsultaTitulo = titulo;
            ConsultaCodigo = codigo;
            bdLiv.AtualizarTitulo(ConsultaTitulo, ConsultaCodigo);            
        }
        public void AutorAtualizado(string autor, int codigo)
        {
            ConsultaAutor = autor;
            ConsultaCodigo = codigo;
            bdLiv.AtualizarAutor(ConsultaAutor, ConsultaCodigo);
        }
        public void GeneroAtualizado(string genero, int codigo)
        {
            ConsultaGenero = genero;
            ConsultaCodigo = codigo;
            bdLiv.AtualizarGenero(ConsultaGenero, ConsultaCodigo);
        }
        public void ValorAtualizado(double valor, int codigo)
        {
            ConsultaValor = valor;
            ConsultaCodigo = codigo;
            bdLiv.AtualizarValor(ConsultaValor, ConsultaCodigo);
        }
        public void QuantidadeAtualizado(int quantidade, int codigo)
        {
            ConsultaQtd = quantidade;
            ConsultaCodigo = codigo;
            bdLiv.AtualizarQuantidade(ConsultaQtd, ConsultaCodigo);
        }
        /*Fim dos Métodos para Atualização dos dados na Base de Dados 
        ----------------------------------------------------------------------------------------*/
    }
}
