using AutoMapper;
using CodigoComun.Entities;
using CodigoComun.Modelos.DTO;
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
		private List<StockDTO> stockDTOs = new List<StockDTO>();
		private StockDTO stock = new StockDTO();

		public StockDTO AgregarStock(StockDTO stockDTOAAgregar)
		{
			try
			{
				Stock stock = stockDTOAAgregar.GetStock(stockDTOAAgregar);
				int r = stockRepository.AddStock(stock);

				if (r == 1)
				{
					stockDTOAAgregar.Mensaje = "Stock Agregado";
					return stockDTOAAgregar;
				}
				else
				{
					stockDTOAAgregar.HuboError = true;
					stockDTOAAgregar.Mensaje = "No se pudo agregar el stock";
					return stockDTOAAgregar;
				}
			}
			catch (Exception ex)
			{
				stockDTOAAgregar.HuboError = true;
				stockDTOAAgregar.Mensaje = $"Hubo un excepción dando de alta el stock: {ex.Message}";
				return stockDTOAAgregar;
			}

		}

		public List<StockDTO> TodosLosStocks()
		{
			try
			{
				List<Stock> stocks = stockRepository.GetTodosStocks();

				foreach (Stock stock in stocks)
				{
					stockDTOs.Add(stock.GetStockDTO(stock));
				}

			}
			catch (Exception ex)
			{
				stockDTOs = new List<StockDTO>()
				{
					new StockDTO()
					{
						HuboError= true,
						Mensaje= $"Hubo error al mostrar los stocks: {ex.Message}"
					}
				};
			}
			return stockDTOs;
		}

		public StockDTO stockPorId(int idDTOStock)
		{
			try
			{
				Stock stockEncontrado = stockRepository.GetStockPorId(idDTOStock);

				if (stockEncontrado != null)
				{
					stock = stockEncontrado.GetStockDTO(stockEncontrado);
					stock.Mensaje = "Mostrar stock";
				}
				else
				{
					stock.Mensaje = "No se pudo mostrar el stock";
				}
				return stock;
			}
			catch (Exception ex)
			{
				stock.HuboError = true;
				stock.Mensaje = $"Hubo una excepción al mostrar el stock: {ex.Message}";
				return stock;
			}
		}

		public StockDTO ModificarStock(StockDTO stockAModificar)
		{
			try
			{
				Stock stock = stockAModificar.GetStock(stockAModificar);
				int r = stockRepository.ActualizarStock(stock);

				if (r == 1)
				{
					stockAModificar.Mensaje = "Stock Modificado";
					return stockAModificar;
				}
				else
				{
					stockAModificar.Mensaje = "No se pudo modificar el Stock";
					return stockAModificar;
				}
			}
			catch (Exception ex)
			{
				stockAModificar.HuboError = true;
				stockAModificar.Mensaje = $"Hubo un excepción modificando el stock: {ex.Message}";
				return stockAModificar;
			}


		}

		public StockDTO EliminarStockSeleccionado(int stockAEliminar)
		{
			try
			{
				int r = stockRepository.EliminarStock(stockAEliminar);

				if (r == 1)
				{
					stock.Mensaje = "Stock eliminado";
					return stock;
				}
				else
				{
					stock.Mensaje = "No se pudo eliminar el stock";
					return stock;
				}
			}
			catch (Exception ex)
			{
				stock.HuboError = true;
				stock.Mensaje = $"Hubo un excepción eliminar el stock: {ex.Message}";
				return stock;
			}

		}


	}
}
