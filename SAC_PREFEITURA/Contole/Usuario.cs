using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SAC_PREFEITURA.Modelos;


namespace SAC_PREFEITURA.Contole
{
    public class Usuario
    {
        #region Atributos

        private string cpf;
        private string senha;
        private string nome;
        private DateTime datanascimento;
        private string cep;
        private string logradouro;
        private int numero;
        private string complemento;
        private string bairro;
        private string  telfixo;
        private string telcel;
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public string Telefone_Celular
        {
            get { return telcel; }
            set { telcel = value; }
        }
        
        public string  Telefone_Fixo
        {
            get { return telfixo; }
            set { telfixo = value; }
        }
        
        public string Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        
        public string Complemento
        {
            get { return complemento; }
            set { complemento = value; }
        }
        
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        
        public string Logradouro
        {
            get { return logradouro; }
            set { logradouro = value; }
        }
        
        public string CEP
        {
            get { return cep; }
            set { cep = value; }
        }
        
        public DateTime DataNascimento
        {
            get { return datanascimento; }
            set { datanascimento = value; }
        }
        
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        
        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        #endregion
        
        AcessoUsuario bdUsuario = new AcessoUsuario();

        public bool ConsultaUsuario(Usuario _user)
        {            
            return bdUsuario.ConsultarUsuario(_user);
        }

        public bool InserirUsuario(Usuario _user)
        {            
            return bdUsuario.InerirUsuario(_user);
        }

        public Usuario LerUsuario(string cpf)
        {
            return bdUsuario.LerUsuario(cpf);
        }

        public bool PesquisaUsuarioDataTable(Usuario user)
        {
            return bdUsuario.PesquisaDataTable(user);
        }
    }
}