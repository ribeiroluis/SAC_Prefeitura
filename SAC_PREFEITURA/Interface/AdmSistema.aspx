<%@ Page Title="Administração Sistema" Language="C#" MasterPageFile="~/Interface/Site.Master" AutoEventWireup="true" CodeBehind="AdmSistema.aspx.cs" Inherits="SAC_PREFEITURA.Interface.AdmSistema" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
<asp:Panel ID="PainelDemandas" runat="server">
<h3>Demandas Cadastradas</h3>
    <div>
    <asp:Label ID="Label1" runat="server" Text="Setor: " style="margin-left:20px"></asp:Label>
    <asp:DropDownList ID="cbSetor" runat="server" style="margin-left:20px" 
        DataSourceID="DataSourceSetor" DataTextField="NOME" DataValueField="Código">
    </asp:DropDownList>
    <asp:AccessDataSource ID="DataSourceSetor" runat="server" 
        DataFile="~/App_Data/BDSacPrefeitura.mdb" 
        SelectCommand="SELECT [Código], [NOME] FROM [Setor] ORDER BY [NOME]">
    </asp:AccessDataSource>
    <asp:Label ID="Label2" runat="server" Text="Tipo Demanda: " style="margin-left:40px"></asp:Label>
    <asp:DropDownList ID="cbDemanda" runat="server" style="margin-left:20px" 
        DataSourceID="DataSourceDemanda" DataTextField="DESCRICAO" DataValueField="ID">
    </asp:DropDownList>
    <asp:AccessDataSource ID="DataSourceDemanda" runat="server" 
        DataFile="~/App_Data/BDSacPrefeitura.mdb" 
        SelectCommand="SELECT [ID], [DESCRICAO] FROM [TipoDemanda] ORDER BY [DESCRICAO]">
    </asp:AccessDataSource>
        <asp:Button Text="Pesquisar" runat="server" style="margin-left:40px"/>

    </div>
    <div>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    </div>
</asp:Panel>

</asp:Content>
