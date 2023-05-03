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
					StockDTO stockDTO = new StockDTO();
					stockDTO.GetStock(stockDTO);
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

		public Stock stockPorId(int idStock)
		{
			Stock stockEnDB = stockRepository.GetStockPorId(idStock);
			return stockEnDB;
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

		public StockDTO EliminarStockSeleccionado(StockDTO stockAEliminar)
		{
			try
			{
				int r = stockRepository.EliminarStock(stockAEliminar.Id);

				if (r == 1)
				{
					stockAEliminar.Mensaje = "Stock eliminado";
					return stockAEliminar;
				}
				else
				{
					stockAEliminar.Mensaje = "No se pudo eliminar el stock";
					return stockAEliminar;
				}
			}
			catch (Exception ex)
			{
				stockAEliminar.HuboError = true;
				stockAEliminar.Mensaje = $"Hubo un excepción eliminar el stock: {ex.Message}";
				return stockAEliminar;
			}

		}


	}
}
