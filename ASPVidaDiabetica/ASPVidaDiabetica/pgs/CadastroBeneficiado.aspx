<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroBeneficiado.aspx.cs" Theme="ObjetosAsp" Inherits="ASPVidaDiabetica.pgs.CadastroBeneficiado" MasterPageFile="~/MasterPage2.Master" %>


<asp:Content ID="conteudoprincipal" ContentPlaceHolderID="conteudoprincipal" runat="server">
    <img src="../img/cadben.jpg" id="imgcad1" />
    <div id="area-principal">
        <h2 id="titulocadben">Cadastro de Beneficiados</h2>
        <div id="textocad1">
            <p>Seja bem-vindo à ONG Vida Diabética!</p>
            <p>Esperamos do fundo de nossos corações que nossa ONG possa ser um espaço onde você pode aprender,
                conhecer, discutir e aprender mais sobre a diabetes, a fim de facilitar a sua vida e a vida das
                pessoas que o cercam.
            </p>
            <p>Obrigado por nos dar a oportunidade de lhe ajudar!</p>


        </div>
    <div id="formcad1">
Tipo da Diabetes: <asp:RadioButtonList ID="rblTipoDiabetes" runat="server">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
        </asp:RadioButtonList>
Ano do Diagnóstico: <asp:TextBox ID="txtAnoDiag" runat="server" skinID="txtboxbonita" CssClass="textbox"></asp:TextBox>
Convênio: <asp:TextBox ID="txtConve" runat="server" skinID="txtboxbonita" CssClass="textbox"></asp:TextBox>
Insulinas ou
        <br />
        medicamentos utilizados: <asp:TextBox ID="txtMed" runat="server" SkinID="txtboxbonita" CssClass="textbox"></asp:TextBox>
Nome do endocrinologista 
        <br />
        responsável: <asp:TextBox ID="txtEndo" runat="server" SkinID="txtboxbonita" CssClass="textbox"></asp:TextBox>
        <br />
                <asp:Button ID="btnFinalBen" runat="server" Width="60px" Text="Finalizar" CssClass="btnCad" OnClick="btnFinalBen_Click" />
</div>
        <br /><br />
        </div>
    </asp:Content>