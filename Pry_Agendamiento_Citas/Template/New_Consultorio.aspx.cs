using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Datos;
using Capa_Negocio;

using System.Data;
using System.Data.SqlClient;

namespace Pry_Agendamiento_Citas.Template
{
    public partial class New_Consultorio : System.Web.UI.Page
    {
        string conex = @"Data Source=LAPTOP-M0HDS4L2\DBSEGUNDO;Initial Catalog=CitasAgendamiento;Integrated Security=True";

        private Tbl_Consultorio consulInfo = new Tbl_Consultorio();
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

            ConsultarImagen();

            //if (!IsPostBack)
            //{
            //    if (Request["cod"] != null)
            //    {
            //        btn_Modify_Consul.Visible = true;

            //        int codg = Convert.ToInt32(Request["cod"]);
            //        consulInfo = Consultorio_Log.obtener_consul_xid(codg);

            //        if (consulInfo != null)
            //        {
            //            txt_numconsul.Text = consulInfo.cons_numero.ToString();


            //            btn_Save_Consul.Visible = false;
            //        }
            //    }
            //}
        }

        //private void guardar()
        //{
        //    try
        //    {
        //        lbl_mensaje.Text = "";
        //        consulInfo = new Tbl_Consultorio();

        //        consulInfo.cons_numero = txt_numconsul.Text; 


        //        Consultorio_Log.saveConsul(consulInfo);

        //        lbl_mensaje.Visible = true;
        //        lbl_mensaje.Text = "Los Datos han sido GUARDADOS";
        //    }
        //    catch (Exception ex)
        //    {
        //        lbl_mensaje.Visible = true;
        //        lbl_mensaje.Text = "Los Datos NO se han guardado! NewP";
        //    }
        //}

        //private void modificar(Tbl_Consultorio consulmodf)
        //{
        //    try
        //    {
        //        lbl_mensaje.Text = "";

        //        consulmodf.cons_numero = txt_numconsul.Text;


        //        Consultorio_Log.modifyConsul(consulmodf);

        //        lbl_mensaje.Visible = true;
        //        lbl_mensaje.Text = "Los Datos han sido MODIFICADO";
        //    }
        //    catch (Exception ex)
        //    {
        //        lbl_mensaje.Visible = true;
        //        lbl_mensaje.Text = "Los Datos NO se han modificado!";
        //    }
        //}

        //private void guardar_modificar_datos_consul(int id)
        //{
        //    if (id == 0)
        //    {
        //        guardar();
        //    }
        //    else
        //    {
        //        consulInfo = Consultorio_Log.obtener_consul_xid(id);

        //        if (consulInfo != null)
        //        {
        //            modificar(consulInfo);
        //        }
        //    }
        //}


        protected void btn_Save_Consul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_numconsul.Text))
            {
                lbl_mensaje.ForeColor = Color.OrangeRed;
                lbl_mensaje.Text = "Debe Llenar todos los Campos!!";
            }
            else
            {
                int Tamanio = ful_imagen.PostedFile.ContentLength;
                byte[] imagenOriginal = new byte[Tamanio];

                ful_imagen.PostedFile.InputStream.Read(imagenOriginal, 0, Tamanio);

                Bitmap ImagenOriginalBinaria = new Bitmap(ful_imagen.PostedFile.InputStream);

                //Redimencionar
                System.Drawing.Image imtThumbnail;
                int TamanioThumbnail = 200;
                imtThumbnail = RedimencionarImagen(ImagenOriginalBinaria, TamanioThumbnail);
                byte[] bImagenThumbnail = new byte[TamanioThumbnail];

                ImageConverter Convertidor = new ImageConverter();
                bImagenThumbnail = (byte[])Convertidor.ConvertTo(imtThumbnail, typeof(byte[]));

                //Insertar en la Base de Datos
                SqlConnection conexionSQL = new SqlConnection(conex);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "INSERT INTO tbl_consultorio (cons_numero, cons_imagen, cons_estado) VALUES (@titulo, @imagen,@estado)";
                cmd.Parameters.Add("@titulo", SqlDbType.Text).Value = txt_numconsul.Text;
                cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = bImagenThumbnail;
                cmd.Parameters.Add("@estado", SqlDbType.Text).Value = 'A';

                cmd.CommandType = CommandType.Text;
                cmd.Connection = conexionSQL;
                conexionSQL.Open();
                cmd.ExecuteNonQuery();


                string ImagenDataURL64 = "data:image/jpg;base64," + Convert.ToBase64String(bImagenThumbnail);

                //lbl_mensaje.Visible = true;
                //lbl_mensaje.Text = "Los Datos han sido GUARDADOS";

                ConsultarImagen();

                //lbl_mensaje.Visible = false;
                //bool existe = Consultorio_Log.autentificar_consul(txt_numconsul.Text);
                //{
                //    if (existe)
                //    {
                //        Tbl_Consultorio consul = new Tbl_Consultorio();
                //        consul = Consultorio_Log.obtener_consul_xnum(txt_numconsul.Text);

                //        if (consul != null)
                //        {
                //            lbl_mensaje.Visible = true;
                //            lbl_mensaje.Text = "Paciente Existente...";
                //        }
                //    }
                //    else
                //    {
                //        lbl_mensaje.Visible = false;
                //        guardar_modificar_datos_consul(Convert.ToInt32(Request["cod"]));
                //    }
                //}
            }
        }

        protected void btn_Modify_Consul_Click(object sender, EventArgs e)
        {
           // guardar_modificar_datos_consul(Convert.ToInt32(Request["cod"]));
        }

        public System.Drawing.Image RedimencionarImagen(System.Drawing.Image ImagenOriginal, int Alto)
        {
            var Radio = (double)Alto / ImagenOriginal.Height;
            var NuevoAncho = (int)(ImagenOriginal.Width * Radio);
            var NuevoAlto = (int)(ImagenOriginal.Height * Radio);
            var NuevaImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimencionada);
            g.DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimencionada;
        }

        protected void ConsultarImagen()
        {
            SqlConnection conexionSQL = new SqlConnection(conex);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT cons_numero, cons_imagen FROM tbl_consultorio ORDER BY cons_id ASC";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conexionSQL;
            conexionSQL.Open();

            DataTable ImagenesBD = new DataTable();
            ImagenesBD.Load(cmd.ExecuteReader());

            Repeater1.DataSource = ImagenesBD;
            Repeater1.DataBind();
            conexionSQL.Close();
        }
    }
}