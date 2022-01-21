using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocio;

namespace Pry_Agendamiento_Citas
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnk_Registro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registrar.aspx");
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            ingresar();
        }

        private void ingresar()
        {
            lbl_mensaje.Text = "";
            if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Ingrese su Usuario..";
            }else if (string.IsNullOrEmpty(txt_password.Text))
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Ingrese su Cedula..";
            }
            else
            {
                //Proceso de Ingreso al Sistema
                bool existenom = Usuario_Log.autentificarXNomLogin(txt_usuario.Text);
                bool existeusu = Usuario_Log.autentificar(txt_usuario.Text, txt_password.Text);
                {
                    if (existenom)
                    {
                        if (existeusu)
                        {
                            Tbl_Usuario usuario = new Tbl_Usuario();
                            usuario = Usuario_Log.autentificarXlogin(txt_usuario.Text, txt_password.Text);

                            int tusu = (int)usuario.tusu_id;

                            if (tusu == 1)
                            {
                                Session["Admin"] = txt_usuario.Text;
                                Response.Redirect("~/Template/Dashboard.aspx");
                            }
                            if (tusu == 2)
                            {
                                Session["Med"] = txt_usuario.Text;
                                Response.Redirect("~/Template/Dashboard.aspx");
                            }
                            if (tusu == 3)
                            {
                                Session["Pac"] = txt_usuario.Text;
                                Response.Redirect("~/Template/Dashboard.aspx");
                            }
                        }
                        else
                        {
                            lbl_mensaje.ForeColor = Color.OrangeRed;
                            lbl_mensaje.Text = "Datos Incorrectos";
                        }
                    }
                    else
                    {
                        lbl_mensaje.ForeColor = Color.OrangeRed;
                        lbl_mensaje.Text = "Usuario NO EXISTE en la BBDD!";
                    }
                }

            }
        }
    }
}