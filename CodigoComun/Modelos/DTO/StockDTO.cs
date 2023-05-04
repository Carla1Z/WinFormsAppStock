using AutoMapper;
using CodigoComun.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Modelos.DTO
{
	public class StockDTO : BaseDTO
	{
		public int Id { get; set; }
		public int? IdArticulo { get; set; }
		public int? IdDeposito { get; set; }
		public decimal? Cantidad { get; set; }
		public ArticuloDTO Articulo { get; set; }
		public DepositoDTO Deposito { get; set; }

		public StockDTO() { }

		public Stock GetStock(StockDTO stockDTO)
		{
			var config = new MapperConfiguration(cfg => cfg.CreateMap<StockDTO, Stock>());
			var mapper = new Mapper(config);
			Stock stockADevolver = mapper.Map<Stock>(stockDTO);
			return stockADevolver;
		}

	}
}
