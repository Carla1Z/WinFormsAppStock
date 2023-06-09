﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Modelos.DTO
{
	public class ArticuloDTO : BaseDTO
	{
		public int Id { get; set; }
		public string Nombre { set; get; }
		public string Marca { get; set; }
		public decimal MinimoStock { get; set; }
		public string Proveedor { get; set; }
		public float Precio { get; set; }
		public string Codigo { get; set; }

		public ArticuloDTO() { }

		public Articulo GetArticulo(ArticuloDTO articuloDTO)
		{
			var config = new MapperConfiguration(cfg => cfg.CreateMap<ArticuloDTO, Articulo>());
			var mapper = new Mapper(config);
			Articulo articuloADevolver = mapper.Map<Articulo>(articuloDTO);
			return articuloADevolver;
		}

	}
}