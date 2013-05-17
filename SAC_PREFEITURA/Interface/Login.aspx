<%@ Page Title="SAC - PREFEITURA DE BETIM .:. ADMINISTRADOR SISTEMA" Language="C#" MasterPageFile="Site.master" AutoEventWireup="true"
    CodeBehind="Login.aspx.cs" Inherits="SAC_PREFEITURA.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<div style="margin-bottom:20px">
    <h2> Login Funcionário</h2>
    <br />
    <div align=left style="margin-left:50px">
    Login: <asp:TextBox ID="txboxlogin" runat ="server" style ="margin-right:20px; margin-left: 20px; margin-top:10px; width:100px"></asp:TextBox>
    </div>
    <div align=left style="margin-left:50px">
    Senha:<input id="txsenhafuncionario" type="password"  style ="margin-right:20px; margin-left: 20px; margin-top:10px; width:100px"/>
    </div>
    <div align=left style="margin-top:10px; margin-left:160px">
    <asp:Button ID="Button2" runat="server" 
        Text="Login" 
        Width="50px" OnClick="Button2_Click"/>          
    </div>
</asp:Content>
