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
using CodigoComun.Modelos;
using CodigoComun.Modelos.DTO;
using CodigoComun.Negocio;

namespace WinFormsAppStock.Vistas
{
    public partial class StocksForm : Form
    {
        public StocksForm()
        {
            InitializeComponent();
            CargarStocks();
        }

        private void CargarStocks()
        {
            StockServices services = new StockServices();
            List<StockDTO> stocksEnLaDB = services.TodosLosStocks();
            gvStocks.DataSource = stocksEnLaDB;
            gvStocks.CellFormatting += gvStocks_CellFormatting;
        }

        private void gvStocks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == gvStocks.Columns["IdArticulo"].Index)
            {
                if (e.Value != null)
                {
                    int idArticulo = (int)e.Value;
                    ArticuloServices articuloAuxiliar = new ArticuloServices();
                    ArticuloDTO articulo = articuloAuxiliar.ArticuloPorId(idArticulo);
                    e.Value = articulo.Nombre;
                }
            }
            else if (e.ColumnIndex == gvStocks.Columns["IdDeposito"].Index)
            {
                if (e.Value != null)
                {
                    int idDeposito = (int)e.Value;
                    DepositoServices depositoServices = new DepositoServices();
                    DepositoDTO deposito = depositoServices.depositoPorId(idDeposito);
                    e.Value = deposito.Nombre;
                }
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            int IdStockAModificar = Convert.ToInt32(this.txtIdStock.Text);

            StocksABM stocksABMModoModificacion = new StocksABM(IdStockAModificar);
            stocksABMModoModificacion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idStockEliminar = Convert.ToInt32(this.txtIdStock.Text);

            Stock stockAuxiliar = new Stock();
            stockAuxiliar.Id = idStockEliminar;

            StockServices stockServices = new StockServices();
            StockDTO mensaje = stockServices.EliminarStockSeleccionado(stockAuxiliar.Id);

            if (mensaje.Mensaje == "Stock eliminado")
            {
                MessageBox.Show("Stock eliminado con exito");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el stock");
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            StocksABM stocksABM = new StocksABM();
            stocksABM.Show();
        }


    }
}
