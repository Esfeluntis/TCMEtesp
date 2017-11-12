<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroVoluntario.aspx.cs" Theme="ObjetosAsp" Inherits="ASPVidaDiabetica.pgs.CadastroVoluntario" MasterPageFile="~/MasterPage2.Master" %>

<asp:Content ID="conteudoprincipal" ContentPlaceHolderID="conteudoprincipal" runat="server">
    <img src="../img/cadvol.jpg" id="imgcad1" />
    <div id="area-principal">
    <h2 id="titulocadben">Cadastro de Voluntários</h2>
    <div id="textocad1">
        <p> Olá, voluntário, seja bem-vindo ao time!</p>
        <p>Preencha os campos abaixo com algumas informações a respeito do que você deseja fazer em nossa ONG.</p>
        <p>Algumas horas após você finalizar seu cadastro, um funcionário de nossa ONG entrará
            em contato com você, a fim de agendar uma espécie de entrevista a fim de lhe direcionar para
            algum trabalho específico em nossa ONG.
        </p>
        <p>Obrigado por se voluntariar, seu trabalho ajudará a facilitar a vida de milhares
            de diabéticos!
        </p>
        </div>
    <div id="formcad2">
Motivação: <asp:TextBox ID="txtMotiv" runat="server" SkinID="txtboxbonita2" CssClass="textbox2" Rows="10" TextMode="MultiLine"></asp:TextBox>
Habilidades: <asp:TextBox ID="txtHab" runat="server" SkinID="txtboxbonita2" CssClass="textbox2" Rows="10" TextMode="MultiLine"></asp:TextBox>
        <br />
        <asp:Button ID="btnFinalVol" runat="server" Width="60px" Text="Finalizar" CssClass="btnCadVol" OnClick="btnFinalVol_Click" />
</div>

              <br /><br />              
        </div>

    </asp:Content>