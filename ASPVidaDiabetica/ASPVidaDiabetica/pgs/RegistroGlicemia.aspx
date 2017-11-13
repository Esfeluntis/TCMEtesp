<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroGlicemia.aspx.cs" Theme="ObjetosAsp" Inherits="ASPVidaDiabetica.pgs.RegistroGlicemia" MasterPageFile="~/MasterPage.Master" %>

<asp:Content ID="conteudoprincipal" ContentPlaceHolderID="conteudoprincipal" runat="server">

Data: <asp:TextBox ID="txtData" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>

    <br />

<asp:DropDownList runat="server" ID="ddlOca">
    <asp:ListItem Selected="True">Ocasião</asp:ListItem>
    <asp:ListItem Value="ANTESCAFE">Antes do café</asp:ListItem>
    <asp:ListItem Value="APOSCAFE">2 h após os café</asp:ListItem>
    <asp:ListItem Value="ANTESLANCHE">Antes do lanche da manhã</asp:ListItem>
    <asp:ListItem Value="DEPOISLANCHE">2 h após o lanche da manhã</asp:ListItem>
    <asp:ListItem Value="ANTESALMOC">Antes do almoço</asp:ListItem>
    <asp:ListItem Value="DEPOISALMOC">2 h após o almoço</asp:ListItem>
    <asp:ListItem Value="ANTESLANCHET">Antes do lanche da tarde</asp:ListItem>
    <asp:ListItem Value="DEPOISLANCHET">2 h após o lanche da tarde</asp:ListItem>
    <asp:ListItem Value="ANTESJANTAR">Antes do jantar</asp:ListItem>
    <asp:ListItem Value="DEPOISJANTAR">2 h após o jantar</asp:ListItem>
    <asp:ListItem Value="ANTESLANCHEN">Antes do lanche da noite</asp:ListItem>
    <asp:ListItem Value="DEPOISLANCHEN">2 h após o lanche da noite</asp:ListItem>
    </asp:DropDownList>

    <br />

    <br />

Valor: <asp:TextBox ID="txtValor" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>

    <br />

Insulina: <asp:TextBox ID="txtInsul" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>

    <br />

<asp:Button ID="btnEnviar" runat="server" Width="60px" Text="Enviar" CssClass="btnCad" OnClick="btnFinalBen_Click" />
</asp:Content>