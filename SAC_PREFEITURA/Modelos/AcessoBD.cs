using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAC_PREFEITURA.BD_SAC_PrefeituraTableAdapters;
using System.Data.Odbc;
using SAC_PREFEITURA.Contole;
using System.Data;

namespace SAC_PREFEITURA.Modelos
{
    public class AcessoBD
    {
    }

    public class AcessoUsuario
    {
        UsuarioTableAdapter usuario = new UsuarioTableAdapter();

        /// <summary>
        /// Construtor da Classe
        /// </summary>
        public AcessoUsuario()
        {

        }

        /// <summary>
        /// Metodo para consultar se o usuáio está cadastrado
        /// </summary>
        /// <param name="_usuario">Objeto do tipo Usuario</param>
        /// <returns>Verdadeiro ou falso</returns>
        public bool ConsultarUsuario(Usuario _usuario)
        {
            try
            {
                var nome = usuario.PesquisaCPFSenha(_usuario.CPF, _usuario.Senha);

                if (nome != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {

                throw;
            }
            finally
            {
                usuario.Connection.Close();
            }
            
                
        }

        public bool PesquisaDataTable(Usuario __objUsuario)
        {
            try
            {
                DataTable tabela = usuario.GetData();
                foreach (var item in tabela.Rows)
                {
                    DataRow linha = (DataRow)item;
                    if (linha["CPF"].ToString().Equals(__objUsuario.CPF) && linha["SENHA"].ToString().Equals(__objUsuario.Senha))
                        return true;
                }

                return false;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
 
            }
        }

        public bool InerirUsuario(Usuario objUsuario)
        {
            Usuario x = objUsuario;
            try
            {
                usuario.InserirUsuario(x.CPF, x.Senha, x.Nome, x.DataNascimento, x.CEP, x.Logradouro, x.Numero, x.Complemento, x.Bairro, x.Telefone_Fixo, x.Telefone_Celular, x.Email);
                return true;
            }
            catch (Exception err)
            {
                return false;
            }
            finally
            {
                usuario.Connection.Close();
            }
        }

        public Usuario LerUsuario(string cpf)
        {

            try
            {
                Usuario x = new Usuario();
                DataTable tabela = usuario.RetornaDataTableporCPF(cpf);


                x.Bairro = tabela.Rows[0]["BAIRRO"].ToString();
                x.CEP = tabela.Rows[0]["CEP"].ToString();
                x.Complemento = tabela.Rows[0]["COMPLEMENTO"].ToString();
                x.CPF = tabela.Rows[0]["CPF"].ToString();
                x.DataNascimento = (DateTime)tabela.Rows[0]["DATANASCIMENTO"];
                x.Email = tabela.Rows[0]["EMAIL"].ToString();
                x.Logradouro = tabela.Rows[0]["LOGRADOURO"].ToString();
                x.Nome = tabela.Rows[0]["NOME"].ToString();
                x.Numero = (int)tabela.Rows[0]["NUMERO"];
                x.Senha = tabela.Rows[0]["SENHA"].ToString();
                x.Telefone_Celular = tabela.Rows[0]["TELEFONECELULAR"].ToString();
                x.Telefone_Fixo = tabela.Rows[0]["TELEFONEFIXO"].ToString();

                return x;
            }
            catch (Exception err)
            {

                throw;
            }
            finally
            {
                usuario.Connection.Close();
            }

            
        }

        public bool AtualizarUsuario(Usuario x)
        {
            try
            {
                usuario.AtualizarUsuario(x.Nome, x.DataNascimento, x.CEP, x.Logradouro, x.Numero, x.Complemento, x.Bairro, x.Telefone_Fixo, x.Telefone_Celular, x.Email, x.CPF);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                usuario.Connection.Close();
            }
        }
    }
}
            