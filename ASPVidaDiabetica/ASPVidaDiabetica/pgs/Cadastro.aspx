<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="ASPVidaDiabetica.pgs.Cadastro" Theme="ObjetosAsp" MasterPageFile="../MasterPage2.Master" %>

<asp:Content ID="conteudoprincipal" ContentPlaceHolderID="conteudoprincipal" runat="server">
        <img src="../img/imgcad1.jpg" id="imgcad1" />
    <div id="area-principal">
    <h2 id="titulocad">Cadastro</h2>
    <p>&nbsp;</p>
    <div id="textocad1">
    <p>Nesta página, estão alguns campos obrigatórios para todas as "funções" que possuímos na ONG.</p>
    <p>Após preencher este formulário, você será redirecionado para uma página com campos específicos de cada
        função.
    </p>
    <p>Desde já, agradecemos pelo seu interesse em participar de nossa ONG!</p>
        </div>

        <div id="formcad1">
        Nome:<asp:TextBox ID="txtNome" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
        RG:<asp:TextBox ID="txtRG" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
        CPF:<asp:TextBox ID="txtCPF" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
        E-mail:<asp:TextBox ID="txtEmail" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
        Endereço:<asp:TextBox ID="txtEnd" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
        Telefone:<asp:TextBox ID="txtTel" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
        Celular:<asp:TextBox ID="txtCel" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
        Data de Nascimento:<asp:TextBox ID="txtDataNasc" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
        Função:<asp:RadioButtonList ID="rblFunc" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="204px">
            <asp:ListItem>Beneficiado</asp:ListItem>
            <asp:ListItem>Voluntário</asp:ListItem>
            <asp:ListItem>Médico</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Button ID="btnProx" runat="server" Width="60px" Text="Próximo" CssClass="btnCad" OnClick="btnProx_Click" />
        <br />
            </div>
        <br /><br /> 
        </div>
</asp:Content>