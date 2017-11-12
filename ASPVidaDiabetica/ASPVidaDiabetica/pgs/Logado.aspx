<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logado.aspx.cs" Inherits="ASPVidaDiabetica.Logado" MasterPageFile="../MasterBeneficiado.Master" %>

<asp:Content ID="conteudoprincipal" ContentPlaceHolderID="conteudoprincipal" runat="server">
    <h2>Olá, <%Response.Write(Session["nome_logon"]); %>, seja bem-vindo(a)!</h2>
 </asp:Content>