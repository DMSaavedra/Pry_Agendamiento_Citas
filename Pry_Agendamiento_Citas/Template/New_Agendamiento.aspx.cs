using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocio;

namespace Pry_Agendamiento_Citas.Template
{
    public partial class New_Agendamiento : System.Web.UI.Page
    {
        private Tbl_Cita_Agendada citaInfo = new Tbl_Cita_Agendada();
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
                    btn_Modify_Agen.Visible = true;

                    int codg = Convert.ToInt32(Request["cod"]);
                    citaInfo = Agendamiento_Log.obtener_agen_xid(codg);

                    if (citaInfo != null)
                    {
                        txt_nombre.Text = citaInfo.cagn_nombre.ToString();




                        ddl_Especialidad.SelectedValue = citaInfo.espc_id.ToString();
                        ddl_nom_doc.SelectedValue = citaInfo.cagn_doctor.ToString();

                        btn_Save_Agen.Visible = false;
                    }
                }
            }
        }

        private void guardar()
        {
            try
            {
                lbl_mensaje.Text = "";
                citaInfo = new Tbl_Cita_Agendada();

                citaInfo.cagn_nombre = txt_nombre.Text;  //No se esta Guardando

                citaInfo.espc_id = Convert.ToInt32(ddl_Especialidad.SelectedValue);
                citaInfo.cagn_doctor = (ddl_Especialidad.SelectedValue);

                Agendamiento_Log.saveAgen(citaInfo);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido GUARDADOS";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han guardado! NewP";
            }
        }

        private void modificar(Tbl_Cita_Agendada agenmodf)
        {
            try
            {
                lbl_mensaje.Text = "";

                agenmodf.cagn_nombre = txt_nombre.Text;
                agenmodf.espc_id = Convert.ToInt32(ddl_Especialidad.SelectedValue);

                agenmodf.cagn_doctor = (ddl_Especialidad.SelectedValue);

                Agendamiento_Log.modifyAgen(agenmodf);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido MODIFICADO";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han modificado!";
            }

        }
        private void guardar_modificar_datos_agen(int id)
        {
            if (id == 0)
            {
                guardar();
            }
            else
            {
                citaInfo = Agendamiento_Log.obtener_agen_xid(id);

                if (citaInfo != null)
                {
                    modificar(citaInfo);
                }
            }
        }


        protected void btn_Save_Agen_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Visible = false;
            bool existe = Agendamiento_Log.autentificar_agen(txt_nombre.Text);
            {
                if (existe)
                {
                    Tbl_Cita_Agendada paci = new Tbl_Cita_Agendada();
                    paci = Agendamiento_Log.obtener_agen_xnom(txt_nombre.Text);

                    if (paci != null)
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "Agendamiento Existente...";
                    }
                }
                else
                {
                    lbl_mensaje.Visible = false;
                    guardar_modificar_datos_agen(Convert.ToInt32(Request["cod"]));
                }
            }
        }

        protected void btn_Modify_Agen_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos_agen(Convert.ToInt32(Request["cod"]));
        }

        protected void btn_enviarc_Click(object sender, EventArgs e)
        {

        }
    }
}