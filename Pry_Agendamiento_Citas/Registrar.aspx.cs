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
    public partial class Registrar : System.Web.UI.Page
    {
        private Tbl_Usuario usuinfo = new Tbl_Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnk_Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }

        protected void btn_registrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nombapell.Text) || string.IsNullOrEmpty(txt_ced.Text) || string.IsNullOrEmpty(txt_correo.Text) ||
                string.IsNullOrEmpty(txt_usuario.Text) || string.IsNullOrEmpty(txt_contrasenia.Text))
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Llenar todos los Campos!!";
            }
            else
            {
                try
                {
                    lbl_mensaje.Text = "";
                    usuinfo = new Tbl_Usuario();

                    usuinfo.usu_apellido_nombre = txt_nombapell.Text;
                    usuinfo.usu_cedula = txt_ced.Text;
                    usuinfo.usu_correo = txt_correo.Text;
                    usuinfo.usu_nomLogin = txt_usuario.Text;
                    usuinfo.usu_contrasenia = txt_contrasenia.Text;


                    Usuario_Log.saveInfoAdmin(usuinfo);

                    lbl_mensaje.ForeColor = Color.Green;
                    lbl_mensaje.Text = "Datos Guardados con Exito!!";

                    Timer1.Enabled = true;
                }
                catch (Exception)
                {
                    lbl_mensaje.ForeColor = Color.Red;
                    lbl_mensaje.Text = "Datos NO Guardados!";
                    throw;
                }
            }
        }
    }
}