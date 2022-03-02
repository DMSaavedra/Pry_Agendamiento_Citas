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
    public partial class HistorialMed : System.Web.UI.Page
    {
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

            if (!IsPostBack)
            {
                cargarCitas();
            }
        }

        private void cargarCitas()
        {
            List<Tbl_Cita_Agendada> listacitas = new List<Tbl_Cita_Agendada>();
            listacitas = Agendamiento_Log.obtener_agendamiento();

            if (listacitas != null)
            {
                grv_cits_agends.DataSource = listacitas;
                grv_cits_agends.DataBind();
            }
        }

        protected void img_lupa_Click(object sender, ImageClickEventArgs e)
        {
            List<Tbl_Cita_Agendada> lis = new List<Tbl_Cita_Agendada>();
            Tbl_Cita_Agendada cit1 = new Tbl_Cita_Agendada();

            string op = ddl_criterio.SelectedValue;

            if (op != "0")
            {
                switch (op)
                {
                    case "N":
                        cit1 = Agendamiento_Log.obtener_agendamiento_xnom(txt_buscar.Text);
                        if (cit1 != null)
                        {
                            lis.Add(cit1);
                            grv_cits_agends.DataSource = lis;
                            grv_cits_agends.DataBind();
                        }
                        else
                        {
                            cargarCitas();
                        }
                        break;
                    case "M":
                        cit1 = Agendamiento_Log.obtener_agendamiento_xmed(txt_buscar.Text);
                        if (cit1 != null)
                        {
                            lis.Add(cit1);
                            grv_cits_agends.DataSource = lis;
                            grv_cits_agends.DataBind();
                        }
                        else
                        {
                            cargarCitas();
                        }
                        break;
                    case "E":
                        cit1 = Agendamiento_Log.obtener_agendamiento_xespec(txt_buscar.Text);
                        if (cit1 != null)
                        {
                            lis.Add(cit1);
                            grv_cits_agends.DataSource = lis;
                            grv_cits_agends.DataBind();
                        }
                        else
                        {
                            cargarCitas();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        protected void img_limpiar_Click(object sender, ImageClickEventArgs e)
        {
            txt_buscar.Text = "";
            cargarCitas();
        }
    }
}