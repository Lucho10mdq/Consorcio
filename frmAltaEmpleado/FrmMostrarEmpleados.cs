using Controlador;
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
    public partial class FrmMostrarEmpleados : Form
    {
        ControladorEmpleado cEmpleado = new ControladorEmpleado();
        public FrmMostrarEmpleados()
        {
            InitializeComponent();
        }

        private void dtglistaEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmMostrarEmpleados_Load(object sender, EventArgs e)
        {
            dtglistaEmpleados.DataSource = null;
            dtglistaEmpleados.DataSource = cEmpleado.DevolverEmpleados();
        }
    }
}
