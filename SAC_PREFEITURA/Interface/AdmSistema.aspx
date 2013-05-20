<%@ Page Title="Administração Sistema" Language="C#" MasterPageFile="~/Interface/Site.Master" AutoEventWireup="true" CodeBehind="AdmSistema.aspx.cs" Inherits="SAC_PREFEITURA.Interface.AdmSistema" %>

<%@ Register TagPrefix="asp" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="PainelDemandas" runat="server">
        <h3>Demandas Cadastradas</h3>
        <div>
            <asp:Label ID="Label1" runat="server" Text="Setor: " Style="margin-left: 20px"></asp:Label>
            <asp:DropDownList ID="cbSetor" runat="server" Style="margin-left: 20px" DataSourceID="ObjetoSetor" DataTextField="NOME" DataValueField="Código" AutoPostBack="True" OnSelectedIndexChanged="cbSetor_SelectedIndexChanged"></asp:DropDownList>
            <asp:ObjectDataSource ID="ObjetoSetor" runat="server" DeleteMethod="Delete" InsertMethod="Insert" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="SAC_PREFEITURA.BD_SAC_PrefeituraTableAdapters.SetorTableAdapter" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="Original_Código" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="NOME" Type="String" />
                    <asp:Parameter Name="SECRETARIA" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="NOME" Type="String" />
                    <asp:Parameter Name="SECRETARIA" Type="String" />
                    <asp:Parameter Name="Original_Código" Type="Int32" />
                </UpdateParameters>
            </asp:ObjectDataSource>
            <asp:Label ID="Label2" runat="server" Text="Tipo Demanda: " Style="margin-left: 40px"></asp:Label>
            <asp:DropDownList ID="cbDemanda" runat="server" Style="margin-left: 20px" AutoPostBack="True"></asp:DropDownList>
            <asp:Button Text="Pesquisar" runat="server" Style="margin-left: 40px" ID="btnPesquisar" OnClick="btnPesquisar_Click" />
        </div>
        <div>
            <br />
            <asp:GridView ID="dtgDadosDemandas" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" AllowPaging="True" CellSpacing="2" ForeColor="Black">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" BorderColor="Black" BorderWidth="1px" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>
        <hr />
    </asp:Panel>
    
    <asp:Panel runat="server" ID="PainelAtualizarDemanda">
        <div>
            <h3>Atualizar Demandas - (selecione a demanda acima e realize as alterações)</h3>
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Id: " style="margin-left: 20px"></asp:Label>
            <asp:TextBox ID="TxIdDemanda" runat="server" Style="margin-left: 20px" Height="20px" Width="40px"></asp:TextBox>
            <asp:Button ID="BtnEnviarDemadna" runat="server" Text="Selecionar" Style="margin-left: 40px" OnClick="BtnEnviarDemadna_Click" />
             <asp:GridView ID="DtgDadosDemandaExpecifica" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" style="margin-top: 20px" AutoGenerateColumns="False" DataSourceID="ObjPesquisa">
                 <Columns>
                     <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" SortExpression="Id" />
                     <asp:BoundField DataField="Tipo" HeaderText="Tipo" SortExpression="Tipo" />
                     <asp:BoundField DataField="Endereço" HeaderText="Endereço" SortExpression="Endereço" />
                     <asp:BoundField DataField="nº" HeaderText="nº" SortExpression="nº" />
                     <asp:BoundField DataField="comp" HeaderText="comp" SortExpression="comp" />
                     <asp:BoundField DataField="Bairro" HeaderText="Bairro" SortExpression="Bairro" />
                     <asp:BoundField DataField="Detalhes" HeaderText="Detalhes" SortExpression="Detalhes" />
                     <asp:BoundField DataField="Cadastrada" HeaderText="Cadastrada" SortExpression="Cadastrada" />
                     <asp:BoundField DataField="Iniciada" HeaderText="Iniciada" SortExpression="Iniciada" />
                     <asp:BoundField DataField="Finalizada" HeaderText="Finalizada" SortExpression="Finalizada" />
                 </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" BorderColor="Black" BorderWidth="1px" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>           
            <asp:ObjectDataSource ID="ObjPesquisa" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="RetornaTabelaPorIDUsuarioDemanda" TypeName="SAC_PREFEITURA.BD_SAC_PrefeituraTableAdapters.ViewDemandasTableAdapter" OnLoad="ObjPesquisa_Load">
                <SelectParameters>
                    <asp:ControlParameter ControlID="TxIdDemanda" Name="Código" PropertyName="Text" Type="Int32" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
        <div>
            
            <asp:Label ID="Label5" runat="server" Text="Cadastrada: " style="margin-left: 10px"></asp:Label>
            <asp:TextBox ID="TxDataCadastro" runat="server" Style="margin-left: 10px; margin-top: 20px;" Height="20px" Width="100px" ReadOnly="True"></asp:TextBox>
            
            <asp:Label ID="Label6" runat="server" Text="Iniciada: " style="margin-left: 10px"></asp:Label>                        
            <asp:ToolkitScriptManager ID="ToolkitScriptManager1" EnableScriptGlobalization="true" runat="server"></asp:ToolkitScriptManager>              
            <asp:TextBox ID="TxIniciada" runat="server" Style="margin-left: 10px; margin-top: 20px;" Height="20px" Width="100px"></asp:TextBox>  
            <asp:CalendarExtender ID="CalendarExtender1" TargetControlID="TxIniciada" runat="server"></asp:CalendarExtender>

            <asp:Label ID="Label7" runat="server" Text="Finalizada: " style="margin-left: 10px"></asp:Label> 
            <asp:TextBox ID="TxFinalizada" runat="server" Style="margin-left: 10px; margin-top: 20px;" Height="20px" Width="100px"></asp:TextBox>  
            <asp:CalendarExtender ID="CalendarExtender2" TargetControlID="TxFinalizada" runat="server"></asp:CalendarExtender>

            <asp:LinkButton ID="LinkAtualizar" runat="server" style="margin-left: 10px" OnClick="LinkAtualizar_Click">Atualizar alterações</asp:LinkButton>
        </div>
        

    </asp:Panel>
</asp:Content>
