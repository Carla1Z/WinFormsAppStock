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
    public partial class DepositosForm : Form
    {
        public DepositosForm()
        {
            InitializeComponent();
            CargarDepositos();
        }

        private void CargarDepositos()
        {
            DepositoServices services = new DepositoServices();
            gvDepositos.DataSource = services.TodosLosDepositos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdDepositoAmodificar = Convert.ToInt32(this.txtIdDeposito.Text);

            DepositoABM depositoABMModoModificacion = new DepositoABM(IdDepositoAmodificar);
            depositoABMModoModificacion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idDepositoEliminar = Convert.ToInt32(this.txtIdDeposito.Text);

            Deposito depositoAuxiliar = new Deposito();
            depositoAuxiliar.Id = idDepositoEliminar;

            DepositoServices services = new DepositoServices();
            string mensaje = services.EliminarDepositoSeleccionado(depositoAuxiliar);

            if (mensaje == "Deposito eliminado")
            {
                MessageBox.Show("Deposito eliminado con exito");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepositoABM depositoABM = new DepositoABM();
            depositoABM.Show();
        }

    }
}
