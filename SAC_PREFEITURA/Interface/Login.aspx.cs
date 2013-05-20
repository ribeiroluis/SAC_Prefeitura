using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using SAC_PREFEITURA.Contole;


namespace SAC_PREFEITURA
{
    public partial class About : System.Web.UI.Page
    {
        AdmSistema x;
        protected void Page_Load(object sender, EventArgs e)
        {
            x = new AdmSistema();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            x.LoginFuncionario = txboxlogin.Text;
            x.SenhaFuncionario = txSenha.Text;

            //Pesquisa no banco o acesso aos usuários e retorna verdadeiro ou falso
            if (x.ValidarAcessoSistema(x))
            {
                //System.Windows.Forms.MessageBox.Show("Acesso liberado","Sucesso!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Response.Write("<script LANGUAGE='JavaScript' >alert('Login efetuado com sucesso!');document.location='" + 
                    ResolveClientUrl("~/Interface/AdmSistema.aspx") + "';</script>");
            }
            else
                Response.Write("<script LANGUAGE='JavaScript' >alert('Login ou senha incorretos');document.location='" +
                    ResolveClientUrl("~/Interface/Login.aspx") + "';</script>");
        }
    }
}
