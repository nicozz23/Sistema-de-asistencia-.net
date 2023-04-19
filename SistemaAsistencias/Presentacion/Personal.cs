using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAsistencias.Datos;
using SistemaAsistencias.Logica;

namespace SistemaAsistencias.Presentacion
{
    public partial class Personal : UserControl
    {
        public Personal()
        {
            InitializeComponent();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = false;
            PanelPaginado.Visible = false;
            PanelRegistro.Visible = true;
            PanelRegistro.Dock = DockStyle.Fill;
            BtnGuardarPersonal.Visible = true;
            BtnGuardarCambios.Visible = false;
            Limpiar();
        }

        private void Limpiar()
        {
            txtNombres.Clear();
            txtIdentificacion.Clear();
            txtSueldo.Clear();
            txtCargo.Clear();
            BuscarCargo();
        }





        private void PanelRegistro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGuardarPersonal_Click(object sender, EventArgs e)
        {

        }
        private void Insertar_Personal()
        {
            Lpersonal parametros = new Lpersonal();
            DPersonal funcion = new DPersonal();
            parametros.Nombres = txtNombres.Text;
            parametros.Identificacion = txtIdentificacion.Text;
            parametros.Pais = cmbPais.Text;


        }

        private void Insertar_cargos()
        {
            if (!string.IsNullOrEmpty(txtCargog.Text))
            {
                if (!string.IsNullOrEmpty(txtSueldog.Text))
                {
                    Lcargo parametros = new Lcargo();
                    DCargo funcion = new DCargo();
                    parametros.Nombre_cargo = txtCargog.Text;
                    parametros.Sueldo_por_hora = Convert.ToDouble(txtSueldog.Text);
                    if (funcion.InsertarCargo(parametros) == true)
                    {
                        txtCargo.Clear();
                        BuscarCargo();
                        PanelCargos.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Agrege el Sueldo", "Falta el Sueldo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Agrege el cargo", "Falta el Cargo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void BuscarCargo()
        {
            DataTable dt = new DataTable();
            DCargo funcion = new DCargo();
            funcion.BuscarCargo(ref dt, txtCargo.Text);
            DataListadoCargos.DataSource = dt;
            bases.DiseñoDtv(ref DataListadoCargos);
        }

        private void txtCargo_TextChanged(object sender, EventArgs e)
        {
            BuscarCargo();
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            PanelCargos.Visible = true;
            PanelCargos.Dock = DockStyle.Fill;
            PanelCargos.BringToFront();
            BtnGuardarC.Visible = true;
            btnGuardarCambiosC.Visible = false;
            txtSueldog.Clear();
            txtCargog.Clear();
        }

        private void BtnGuardarC_Click(object sender, EventArgs e)
        {
            Insertar_cargos();
        }

        private void txtSueldog_KeyPress(object sender, KeyPressEventArgs e)
        {
            bases.Decimales(txtSueldog, e);
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            bases.Decimales(txtSueldo, e);
        }
    }
}
