using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SAC_PREFEITURA.Contole;
using System.Drawing;

namespace SAC_PREFEITURA
{
    public partial class _Default : System.Web.UI.Page
    {
        Usuario x;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (LbCPFLogin.Text.Equals("0"))
            {
                x = new Usuario();
                x = (Usuario)Session["Usuario"];
                CarregarDados(x);
                DtgDados.DataSource = x.DemandasPorUsuario(x.CPF);
                DtgDados.DataBind();
            }
            else
            {
                x = new Usuario();
                DtgDados.DataSource = x.DemandasPorUsuario(LbCPFLogin.Text);
                DtgDados.DataBind();
            }

            
        }

        protected void LinkButtonAtualizarDados_Click(object sender, EventArgs e)
        {
            x = new Usuario();
            x.Bairro = TxBairro.Text.ToUpper();
            x.CEP = TxCEP.Text;
            x.Complemento = TxComplemento.Text;
            x.DataNascimento= DateTime.Parse(TxDTNascimento.Text);
            x.Email = TxEmail.Text.ToUpper();
            x.Logradouro = TxLogradouro.Text.ToUpper();
            x.Nome = TXNome.Text.ToUpper();
            x.Numero = int.Parse(TxNumero.Text);
            x.Telefone_Fixo = TxFixo.Text;
            x.Telefone_Celular = TxCell.Text;
            x.CPF = LbCPFLogin.Text;
            x.AtualizarUsuario(x);
            CarregarDados(x.LerUsuario(x.CPF));
        }

        private void CarregarDados(Usuario z)
        {
            TxBairro.Text = z.Bairro.ToUpper();
            TxCEP.Text = z.CEP;
            TxComplemento.Text = z.Complemento;
            TxDTNascimento.Text = z.DataNascimento.ToShortDateString();
            TxEmail.Text = z.Email.ToUpper();
            TxLogradouro.Text = z.Logradouro.ToUpper();
            TXNome.Text = z.Nome.ToUpper();
            TxNumero.Text = z.Numero.ToString();
            TxFixo.Text = z.Telefone_Fixo;
            TxCell.Text = z.Telefone_Celular;
            LbCPFLogin.Text = z.CPF;
        }

        protected void BtnConfirmar_Click(object sender, EventArgs e)
        {
            int i = 0;
            
            Demandas d = new Demandas();

            if (TxBairroOcorrencia.Text.Equals(""))
            {
                TxBairroOcorrencia.BackColor = Color.Yellow;
                i++;
            }
            if (TxNumeroOcorrencia.Text.Equals(""))
            {
                TxNumeroOcorrencia.BackColor = Color.Yellow;
                i++;
            }
            if (TxDescricaoDetalhada.Text.Equals(""))
            {
                TxDescricaoDetalhada.BackColor = Color.Yellow;
                i++;
            }
            if (TxLogradouroOcorrencia.Text.Equals(""))
            {
                TxLogradouroOcorrencia.BackColor = Color.Yellow;
                i++;
            }

            if (i > 0)
            {
                Response.Write("<script LANGUAGE='JavaScript' >alert('Preencha os campos faltosos')</script>");
            }
            else
            {
                d.BairroDemanda = TxBairroOcorrencia.Text.ToUpper();
                d.ComplementoDemanda = TxComplementoOcorrencia.Text.ToUpper();
                d.DescricaoDemanda = TxDescricaoDetalhada.Text.ToUpper();
                d.IdTipoDemanda = int.Parse(cbServicos.SelectedValue);
                d.LogradouroDemanda = TxLogradouroOcorrencia.Text.ToUpper();
                d.NumeroDemanda = int.Parse(TxNumeroOcorrencia.Text);
                d.InserirDemanda(d, LbCPFLogin.Text);
                Page_Load(sender, e);
            }   
        }
        
    }
}
