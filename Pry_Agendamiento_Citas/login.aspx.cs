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
        int contador = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            Session["con"] = Session["Conantiguo"];
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
            }
            else if (string.IsNullOrEmpty(txt_password.Text))
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

                            lbl_intentos.Text = (contador + (Convert.ToInt32(Session["con"]))).ToString();
                            Session["Conantiguo"] = lbl_intentos.Text.ToString();

                            if (Convert.ToInt32(lbl_intentos.Text) == 3)
                            {
                                btn_ingresar.Visible = false;
                                lnk_olvido.Visible = true;

                                Session["con"] = null;
                                Session["Conantiguo"] = null;
                            }
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
        protected void lnk_olvido_Click(object sender, EventArgs e)
        {
            btn_recuperar.Visible = true;
            txt_password.Visible = false;
            Label2.Visible = false;
            lbl_mensaje.Text = "";

            lnk_olvido.Visible = false;
            lnk_Registro.Visible = false;

            txt_usuario.Text = "";
            lnk_Cancelar.Visible = true;
            Label3.Text = "Cedula";
        }

        protected void btn_recuperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                lbl_mensaje.Text = "Ingrese su CEDULA para el proceso de recuperacion!";
            }
            else
            {
                olvido();
            }
        }

        private void olvido()
        {
            if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                lbl_mensaje.Text = "Ingrese su CEDULA!!";
            }
            else
            {
                bool existe = Usuario_Log.autentificarXCedula(txt_usuario.Text);
                {
                    if (existe)
                    {
                        Tbl_Usuario usu = new Tbl_Usuario();
                        usu = Usuario_Log.obtenerUsuXCedula(txt_usuario.Text);

                        string from = "asistenciatecnica067@gmail.com";
                        string pass = "ansii12345@@";
                        string to = usu.usu_correo;
                        string sms = "Su Credenciales son: "+usu.usu_nomLogin+" y la contraseña para ingresar al sistema es: "+usu.usu_cedula;

                        if (new EmailRecuperacion().enviarcorreo(from,pass,to,sms))
                        {
                            lbl_mensaje.ForeColor = Color.GreenYellow;
                            lbl_mensaje.Text = "Correo Enviado con EXITO";
                            Timer1.Enabled = true;
                        }
                        else
                        {
                            lbl_mensaje.ForeColor = Color.Red;
                            lbl_mensaje.Text = "NO ENVIADO!!!";
                        }
                    }
                    else
                    {
                        lbl_mensaje.Text = "Usuario Incorrecto";
                    }
                }
            }
        }

        protected void lnk_Cancelar_Click(object sender, EventArgs e)
        {
            btn_recuperar.Visible = false;
            txt_password.Visible = true;
            Label2.Visible = true;
            btn_ingresar.Visible = true;
            lnk_olvido.Visible = false;

            lbl_intentos.Text = "";
            txt_usuario.Text = "";
            lnk_Cancelar.Visible = false;
            lnk_Registro.Visible = true;

            lbl_mensaje.Text = "";
            Label3.Text = "Usuario";
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            btn_recuperar.Visible = false;
            txt_password.Visible = true;
            Label2.Visible = true;
            btn_ingresar.Visible = true;
            lnk_olvido.Visible = false;

            lbl_intentos.Text = "";
            txt_usuario.Text = "";
            lnk_Cancelar.Visible = false;
            lnk_Registro.Visible = true;

            lbl_mensaje.Text = "";
            Label3.Text = "Usuario";

            Timer1.Enabled = false;
        }
    }
}