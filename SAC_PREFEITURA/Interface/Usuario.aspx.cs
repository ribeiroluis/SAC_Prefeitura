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
        Usuario x = new Usuario();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            x = (Usuario)Session["Usuario"];
            TxBairro.Text = x.Bairro;
            TxCEP.Text = x.CEP;
            TxComplemento.Text = x.Complemento;
            TxDTNascimento.Text = x.DataNascimento.ToShortDateString();
            TxEmail.Text = x.Email;
            TxLogradouro.Text = x.Logradouro;
            TXNome.Text = x.Nome;
            TxNumero.Text = x.Numero.ToString();
            TxFixo.Text = x.Telefone_Celular;
            TxCell.Text = x.Telefone_Celular;
            LbCPFLogin.Text = x.CPF;
        }
        
    }
}
