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
    public partial class Dashboard : System.Web.UI.Page
    {
        private static DateTime fchAct = DateTime.Now;

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
                cargarCitasFchAct();
            }
        }

        private void cargarCitasFchAct()
        {
            List<Tbl_Cita_Agendada> listapac = new List<Tbl_Cita_Agendada>();
            listapac = Agendamiento_Log.obtener_citasXfecha(fchAct);

            if (listapac != null)
            {
                grv_citas_fchAct.DataSource = listapac;
                grv_citas_fchAct.DataBind();
            }
        }
    }
}