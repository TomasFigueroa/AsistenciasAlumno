using Backend;
using datos.clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.clases
{
    public class NegAsistencia
    {
        AdminAsis Datosasistencia = new AdminAsis();

        public int abmAsistencia(string accion, Asistencias aLumno)
        {
            return Datosasistencia.abmAsistencia(accion, aLumno);
        }
        public DataSet ListadoAsistencia(string cual)
        {
            return Datosasistencia.listadoAsistencias(cual);
        }
    }
}
