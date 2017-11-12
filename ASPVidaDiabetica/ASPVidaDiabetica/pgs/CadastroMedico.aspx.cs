using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVidaDiabetica.pgs
{
    public partial class CadastroMedico : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();
        Share sh = new Share();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFinal_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("insert into tblGeral values('" + sh.getNome() + "', '" + sh.getRG() + "', '" + sh.getCPF() + "','" + sh.getEmail() + "','" + sh.getEndereco() + "','" + sh.getTel() + "','" + sh.getCel() + "','" + sh.getDataNasc() + "','med')");
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("Select max(idGeral) from tblGeral where tipo='med'");
            string max = (dt.Rows[0][0]).ToString();
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("insert into tblMedicos values('" + max + "', '" + txtEspec.Text + "', '" + txtCRM.Text + "','" + txtLinkCurr.Text + "')");
            Response.Redirect("obrigado.aspx");
        }
    }
}