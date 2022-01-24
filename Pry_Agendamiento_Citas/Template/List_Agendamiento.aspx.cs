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
    public partial class List_Agendamiento : System.Web.UI.Page
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
            listapac = Agendamiento_Log.obtener_agendamiento();

            if (listapac != null)
            {
                grv_agendamiento.DataSource = listapac;
                grv_agendamiento.DataBind();
            }
        }

        protected void grv_agendamiento_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Template/New_Agendamiento.aspx?cod=" + codigo, true);
            }
            else if (e.CommandName == "Eliminar")
            {
                Tbl_Cita_Agendada paciEl = new Tbl_Cita_Agendada();
                paciEl = Agendamiento_Log.obtener_agen_xid(codigo);

                if (paciEl != null)
                {
                    Agendamiento_Log.deleteagen(paciEl);
                    cargarAgendamiento();
                }
            }
        }
    }
}