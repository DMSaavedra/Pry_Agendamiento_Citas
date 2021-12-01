using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pry_Agendamiento_Citas
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnk_Registro_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registrar.aspx");
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/Doctores.aspx");
        }
    }
}