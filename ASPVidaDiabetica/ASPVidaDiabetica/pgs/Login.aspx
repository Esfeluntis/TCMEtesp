<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASPVidaDiabetica.Login" Theme="ObjetosAsp" MasterPageFile="../MasterPage2.Master" %>

<asp:Content ID="conteudoprincipal" ContentPlaceHolderID="conteudoprincipal" runat="server">
    <div id="bglogin">
    <div id="login">


        <span id="lblUser">Usuário: </span><asp:TextBox ID="txtUser" runat="server" CssClass="textbox3" SkinID="txtboxbonita"></asp:TextBox><br />
        <span id="lblSenha">Senha: </span><asp:TextBox ID="txtSenha" runat="server" TextMode="Password" CssClass="textbox3" SkinID="txtboxbonita"></asp:TextBox><br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" Width="60px" OnClick="btnLogin_Click" CssClass="btnlogin" />


    </div>
        <h3 id="cadastro">Não é cadastrado?Cadastre-se clicando<a href="InicioCadastro.aspx" id="aqui">aqui</a>!</h3>
        </div>


    </asp:Content>

    <asp:Content ID="estalogado" ContentPlaceHolderID="estalogado" runat="server">
        <%EstaLogado();%>
        </asp:Content>