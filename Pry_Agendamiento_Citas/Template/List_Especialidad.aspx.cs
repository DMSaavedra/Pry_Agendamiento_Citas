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
    public partial class List_Especialidad : System.Web.UI.Page
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
                cargarEspecialidades();
            }
        }

        private void cargarEspecialidades()
        {
            List<Tbl_Especialidad> listaespe = new List<Tbl_Especialidad>();
            listaespe = Especialidad_Log.obtener_espe();

            if (listaespe != null)
            {
                grv_especialidad.DataSource = listaespe;
                grv_especialidad.DataBind();
            }
        }
       
        protected void grv_especialidad_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Template/New_Especialidad.aspx?cod=" + codigo, true);
            }
                Tbl_Especialidad espeEl = new Tbl_Especialidad();
                espeEl = Especialidad_Log.obtener_espe_xid(codigo);

                if (espeEl != null)
                {
                    Especialidad_Log.deleteEspe(espeEl);
                    cargarEspecialidades();
                }
            
        }
    }
}