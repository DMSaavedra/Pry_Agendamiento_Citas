using System;
using System.Collections.Generic;
using System.Drawing;
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
        private Tbl_Cita_Agendada citaInfo = new Tbl_Cita_Agendada();
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
                if (Request["cod"] != null)
                {
                    btn_Modify_Agen.Visible = true;

                    int codg = Convert.ToInt32(Request["cod"]);
                    citaInfo = Agendamiento_Log.obtener_agen_xid(codg);

                    if (citaInfo != null)
                    {
                        ddl_pacientes.SelectedValue = citaInfo.cagn_paciente.ToString();
                        ddl_nom_doc.SelectedValue = citaInfo.cagn_doctor.ToString();
                        txt_fechaRT.Text = citaInfo.cagn_fechaAgen.ToString();
                        //txt_nombre.Text = citaInfo.cagn_paciente.ToString();

                        ddl_Especialidad.SelectedValue = citaInfo.espc_id.ToString();

                        btn_Save_Agen.Visible = false;
                    }
                }
                cargarPacientes();
                cargarDoctores();
                cargarEspecialidades();
            }
        }

        private void cargarDoctores()
        {
            List<Tbl_Usuario> listapac = new List<Tbl_Usuario>();
            listapac = Capa_Negocio.Usuario_Log.obtener_usu_medicos();

            listapac.Insert(0, new Tbl_Usuario() { usu_apellido_nombre = "Seleccione" });

            ddl_nom_doc.DataSource = listapac;
            ddl_nom_doc.DataTextField = "usu_apellido_nombre";
            ddl_nom_doc.DataValueField = "usu_apellido_nombre";
            ddl_nom_doc.DataBind();
        }

        private void cargarEspecialidades()
        {
            List<Tbl_Especialidad> listespc = new List<Tbl_Especialidad>();
            listespc = Capa_Negocio.Doctor_Log.obtener_especialidad();

            listespc.Insert(0, new Tbl_Especialidad() { espc_nombre = "Seleccione" });

            ddl_Especialidad.DataSource = listespc;
            ddl_Especialidad.DataTextField = "espc_nombre";
            ddl_Especialidad.DataValueField = "espc_id";
            ddl_Especialidad.DataBind();
        }

        private void cargarPacientes()
        {
            List<Tbl_Usuario> listapac = new List<Tbl_Usuario>();
            listapac = Capa_Negocio.Usuario_Log.obtener_usu_paciente();

            listapac.Insert(0, new Tbl_Usuario() { usu_apellido_nombre = "Seleccione" });

            ddl_pacientes.DataSource = listapac;
            ddl_pacientes.DataTextField = "usu_apellido_nombre";
            ddl_pacientes.DataValueField = "usu_apellido_nombre";
            ddl_pacientes.DataBind();
        }

        private void guardar()
        {
            try
            {
                lbl_mensaje.Text = "";
                citaInfo = new Tbl_Cita_Agendada();

                citaInfo.cagn_paciente = ddl_pacientes.SelectedValue;
                citaInfo.cagn_doctor = (ddl_nom_doc.SelectedValue);
                citaInfo.cagn_fechaAgen = Convert.ToDateTime(txt_fechaRT.Text);
                citaInfo.cagn_horaAgen = txt_horaRT.Text;
                citaInfo.espc_id = Convert.ToInt32(ddl_Especialidad.SelectedValue);

                Agendamiento_Log.saveAgen(citaInfo);

                //Envio Correo
                enviarCita();

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido GUARDADOS";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han guardado! NewP";
            }
        }

        private void enviarCita()
        {
            Tbl_Usuario usu = new Tbl_Usuario();
            usu = Usuario_Log.obtener_usu_xnom(ddl_pacientes.SelectedValue);

            Tbl_Consultorio consul = new Tbl_Consultorio();
            consul = Usuario_Log.obtener_cons_xid(ddl_Especialidad.SelectedValue);


            string from = "asistenciatecnica067@gmail.com";
            string pass = "ansii12345@@";
            string to = "saavedratony752@gmail.com"; //usu.usu_correo;
            string sms = "DATOS DE CITA AGENDADA \n Apellido y Nombre: " + usu.usu_apellido_nombre +
                         "\n Identificacion: " + usu.usu_cedula +
                         "\n Edad: " + usu.usu_edad +
                         "\n Genero: " + usu.usu_genero +
                         "\n Se ha Agendado una cita para el Dia: " + txt_fechaRT.Text + " y hora: " + txt_horaRT.Text +
                         "\n Con El/La Doctor: " + ddl_nom_doc.SelectedValue + ".\n En el Consultorio Número: " + consul.cons_numero +
                         "\n En la Especialidad: " + ddl_Especialidad.SelectedValue +
                         "\n\n\n Se Recomienda estar 10 minutos antes para la Validacion de Turno y toma de Signos Vitales. \n Gracias";

            if (new EmailCitaAgn().enviarcorreo(from, pass, to, sms))
            {
                lbl_mensajeDos.ForeColor = Color.Green;
                lbl_mensajeDos.Text = "Correo Enviado con EXITO";
            }
            else
            {
                lbl_mensajeDos.ForeColor = Color.Red;
                lbl_mensajeDos.Text = "NO ENVIADO!!!";
            }
        }

        private void modificar(Tbl_Cita_Agendada agenmodf)
        {
            try
            {
                lbl_mensaje.Text = "";

                agenmodf.cagn_paciente = ddl_pacientes.SelectedValue;
                agenmodf.cagn_doctor = ddl_nom_doc.SelectedValue;
                agenmodf.cagn_fechaAgen = Convert.ToDateTime(txt_fechaRT.Text);
                agenmodf.cagn_horaAgen = txt_horaRT.Text;
                agenmodf.espc_id = Convert.ToInt32(ddl_Especialidad.SelectedValue);

                Agendamiento_Log.modifyAgen(agenmodf);

                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos han sido MODIFICADO";
            }
            catch (Exception ex)
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Los Datos NO se han modificado!";
            }

        }
        private void guardar_modificar_datos_agen(int id)
        {
            if (id == 0)
            {
                guardar();
            }
            else
            {
                citaInfo = Agendamiento_Log.obtener_agen_xid(id);

                if (citaInfo != null)
                {
                    modificar(citaInfo);
                }
            }
        }


        protected void btn_Save_Agen_Click(object sender, EventArgs e)
        {
            if (ddl_pacientes.SelectedIndex == 0)
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Seleccionar un Paciente";
            }
            else if (ddl_nom_doc.SelectedIndex == 0)
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Seleccionar un Doctor";
            }
            else if (ddl_Especialidad.SelectedIndex == 0)
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Seleccionar una Especialidad";
            }
            else if (txt_horaRT.Text == "" || txt_horaRT.Text == " ")
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Seleccionar una Hora";
            }
            //else if (txt_horaRT.Text <= "07:00")
            //{
            //    lbl_mensaje.ForeColor = Color.OrangeRed;
            //    lbl_mensaje.Text = "Debe Seleccionar una Hora entre las 08:00 y las 17:00";
            //}
            else
            {
                lbl_mensaje.Visible = false;
                bool existe = Agendamiento_Log.autentificar_agen(ddl_pacientes.SelectedValue);
                {
                    if (existe)
                    {
                        Tbl_Cita_Agendada paci = new Tbl_Cita_Agendada();
                        paci = Agendamiento_Log.obtener_agen_xfechahora(txt_fechaRT.Text, txt_horaRT.Text);
                        //paci = Agendamiento_Log.obtener_agen_xnom(ddl_pacientes.SelectedValue);

                        if (paci != null)
                        {
                            lbl_mensaje.Visible = true;
                            lbl_mensaje.ForeColor = Color.Red;
                            lbl_mensaje.Text = "Agendamiento Existente...";
                        }
                    }
                    else
                    {
                        lbl_mensaje.Visible = false;
                        guardar_modificar_datos_agen(Convert.ToInt32(Request["cod"]));
                    }

                    //lbl_mensaje.Visible = false;
                    //guardar_modificar_datos_agen(Convert.ToInt32(Request["cod"]));
                }
            }
        }

        protected void btn_Modify_Agen_Click(object sender, EventArgs e)
        {
            guardar_modificar_datos_agen(Convert.ToInt32(Request["cod"]));
        }

        protected void btn_Limpiar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";
            lbl_mensaje.ForeColor = Color.Green;
            lbl_mensajeDos.Text = "";
        }
    }
}