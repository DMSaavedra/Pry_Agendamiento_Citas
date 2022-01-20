using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pry_Agendamiento_Citas.Template
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");
        }

        protected void lnk_Agendamiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("Agendar.aspx");
        }

        protected void lnk_New_Paciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("Pacientes.aspx");
        }

        protected void lnk_Inicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("Inicio.aspx");
        }

        protected void lnk_New_Doctor_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewDoctor.aspx");
        }

        protected void lnk_New_Especialidad_Click(object sender, EventArgs e)
        {
            Response.Redirect("NewEspecialidad.aspx");
        }

        protected void lnk_cardiologia_Click(object sender, EventArgs e)
        {

        }
    }
}