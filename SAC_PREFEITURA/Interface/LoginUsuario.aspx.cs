using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAC_PREFEITURA.Contole;

namespace SAC_PREFEITURA.Interface
{
    public partial class LoginUsuario : System.Web.UI.Page
    {
        Usuario user;

        /// <summary>
        /// Carregar a pagina
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo para cadastrar ou logar o usuario no sistema
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogar_Click(object sender, EventArgs e)
        {
            user = new Usuario();
            user.CPF = txCPF.Text;
            user.Senha = txSenha.Text;

            ValidarCPF validar = new ValidarCPF();

            if (btnLogar.Text.Equals("Login") )
            {
                if (user.ConsultaUsuario(user) && validar.ValidaCPF(user.CPF))
                {
                    user = user.LerUsuario(user.CPF);
                    Session["Usuario"] = user;
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Login efetuado com sucesso!');document.location='" +
                        ResolveClientUrl("~/Interface/Usuario.aspx") + "';</script>");
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Login ou senha incorretos');document.location='" +
                        ResolveClientUrl("~/Interface/LoginUsuario.aspx") + "';</script>");
                }
            }
            else
            {
                if (txSenha.Text.Equals(TxConfirmarSenha.Text) && validar.ValidaCPF(user.CPF))
                {
                    user.InserirUsuario(user);
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Cadastro realizado com sucesso!')</script>");
                }
                else
                {
                    Response.Write("<script LANGUAGE='JavaScript' >alert('Senhas incorretas, ou cpf incorreto!')</script>");
                }
                        
                TxConfirmarSenha.Visible = false;
                lbConfirmarSenha.Visible = false;
                btnLogar.Text = "Login";
                btnLogar.Width = 70;
            }
        }

        /// <summary>
        /// Opção para liberar o campo de cadastrar usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LinkButtonCadastrarNovo_Click(object sender, EventArgs e)
        {
            TxConfirmarSenha.Visible = true;
            lbConfirmarSenha.Visible = true;
            btnLogar.Text = "Cadastrar novo";
            btnLogar.Width = 120;
        }
        
    }
}