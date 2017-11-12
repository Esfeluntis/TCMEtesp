using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVidaDiabetica.pgs
{
    public partial class CadastroBeneficiado : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();
        Share sh = new Share();
        string tipodia;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFinalBen_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("insert into tblGeral values('" + sh.getNome() + "', '" + sh.getRG() + "', '" + sh.getCPF() + "','" + sh.getEmail() + "','" + sh.getEndereco() + "','" + sh.getTel() + "','" + sh.getCel() + "','" + sh.getDataNasc() + "','ben')");
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("Select max(idGeral) from tblGeral where tipo='ben'");
            string max = (dt.Rows[0][0]).ToString();
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("insert into tblBeneficiados values('" + max + "', '" + rblTipoDiabetes.SelectedValue + "', '" + txtAnoDiag.Text + "','" + txtConve.Text + "','" + txtMed.Text + "','" + txtEndo.Text + "', 'Site')");
            Response.Redirect("obrigado.aspx");
        }
    }
}