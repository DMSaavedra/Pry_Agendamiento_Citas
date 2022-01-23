using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    class Agendamiento_Log
    {
        //Instancia de DataContex
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        public static List<Tbl_Cita_Agendada> obtener_cagn_paciente()
        {
            var lista = dc.Tbl_Cita_Agendada.Where(agen => agen.cagn_estado == 'A');
            return lista.ToList();
        }
    }
}
