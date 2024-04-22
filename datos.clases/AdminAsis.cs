using Backend;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos.clases
{
    public class AdminAsis : DatosConexion
    {
        public int abmAsistencia(string accion, Asistencias aLumno)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = $"insert into alumnoasis (Nombres,apellidos,DNI,Asistencia,Fechas) values ('{aLumno.Nombres}','{aLumno.apellido}','{aLumno.DNis}','{aLumno.asistnecias}','{aLumno.fehas}');";

            }

            if (accion == "Modificar")
            {
                orden = $"update alumnoasis SET Nombres='{aLumno.Nombres}',apellidos='{aLumno.apellido}',DNI={aLumno.DNis},Asistencia='{aLumno.asistnecias}' ,Fechas= '{aLumno.fehas}' where Id={aLumno.id};";
            }
            if (accion == "Borrar")
            {
                orden = "Delete from alumnoasis WHERE ID=" + aLumno.id + "";
            }

            // falta la orden de borrar
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Errror al tratar de guardar,borrar o modificar de alumno", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }


        public DataSet listadoAsistencias(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            {
                orden = "select * from alumnoasis where DNI = " + cual + ";";
            }

            else
            {
                orden = "select * from alumnoasis;";
            }

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Alumno", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }
    }
}
