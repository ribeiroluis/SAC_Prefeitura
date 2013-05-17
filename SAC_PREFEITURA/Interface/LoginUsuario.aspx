<%@ Page Title="" Language="C#" MasterPageFile="~/Interface/Site.Master" AutoEventWireup="true" CodeBehind="LoginUsuario.aspx.cs" Inherits="SAC_PREFEITURA.Interface.LoginUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    
        <asp:Panel ID="PainelLogin" runat="server">
        <div style="margin-bottom:20px">
        <h2> Login Usuário</h2>
        <br />
        <asp:Label ID="LbCPF" runat="server" Text="CPF: " style ="margin-right:20px; margin-left: 20px"></asp:Label>
        <asp:TextBox ID="txCPF" runat ="server" style ="margin-right:20px; margin-left: 20px"></asp:TextBox>
        <br />
        <asp:Label ID="lbsenha" runat="server" Text="Senha: " style ="margin-right:20px; margin-left: 20px"></asp:Label>
        <asp:TextBox ID="txSenha" runat="server" TextMode="Password" style="margin-left: 7px; margin-top:10px"></asp:TextBox>
        <asp:Label ID="lbConfirmarSenha" Visible="false" runat="server" Text="Confirmar senha: " style ="margin-right:20px; margin-left: 20px"></asp:Label>
        <asp:TextBox ID="TxConfirmarSenha" Visible="false" runat="server" TextMode="Password" style="margin-left: 7px; margin-top:10px"></asp:TextBox>
        <br/>
            <asp:Button ID="btnLogar" runat="server" onclick="btnLogar_Click" 
                style="margin-right:59px; margin-left: 150px; margin-top:10px" Text="Login" 
                Width="70px" />
            <br />
            <br />
            <asp:LinkButton ID="LinkButtonCadastrarNovo" runat="server" 
                style="margin-left:20px" onclick="LinkButtonCadastrarNovo_Click">Cadastrar novo</asp:LinkButton>
            <asp:LinkButton ID="LinkButtonEsqueciSenha" runat="server" style="margin-left:20px">Esqueci senha</asp:LinkButton>
     </div>
        </asp:Panel>   
</asp:Content>
