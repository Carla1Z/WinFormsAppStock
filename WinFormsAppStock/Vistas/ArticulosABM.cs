using CodigoComun.Modelos;
using CodigoComun.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsAppStock.Vistas
{
    public partial class ArticulosABM : Form
    {
        public bool EstoyModificando { get; set; }

        public ArticulosABM()
        {
            InitializeComponent();
            EstoyModificando = false;
        }

        public ArticulosABM(int idArticuloAModificar)
        {
            InitializeComponent();
            CargarDatosArticuloParaModificar(idArticuloAModificar);
            EstoyModificando = true;
        }

        private void AgregarArticulo()
        {
            Articulo articuloAGuardar = new Articulo();
            articuloAGuardar.Nombre = txtNombre.Text;
            articuloAGuardar.Marca = txtMarca.Text;
            articuloAGuardar.MinimoStock = Convert.ToDecimal(txtMinStock.Text);
            articuloAGuardar.Proveedor = txtProveedor.Text;
            articuloAGuardar.Precio = (float)Convert.ToDecimal(txtPrecio.Text);
            articuloAGuardar.Codigo = txtCodigo.Text;

            //instancio el servicio
            ArticuloServices articuloServices = new ArticuloServices();
            string mensaje = articuloServices.AgregarArticulo(articuloAGuardar);

            if (mensaje == "Articulo Agregado")
            {
                MessageBox.Show("Articulo Agregado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje);
            }
        }

        private void CargarDatosArticuloParaModificar(int idArticuloAModificar)
        {
            Articulo articuloAuxiliar = new Articulo();

            Articulo articuloConDatosDeLaBaseDeDatos = articuloAuxiliar.GetArticuloPorId(idArticuloAModificar);

            txtId.Text = articuloConDatosDeLaBaseDeDatos.Id.ToString();
            txtNombre.Text = articuloConDatosDeLaBaseDeDatos.Nombre;
            txtMarca.Text = articuloConDatosDeLaBaseDeDatos.Marca;
            txtMinStock.Text = articuloConDatosDeLaBaseDeDatos.MinimoStock.ToString();
            txtProveedor.Text = articuloConDatosDeLaBaseDeDatos.Proveedor;
            txtPrecio.Text = articuloConDatosDeLaBaseDeDatos.Precio.ToString();
            txtCodigo.Text = articuloConDatosDeLaBaseDeDatos.Codigo.ToString();
        }

        private void ModificarArticulo()
        {
            Articulo ArticuloAModificar = new Articulo();
            ArticuloAModificar.Nombre = txtNombre.Text;
            ArticuloAModificar.Marca = txtMarca.Text;
            ArticuloAModificar.MinimoStock = Convert.ToDecimal(txtMinStock.Text);
            ArticuloAModificar.Proveedor = txtProveedor.Text;
            ArticuloAModificar.Precio = (float)Convert.ToDecimal(txtPrecio.Text);
            ArticuloAModificar.Codigo = txtCodigo.Text;
            ArticuloAModificar.Id = Convert.ToInt32(txtId.Text);

            ArticuloServices articuloServices = new ArticuloServices();
            string mensaje = articuloServices.ModificarArticulo(ArticuloAModificar);

            if (mensaje == "Articulo Modificado")
            {
                MessageBox.Show("Articulo modificado con exito");
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
                ModificarArticulo();
            }
            else
            {
                this.AgregarArticulo();
            }
        }
    }
}
