using CodigoComun.Entities;
using CodigoComun.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Negocio
{
    public class StockServices
    {
        private StockRepository stockRepository = new StockRepository();

        public string AgregarStock(Stock stockAAgregar)
        {
            StockRepository repository = new StockRepository();
            int r = repository.AddStock(stockAAgregar);

            if (r == 1)
            {
                return "Stock Agregado";
            }
            else
            {
                return "No se pudo agregar el stock";
            }
        }

        public List<Stock> TodosLosStocks()
        {
            return stockRepository.GetTodosStocks();
        }

        public Stock stockPorId(int idStock)
        {
            Stock stockEnDB = stockRepository.GetStockPorId(idStock);
            return stockEnDB;
        }


        public string EliminarStockSeleccionado(Stock stockAEliminar)
        {
            int r = stockRepository.EliminarStock(stockAEliminar.Id);

            if (r == 1)
            {
                return "Stock eliminado";
            }
            else
            {
                return "No se pudo eliminar el stock";
            }
        }


        public string ModificarStock(Stock stockAModificar)
        {
            int r = stockRepository.ActualizarStock(stockAModificar);

            if (r == 1)
            {
                return "Stock Modificado";
            }
            else
            {
                return "No se pudo modificar el Stock";
            }

        }



    }
}
