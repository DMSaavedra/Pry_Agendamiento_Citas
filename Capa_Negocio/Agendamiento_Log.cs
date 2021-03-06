using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocio
{
    public class Agendamiento_Log
    {
        //Instancia de DataContex
        private static DataClasses1DataContext dc = new DataClasses1DataContext();

        public static Tbl_Cita_Agendada obtener_agen_xid(int id)
        {
            var agenId = dc.Tbl_Cita_Agendada.FirstOrDefault(agen => agen.cagn_id.Equals(id) && agen.cagn_estado == 'A');
            return agenId;
        }


        public static List<Tbl_Cita_Agendada> obtener_cagn_paciente()
        {
            var lista = dc.Tbl_Cita_Agendada.Where(agen => agen.cagn_estado == 'A');
            return lista.ToList();
        }
        public static void saveAgen(Tbl_Cita_Agendada agendamiento)
        {
            try
            {
                agendamiento.cagn_estado= 'A';

                dc.Tbl_Cita_Agendada.InsertOnSubmit(agendamiento);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Los datos no han sido guardados <br/>" + ex.Message);
            }
        }

        public static void modifyAgen(Tbl_Cita_Agendada agendamiento)
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

        public static void deleteAgenda(Tbl_Cita_Agendada agendamiento)
        {
            try
            {
                //Borrado Logico
                agendamiento.cagn_estado = 'I';
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

        public static bool autentificar_agen(string nombre)
        {
            var auto = dc.Tbl_Cita_Agendada.Any(agen => agen.cagn_paciente.Equals(nombre));
            return auto;
        }

        public static Tbl_Cita_Agendada obtener_agen_xnom(string nombre)
        {
            var agenId = dc.Tbl_Cita_Agendada.FirstOrDefault(agen => agen.cagn_id.Equals(nombre) && agen.cagn_estado == 'A');
            return agenId;
        }

        public static Tbl_Cita_Agendada obtener_agen_xfechahora(string fecha, string hora)
        {
            var agenId = dc.Tbl_Cita_Agendada.FirstOrDefault(agen => agen.cagn_fechaAgen.Equals(fecha) && agen.cagn_horaAgen.Equals(hora) && agen.cagn_estado == 'A');
            return agenId;
        }
        public static List<Tbl_Cita_Agendada> obtener_agendamiento()
        {
            var lista = dc.Tbl_Cita_Agendada.Where(age => age.cagn_estado == 'A' );
            return lista.ToList();
        }

        //Citas por Paciente
        public static Tbl_Cita_Agendada obtener_agendamiento_xnom(string nombre)
        {
            var citxnom = dc.Tbl_Cita_Agendada.FirstOrDefault(age => age.cagn_paciente.Equals(nombre) && age.cagn_estado == 'A');
            return citxnom;
        }

        //Citas por Medico
        public static Tbl_Cita_Agendada obtener_agendamiento_xmed(string medc)
        {
            var citxnom = dc.Tbl_Cita_Agendada.FirstOrDefault(age => age.cagn_doctor.Equals(medc) && age.cagn_estado == 'A');
            return citxnom;
        }

        //Citas por Especialidad
        public static Tbl_Cita_Agendada obtener_agendamiento_xespec(string espec)
        {
            var citxnom = dc.Tbl_Cita_Agendada.FirstOrDefault(age => age.espc_id.Equals(espec) && age.cagn_estado == 'A');
            return citxnom;
        }
        //Lista de Citas con Fecha del Dia

        public static List<Tbl_Cita_Agendada> obtener_citasXfecha(DateTime fecha)
        {
            var lista = dc.Tbl_Cita_Agendada.Where(age => age.cagn_estado == 'A' && age.cagn_fechaAgen.Equals(fecha));
            return lista.ToList();
        }

        public static void deleteagen(Tbl_Cita_Agendada agendamiento)
        {
            try
            {
                //Borrado Logico
                agendamiento.cagn_estado = 'I';
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
