<%@ Page Title="SAC - PREFEITURA DE BETIM .:. USUARIO" Language="C#" MasterPageFile="Site.master" AutoEventWireup="true"
    CodeBehind="Usuario.aspx.cs" Inherits="SAC_PREFEITURA._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
    <asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    </asp:Content>
    
    <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    CPF - Login: <asp:Label ID="LbCPFLogin" runat="server" Text="0"></asp:Label>        
        <asp:Panel ID="PainelDados" runat="server">
          <div style="margin-bottom:20px">
          <h2>Dados do usuário</h2>
          <br />
              Nome:<asp:TextBox ID="TXNome" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="500px"></asp:TextBox>
              DataNacimento(dd/mm/aaaa):
              <asp:ToolkitScriptManager ID="ToolkitScriptManager1" EnableScriptGlobalization="true" runat="server"></asp:ToolkitScriptManager>              
              <asp:TextBox ID="TxDTNascimento" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="100px"></asp:TextBox>
              <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="TxDTNascimento" runat="server"></asp:CalendarExtender>              
          </div>
          <div style="margin-bottom:20px">
              CEP:<asp:TextBox ID="TxCEP" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="90px"></asp:TextBox>
              Logradouro:<asp:TextBox ID="TxLogradouro" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="350px"></asp:TextBox>
              nº:<asp:TextBox ID="TxNumero" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="50px"></asp:TextBox>
              <br />
              <br />
              Complemento:<asp:TextBox ID="TxComplemento" runat ="server" 
                  style ="margin-right:20px; margin-left: 20px" Width="109px"></asp:TextBox>
              Bairro:<asp:TextBox ID="TxBairro" runat ="server" 
                  style ="margin-right:20px; margin-left: 20px" Width="292px"></asp:TextBox>              
          </div>
          <div style="margin-bottom:20px">
              Telefone Fixo:<asp:TextBox ID="TxFixo" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="100px"></asp:TextBox>
              Telefone Celular:<asp:TextBox ID="TxCell" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="100px"></asp:TextBox>
              E-Mail:<asp:TextBox ID="TxEmail" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="300px"></asp:TextBox>
              <br />
              <br />
              <asp:LinkButton ID="LinkButtonAtualizarDados" runat="server" OnClick="LinkButtonAtualizarDados_Click" >Atualizar dados.</asp:LinkButton>
          </div>            
          <hr />    
          <div style="margin-bottom: 20px">
          <h2>Dados da ocorrência</h2>
              Serviço solicitato:<asp:DropDownList ID="cbServicos" runat="server" Height="20px" style="font-size:12px; margin-left: 19px;" Width="200px" DataSourceID="AccessDataSource1" DataTextField="DESCRICAO" DataValueField="ID">
                   <asp:ListItem>Capina</asp:ListItem>
                   <asp:ListItem>Entulho</asp:ListItem>
                   <asp:ListItem>Animal em via pública</asp:ListItem>
                   <asp:ListItem>Lixo</asp:ListItem>
                  <asp:ListItem>Outros - Especifique</asp:ListItem>
              </asp:DropDownList>              
              <asp:AccessDataSource ID="AccessDataSource1" runat="server" DataFile="~/App_Data/BDSacPrefeitura.mdb" SelectCommand="SELECT [DESCRICAO], [ID], [IDSETOR] FROM [TipoDemanda] ORDER BY [DESCRICAO]"></asp:AccessDataSource>
              <br />
              <br />
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
                      Style="margin-right: 20px; margin-left: 20px" Width="137px" Height="30px" OnClick="BtnConfirmar_Click"/>                   
              </div>
              <hr />
            </asp:Panel>

        <asp:Panel ID="PainelDemandas" runat="server">
        <h3>Demandas Cadastradas</h3>
        <asp:GridView ID="DtgDados" runat="server" CellPadding="4" ForeColor="#333333" 
                BorderWidth="2px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" BorderColor="Black" BorderWidth="2px" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
        </asp:Panel>             
    
    </asp:Content>
