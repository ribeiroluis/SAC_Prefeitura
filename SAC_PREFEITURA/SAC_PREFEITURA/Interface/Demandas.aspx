<%@ Page Title="Gerenciar Demandas" Language="C#" MasterPageFile="~/Interface/Site.Master" AutoEventWireup="true" CodeBehind="Demandas.aspx.cs" Inherits="SAC_PREFEITURA.Interface.Demandas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Tipo de Demanda</h3>
    <div style="margin-bottom:20px; margin-top:20px">
              Serviço solicitato:<asp:DropDownList ID="cbServicos" runat="server" Height="20px" style="font-size:12px; margin-left: 19px;" Width="200px">
                   <asp:ListItem>Capina</asp:ListItem>
                   <asp:ListItem>Entulho</asp:ListItem>
                   <asp:ListItem>Animal em via pública</asp:ListItem>
                   <asp:ListItem>Lixo</asp:ListItem>
                  <asp:ListItem>Outros</asp:ListItem>
              </asp:DropDownList>
          </div>
    <hr />
    <div style="margin-bottom:20px; margin-top:20px">
        <h3>Demandas</h3>
    </div>
</asp:Content>
