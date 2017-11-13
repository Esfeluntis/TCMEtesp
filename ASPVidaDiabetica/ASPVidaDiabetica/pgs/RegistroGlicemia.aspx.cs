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
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executarSQL("select max(DATA) from tblRegGlicemia where IDBENEFICIA = " + Session["id_ben"].ToString());

                int resultado = (DateTime.Compare(Convert.ToDateTime(dt.Rows[0][0].ToString()), DateTime.Now));
            if (resultado < 0)
            {
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executarSQL("select max(DATA) from tblRegGlicemia where IDBENEFICIA = " + Session["id_ben"].ToString());

                    while ((DateTime.Compare(Convert.ToDateTime(dt.Rows[0][0].ToString()), DateTime.Now) < 0))
                    {
                        string data = dt.Rows[0][0].ToString();
                        dt = new DataTable();
                        con = new ClasseConexao();
                        dt = con.executarSQL("insert into tblRegGlicemia (IDBENEFICIA, DATA) values (" + Session["id_ben"].ToString() +", " + "dateadd(day, 1, '" + Convert.ToDateTime(data).ToShortDateString() + "'))");
                        dt = new DataTable();
                        con = new ClasseConexao();
                        dt = con.executarSQL("select max(DATA) from tblRegGlicemia where IDBENEFICIA = " + Session["id_ben"].ToString());
                        
                    }
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executarSQL("update tblRegGlicemia set " + ddlOca.SelectedValue + " = " + txtValor.Text + " where data = '" + txtData.Text + "' and idBeneficia = " + Session["id_ben"].ToString());
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executarSQL("update tblRegGlicemia set " + ddlOca.SelectedValue + "insul" + " = " + txtInsul.Text + " where data = '" + txtData.Text + "' and idBeneficia = " + Session["id_ben"].ToString());
            }
            }



            }
        }
    

