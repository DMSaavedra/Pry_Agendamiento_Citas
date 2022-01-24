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
    public partial class New_Consultorio : System.Web.UI.Page
    {
        private Tbl_Consultorio consulInfo = new Tbl_Consultorio();
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
                    btn_Modify_Consul.Visible = true;

                    int codg = Convert.ToInt32(Request["cod"]);
                    consulInfo = Consultorio_Log.obtener_consul_xid(codg);

                    if (consulInfo != null)
                    {
                        txt_numconsul.Text = consulInfo.cons_numero.ToString();


                        btn_Save_Consul.Visible = false;
                    }
                }
            }
        }

        private void guardar()
        {
            try
            {
                lbl_mensaje.Text = "";
                consulInfo = new Tbl_Consultorio();

                consulInfo.cons_numero = txt_numconsul.Text;  //No se esta Guardando


                Consultorio_Log.saveConsul(consulInfo);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido GUARDADOS";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han guardado! NewP";
            }
        }

        private void modificar(Tbl_Consultorio consulmodf)
        {
            try
            {
                lbl_mensaje.Text = "";

                consulmodf.cons_numero = txt_numconsul.Text;


                Consultorio_Log.modifyConsul(consulmodf);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido MODIFICADO";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han modificado!";
            }
        }
        private void guardar_modificar_datos_consul(int id)
        {
            if (id == 0)
            {
                guardar();
            }
            else
            {
                consulInfo = Consultorio_Log.obtener_consul_xid(id);

                if (consulInfo != null)
                {
                    modificar(consulInfo);
                }
            }
        }


        protected void btn_Save_Consul_Click(object sender, EventArgs e)
        {

            lbl_mensaje.Visible = false;
            bool existe = Consultorio_Log.autentificar_consul(txt_numconsul.Text);
            {
                if (existe)
                {
                    Tbl_Consultorio consul = new Tbl_Consultorio();
                    consul = Consultorio_Log.obtener_consul_xnum(txt_numconsul.Text);

                    if (consul != null)
                    {
                        lbl_mensaje.Visible = true;
                        lbl_mensaje.Text = "Paciente Existente...";
                    }
                }
                else
                {
                    lbl_mensaje.Visible = false;
                    guardar_modificar_datos_consul(Convert.ToInt32(Request["cod"]));
                }
            }
        }

        protected void btn_Modify_Consul_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos_consul(Convert.ToInt32(Request["cod"]));
        }
    }
}