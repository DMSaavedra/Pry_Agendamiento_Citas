using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Paciente_Log
    {
        //Instancia de DataContex
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        //Pacientes
        public static List<Tbl_Usuario> obtener_usu_paciente()
        {
            var lista = dc.Tbl_Usuario.Where(usu => usu.usu_estado == 'A' & usu.tusu_id == 3);
            return lista.ToList();
        }

        public static Tbl_Usuario obtener_paci_xid(int id)
        {
            var pacId = dc.Tbl_Usuario.FirstOrDefault(pac => pac.usu_id.Equals(id) && pac.usu_estado == 'A');
            return pacId;
        }

        public static bool autentificar_paci(string nombre)
        {
            var auto = dc.Tbl_Usuario.Any(pac => pac.usu_apellido_nombre.Equals(nombre));
            return auto;
        }

        public static Tbl_Usuario obtener_pac_xnom(string nombre)
        {
            var pacId = dc.Tbl_Usuario.FirstOrDefault(pac => pac.usu_apellido_nombre.Equals(nombre) && pac.usu_estado == 'A');
            return pacId;
        }

        //Guardar
        public static void savePacie(Tbl_Usuario usuario)
        {
            try
            {
                usuario.usu_estado = 'A';
                usuario.tusu_id = 3;

                dc.Tbl_Usuario.InsertOnSubmit(usuario);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados <br/>" + ex.Message);
            }
        }

        //Modificar
        public static void modifyPacie(Tbl_Usuario usuario)
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
        public static void deletePacie(Tbl_Usuario usuario)
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
