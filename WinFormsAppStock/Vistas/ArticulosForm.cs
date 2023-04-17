using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodigoComun.Modelos;
using CodigoComun.Negocio;

namespace WinFormsAppStock.Vistas
{
    public partial class ArticulosForm : Form
    {
        public ArticulosForm()
        {
            InitializeComponent();
            CargarArticulos();
        }

        private void CargarArticulos()
        {
            Articulo articuloAuxiliar = new Articulo();
            List<Articulo> articulosEnLaDB = articuloAuxiliar.GetTodosLosArticulos();
            gvArticulos.DataSource = articulosEnLaDB;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int IdArticuloAmodificar = Convert.ToInt32(this.txtIdArticulo.Text);

            ArticulosABM articuloABMModoModificacion = new ArticulosABM(IdArticuloAmodificar);
            articuloABMModoModificacion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idArticuloEliminar = Convert.ToInt32(this.txtIdArticulo.Text);

            Articulo articuloAuxiliar = new Articulo();
            articuloAuxiliar.Id = idArticuloEliminar;

            ArticuloServices articuloServices = new ArticuloServices();
            string mensaje = articuloServices.EliminarArticulo(articuloAuxiliar);

            if (mensaje == "Articulo eliminado")
            {
                MessageBox.Show("Articulo eliminado con exito");
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArticulosABM articulosABM = new ArticulosABM();
            articulosABM.Show();
        }

    }
}
