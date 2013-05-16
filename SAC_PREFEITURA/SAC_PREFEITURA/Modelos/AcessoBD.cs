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
        }

        public Usuario LerUsuario(string cpf)
        {
            DataTable dados = usuario.GetData();
            Usuario x = new Usuario();

            for (int i = 0; i < dados.Rows.Count; i++)
            {
                var linha = dados.Rows[i];
                if (cpf.Equals(linha["CPF"].ToString()))
                {
                    x.Nome = linha["NOME"].ToString();
                    x.Logradouro = linha["LOGRADOURO"].ToString();
                }
            }
            return x;
        }
    }
}
            