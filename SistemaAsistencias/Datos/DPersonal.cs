using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SistemaAsistencias.Logica;

namespace SistemaAsistencias.Datos
{
    public class DPersonal
    {
        //METODOS SQL COMAND ALTERA BASE DE DATOS
        public bool InsertarPersonal(Lpersonal parametros)
        {
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("InsertarPersonal", CONEXIONMAESTRA.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@Sueldo_por_hora", parametros.Sueldo_por_hora);
                cmd.ExecuteNonQuery();
                return true;
            }
			catch (Exception ex)
			{
                MessageBox.Show(ex.Message);
				return false;
			}
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }
        public bool EditarPersonal(Lpersonal parametros)
        {
            try
            {
//              
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("EditarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
                cmd.Parameters.AddWithValue("@Nombres", parametros.Nombres);
                cmd.Parameters.AddWithValue("@Identificacion", parametros.Identificacion);
                cmd.Parameters.AddWithValue("@Pais", parametros.Pais);
                cmd.Parameters.AddWithValue("@Id_cargo", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@Sueldo_por_hora", parametros.Sueldo_por_hora);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }
        public bool EliminarPersonal(Lpersonal parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("EliminarPersonal", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_personal", parametros.Id_personal);
               
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }
        public void MostrarPersonal(ref DataTable dt, int desde, int hasta)
        {
            //EJECUCION DE COMANDOS (NO MODIFICA BASE DE DATOS, ADAPTA )
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("MostrarPersonal", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Desde", desde);
                da.SelectCommand.Parameters.AddWithValue("@Hasta", hasta);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
                

            }
            finally
            {
                CONEXIONMAESTRA.Cerrar();
            }
        }
    }

    
}
