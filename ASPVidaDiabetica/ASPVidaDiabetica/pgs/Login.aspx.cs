﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVidaDiabetica
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["logon"] = "0";
        }

        public void EstaLogado()
        {
            if (Session["estalogado"].ToString() == "1")
            {
                Response.Write("<script language='javascript'> alert('Para acessar esta e outras páginas, faça login!'); </script>");
            }
        }
        DataTable dt = new DataTable();
        ClasseConexao con = new ClasseConexao();



        protected void btnLogin_Click(object sender, EventArgs e)
        {
            con = new ClasseConexao();
            dt = new DataTable();
            dt = con.executarSQL("select * from tblAcesso where usuario='" + txtUser.Text + "' and senha='" + txtSenha.Text + "'");

            if (dt.Rows.Count > 0)
            {
                string idgeral = dt.Rows[0][1].ToString();
                dt = new DataTable();
                con = new ClasseConexao();
                dt = con.executarSQL("select * from tblBeneficiados where idGeral =" + idgeral);
                Session["id_ben"] = (dt.Rows[0][0]).ToString();
                Session["nome_logon"] = txtUser.Text;
                Session["logon"] = "1";
                Response.Redirect("Logado.aspx");
            }
            else
            {
                Response.Write("<script language='javascript'> alert('Usuário ou senha inválido(s)');</script>");
                txtUser.Text = "";
                txtSenha.Text = "";
            }
            }
    }
}