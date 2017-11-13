using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVidaDiabetica.pgs
{
    public partial class cadacesso : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFinalAc_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("insert into tblAcesso values (" + Session["max"].ToString() + " , '" + txtUsuar.Text + "','" + txtSenha.Text + "', 2)");
            Response.Redirect("obrigado.aspx");
        }
    }
}