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
    public partial class List_Paciente : System.Web.UI.Page
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
                cargarPacientes();
            }
        }

        private void cargarPacientes()
        {
            List<Tbl_Usuario> listapac = new List<Tbl_Usuario>();
            listapac = Usuario_Log.obtener_usu_paciente();

            if (listapac != null)
            {
                grv_paciente.DataSource = listapac;
                grv_paciente.DataBind();
            }
        }

        protected void grv_paciente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Template/New_Paciente.aspx?cod=" + codigo, true);
            }
            else if (e.CommandName == "Eliminar")
            {
                Tbl_Usuario paciEl = new Tbl_Usuario();
                paciEl = Paciente_Log.obtener_paci_xid(codigo);

                if (paciEl != null)
                {
                    Paciente_Log.deletePacie(paciEl);
                    cargarPacientes();
                }
            }
        }
    }
}