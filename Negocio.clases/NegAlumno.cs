using Backend;
using System.Data;
using datos.clases;
namespace Negocio.clases
{
    public class NegAlumno
    {
        Admin DatosAlumno = new Admin();

        public int abmAlumno(string accion, Alumno aLumno)
        {
            return DatosAlumno.abmAlumno(accion, aLumno);
        }
        public DataSet ListadoAlumno(string cual)
        {
            return DatosAlumno.listadoAlumno(cual);
        }
    }
}
