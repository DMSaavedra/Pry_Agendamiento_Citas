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
    public partial class New_Doctor : System.Web.UI.Page
    {
        private Tbl_Usuario medicInfo = new Tbl_Usuario();

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
                    btn_Modify_Med.Visible = true;

                    int codf = Convert.ToInt32(Request["cod"]);
                    medicInfo = Doctor_Log.obtener_med_xid(codf);

                    if (medicInfo != null)
                    {
                        txt_Aps_Noms.Text = medicInfo.usu_apellido_nombre.ToString();
                        txt_Edad.Text = medicInfo.usu_edad.ToString();
                        txt_cedula.Text = medicInfo.usu_cedula.ToString();
                        txt_telef.Text = medicInfo.usu_telefono.ToString();
                        txt_User.Text = medicInfo.usu_nomLogin.ToString();
                        txt_passw.Text = medicInfo.usu_contrasenia.ToString();

                        ddl_genero.SelectedValue = medicInfo.usu_genero.ToString();
                        ddl_grup_sangre.SelectedValue = medicInfo.usu_grupo_sanguineo.ToString();
                        txt_email.Text = medicInfo.usu_correo.ToString();
                        ddl_especialidad.SelectedValue = medicInfo.espc_id.ToString();

                        btn_Save_Med.Visible = false;
                    }
                }

                cargarEspecialidades();
            }
        }

        private void cargarEspecialidades()
        {
            List<Tbl_Especialidad> listespc = new List<Tbl_Especialidad>();
            listespc = Capa_Negocio.Doctor_Log.obtener_especialidad();

            listespc.Insert(0, new Tbl_Especialidad() { espc_nombre = "Seleccione" });

            ddl_especialidad.DataSource = listespc;
            ddl_especialidad.DataTextField = "espc_nombre";
            ddl_especialidad.DataValueField = "espc_id";
            ddl_especialidad.DataBind();
        }

        private void guardar()
        {
            try
            {
                lbl_mensaje.Text = "";

                medicInfo = new Tbl_Usuario();

                medicInfo.usu_apellido_nombre = txt_Aps_Noms.Text;  
                medicInfo.usu_edad = Convert.ToInt32(txt_Edad.Text);
                medicInfo.usu_cedula = txt_cedula.Text;
                medicInfo.usu_telefono = txt_telef.Text;
                medicInfo.usu_nomLogin = txt_User.Text;
                medicInfo.usu_contrasenia = txt_passw.Text;
                medicInfo.usu_grupo_sanguineo = Convert.ToInt32(ddl_grup_sangre.SelectedValue);
                medicInfo.usu_genero = ddl_genero.SelectedValue;
                medicInfo.usu_correo = txt_email.Text;
                medicInfo.espc_id = Convert.ToInt32(ddl_especialidad.SelectedValue);

                Doctor_Log.saveMedi(medicInfo);


                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido GUARDADOS";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han guardado! NewD";
            }
        }

        private void modificar(Tbl_Usuario medimodf)
        {
            try
            {
                lbl_mensaje.Text = "";

                medimodf.usu_apellido_nombre = txt_Aps_Noms.Text;
                medimodf.usu_edad = Convert.ToInt32(txt_Edad.Text);
                medimodf.usu_cedula = txt_cedula.Text;
                medimodf.usu_telefono = txt_telef.Text;
                medimodf.usu_nomLogin = txt_User.Text;
                medimodf.usu_contrasenia = txt_passw.Text;
                medimodf.usu_grupo_sanguineo = Convert.ToInt32(ddl_grup_sangre.SelectedValue);
                medimodf.usu_genero = ddl_genero.SelectedValue;
                medimodf.usu_correo = txt_email.Text;
                medimodf.espc_id = Convert.ToInt32(ddl_especialidad.SelectedValue);

                Doctor_Log.modifyMedi(medimodf);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido MODIFICADO";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han modificado!";
            }
        }

        private void guardar_modificar_datos_med(int id)
        {
            if (id == 0)
            {
                guardar();
            }
            else
            {
                medicInfo = Doctor_Log.obtener_med_xid(id);

                if (medicInfo != null)
                {
                    modificar(medicInfo);
                }
            }
        }

        protected void btn_Save_Med_Click(object sender, EventArgs e)
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
            else if (ddl_especialidad.SelectedIndex == 0)
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Seleccionar una Especialidad";
            }
            else
            {

                lbl_mensaje.Visible = false;
                bool existe = Doctor_Log.autentificar_medi(txt_Aps_Noms.Text);
                {
                    if (existe)
                    {
                        Tbl_Usuario medi = new Tbl_Usuario();
                        medi = Doctor_Log.obtener_medi_xnom(txt_Aps_Noms.Text);

                        if (medi != null)
                        {
                            lbl_mensaje.Visible = true;
                            lbl_mensaje.Text = "Doctor Existente...";
                        }
                    }
                    else
                    {
                        lbl_mensaje.Visible = false;
                        guardar_modificar_datos_med(Convert.ToInt32(Request["cod"]));
                    }
                }
            }
        }

        protected void btn_Modify_Med_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos_med(Convert.ToInt32(Request["cod"]));
        }
    }
}