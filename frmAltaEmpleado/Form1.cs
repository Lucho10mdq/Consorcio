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
    public partial class frmAltaEmpleado : Form
    {
        ControladorConsorcio cConsorcio = new ControladorConsorcio();
        ControladorEmpleado cEmpleado = new ControladorEmpleado();
        public frmAltaEmpleado()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {      
                cmbNombre.DataSource = cConsorcio.DevolverConsorcios();
                cmbNombre.DisplayMember = "nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var result = false;
            var message = String.Empty;
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string cuil = txtCuil.Text;
            //Corregir
            Consorcio oConsorcio = (Consorcio)cmbNombre.SelectedItem;
            if (cmbNombre.SelectedIndex.Equals(0))
                if (!String.IsNullOrEmpty(txtApellido.Text) && !String.IsNullOrEmpty(txtNombre.Text) && !String.IsNullOrEmpty(txtCuil.Text) && !String.IsNullOrEmpty(txtValorHora.Text) && !String.IsNullOrEmpty(txtValorMes.Text))

                    result = cEmpleado.AgregarEmpleado(apellido, nombre, cuil, Convert.ToDouble(txtValorHora.Text), Convert.ToDouble(txtValorMes.Text),oConsorcio.ConsorcioId,oConsorcio.Nombre,oConsorcio.Cuit);
                else
                    message = "Debe llenar los campos vacios";
            else
                message = "Debe llenar los campos vacios";
            if (!result && String.IsNullOrEmpty(message))
                message = "Ya existe empleado";

            MessageBox.Show(message);
            txtNombre.Clear();
            txtApellido.Clear();
            txtApellido.Clear();
            txtValorHora.Clear();
            txtValorMes.Clear();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            FrmMostrarEmpleados MostrarEmpleados = new FrmMostrarEmpleados();
            MostrarEmpleados.Show();
        }

        private void btnCalcularSueldo_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            resultado=cEmpleado.CalcularSueldo();
            lblresultado.Text = Convert.ToString(resultado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarEmpleado BuscarEmpleado = new FrmBuscarEmpleado();
            BuscarEmpleado.Show();
        }
    }
}
