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
    public partial class List_Doctor : System.Web.UI.Page
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
                cargarDoctores();
            }
        }

        private void cargarDoctores()
        {
            List<Tbl_Usuario> listadoc = new List<Tbl_Usuario>();
            listadoc = Usuario_Log.obtener_usu_medicos();

            if (listadoc != null)
            {
                grv_doctores.DataSource = listadoc;
                grv_doctores.DataBind();
            }
        }
    }
}