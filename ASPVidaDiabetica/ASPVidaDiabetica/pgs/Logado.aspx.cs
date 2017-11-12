using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVidaDiabetica
{
    public partial class Logado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["logon"].ToString() != "1")
            {
                Session["logon"] = null;
                Session["nome-logon"] = null;
                Session["estalogado"] = "1";
                Response.Redirect("Login.aspx");

            }
        }
    }
}