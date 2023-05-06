using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodigoComun.Entities;
using CodigoComun.Modelos;
using CodigoComun.Modelos.DTO;
using CodigoComun.Negocio;

namespace WinFormsAppStock.Vistas
{
    public partial class StocksABM : Form
    {
        public bool EstoyModificando { get; set; }

        public StocksABM()
        {
            InitializeComponent();
            this.CargarArticulos();
            this.CargarDepositos();
            EstoyModificando = false;
        }

        public StocksABM(int IdStockAModificar)
        {
            InitializeComponent();
            CargarDatosStocksParaModificar(IdStockAModificar);
            EstoyModificando = true;
        }

        private void CargarDepositos()
        {
            List<DepositoDTO> depositos = new List<DepositoDTO>();

            DepositoServices services = new DepositoServices();
            depositos = services.TodosLosDepositos();

            cbIdDeposito.DataSource = new BindingSource(depositos, null);
            cbIdDeposito.DisplayMember = "Nombre";
            cbIdDeposito.ValueMember = "Id";
        }

        private void CargarArticulos()
        {
            List<ArticuloDTO> articulos = new List<ArticuloDTO>();

            ArticuloServices articuloAuxiliar = new ArticuloServices();
            articulos = articuloAuxiliar.TodosLosArticulos();

            cbtIdArticulo.DataSource = new BindingSource(articulos, null);
            cbtIdArticulo.DisplayMember = "Nombre";
            cbtIdArticulo.ValueMember = "Id";
        }

        private void AgregarStock()
        {
            var depositoSeleccionado = cbIdDeposito.SelectedItem;
            var articuloSeleccionado = cbtIdArticulo.SelectedItem;

            StockDTO stockAAgregar = new StockDTO();
            stockAAgregar.Cantidad = Convert.ToDecimal(this.txtCantidad.Text);
            //stockAAgregar.Articulos = (Articulo)articuloSeleccionado;
            stockAAgregar.IdArticulo = ((ArticuloDTO)articuloSeleccionado).Id;
            stockAAgregar.IdDeposito = ((DepositoDTO)depositoSeleccionado).Id;
            //stockAAgregar.IdDepositoNavigation = (Deposito)depositoSeleccionado;

            StockServices services = new StockServices();
            StockDTO mensaje = services.AgregarStock(stockAAgregar);

            if (mensaje.Mensaje == "Stock Agregado")
            {
                MessageBox.Show("Stock Agregado con exito");
            }
            else
            {
                MessageBox.Show("No se pudo agregar stock");
            }
        }

        private void CargarDatosStocksParaModificar(int idStockAModificar)
        {
            StockServices services = new StockServices();
            StockDTO stockAuxiliar = services.stockPorId(idStockAModificar);

            txtId.Text = stockAuxiliar.Id.ToString();
            txtCantidad.Text = stockAuxiliar.Cantidad.ToString();

            // Cargar lista completa de objetos en ComboBox de Artículos
            cbtIdArticulo.DisplayMember = "Nombre"; // nombre de la propiedad que se mostrará en el ComboBox
            cbtIdArticulo.ValueMember = "Id"; // nombre de la propiedad que se almacenará en el ComboBox
            cbtIdArticulo.DataSource = new ArticuloServices().TodosLosArticulos(); // se cargan todos los objetos de Articulo en el ComboBox

            // Cargar lista completa de objetos en ComboBox de Depósitos
            cbIdDeposito.DisplayMember = "Nombre"; // nombre de la propiedad que se mostrará en el ComboBox
            cbIdDeposito.ValueMember = "Id"; // nombre de la propiedad que se almacenará en el ComboBox
            cbIdDeposito.DataSource = new DepositoServices().TodosLosDepositos(); // se cargan todos los objetos de Deposito en el ComboBox

            cbtIdArticulo.SelectedValue = stockAuxiliar.IdArticulo;
            cbIdDeposito.SelectedValue = stockAuxiliar.IdDeposito;
        }


        private void ModificarStock()
        {
            StockDTO StockAModificar = new StockDTO();
            StockAModificar.Cantidad = Convert.ToDecimal(txtCantidad.Text);
            StockAModificar.IdArticulo = ((ArticuloDTO)cbtIdArticulo.SelectedItem).Id;
            StockAModificar.IdDeposito = ((DepositoDTO)cbIdDeposito.SelectedItem).Id;
            StockAModificar.Id = Convert.ToInt32(txtId.Text);

            StockServices stockServices = new StockServices();
            StockDTO mensaje = stockServices.ModificarStock(StockAModificar);

            if (mensaje.Mensaje == "Stock Modificado")
            {
                MessageBox.Show("Stock modificado con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show(mensaje.Mensaje);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (EstoyModificando == true)
            {
                ModificarStock();
            }
            else
            {
                AgregarStock();
            }
        }
    }
}
