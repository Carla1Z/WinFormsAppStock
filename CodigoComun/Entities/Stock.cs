﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using AutoMapper;
using CodigoComun.Modelos;
using CodigoComun.Modelos.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodigoComun.Entities
{
	public partial class Stock
	{
		public int Id { get; set; }
		public int? IdArticulo { get; set; }
		public int? IdDeposito { get; set; }
		public decimal? Cantidad { get; set; }
		public virtual Deposito IdDepositoNavigation { get; set; }
		[ForeignKey("IdArticulo")]
		public Articulo Articulos { get; set; }

		public StockDTO GetStockDTO(Stock stock)
		{
			var config = new MapperConfiguration(cfg => cfg.CreateMap<Stock, StockDTO>());
			var mapper = new Mapper(config);
			StockDTO stockDTOADevolver = mapper.Map<StockDTO>(stock);
			return stockDTOADevolver;
		}

	}
}