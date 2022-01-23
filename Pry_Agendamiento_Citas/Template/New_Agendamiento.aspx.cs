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
                cargarAgendamiento();
            }
        }
        private void cargarAgendamiento()
        {
            List<Tbl_Cita_Agendada> listapac = new List<Tbl_Cita_Agendada>();
            listapac = Usuario_Log.obtener_usu_paciente();

            if (listapac != null)
            {
                grv_paciente.DataSource = listapac;
                grv_paciente.DataBind();
            }
        }
    }
}