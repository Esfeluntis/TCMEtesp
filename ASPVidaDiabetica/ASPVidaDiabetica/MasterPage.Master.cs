using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVidaDiabetica
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void EstaLogado()
        {
            if (Session["estalogado"].ToString() == "1")
            {
                Response.Write("<script language='javascript'> alert('Para acessar esta e outras páginas, faça login!');");
            }
        }
    }
}