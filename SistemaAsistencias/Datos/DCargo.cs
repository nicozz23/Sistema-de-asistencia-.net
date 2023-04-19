using SistemaAsistencias.Logica;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencias.Datos
{
    public  class DCargo
    {
        //METODOS SQL COMAND ALTERA BASE DE DATOS
        public bool InsertarCargo(Lcargo parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("InsertarCargo", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreCargo", parametros.Nombre_cargo);
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
        public bool EditarCargo(Lcargo parametros)
        {
            try
            {
                              
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("EditarCargo", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", parametros.Id_cargo);
                cmd.Parameters.AddWithValue("@NombreCargo", parametros.Nombre_cargo);
                cmd.Parameters.AddWithValue("@Sueldo", parametros.Sueldo_por_hora);
      
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
    
        public void BuscarCargo(ref DataTable dt, string buscador)
        {
            //EJECUCION DE COMANDOS (NO MODIFICA BASE DE DATOS, ADAPTA )
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("BuscarCargo", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
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
