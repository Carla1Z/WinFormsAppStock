using CodigoComun.Modelos;
using CodigoComun.Modelos.DTO;
using CodigoComun.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Negocio
{
	public class ArticuloServices
	{
		public ArticuloDTO AgregarArticulo(ArticuloDTO articuloDTOAAgregar)
		{
			try
			{

				ArticuloRepository articuloRepository = new ArticuloRepository();

				//verifico antes de agregar articulo
				Articulo articuloAuxiliar = articuloRepository.GetArticuloPorCodigo(articuloDTOAAgregar.Codigo);

				if (articuloAuxiliar != null)
				{
					articuloDTOAAgregar.HuboError = true;
					articuloDTOAAgregar.Mensaje = $"Ya existe un articulo con el codigo {articuloDTOAAgregar.Codigo}";
					return articuloDTOAAgregar;
				}

				Articulo articulo = articuloDTOAAgregar.GetArticulo(articuloDTOAAgregar);

				int r = articuloRepository.AddArticuloDB(articulo);

				if (r == 1)
				{
					articuloDTOAAgregar.Mensaje = "Articulo Agregado";
					return articuloDTOAAgregar;
				}
				else
				{
					articuloDTOAAgregar.Mensaje = "No se pudo agregar el articulo";
					return articuloDTOAAgregar;
				}
			}
			catch (Exception ex)
			{
				articuloDTOAAgregar.HuboError = true;
				articuloDTOAAgregar.Mensaje = $"Hubo una excepción dando de alta el articulo {ex.Message}";
				return articuloDTOAAgregar;
			}

		}

		public string ModificarArticulo(Articulo articuloAModificar)
		{
			ArticuloRepository articuloRepository = new ArticuloRepository();
			int r = articuloRepository.UpdateArticuloDB(articuloAModificar);

			if (r == 1)
			{
				return "Articulo Modificado";
			}
			else
			{
				return "No se pudo modificar el articulo";
			}
		}


		public string EliminarArticulo(int articuloAEliminar)
		{
			ArticuloRepository articuloRepository = new ArticuloRepository();
			int r = articuloRepository.DeleteArticuloDB(articuloAEliminar);

			if (r == 1)
			{
				return "Articulo eliminado";
			}
			else
			{
				return "No se pudo eliminar el articulo";
			}

		}

	}
}
