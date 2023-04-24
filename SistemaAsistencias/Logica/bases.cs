using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAsistencias.Logica
{
    public class bases
    {
        public static void DiseñoDtv(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.White;
            Listado.EnableHeadersVisualStyles = false;  
            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;
            
            Listado.CellBorderStyle = DataGridViewCellBorderStyle.None;
        }

        public static object Decimales(TextBox Cajatexto, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
           
            else if (char.IsControl(e.KeyChar)) {
                e.Handled = false;
            }
            else if (e.KeyChar=='.' && (~Cajatexto.Text.IndexOf("."))!=0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar=='.')
            {
                e.Handled= false;

            }
            else if (e.KeyChar==',')
            {
                e.Handled= false;
            }
            else
            {
                e.Handled = true;
            }
            return null;
        }
    }
}
