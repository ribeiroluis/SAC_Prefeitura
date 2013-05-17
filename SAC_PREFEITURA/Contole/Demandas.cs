using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SAC_PREFEITURA.Contole
{
    public class Demandas
    {

        #region Atributos
        private int iddemanda;
        private int idtipodemanda;
        private string logradouro;
        private int numero;
        private string comp;
        private string bairro;
        private string descricao;

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

        public void InserirDemanda(Demandas demanda)
        {
 
        }

    }
}