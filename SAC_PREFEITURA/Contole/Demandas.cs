using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using SAC_PREFEITURA.Modelos;

namespace SAC_PREFEITURA.Contole
{
    public class Demandas
    {
        AcessoDemandas bdDemandas = new AcessoDemandas();

        #region Atributos
        private int iddemanda;
        private int idtipodemanda;
        private string logradouro;
        private int numero;
        private string comp;
        private string bairro;
        private string descricao;
        private string datacadastro;
        private string datainicio;
        private bool status;
        private string datafim;

        public string DataFinalizada
        {
            get { return datafim; }
            set { datafim = value; }
        }
        

        public bool StatusDemanda
        {
            get { return status; }
            set { status = value; }
        }
        

        public string DataInicio
        {
            get { return datainicio; }
            set { datainicio = value; }
        }
        

        public string DataCadastro
        {
            get { return datacadastro; }
            set { datacadastro = value; }
        }
        

        public string DescricaoDemanda
        {
            get { return descricao; }
            set { descricao = value; }
        }
        

        public string BairroDemanda
        {
            get { return bairro; }
            set { bairro = value; }
        }
        

        public string ComplementoDemanda
        {
            get { return comp; }
            set { comp = value; }
        }
        

        public int NumeroDemanda
        {
            get { return numero; }
            set { numero = value; }
        }
        


        public string LogradouroDemanda
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        

        public int IdTipoDemanda
        {
            get { return idtipodemanda; }
            set { idtipodemanda = value; }
        }
        

        public int idDemanda
        {
            get { return iddemanda; }
            set { iddemanda = value; }
        }
        #endregion Atributos

        public void InserirDemanda(Demandas demanda, string cpf)
        {
            bdDemandas.IncluirDemanda(demanda);
            bdDemandas.IncluirUsuarioDemanda(cpf);
        }

        public DataTable RetornaDemandaPorSetor(int idSetor)
        {
            return bdDemandas.RetornaDemandasPorIDSetor(idSetor);
        }

        public DataTable RetornaDemandasPorSetorDemanda(int idDemanda, int Idsetor)
        {
            return bdDemandas.RetornaDemandasPorIDSetorIDDemanda(idDemanda, Idsetor);
        }

        public Demandas PesquisaDemandaPorID(int iddemanda)
        {
            return bdDemandas.PesquisaDemandaPorID(iddemanda);
        }

        public void AtualizarUsuarioDemanda(Demandas x)
        {
            bdDemandas.AtualizaUsuarioDemanda(x);
        }

        
    }
}