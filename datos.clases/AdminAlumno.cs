using Backend;
using System.Data.SqlClient;
using System.Data;
using System;

namespace datos.clases
{
    public class Admin:DatosConexion
    {
        public int abmAlumno(string accion, Alumno aLumno)
        {
            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
            {
                orden = $"insert into asistencias (DNI,Nombre,Apellido) values ({aLumno.dni},'{aLumno.nombre}','{aLumno.Apellido}');";

            }

            if (accion == "Modificar")
            {
                orden = $"update asistencias SET Nombre='{aLumno.nombre}',Apellido='{aLumno.Apellido}'  where DNI={aLumno.dni};";
            }
            if (accion == "Borrar")
            {
                orden = "Delete from asistencias WHERE DNI=" + aLumno.dni + "";
            }
            if(accion =="Buscar") 
            {
                orden = $"SELECT * FROM asistencias WHERE DNI="+  aLumno.dni+ "";
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


        public DataSet listadoAlumno(string cual)
        {
            string orden = string.Empty;
            if (cual != "Todos")
            {
                orden = "select * from asistencias where DNI = " + cual + ";";
            }

            else
            {
                orden = "select * from asistencias;";
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
