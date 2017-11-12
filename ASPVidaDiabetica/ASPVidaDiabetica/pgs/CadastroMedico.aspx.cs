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
            dt = con.executa_sql("insert");
            Session["logon"] = "1";
            Session["nome_logon"] = sh.getNome();
            Session["idBen"] = null; //pegar id;
            Response.Redirect("Logado.aspx");
        }
    }
}