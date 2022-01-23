using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
     public class Especialidad_Log
    {

        //Instancia de DataContex
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        //Especialidad
        public static Tbl_Especialidad obtener_espe_xid(int id)
        {
            var espeId = dc.Tbl_Especialidad.FirstOrDefault(espe => espe.espc_id.Equals(id) && espe.espc_estado == 'A');
            return espeId;
        }
        public static void saveEspe(Tbl_Especialidad especialidad)
        {
            try
            {
                especialidad.espc_estado = 'A';
               

                dc.Tbl_Especialidad.InsertOnSubmit(especialidad);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados <br/>" + ex.Message);
            }
        }
        public static void modifyEspe(Tbl_Especialidad especialidad)
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
        public static bool autentificar_espe(string nombre)
        {
            var auto = dc.Tbl_Especialidad.Any(espe => espe.espc_nombre.Equals(nombre));
            return auto;
        }

        public static Tbl_Especialidad obtener_espe_xnom(string nombre)
        {
            var espeId = dc. Tbl_Especialidad.FirstOrDefault(espe => espe.espc_nombre.Equals(nombre) && espe.espc_estado == 'A');
            return espeId;
        }

        public static List<Tbl_Especialidad> obtener_espe()
        {
            var lista = dc.Tbl_Especialidad.Where(espe => espe.espc_estado == 'A');
            return lista.ToList();
        }

        //Eliminar
        public static void deleteEspe(Tbl_Especialidad especialidad)
        {
            try
            {
                //Borrado Logico
                especialidad.espc_estado = 'I';
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
