<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadacesso.aspx.cs" Theme="ObjetosAsp" Inherits="ASPVidaDiabetica.pgs.cadacesso" MasterPageFile="~/MasterPage.Master" %>

<asp:Content ID="conteudoprincipal" ContentPlaceHolderID="conteudoprincipal" runat="server">

    <h2 id="titulocadben">Informações para Acesso</h2>
    <div id="textocad1">
        Preencha abaixo as informações que você deseja utilizar para fazer login em nossa plataforma web!
    </div>
    <div id="formcad1">
Usuário: <asp:TextBox ID="txtUsuar" runat="server" skinID="txtboxbonita" CssClass="textbox"></asp:TextBox>
Senha: <asp:TextBox ID="txtSenha" runat="server" skinID="txtboxbonita" CssClass="textbox"></asp:TextBox>
        <asp:Button ID="btnFinalAc" runat="server" Width="60px" Text="Finalizar" CssClass="btnCad" OnClick="btnFinalAc_Click" />
    </div>
    <br /><br />
    

    </asp:Content>