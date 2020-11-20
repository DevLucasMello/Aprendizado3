using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;//Indica que serão utilizados comandos da classe Data (Comandos para conexão com o Banco de Dados)
using MySql.Data.MySqlClient;//Biblioteca que faz a conexão com o Banco de Dados
using System.Data;//Biblioteca para trazer os dados do Banco de Dados
using System.Windows.Forms;//Utilizando Métodos da Classe Forms (Formulários - Design)

namespace Projeto_Livraria
{
    class LivroDAO
    {//Declaração de variáveis
        public MySqlCommand sql;//Executa um dado armazenado (query)
        public MySqlConnection conexao;//Faz a conexao com o Banco de Dados
        public MySqlDataReader read;//Faz a leitura dos dados do Banco de Dados
        public DataSet conexaoDataSet;//Faz abrir as conexões para utilização de métodos do Banco de Dados (Insert, Alter, Delete)
        public int i, j;//Variáveis contadoras
        public string codigo, resultado, mensagem;//Variáveis para execusão de comandos do Banco de Dados e retorno em tela
        public int flag;//Indicador de condição para abertura e fechamento da conexão com o Banco de Dados        

        //Variáveis para salvar os dados da Base de Dados
        public int[] codigoVet;
        public string[] tituloVet;
        public string[] autorVet;
        public string[] generoVet;
        public double[] valorEstoqueVet;
        public int[] qtdEstoqueVet;
        public string[] valorExibVet;


        public int[] codCompra;
        public string[] nomeCompra;
        public string[] telefoneCompra;
        public string[] emailCompra;
        public string[] tituloCompra;
        public int[] codLivroCompra;


        //Método Construtor
        public LivroDAO()
        {
            conexaoDataSet = new DataSet();//Abrindo as conexões para utilização de Métodos do Banco de Dados
            conexao = new MySqlConnection(@"Server=localhost;DataBase=Livraria;Uid=root;Password=Lm@518792;");//Abrindo a conexao com o Banco de Dados
            try
            {
                conexao.Open();//Abrindo na Base de Dados                
                flag = 1;//Alterando a Bandeira para 1 - Aberto a Conexão
            }
            catch (Exception e)//Salvando o erro
            {
                MessageBox.Show("Erro!" + e);//Exibindo o erro na tela
                conexao.Close();//Fechando da Base de Dados
                flag = 0;//Alterando a Bandeira para 0 - Fechado a Conexão
            }//Fim do Try - Catch

            //Instanciar as Variáveis
            i = 0;
            j = 0;
            codigo = "";
            resultado = "";
            mensagem = "";
            codigoVet = new int[200];
            tituloVet = new string[200];
            autorVet = new string[200];
            generoVet = new string[200];
            valorEstoqueVet = new double[200];
            qtdEstoqueVet = new int[200];
            valorExibVet = new string[200];

            codCompra = new int[200];
            nomeCompra = new string[200];
            telefoneCompra = new string[200];
            emailCompra = new string[200];
            tituloCompra = new string[200];
            codLivroCompra = new int[200];
        }//Fim do Método Construtor

        public void Cadastrar(string titulo, string autor, string genero, double valor, int quantidade)
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "'" + titulo + "','" + autor + "','" + genero + "','" + valor.ToString().Replace(",", ".") + "','" + quantidade + "'";//Recebe os dados a serem salvos no Banco de Dados (em forma de texto)                
                resultado = "INSERT INTO Livro(titulo,autor,genero, valorEstoque, quantidadeEstoque) values(" + codigo + ")";//Armazena a linha a ser inserida no Banco de Dados (em forma de texto)//Armazena a linha a ser inserida no Banco de Dados (em forma de texto) 
                sql = new MySqlCommand(resultado, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção                

                MessageBox.Show("Cadastrado com sucesso");
            }
            catch 
            {
                MessageBox.Show("Erro!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }//Fim do Método Cadastrar

        public void ComprarLivro(string nome, string telefone, string email, string titulo, int cod)
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "'" + nome + "','" + telefone + "','" + email + "','" + titulo + "','" + cod + "'";//Recebe os dados a serem salvos no Banco de Dados (em forma de texto)                
                resultado = "INSERT INTO Compra(nome,telefone,email,titulo,codLivro) values(" + codigo + ")";//Armazena a linha a ser inserida no Banco de Dados (em forma de texto)//Armazena a linha a ser inserida no Banco de Dados (em forma de texto) 
                sql = new MySqlCommand(resultado, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção                

                MessageBox.Show("Compra efetuada com sucesso");
            }
            catch
            {
                MessageBox.Show("Erro!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }//Fim do Método Cadastrar
    

        public void ReservarLivro(string nome, string telefone, string email, string titulo, int cod)
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "'" + nome + "','" + telefone + "','" + email + "','" + titulo + "','" + cod + "'";//Recebe os dados a serem salvos no Banco de Dados (em forma de texto)                
                resultado = "INSERT INTO Reserva(nome,telefone,email,titulo,codLivro) values(" + codigo + ")";//Armazena a linha a ser inserida no Banco de Dados (em forma de texto)//Armazena a linha a ser inserida no Banco de Dados (em forma de texto) 
                sql = new MySqlCommand(resultado, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção                

                MessageBox.Show("Reserva efetuada com sucesso");
            }
            catch
            {
                MessageBox.Show("Erro!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }//Fim do Método Cadastrar
    

        public string RelatorioLivrosComprados()
        {
            SelecionarLivrosCompra();
            string mensagem = " Código Compra |   Nome | Telefone | Email | Título | Código Livro" + "\n\n";
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                mensagem += "           " + codCompra[i] + " | " + nomeCompra[i] + " | " + telefoneCompra[i] + " | " + emailCompra[i] + " | " + tituloCompra[i] + " | " + codLivroCompra[i] + "\n";
            }

            return mensagem;
        }

        public string RelatorioLivrosReservados()
        {
            SelecionarLivrosReserva();
            string mensagem = " Código Reserva |   Nome | Telefone | Email | Título | Código Livro" + "\n\n";
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                mensagem += "           " + codCompra[i] + " | " + nomeCompra[i] + " | " + telefoneCompra[i] + " | " + emailCompra[i] + " | " + tituloCompra[i] + " | " + codLivroCompra[i] + "\n";
            }

            return mensagem;
        }

        public void SelecionarLivrosCompra()
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                string query = "SELECT * FROM Compra";
                //Instanciando os vetores com valores iniciais
                for (i = 0; i < 200; i++)
                {
                    codCompra[i] = 0;
                    nomeCompra[i] = "";
                    telefoneCompra[i] = "";
                    emailCompra[i] = "";
                    tituloCompra[i] = "";
                    codLivroCompra[i] = 0;                    
                }
                sql = new MySqlCommand(query, conexao);//Executar o comando na base de dados
                read = sql.ExecuteReader();//Executando a leitura dos dados armazenados no Banco de Dados

                //Variáveis Contadoras
                i = 0;
                j = 0;
                //Criar um while para percorrer todo o Banco de Dados. Coletar o dado encontrado
                //E armazenar termporariamente no vetor
                while (read.Read())
                {
                    codCompra[i] = Convert.ToInt32(read["id"]);
                    nomeCompra[i] = "" + read["nome"];
                    telefoneCompra[i] = "" + read["telefone"];
                    emailCompra[i] = "" + read["email"];
                    tituloCompra[i] = "" + read["titulo"];
                    codLivroCompra[i] = Convert.ToInt32(read["codLivro"]);
                    i++;
                    j++;
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro!" + e);
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }

        public void SelecionarLivrosReserva()
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                string query = "SELECT * FROM Reserva";
                //Instanciando os vetores com valores iniciais
                for (i = 0; i < 200; i++)
                {
                    codCompra[i] = 0;
                    nomeCompra[i] = "";
                    telefoneCompra[i] = "";
                    emailCompra[i] = "";
                    tituloCompra[i] = "";
                    codLivroCompra[i] = 0;
                }
                sql = new MySqlCommand(query, conexao);//Executar o comando na base de dados
                read = sql.ExecuteReader();//Executando a leitura dos dados armazenados no Banco de Dados

                //Variáveis Contadoras
                i = 0;
                j = 0;
                //Criar um while para percorrer todo o Banco de Dados. Coletar o dado encontrado
                //E armazenar termporariamente no vetor
                while (read.Read())
                {
                    codCompra[i] = Convert.ToInt32(read["id"]);
                    nomeCompra[i] = "" + read["nome"];
                    telefoneCompra[i] = "" + read["telefone"];
                    emailCompra[i] = "" + read["email"];
                    tituloCompra[i] = "" + read["titulo"];
                    codLivroCompra[i] = Convert.ToInt32(read["codLivro"]);
                    i++;
                    j++;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro!" + e);
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }


        public void SelecionarTudo()
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                string query = "SELECT * FROM Livro";
                //Instanciando os vetores com valores iniciais
                for (i = 0; i < 200; i++)
                {
                    codigoVet[i] = 0;
                    tituloVet[i] = "";
                    autorVet[i] = "";
                    generoVet[i] = "";
                    valorEstoqueVet[i] = 0;
                    qtdEstoqueVet[i] = 0;
                    valorExibVet[i] = "";
                }
                sql = new MySqlCommand(query, conexao);//Executar o comando na base de dados
                read = sql.ExecuteReader();//Executando a leitura dos dados armazenados no Banco de Dados

                //Variáveis Contadoras
                i = 0;
                j = 0;
                //Criar um while para percorrer todo o Banco de Dados. Coletar o dado encontrado
                //E armazenar termporariamente no vetor
                while (read.Read())
                {
                    codigoVet[i] = Convert.ToInt32(read["codLivro"]);
                    tituloVet[i] = "" + read["titulo"];
                    autorVet[i] = "" + read["autor"];
                    generoVet[i] = "" + read["genero"];
                    valorEstoqueVet[i] = Convert.ToDouble(read["valorEstoque"]);
                    qtdEstoqueVet[i] = Convert.ToInt32(read["quantidadeEstoque"]);
                    i++;
                    j++;
                }
                for (i = 0; i < j; i++)
                {
                    if (valorEstoqueVet[i] < 10)
                    {
                        valorExibVet[i] = "   " + valorEstoqueVet[i] + "00";
                    }
                    else if (valorEstoqueVet[i] < 100)
                    {
                        valorExibVet[i] = "  " + valorEstoqueVet[i] + "00";
                    }
                    else if (valorEstoqueVet[i] < 1000)
                    {
                        valorExibVet[i] = " " + valorEstoqueVet[i] + "00";
                    }
                    else if (valorEstoqueVet[i] < 10000)
                    {
                        valorExibVet[i] = "" + valorEstoqueVet[i] + "00";
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro!" + e);
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }

        public string ConsultaTodos()
        {
            string mensagem = " Código |   Título | Autor | Genero | Valor " + "\n\n";
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                mensagem += "           " + codigoVet[i] + " | " + tituloVet[i] + " | " + autorVet[i] + " | " + generoVet[i] + " | " + valorExibVet[i] + "\n";
            }
            
            return mensagem;
        }

        public string ConsultarTitulo(int codLivro)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (codLivro == codigoVet[i])
                {
                    return tituloVet[i];
                }
            }
            return "Não Encontrado";
        }
        public string ConsultarAutor(int codLivro)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (codLivro == codigoVet[i])
                {
                    return autorVet[i];
                }
            }
            return "Não Encontrado";
        }
        public string ConsultarGenero(int codLivro)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (codLivro == codigoVet[i])
                {
                    return generoVet[i];
                }
            }
            return "Não Encontrado";
        }
        public string ConsultarValor(int codLivro)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (codLivro == codigoVet[i])
                {
                    return valorExibVet[i];
                }
            }
            return "Não Encontrado";
        }
        public int ConsultarQuantidade(int codLivro)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (codLivro == codigoVet[i])
                {
                    return qtdEstoqueVet[i];
                }
            }
            return 0;
        }

        public void AtualizarTitulo(string titulo, int codLivro)
        {
            try
            {                
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Livro SET titulo = '" + titulo + "' WHERE codLivro= '" + codLivro + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i = 1;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarAutor(string autor, int codLivro)
        {
            try
            {               
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Livro SET autor = '" + autor + "' WHERE codLivro= '" + codLivro + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i = 1;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarGenero(string genero, int codLivro)
        {
            try
            {                
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Livro SET genero = '" + genero + "' WHERE codLivro= '" + codLivro + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i = 1;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarValor(double valor, int codLivro)
        {
            try
            {                
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Livro SET valorEstoque = '" + valor.ToString().Replace(",", ".") + "' WHERE codLivro= '" + codLivro + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i = 1;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarQuantidade(int quantidade, int codLivro)
        {
            try
            {                
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Livro SET quantidadeEstoque = '" + quantidade + "' WHERE codLivro= '" + codLivro + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i = 1;                
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void Excluir(int codLivro)
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }

                codigo = "DELETE FROM Livro WHERE codLivro= '" + codLivro + "'";
                sql = new MySqlCommand(codigo, conexao);
                resultado = "" + sql.ExecuteNonQuery();
                MessageBox.Show("Dado apagado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
            flag = 0;
            conexao.Close();
        }
    }
}
