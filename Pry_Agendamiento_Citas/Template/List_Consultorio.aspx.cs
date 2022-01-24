using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocio;

namespace Pry_Agendamiento_Citas
{
    public partial class List_Consultorio : System.Web.UI.Page
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
                cargarConsultorio();
            }

        }

        private void cargarConsultorio()
        {
            List<Tbl_Consultorio> listaconsul = new List<Tbl_Consultorio>();
            listaconsul = Consultorio_Log.obtener_consul();

            if (listaconsul!= null)
            {
                grv_consultorios.DataSource = listaconsul;
                grv_consultorios.DataBind();
            }
        }

        protected void grv_consultorios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int codigo = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Editar")
            {
                Response.Redirect("~/Template/New_Consultorio.aspx?cod=" + codigo, true);
            }
            else if (e.CommandName == "Eliminar")
            {
                Tbl_Usuario paciEl = new Tbl_Usuario();
                paciEl = Paciente_Log.obtener_paci_xid(codigo);

                if (paciEl != null)
                {
                    Paciente_Log.deletePacie(paciEl);
                    cargarConsultorio();
                }
            }
        }
    }
}