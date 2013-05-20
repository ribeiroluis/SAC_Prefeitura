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

    /// <summary>
    /// Acesso ao banco de Dados Tabela Usuarios
    /// </summary>
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

        public DataTable DemandasPorUsuario(string cpf)
        {
            ViewDemandasPorUsuarioTableAdapter view = new ViewDemandasPorUsuarioTableAdapter();
            try
            {
                
                return view.GetData(cpf);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                view.Connection.Close();
            }
            
        }
    }

    /// <summary>
    /// Acesso ao banco de Dados Tabela Demandas, UsuarioDemanda
    /// </summary>
    public class AcessoDemandas
    {
        DemandasTableAdapter dbDemandas = new DemandasTableAdapter();
        UsuarioDemandaTableAdapter dbUsuarioDemanda = new UsuarioDemandaTableAdapter();
        TipoDemandaTableAdapter dbTipodemanda = new TipoDemandaTableAdapter();

        public bool IncluirDemanda(Demandas x)
        {
            try
            {
                dbDemandas.InserirDemanda(x.IdTipoDemanda, x.LogradouroDemanda, x.NumeroDemanda, x.ComplementoDemanda, x.BairroDemanda, x.DescricaoDemanda);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                dbDemandas.Connection.Close();
            }
        }

        public bool IncluirUsuarioDemanda(string cpf)
        {
            DateTime agora = DateTime.Now;
            try
            {
                int iddemanda = (int)dbDemandas.RetornaUltimoID();
                dbUsuarioDemanda.InserirUsuarioDemanda(cpf, iddemanda, agora);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
            finally
            {
                dbUsuarioDemanda.Connection.Close();
            }
        }

        public DataTable RetornaDemandasPorIDSetor(int Idsetor)
        {
            return dbTipodemanda.RetornaPorIDSetor(Idsetor);
        }

        public DataTable RetornaDemandasPorIDSetorIDDemanda(int iddemanda, int idsetor)
        {
            ViewDemandasTableAdapter view = new ViewDemandasTableAdapter();
            return view.GetData(idsetor, iddemanda);
        }

        public Demandas PesquisaDemandaPorID(int iddemanda)
        {
            Demandas x = new Demandas();
            
            DataRow LinhaTabela = dbUsuarioDemanda.RetornaDemandaCadastradaPorID(iddemanda).Rows[0];
            
            x.DataCadastro = DateTime.Parse(LinhaTabela["DATACADASTRO"].ToString()).ToShortDateString();

            var aux = LinhaTabela["DATAINICIO"].ToString();

            if (!aux.Equals(""))
            {
                x.DataInicio = DateTime.Parse(LinhaTabela["DATAINICIO"].ToString()).ToShortDateString();
            }

            aux = LinhaTabela["DATAFIM"].ToString();

            if (!aux.Equals(""))
            {
                x.DataFinalizada = LinhaTabela["DATAFIM"].ToString();
            }

            return x;
        }

        public int AtualizaUsuarioDemanda(Demandas x)
        {
            if(x.DataFinalizada == null)
                return dbUsuarioDemanda.AtualizaDemandaStatus(DateTime.Parse(x.DataInicio), null, x.StatusDemanda, x.idDemanda);
            else
                return dbUsuarioDemanda.AtualizaDemandaStatus(DateTime.Parse(x.DataInicio), DateTime.Parse(x.DataFinalizada), x.StatusDemanda, x.idDemanda);
        }
 
    }

    /// <summary>
    /// Acesso ao banco de dados AcessoSistema
    /// </summary>
    public class AcessoSistema
    {
        AcessoSistemaTableAdapter acessar;

        public AcessoSistema()
        {
            acessar = new AcessoSistemaTableAdapter();
        }

        public bool ValidarAcesso(AdmSistema x)
        {
            var aux = acessar.ValidarUsuarioSenha(x.LoginFuncionario, x.SenhaFuncionario);
            
            if (aux!=null)
            {
                return true;
            }
            else
                return false;
        }


    }
}


            