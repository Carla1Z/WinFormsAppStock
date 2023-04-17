using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodigoComun.Entities;
using CodigoComun.Negocio;

namespace WinFormsAppStock.Vistas
{
    public partial class DepositoABM : Form
    {
        public bool EstoyModificando { get; set; }

        public DepositoABM()
        {
            InitializeComponent();
            EstoyModificando = false;

        }

        public DepositoABM(int idDepositoAModificar)
        {
            InitializeComponent();
            CargarDatosDepositoParaModificar(idDepositoAModificar);
            EstoyModificando = true;
        }

        private void AgregarDeposito()
        {
            Deposito depositoAGuardar = new Deposito();
            depositoAGuardar.Capacidad = Convert.ToDecimal(txtCapacidad.Text);
            depositoAGuardar.Nombre = txtNombre.Text;
            depositoAGuardar.Direccion = txtDireccion.Text;

            DepositoServices depositoServices = new DepositoServices();
            string mensaje = depositoServices.AgregarDeposito(depositoAGuardar);
            
            if (mensaje == "Deposito Agregado")
            {
                MessageBox.Show("Deposito Agregado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void CargarDatosDepositoParaModificar(int idDepositoAModificar)
        {
            DepositoServices services = new DepositoServices();
            Deposito depositoAuxiliar = services.depositoPorId(idDepositoAModificar);


            txtId.Text = depositoAuxiliar.Id.ToString();
            txtCapacidad.Text = depositoAuxiliar.Capacidad.ToString();
            txtNombre.Text = depositoAuxiliar.Nombre;
            txtDireccion.Text = depositoAuxiliar.Direccion;

        }

        private void ModificarDeposito()
        {
            Deposito DepositoAModificar = new Deposito();
            DepositoAModificar.Capacidad = Convert.ToDecimal(txtCapacidad.Text);
            DepositoAModificar.Nombre = txtNombre.Text;
            DepositoAModificar.Direccion = txtDireccion.Text;
            DepositoAModificar.Id = Convert.ToInt32(txtId.Text);

            DepositoServices depositoServices = new DepositoServices();
            string mensaje = depositoServices.ModificarDeposito(DepositoAModificar);

            if (mensaje == "Deposito Modificado")
            {
                MessageBox.Show("Deposito modificado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (EstoyModificando == true)
            {
                ModificarDeposito();
            }
            else
            {
                this.AgregarDeposito();
            }
        }
    }
}
