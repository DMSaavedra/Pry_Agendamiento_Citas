using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Doctor_Log
    {
        //Instancia de DataContex
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        //Pacientes
        public static List<Tbl_Usuario> obtener_usu_medicos()
        {
            var lista = dc.Tbl_Usuario.Where(usu => usu.usu_estado == 'A' & usu.tusu_id == 2);
            return lista.ToList();
        }

        //Obtener Especialidades 
        public static List<Tbl_Especialidad> obtener_especialidad()
        {
            var lista = dc.Tbl_Especialidad.Where(espc => espc.espc_estado == 'A');
            return lista.ToList();
        }

        public static Tbl_Usuario obtener_med_xid(int id)
        {
            var pacId = dc.Tbl_Usuario.FirstOrDefault(pac => pac.usu_id.Equals(id) && pac.usu_estado == 'A');
            return pacId;
        }

        public static bool autentificar_medi(string nombre)
        {
            var auto = dc.Tbl_Usuario.Any(pac => pac.usu_apellido_nombre.Equals(nombre));
            return auto;
        }

        public static Tbl_Usuario obtener_medi_xnom(string nombre)
        {
            var pacId = dc.Tbl_Usuario.FirstOrDefault(pac => pac.usu_apellido_nombre.Equals(nombre) && pac.usu_estado == 'A');
            return pacId;
        }

        //Guardar
        public static void saveMedi(Tbl_Usuario usuario)
        {
            try
            {
                usuario.usu_estado = 'A';
                usuario.tusu_id = 2;

                dc.Tbl_Usuario.InsertOnSubmit(usuario);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados <br/>" + ex.Message);
            }
        }

        //Modificar
        public static void modifyMedi(Tbl_Usuario usuario)
        {
            try
            {
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Los Datos no han sido guardados. <br>" + ex.Message);
            }
        }

        //Eliminar
        public static void deleteMedi(Tbl_Usuario usuario)
        {
            try
            {
                //Borrado Logico
                usuario.usu_estado = 'I';
                dc.SubmitChanges();


                //Borrado Fisico
                //dc.Tbl_Usuario.DeleteOnSubmit(usuario);
                //dc.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw new ArgumentException("Los Datos no han sido eliminados. <br>" + ex.Message);
            }
        }
    }
}
