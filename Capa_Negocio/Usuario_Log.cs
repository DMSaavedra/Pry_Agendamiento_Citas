using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Usuario_Log
    {
        //Instancia de DataContex
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        //Usuarios General
        public static List<Tbl_Usuario> obtener_usuario()
        {
            var lista = dc.Tbl_Usuario.Where(usu => usu.usu_estado == 'A');
            return lista.ToList();
        }

        //Pacientes
        public static List<Tbl_Usuario> obtener_usu_paciente()
        {
            var lista = dc.Tbl_Usuario.Where(usu => usu.usu_estado == 'A' & usu.tusu_id == 3);
            return lista.ToList();
        }

        //Medicos
        public static List<Tbl_Usuario> obtener_usu_medicos()
        {
            var lista = dc.Tbl_Usuario.Where(usu => usu.usu_estado == 'A' & usu.tusu_id == 2);
            return lista.ToList();
        }

        public static bool autentificar_usu (string nombre)
        {
            var auto = dc.Tbl_Usuario.Any(usu => usu.usu_apellido_nombre.Equals(nombre));
            return auto;
        }

        public static Tbl_Usuario obtener_usu_xnom(string nombre)
        {
            var usuid = dc.Tbl_Usuario.FirstOrDefault(usu => usu.usu_apellido_nombre.Equals(nombre) && usu.usu_estado == 'A');
            return usuid;
        }

        //Verificacion de Credenciales
        public static bool autentificar(string user, string cedula)
        {
            var auto = dc.Tbl_Usuario.Any(usu => usu.usu_estado == 'A' && usu.usu_nomLogin.Equals(user) && usu.usu_cedula.Equals(cedula));
            return auto;
        }

        //Verficacion de Existencia
        public static bool autentificarXNomLogin(string user)
        {
            var auto = dc.Tbl_Usuario.Any(usu => usu.usu_estado == 'A' & usu.usu_nomLogin.Equals(user));
            return auto;
        }

        //Obtener Informacion por las credenciales
        public static Tbl_Usuario autentificarXlogin(string user, string cedula)
        {
            var nlogin = dc.Tbl_Usuario.Single(usu => usu.usu_estado == 'A' & usu.usu_nomLogin.Equals(user) & usu.usu_cedula.Equals(cedula));
            return nlogin;
        }

        //Guardar Datos
        public static void saveInfo(Tbl_Usuario usuario)
        {
            try
            {
                usuario.usu_estado = 'A';

                dc.Tbl_Usuario.InsertOnSubmit(usuario);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados <br/>" + ex.Message);
            }
        }

        //Registro Nuevo Usuario - Administrador
        public static void saveInfoAdmin(Tbl_Usuario usuario)
        {
            try
            {
                usuario.usu_estado = 'A';
                usuario.tusu_id = 1;

                dc.Tbl_Usuario.InsertOnSubmit(usuario);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados <br/>" + ex.Message);
            }
        }
    }
}
