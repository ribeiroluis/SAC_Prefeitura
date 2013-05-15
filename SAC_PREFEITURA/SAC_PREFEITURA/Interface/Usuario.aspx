<%@ Page Title="SAC - PREFEITURA DE BETIM .:. USUARIO" Language="C#" MasterPageFile="Site.master" AutoEventWireup="true"
    CodeBehind="Usuario.aspx.cs" Inherits="SAC_PREFEITURA._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="margin-bottom:20px">
    <h2> Login Usuário</h2>
    <br />
              CPF: <asp:TextBox ID="TextBox2" runat ="server" style ="margin-right:20px; margin-left: 20px"></asp:TextBox>
              Senha:<input id="Password1" type="password"  style ="margin-right:20px; margin-left: 20px"/>
              <asp:Button ID="Button2" runat="server" style="margin-right:20px; margin-left: 20px" Text="Cadastrar / Login" Width="149px" />
          </div>
          <hr />
          <h2> Tipo de Ocorrência</h2>
          <br />
          <div style="margin-bottom:20px">
              Serviço solicitato:<asp:DropDownList ID="cbServicos" runat="server" Height="20px" style="font-size:12px; margin-left: 19px;" Width="200px">
                   <asp:ListItem>Capina</asp:ListItem>
                   <asp:ListItem>Entulho</asp:ListItem>
                   <asp:ListItem>Animal em via pública</asp:ListItem>
                   <asp:ListItem>Lixo</asp:ListItem>
                  <asp:ListItem>Outros - Especifique</asp:ListItem>

              </asp:DropDownList>
          </div>
          <hr />
          <div style="margin-bottom:20px">
          <h2>Dados do usuário</h2>
          <br />
              Nome:<asp:TextBox ID="TXNome" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="500px"></asp:TextBox>
              DataNacimento(dd/mm/aaaa):<asp:TextBox ID="TxDTNascimento" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="100px"></asp:TextBox>
          </div>
          <div style="margin-bottom:20px">
              CEP:<asp:TextBox ID="TxCEP" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="90px"></asp:TextBox>
              Logradouro:<asp:TextBox ID="TxLogradouro" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="350px"></asp:TextBox>
              nº:<asp:TextBox ID="TxNumero" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="50px"></asp:TextBox>
              <br />
              <br />
              Complemento:<asp:TextBox ID="TextBox1" runat ="server" 
                  style ="margin-right:20px; margin-left: 20px" Width="109px"></asp:TextBox>
              Bairro:<asp:TextBox ID="TxBairro" runat ="server" 
                  style ="margin-right:20px; margin-left: 20px" Width="292px"></asp:TextBox>              
          </div>
          <div style="margin-bottom:20px">
              Telefone Fixo:<asp:TextBox ID="TxFixo" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="100px"></asp:TextBox>
              Telefone Celular:<asp:TextBox ID="TxCell" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="100px"></asp:TextBox>
              E-Mail:<asp:TextBox ID="TxEmail" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="300px"></asp:TextBox>
          </div>
          <hr />
          <div style="margin-bottom: 20px">
              <h2>Dados da ocorrência</h2>
              <p>&nbsp;</p>
              Logradouro:<asp:TextBox ID="TxLogradouroOcorrencia" runat="server" Style="margin-right: 20px; margin-left: 20px" Width="350px"></asp:TextBox>
              nº:<asp:TextBox ID="TxNumeroOcorrencia" runat="server" Style="margin-right: 20px; margin-left: 20px" Width="50px"></asp:TextBox>
              Complemento:<asp:TextBox ID="TxComplementoOcorrencia" runat="server" Style="margin-right: 20px; margin-left: 20px" Width="90px"></asp:TextBox>              
              <br />
              <br />
              Bairro:<asp:TextBox ID="TxBairroOcorrencia" runat="server" Style="margin-right: 20px; margin-left: 20px" Width="150px"></asp:TextBox>
          </div>
          <div style="margin-bottom: 20px">                                   
                  Descrição detalhada:<asp:TextBox ID="TxDescricaoDetalhada" runat="server" 
                      Style="margin-right: 20px; margin-left: 20px" Width="704px"></asp:TextBox>
          </div>
          <hr />
          <div style="margin-bottom: 20px">                  
                 <asp:Button ID="BtnConfirmar" runat="server" Text="Inserir demanda" 
                      Style="margin-right: 20px; margin-left: 20px" Width="108px" Height="30px"/>                   
              </div>
</asp:Content>
