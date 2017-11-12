using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVidaDiabetica.pgs
{
    public partial class Cadastro : System.Web.UI.Page
    {
        Share sh = new Share();
        public void SetAll()
        {
            sh.setNome(txtNome.Text);
            sh.setRG(txtRG.Text);
            sh.setCPF(txtCPF.Text);
            sh.setEmail(txtEmail.Text);
            sh.setEndereco(txtEnd.Text);
            sh.setTel(txtTel.Text);
            sh.setCel(txtCel.Text);
            sh.setDataNasc(txtDataNasc.Text);

        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnProx_Click(object sender, EventArgs e)
        {

            if (rblFunc.SelectedValue.Equals("Beneficiado"))
            {
                SetAll();
                sh.setFunc("BN");
                Response.Redirect("CadastroBeneficiado.aspx");
            }
            if (rblFunc.SelectedValue.Equals("Voluntário"))
            {
                SetAll();
                sh.setFunc("VO");
                Response.Redirect("CadastroVoluntario.aspx");
            }
            if (rblFunc.SelectedValue.Equals("Médico"))
            {
                SetAll();
                sh.setFunc("ME");
                Response.Redirect("CadastroMedico.aspx");
            }
            else
            {
                Response.Write("<script language='javascript'> alert('Selecione uma função!');</script>");
            }
        }
    }
}