using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pry_Agendamiento_Citas.Template
{
    public partial class Page : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                Panel1.Visible = true;
                Panel3.Visible = true;
            }
            else if (Session["Med"] != null)
            {
                Panel2.Visible = true;
                Panel3.Visible = true;
            }
            else if (Session["Pac"] != null)
            {
                Panel3.Visible = true;
            }
            else
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void lnk_Inicio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Dashboard.aspx");
        }

        protected void lnk_New_Paciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/New_Paciente.aspx");
        }

        protected void lnk_New_Doctor_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/New_Doctor.aspx");
        }

        protected void lnk_New_Especialidad_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/New_Especialidad.aspx");
        }

        protected void lnk_agendamiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/New_Agendamiento.aspx");
        }

        protected void lnk_Agendamiento_Doc_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/New_Agendamiento.aspx");
        }

        protected void btn_Cerrar_Session_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/login.aspx");
        }

        protected void lnk_consultorio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/New_Consultorio.aspx");
        }

        protected void lnk_List_Paciente_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/List_Paciente.aspx");

        }

        protected void lnk_List_Doctor_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/List_Doctor.aspx");
        }

        protected void lnk_List_Especialidad_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/List_Especialidad.aspx");
        }

        protected void lnk_List_Consultorio_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/List_Consultorio.aspx");
        }

        protected void lnk_List_Agendamiento_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/List_Agendamiento.aspx");
        }

        protected void lnk_Usuarios_Adm_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/List_Administrador.aspx");

        }

        protected void lnk_inicio_docs_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Template/Dashboard.aspx");
        }
    }
}