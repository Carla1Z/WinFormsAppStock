using CodigoComun.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Repository
{
    public class StockRepository
    {
        private StockAppContext db = new StockAppContext();

        public List<Stock> GetTodosStocks()
        {
            List<Stock> stockADevolver = new List<Stock>();
            stockADevolver = db.Stocks.ToList();

            return stockADevolver;
        }

        public Stock GetStockPorId(int idStock)
        {
            Stock stockADevolver = db.Stocks.Where(p => p.Id == idStock).FirstOrDefault();

            return stockADevolver;
        }

		public bool ExisteStock(int idArticulo, int idDeposito)
		{
			return db.Stocks.Any(s => s.IdArticulo == idArticulo && s.IdDeposito == idDeposito);
		}


		public int AddStock(Stock stock)
        {
            db.Stocks.Add(stock);
            return db.SaveChanges();
        }

        public int ActualizarStock(Stock stockModificar)
        {
            db.Entry(stockModificar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }

        public int EliminarStock(int eliminarStock)
        {
            Stock stockAEliminar = GetStockPorId(eliminarStock);
            db.Stocks.Remove(stockAEliminar);
            int r = db.SaveChanges();
            return r;
        }

    }

}

