using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAC_PREFEITURA.Contole;

namespace SAC_PREFEITURA
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.CPF = txCPF.Text;
            user.Senha = txSenha.Text;


            if (this.btnLogar.Text.Equals("Cadastrar"))
            {
                user.InserirUsuario(user);
            }
            else
            {
                if (user.ConsultaUsuario(user))
                {
                    Usuario _user = user.LerUsuario(txCPF.Text);
                }
                else
                {
                    this.btnLogar.Text = "Cadastrar";
                }
            }
        }
    }
}
