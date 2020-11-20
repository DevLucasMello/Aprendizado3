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
    class ClienteDAO
    {
        //Declaração de variáveis
        public MySqlCommand sql;//Executa um dado armazenado (query)
        public MySqlConnection conexao;//Faz a conexao com o Banco de Dados
        public MySqlDataReader read;//Faz a leitura dos dados do Banco de Dados
        public DataSet conexaoDataSet;//Faz abrir as conexões para utilização de métodos do Banco de Dados (Insert, Alter, Delete)
        public int i, j;//Variáveis contadoras
        public string codigo, resultado, mensagem;//Variáveis para execusão de comandos do Banco de Dados e retorno em tela
        public int flag;//Indicador de condição para abertura e fechamento da conexão com o Banco de Dados        

        //Variáveis para salvar os dados da Base de Dados
        public long[] CPFVet;
        public string[] senhaVet;
        public string[] nomeVet;
        public string[] ruaVet;        
        public string[] numeroVet;
        public string[] CEPVet;
        public string[] cidadeVet;
        public string[] bairroVet;
        public string[] UFVet;
        public string[] paisVet;
        public string[] telefoneVet;
        public string[] emailVet;

        //Método Construtor
        public ClienteDAO()
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
            CPFVet = new long[200];
            senhaVet = new string[200];
            nomeVet = new string[200];
            ruaVet = new string[200];
            numeroVet = new string[200];
            CEPVet = new string[200];
            cidadeVet = new string[200];
            bairroVet = new string[200];
            UFVet = new string[200];
            paisVet = new string[200];
            telefoneVet = new string[200];
            emailVet = new string[200];            
        }//Fim do Método Construtor

        public void Cadastrar(long CPF, string senha, string nome, string rua, string numero, string CEP, string cidade, string bairro, string UF, string pais, string telefone, string email)
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "'" + CPF + "','" + senha + "','" + nome + "','" + rua + "','" + numero + "','" + CEP + "','" + cidade + "','" + bairro + "','" + UF + "','" + pais + "','" + telefone + "','" + email + "'";//Recebe os dados a serem salvos no Banco de Dados (em forma de texto)                
                resultado = "INSERT INTO Cliente(CPFouCNPJ,senha,nome,rua,numero,CEP,cidade,bairro,UF,pais,telefone,email) values(" + codigo + ")";//Armazena a linha a ser inserida no Banco de Dados (em forma de texto)//Armazena a linha a ser inserida no Banco de Dados (em forma de texto) 
                sql = new MySqlCommand(resultado, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção                

                MessageBox.Show("Cadastrado com Sucesso");
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro!" + e);
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }//Fim do Método Cadastrar
        public void SelecionarTudo()
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                string query = "SELECT * FROM Cliente";
                //Instanciando os vetores com valores iniciais
                for (i = 0; i < 200; i++)
                {
                    CPFVet[i] = 0;
                    senhaVet[i] = "";
                    nomeVet[i] = "";
                    ruaVet[i] = "";
                    numeroVet[i] = "";
                    CEPVet[i] = "";
                    cidadeVet[i] = "";
                    bairroVet[i] = "";
                    UFVet[i] = "";
                    paisVet[i] = "";
                    telefoneVet[i] = "";
                    emailVet[i] = "";                    
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
                    CPFVet[i] = Convert.ToInt64(read["CPFouCNPJ"]);
                    senhaVet[i] = "" + read["senha"];
                    nomeVet[i] = "" + read["nome"];
                    ruaVet[i] = "" + read["rua"];
                    numeroVet[i] = "" + read["numero"];
                    CEPVet[i] = "" + read["CEP"];
                    cidadeVet[i] = "" + read["cidade"];
                    bairroVet[i] = "" + read["bairro"];
                    UFVet[i] = "" + read["UF"];
                    paisVet[i] = "" + read["pais"];
                    telefoneVet[i] = "" + read["telefone"];
                    emailVet[i] = "" + read["email"];
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
        public long ConsultarCPF(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return CPFVet[i];
                }
            }
            return 0;
        }
        public string ConsultarSenha(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return senhaVet[i];
                }
            }
            return "";
        }
        public string ConsultarNome(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return nomeVet[i];
                }
            }
            return "Não Encontrado";
        }
        public string ConsultarRua(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return ruaVet[i];
                }
            }
            return "";
        }
        public string ConsultarNumero(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return numeroVet[i];
                }
            }
            return "";
        }
        public string ConsultarCEP(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return CEPVet[i];
                }
            }
            return "";
        }
        public string ConsultarCidade(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return cidadeVet[i];
                }
            }
            return "";
        }
        public string ConsultarBairro(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return bairroVet[i];
                }
            }
            return "";
        }
        public string ConsultarUF(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return UFVet[i];
                }
            }
            return "";
        }
        public string ConsultarPais(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return paisVet[i];
                }
            }
            return "";
        }
        public string ConsultarTelefone(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return telefoneVet[i];
                }
            }
            return "";
        }
        public string ConsultarEmail(long CPF)
        {
            SelecionarTudo();
            for (i = 0; i < j; i++)
            {
                if (CPF == CPFVet[i])
                {
                    return emailVet[i];
                }
            }
            return "";
        }
        public void AtualizarSenha(string senha, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET senha = '" + senha + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarNome(string nome, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET nome = '" + nome + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarRua(string rua, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET rua = '" + rua + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarNumero(string numero, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET numero = '" + numero + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarCEP(string CEP, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET CEP = '" + CEP + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarCidade(string cidade, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET cidade = '" + cidade + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarBairro(string bairro, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET bairro = '" + bairro + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarUF(string UF, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET UF = '" + UF + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarPais(string pais, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET pais = '" + pais + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarTelefone(string telefone, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET telefone = '" + telefone + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void AtualizarEmail(string email, long CPF)
        {
            try
            {
                i = 0;
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }
                codigo = "UPDATE Cliente SET email = '" + email + "' WHERE CPFouCNPJ= '" + CPF + "'";//Recebe os dados a serem atualizados no Banco de Dados (em forma de texto)
                sql = new MySqlCommand(codigo, conexao);//Insere os dados em forma de query no Banco de Dados
                resultado = "" + sql.ExecuteNonQuery();//Faz a função do Ctrl + Enter, salvando o número de comandos executados
                //Retorno da Inserção
                i++;
            }
            catch
            {
                MessageBox.Show("Algo deu Errado!");
            }//Fim do Try - Catch
            flag = 0;
            conexao.Close();
        }
        public void Excluir(long CPF)
        {
            try
            {
                if (flag == 0)
                {
                    conexao.Open();
                    flag = 1;
                }

                codigo = "DELETE FROM Cliente WHERE CPFouCNPJ= '" + CPF + "'";
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
