<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroMedico.aspx.cs" Inherits="ASPVidaDiabetica.pgs.CadastroMedico" MasterPageFile="~/MasterPage2.Master" Theme="ObjetosAsp" %>


<asp:Content ID="conteudoprincipal" ContentPlaceHolderID="conteudoprincipal" runat="server">
    <img src="../img/cadmed.jpg" id="imgcad1" />
        <div id="area-principal">
            <br />
    <h2 id="titulocadmed">Cadastro de Médicos</h2>
    <div id="textocad1">
    <p>Bem-vindo ao time, Dr.(a)!</p>
    <p>Por favor, preencha os campos abaixo para efetuar seu cadastro!</p>
    <p>Para trabalhar em nossa ONG, você deverá ainda passar por uma entrevista, onde o conheceremos melhor, a fim
        de proporcionarmos o melhor atendimento para nossos beneficiados!
    </p>
    <p>Em algumas horas, um representante de nossa ONG entrará em contato via e-mail, onde vocês poderão agendar
        esta entrevista.
    </p>
    <p>Obrigado pela atenção, esperamos vê-lo em breve em nossa equipe!</p>
        </div>
    <div id="formcad1">
Especialidade: <asp:TextBox ID="txtEspec" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
CRM: <asp:TextBox ID="txtCRM" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
Link para currículo: <asp:TextBox ID="txtLinkCurr" runat="server" CssClass="textbox" SkinID="txtboxbonita"></asp:TextBox>
        <br />
        <asp:Button ID="btnFinalMed" runat="server" Width="60px" Text="Finalizar" CssClass="btnCad" OnClick="btnFinal_Click" />

</div>
            <br /><br />
            </div>
    </asp:Content>