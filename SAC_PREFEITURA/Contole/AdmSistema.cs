using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAC_PREFEITURA.Modelos;

namespace SAC_PREFEITURA.Contole
{
    public class AdmSistema
    {
        AcessoSistema acesso;

        #region Atributos
        
        private string login;
        private string senha;
        private string nome;
        private string telefone;
        private string setor;
        private string secretaria;        

        public string SenhaFuncionario
        {
            get { return senha; }
            set { senha = value; }
        }
                
        public string Secretaria
        {
            get { return secretaria; }
            set { secretaria = value; }
        }
        
        public string Setor
        {
            get { return setor; }
            set { setor = value; }
        }
        
        public string TelefoneFuncionario
        {
            get { return telefone; }
            set { telefone = value; }
        }
        
        public string NomeFuncionario
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public string LoginFuncionario
        {
            get { return login; }
            set { login = value; }
        }
        #endregion


        public bool ValidarAcessoSistema(AdmSistema x)
        {
            acesso = new AcessoSistema();
            return acesso.ValidarAcesso(x);
        }


    }
}