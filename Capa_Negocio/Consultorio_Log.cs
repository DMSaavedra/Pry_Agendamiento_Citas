using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Consultorio_Log
    {
        private static DataClasses1DataContext dc = new DataClasses1DataContext();
        public static Tbl_Consultorio obtener_consul_xid(int id)
        {
            var consulId = dc.Tbl_Consultorio.FirstOrDefault(con => con.cons_id.Equals(id) && con.cons_estado == 'A');
            return consulId;
        }

        public static void saveConsul(Tbl_Consultorio consultorio)
        {
            try
            {
                consultorio.cons_estado = 'A';
                

                dc.Tbl_Consultorio.InsertOnSubmit(consultorio);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados <br/>" + ex.Message);
            }
        }

        public static void modifyConsul(Tbl_Consultorio consultorio)
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

        public static bool autentificar_consul(string numero)
        {
            var auto = dc.Tbl_Consultorio.Any(consu => consu.cons_numero.Equals(numero));
            return auto;
        }

        public static Tbl_Consultorio obtener_consul_xnum(string numero)
        {
            var consulId = dc.Tbl_Consultorio.FirstOrDefault(consul => consul.cons_numero.Equals(numero) && consul.cons_estado == 'A');
            return consulId;
        }

        public static List<Tbl_Consultorio> obtener_consul()
        {
            var lista = dc.Tbl_Consultorio.Where(consu => consu.cons_estado == 'A');
            return lista.ToList();
        }


    }
}
