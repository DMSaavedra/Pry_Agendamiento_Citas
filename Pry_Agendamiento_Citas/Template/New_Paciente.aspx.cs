using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocio;

namespace Pry_Agendamiento_Citas.Template
{
    public partial class New_Paciente : System.Web.UI.Page
    {
        private Tbl_Usuario pacieInfo = new Tbl_Usuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                lbl_nombre.Text = Session["Admin"].ToString();
            }
            else if (Session["Med"] != null)
            {
                lbl_nombre.Text = Session["Med"].ToString();
            }
            else if (Session["Pac"] != null)
            {
                lbl_nombre.Text = Session["Pac"].ToString();
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }

            if (!IsPostBack)
            {
                if (Request["cod"] != null)
                {
                    btn_Modify_Pac.Visible = true;

                    int codg = Convert.ToInt32(Request["cod"]);
                    pacieInfo = Paciente_Log.obtener_paci_xid(codg);

                    if (pacieInfo != null)
                    {
                        txt_Aps_Noms.Text = pacieInfo.usu_apellido_nombre.ToString();
                        txt_Edad.Text = pacieInfo.usu_edad.ToString();
                        txt_cedula.Text = pacieInfo.usu_cedula.ToString();
                        txt_telef.Text = pacieInfo.usu_telefono.ToString();
                        txt_User.Text = pacieInfo.usu_nomLogin.ToString();
                        txt_passw.Text = pacieInfo.usu_contrasenia.ToString();

                        ddl_genero.SelectedValue = pacieInfo.usu_genero.ToString();
                        ddl_grup_sangre.SelectedValue = pacieInfo.usu_grupo_sanguineo.ToString();
                        txt_email.Text = pacieInfo.usu_correo.ToString();

                        btn_Save_Pac.Visible = false;
                    }
                }
            }
        }

        private void guardar()
        {
            try
            {
                lbl_mensaje.Text = "";
                pacieInfo = new Tbl_Usuario();

                pacieInfo.usu_apellido_nombre = txt_Aps_Noms.Text;
                pacieInfo.usu_edad = Convert.ToInt32(txt_Edad.Text);
                pacieInfo.usu_cedula = txt_cedula.Text;
                pacieInfo.usu_telefono = txt_telef.Text;
                pacieInfo.usu_nomLogin = txt_User.Text;
                pacieInfo.usu_contrasenia = txt_passw.Text;

                pacieInfo.usu_grupo_sanguineo = Convert.ToInt32(ddl_grup_sangre.SelectedValue);
                pacieInfo.usu_genero = ddl_genero.SelectedValue;
                pacieInfo.usu_correo = txt_email.Text;

                Paciente_Log.savePacie(pacieInfo);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido GUARDADOS";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han guardado! NewP";
            }
        }

        private void modificar(Tbl_Usuario pacimodf)
        {
            try
            {
                lbl_mensaje.Text = "";

                pacimodf.usu_apellido_nombre = txt_Aps_Noms.Text;
                pacimodf.usu_edad = Convert.ToInt32(txt_Edad.Text);
                pacimodf.usu_cedula = txt_cedula.Text;
                pacimodf.usu_telefono = txt_telef.Text;
                pacimodf.usu_nomLogin = txt_User.Text;
                pacimodf.usu_contrasenia = txt_passw.Text;

                pacimodf.usu_grupo_sanguineo = Convert.ToInt32(ddl_grup_sangre.SelectedValue);
                pacimodf.usu_genero = ddl_genero.SelectedValue;
                pacimodf.usu_correo = txt_email.Text;

                Paciente_Log.modifyPacie(pacimodf);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido MODIFICADO";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han modificado!";
            }
        }

        private void guardar_modificar_datos_paci(int id)
        {
            if (id == 0)
            {
                guardar();
            }
            else
            {
                pacieInfo = Paciente_Log.obtener_paci_xid(id);

                if (pacieInfo != null)
                {
                    modificar(pacieInfo);
                }
            }
        }

        protected void btn_Save_Pac_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Aps_Noms.Text) || string.IsNullOrEmpty(txt_Edad.Text) || string.IsNullOrEmpty(txt_cedula.Text) ||
                string.IsNullOrEmpty(txt_telef.Text) || string.IsNullOrEmpty(txt_User.Text) || string.IsNullOrEmpty(txt_passw.Text) || string.IsNullOrEmpty(txt_email.Text))
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Llenar todos los Campos!!";
            }
            else if (ddl_genero.SelectedIndex == 0)
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Seleccionar un Genero";
            }
            else if (ddl_grup_sangre.SelectedIndex == 0)
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Seleccionar un Grupo Sanguineo";
            }
            else
            {
                lbl_mensaje.Visible = false;
                bool existe = Paciente_Log.autentificar_paci(txt_Aps_Noms.Text);
                {
                    if (existe)
                    {
                        Tbl_Usuario paci = new Tbl_Usuario();
                        paci = Paciente_Log.obtener_pac_xnom(txt_Aps_Noms.Text);

                        if (paci != null)
                        {
                            lbl_mensaje.Visible = true;
                            lbl_mensaje.Text = "Paciente Existente...";
                        }
                    }
                    else
                    {
                        lbl_mensaje.Visible = false;
                        guardar_modificar_datos_paci(Convert.ToInt32(Request["cod"]));
                    }
                }
            }

        }

        protected void btn_Modify_Pac_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos_paci(Convert.ToInt32(Request["cod"]));
        }
    }
}