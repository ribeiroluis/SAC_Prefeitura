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
            if (LbCPFLogin.Text.Equals("0"))
            {
                Usuario x = new Usuario();
                x = (Usuario)Session["Usuario"];
                CarregarDados(x);
            }
            
        }

        protected void LinkButtonAtualizarDados_Click(object sender, EventArgs e)
        {
            Usuario x = new Usuario();
            x.Bairro = TxBairro.Text;
            x.CEP = TxCEP.Text;
            x.Complemento = TxComplemento.Text;
            x.DataNascimento= DateTime.Parse(TxDTNascimento.Text);
            x.Email = TxEmail.Text;
            x.Logradouro = TxLogradouro.Text;
            x.Nome = TXNome.Text;
            x.Numero = int.Parse(TxNumero.Text);
            x.Telefone_Fixo = TxFixo.Text;
            x.Telefone_Celular = TxCell.Text;
            x.CPF = LbCPFLogin.Text;
            x.AtualizarUsuario(x);
            CarregarDados(x.LerUsuario(x.CPF));
        }

        private void CarregarDados(Usuario x)
        {
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
