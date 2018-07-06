using Controlador;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAltaEmpleado
{
    public partial class FrmBuscarEmpleado : Form
    {
        ControladorEmpleado cEmpleado = new ControladorEmpleado();
        public FrmBuscarEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var message = String.Empty;
            string dni = txtBuscar.Text;
            Empleado oEmpleado;
            if (!String.IsNullOrEmpty(txtBuscar.Text))
            {
                oEmpleado = cEmpleado.BuscarEmpleado(dni);
                 if (oEmpleado == null)
                    MessageBox.Show("El empleado no existe");
                 else
                    dtgEmpleado.Rows.Add(oEmpleado.Apellido, oEmpleado.Nombre, oEmpleado.Cuil, oEmpleado.HoraPorMes, oEmpleado.ValorHora, oEmpleado.Consorcio.Nombre, oEmpleado.Consorcio.Cuit);
            }
            else
                MessageBox.Show("Debe llenar los campos vacios");     
        }
    }
}
