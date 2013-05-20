using SAC_PREFEITURA.Contole;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SAC_PREFEITURA.Interface
{
    public partial class AdmSistema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cbSetor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Demandas d = new Demandas();
            cbDemanda.DataSource = d.RetornaDemandaPorSetor(int.Parse(cbSetor.SelectedValue));
            cbDemanda.DataTextField = "DESCRICAO";
            cbDemanda.DataValueField = "ID";
            cbDemanda.DataBind();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            Demandas d = new Demandas();

            int idDemanda = int.Parse(cbDemanda.SelectedValue);
            int idSetor = int.Parse(cbSetor.SelectedValue);

            dtgDadosDemandas.DataSource = d.RetornaDemandasPorSetorDemanda(idDemanda, idSetor);
            dtgDadosDemandas.DataBind();
        }

        protected void BtnEnviarDemadna_Click(object sender, EventArgs e)
        {
            Demandas d = new Demandas();
            
            d = d.PesquisaDemandaPorID(int.Parse(TxIdDemanda.Text));

            TxDataCadastro.Text = d.DataCadastro;
            TxDataCadastro.ReadOnly = true;

            if (d.DataInicio != null)
            {
                TxIniciada.Text = d.DataInicio;
                TxIniciada.ReadOnly = true;
            }
            else
            {
                TxIniciada.Text = "";
                TxIniciada.ReadOnly = false;
            }

            if (d.DataFinalizada != null)
            {
                TxFinalizada.Text = d.DataFinalizada;
                TxFinalizada.ReadOnly = true;
                LinkAtualizar.Enabled = false;
            }
            else
            {
                LinkAtualizar.Enabled = true;
                TxFinalizada.Text = "";
            }
        }

        protected void LinkAtualizar_Click(object sender, EventArgs e)
        {
            Demandas d = new Demandas();
            
            d.idDemanda = int.Parse(TxIdDemanda.Text);

            if (!TxIniciada.Text.Equals(""))
            {
                d.DataInicio = TxIniciada.Text;                
            }

            if (!TxFinalizada.Text.Equals(""))
            {
                d.DataFinalizada = TxFinalizada.Text;
                d.StatusDemanda = true;
            }

            if (TxIniciada.Text.Equals(""))
                Response.Write("<script LANGUAGE='JavaScript' >alert('Preencha os campos faltosos')</script>");
            else
                d.AtualizarUsuarioDemanda(d);

            ObjPesquisa_Load(sender, e);

                       

        }

        protected void ObjPesquisa_Load(object sender, EventArgs e)
        {

        }
    }
}