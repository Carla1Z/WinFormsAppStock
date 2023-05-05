using CodigoComun.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Repository
{
	public class DepositoRepository
	{
		private StockAppContext db = new StockAppContext();

		public List<Deposito> GetTodosLosDepositos()
		{
			List<Deposito> depositoADevolver = new List<Deposito>();
			depositoADevolver = db.Depositos.ToList();

			return depositoADevolver;
		}

		public Deposito GetDepositoPorId(int idDeposito)
		{
			Deposito depositoADevolver = db.Depositos.Where(p => p.Id == idDeposito).FirstOrDefault();

			return depositoADevolver;
		}

		public bool EliminarStockConArticulo(int depositoId)
		{
			var stockDeposito = db.Stocks.Where(p => p.IdDeposito == depositoId);
			foreach (var stock in stockDeposito)
			{
				if (stock.IdArticulo != null && stock.Cantidad > 0)
				{
					return true;
				}
			}
			return false;
		}

		public int EliminarDeposito(int idDepositoAEliminar)
		{
			Deposito depositoAEliminar = GetDepositoPorId(idDepositoAEliminar);
			db.Depositos.Remove(depositoAEliminar);

			int r = db.SaveChanges();
			return r;
		}

		public Deposito GetDepositoPorNombre(string nombreABuscar)
		{
			Deposito depositoNombre = db.Depositos.Where(p => p.Nombre == nombreABuscar).FirstOrDefault();
			return depositoNombre;
		}

		public int AddDeposito(Deposito depositoAAgregar)
		{
			db.Depositos.Add(depositoAAgregar);

			int r = db.SaveChanges();
			return r;
		}

		public int UpdateDeposito(Deposito depositoAModificar)
		{
			db.Entry(depositoAModificar).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
			return db.SaveChanges();
		}


	}
}
