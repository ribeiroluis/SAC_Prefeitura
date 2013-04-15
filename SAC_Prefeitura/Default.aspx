<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SAC_Prefeitura.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Estilos.css" rel="stylesheet" />    
    <title>Prefeitura Municipal de Betim - SAC</title>
    <style type="text/css">
        #form1 {
            height: 470px;
        }
        .auto-style1 {
            font-size: x-large;
            font-family: "Comic Sans MS";
        }
    </style>
</head>
<body>
      <form id="form1" runat="server" class ="Centralizar">
          <asp:Image ID="Image1" runat="server" Height="66px" ImageAlign="Middle" ImageUrl="http://www.betim.mg.gov.br/imgs/logo.gif" Width="106px" style="margin-left:50px; margin-right:100px"/>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
          <span class="auto-style1">
           <strong>Prefeitura Municipal de Betim - SAC</strong>
          </span>
          <hr/>
          <div style="margin-bottom:20px">
              CPF: <asp:TextBox ID="TextBox2" runat ="server" style ="margin-right:20px; margin-left: 20px"></asp:TextBox>
              Senha:<input id="Password1" type="password"  style ="margin-right:20px; margin-left: 20px"/>
              <asp:Button ID="Button2" runat="server" style="margin-right:20px; margin-left: 20px" Text="Cadastrar / Login" Width="149px" />
          </div>
          <hr />
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
              Nome:<asp:TextBox ID="TXNome" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="500px"></asp:TextBox>
              DataNacimento(dd/mm/aaaa):<asp:TextBox ID="TxDTNascimento" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="100px"></asp:TextBox>
          </div>
          <div style="margin-bottom:20px">
              CEP:<asp:TextBox ID="TxCEP" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="90px"></asp:TextBox>
              Logradouro:<asp:TextBox ID="TxLogradouro" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="350px"></asp:TextBox>
              nº:<asp:TextBox ID="TxNumero" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="50px"></asp:TextBox>
              Complemento:<asp:TextBox ID="TextBox1" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="90px"></asp:TextBox>
              Bairro:<asp:TextBox ID="TxBairro" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="150px"></asp:TextBox>              
          </div>
          <div style="margin-bottom:20px">
              Telefone Fixo:<asp:TextBox ID="TxFixo" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="100px"></asp:TextBox>
              Telefone Celular:<asp:TextBox ID="TxCell" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="100px"></asp:TextBox>
              E-Mail:<asp:TextBox ID="TxEmail" runat ="server" style ="margin-right:20px; margin-left: 20px" Width="300px"></asp:TextBox>
          </div>
          <hr />
          <div style="margin-bottom: 20px">
              <h2>Dados da ocorrência</h2>
              Logradouro:<asp:TextBox ID="TxLogradouroOcorrencia" runat="server" Style="margin-right: 20px; margin-left: 20px" Width="350px"></asp:TextBox>
              nº:<asp:TextBox ID="TxNumeroOcorrencia" runat="server" Style="margin-right: 20px; margin-left: 20px" Width="50px"></asp:TextBox>
              Complemento:<asp:TextBox ID="TxComplementoOcorrencia" runat="server" Style="margin-right: 20px; margin-left: 20px" Width="90px"></asp:TextBox>
              Bairro:<asp:TextBox ID="TxBairroOcorrencia" runat="server" Style="margin-right: 20px; margin-left: 20px" Width="150px"></asp:TextBox>
          </div>
          <div style="margin-bottom: 20px">                                   
                  Descrição detalhada:<asp:TextBox runat="server" Width="1024px" Style="margin-right: 20px; margin-left: 20px" ToolTip="Ex: Ponto de referência, nome do proprietário, e especificidades do local"></asp:TextBox>
              </div>
          <hr />
          <div style="margin-bottom: 20px">                  
                  Carregar foto: 
                  <asp:Button ID="btnCarregar" runat="server" Text="..." Style="margin-right: 20px; margin-left: 20px" Width="30px" Height="20px"/>
                 <asp:Button ID="BtnConfirmar" runat="server" Text="Inserir demanda" Style="margin-right: 20px; margin-left: 20px" Width="200px" Height="30px"/>                   
              </div>
          <hr />        
          <div style="margin-bottom: 20px">
              <h2>Demandas cadastradas - status</h2>                            
              <asp:GridView ID="DtgDados" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                  <Columns>
                      <asp:CheckBoxField HeaderText="Realizado" ReadOnly="True" Text="Realizado" />
                      <asp:BoundField HeaderText="Tipo de serviço" />
                  </Columns>
                  <FooterStyle BackColor="White" ForeColor="#000066" />
                  <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                  <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                  <RowStyle ForeColor="#000066" />
                  <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                  <SortedAscendingCellStyle BackColor="#F1F1F1" />
                  <SortedAscendingHeaderStyle BackColor="#007DBB" />
                  <SortedDescendingCellStyle BackColor="#CAC9C9" />
                  <SortedDescendingHeaderStyle BackColor="#00547E" />
              </asp:GridView>
              </div>
          </form>
</body>
</html>
