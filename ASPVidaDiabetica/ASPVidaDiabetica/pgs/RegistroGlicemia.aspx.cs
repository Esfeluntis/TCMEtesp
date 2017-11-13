using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVidaDiabetica.pgs
{
    public partial class RegistroGlicemia : System.Web.UI.Page
    {
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();
        Share sh = new Share();
        


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFinalBen_Click(object sender, EventArgs e)
        {
            Session["id_ben"] = "1";
            dt = new DataTable();
            con = new ClasseConexao();
            dt = con.executarSQL("update tblRegGlicemia set " + ddlOca.SelectedValue + " = " + txtValor.Text + " where data = '" + txtData.Text + "' and idBeneficiado = 1");

        }
    }
}