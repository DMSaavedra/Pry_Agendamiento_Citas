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
    public partial class New_Especialidad : System.Web.UI.Page
    {
        private Tbl_Especialidad espeInfo = new Tbl_Especialidad();
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
                    espeInfo = Especialidad_Log.obtener_espe_xid(codg);

                    if (espeInfo != null)
                    {
                        txt_especialidad.Text = espeInfo.espc_nombre.ToString();
                        txt_despecialidad.Text = espeInfo.espc_descripcion.ToString();

                        ddl_edad.SelectedValue = espeInfo.espc_edad_dirg.ToString();
                        ddl_consultorio.SelectedValue = espeInfo.cons_id.ToString();

                        btn_Save_Pac.Visible = false;
                    }
                }
                cargarConsultorios();
            }
        }

        private void cargarConsultorios()
        {
            List<Tbl_Consultorio> listconsu = new List<Tbl_Consultorio>();
            listconsu = Capa_Negocio.Consultorio_Log.obtener_consul();

            listconsu.Insert(0, new Tbl_Consultorio() { cons_numero = "Seleccione" });

            ddl_consultorio.DataSource = listconsu;
            ddl_consultorio.DataTextField = "cons_numero";
            ddl_consultorio.DataValueField = "cons_id";
            ddl_consultorio.DataBind();
        }

        private void guardar()
        {
            try
            {
                lbl_mensaje.Text = "";
                espeInfo = new Tbl_Especialidad();

                espeInfo.espc_nombre = txt_especialidad.Text;  
                espeInfo.espc_descripcion = txt_despecialidad.Text;


                espeInfo.espc_edad_dirg = Convert.ToInt32(ddl_edad.SelectedValue);
                espeInfo.cons_id = Convert.ToInt32(ddl_consultorio.SelectedValue);


                Especialidad_Log.saveEspe(espeInfo);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido GUARDADOS";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han guardado!";
            }
        }
        private void modificar(Tbl_Especialidad espemodf)
        {
            try
            {
                lbl_mensaje.Text = "";

                espemodf.espc_nombre = txt_especialidad.Text;
                espemodf.espc_descripcion = txt_despecialidad.Text;
                espemodf.espc_edad_dirg = Convert.ToInt32(ddl_edad.SelectedValue);
                espemodf.cons_id = Convert.ToInt32(ddl_consultorio.SelectedValue);


                Especialidad_Log.modifyEspe(espemodf);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido MODIFICADO";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han modificado!";
            }
        }

        private void guardar_modificar_datos_espe(int id)
        {
            if (id == 0)
            {
                guardar();
            }
            else
            {
                espeInfo = Especialidad_Log.obtener_espe_xid(id);

                if (espeInfo != null)
                {
                    modificar(espeInfo);
                }
            }
        }
        protected void btn_Save_Pac_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_especialidad.Text) || string.IsNullOrEmpty(txt_despecialidad.Text))
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Llenar todos los Campos!!";
            }
            else if (ddl_edad.SelectedIndex == 0)
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Seleccionar un Rango de Edad";
            }
            else if (ddl_consultorio.SelectedIndex == 0)
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Seleccionar un Numero de Consultorio";
            }
            else
            {

                lbl_mensaje.Visible = false;
                bool existe = Especialidad_Log.autentificar_espe(txt_especialidad.Text);
                {
                    if (existe)
                    {
                        Tbl_Especialidad espe = new Tbl_Especialidad();
                        espe = Especialidad_Log.obtener_espe_xnom(txt_especialidad.Text);

                        if (espe != null)
                        {
                            lbl_mensaje.Visible = true;
                            lbl_mensaje.Text = "Especialidad Existente...";
                        }
                    }
                    else
                    {
                        lbl_mensaje.Visible = false;
                        guardar_modificar_datos_espe(Convert.ToInt32(Request["cod"]));
                    }
                }
            }
        }

        protected void btn_Modify_Pac_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos_espe(Convert.ToInt32(Request["cod"]));
        }
    }
}