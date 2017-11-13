using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVidaDiabetica.pgs
{
    public partial class CadastroVoluntario : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();
        Share sh = new Share();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFinalVol_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("insert into tblGeral values('" + sh.getNome() + "', '" + sh.getRG() + "', '" + sh.getCPF() + "','" + sh.getEmail() + "','" + sh.getEndereco() + "','" + sh.getTel() + "','" + sh.getCel() + "','" + sh.getDataNasc() + "','vol')");
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("Select max(idGeral) from tblGeral where tipo='vol'");
            string max = (dt.Rows[0][0]).ToString();
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("insert into tblVoluntarios values('" + max + "', 'Não definido', '" + txtMotiv.Text + "', '" + txtHab.Text + "')");
            Response.Redirect("obrigado.aspx");

        }
    }
}