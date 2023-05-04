using AutoMapper;
using CodigoComun.Datos;
using CodigoComun.Modelos.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodigoComun.Modelos
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Nombre { set; get; }
        public string Marca { get; set; }
        public decimal MinimoStock { get; set; }
        public string Proveedor { get; set; }
        public float Precio { get; set; }
        public string Codigo { get; set; }
        private AccesoDatos ac;


        public Articulo()
        {
            ac = new AccesoDatos();

        }

		public ArticuloDTO GetArticuloDTO(Articulo articulo)
		{
			var config = new MapperConfiguration(cfg => cfg.CreateMap<Articulo, ArticuloDTO>());
			var mapper = new Mapper(config);
			ArticuloDTO articuloDTOADevolver = mapper.Map<ArticuloDTO>(articulo);
			return articuloDTOADevolver;
		}

	}
}
