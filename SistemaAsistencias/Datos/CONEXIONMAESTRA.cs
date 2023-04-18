using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SistemaAsistencias.Datos
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = "Data source =DESKTOP-REC33TM\\SQLEXPRESS; Initial Catalog=SistemaAsistencias;Integrated Security=false";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if(conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void Cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
