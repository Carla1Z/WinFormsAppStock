using AutoMapper;
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
		ArticuloRepository articuloRepository = new ArticuloRepository();
		public ArticuloDTO AgregarArticulo(ArticuloDTO articuloDTOAAgregar)
		{
			try
			{
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
				articuloDTOAAgregar.Mensaje = $"Hubo una excepción dando de alta el articulo: {ex.Message}";
				return articuloDTOAAgregar;
			}

		}

		public List<ArticuloDTO> TodosLosArticulos()
		{
			List<ArticuloDTO> articuloDTOs = new List<ArticuloDTO>();
			try
			{
				List<Articulo> articulos = articuloRepository.GetTodosLosArticulos();
				foreach (Articulo articulo in articulos)
				{
					ArticuloDTO articuloDTO = new ArticuloDTO();
					articuloDTO.GetArticulo(articuloDTO);
				}
			}
			catch (Exception ex)
			{
				articuloDTOs = new List<ArticuloDTO>()
				{
					new ArticuloDTO()
						{
						HuboError = true,
						Mensaje = $"Hubo un error al mostrar los articulos: {ex.Message}"
						}
				};
			}

			return articuloDTOs;
		}



		public ArticuloDTO ArticuloPorId(int articuloDTOId)
		{
			ArticuloDTO articuloDTO = new ArticuloDTO();
			try
			{
				Articulo articuloEncontrado = articuloRepository.GetArticuloPorId(articuloDTOId);

				if (articuloEncontrado != null)
				{
					int idArticulo = articuloEncontrado.Id;
					articuloDTO.Mensaje = "Mostrar articulo";
					return articuloDTO;
				}
				else
				{
					articuloDTO.Mensaje = "No se pudo mostrar el articulo";
					return articuloDTO;
				}
			}
			catch (Exception ex)
			{
				articuloDTO.HuboError = true;
				articuloDTO.Mensaje = $"Hubo una excepción mostrando el articulo: {ex.Message}";
				return articuloDTO;
			}
		}

		public ArticuloDTO ModificarArticulo(ArticuloDTO articuloDTOAModificar)
		{
			try
			{
				Articulo articuloAuxiliar = articuloDTOAModificar.GetArticulo(articuloDTOAModificar);

				int r = articuloRepository.UpdateArticuloDB(articuloAuxiliar);

				if (r == 1)
				{
					articuloDTOAModificar.Mensaje = "Articulo Modificado";
					return articuloDTOAModificar;
				}
				else
				{
					articuloDTOAModificar.Mensaje = "No se pudo modificar el articulo";
					return articuloDTOAModificar;
				}
			}
			catch (Exception ex)
			{
				articuloDTOAModificar.HuboError = true;
				articuloDTOAModificar.Mensaje = $"Hubo una excepción modificando el articulo: {ex.Message}";
				return articuloDTOAModificar;
			}

		}

		public ArticuloDTO EliminarArticulo(int articuloAEliminar)
		{
			ArticuloDTO articuloDTOEliminado = new ArticuloDTO();
			try
			{
				int r = articuloRepository.DeleteArticuloDB(articuloAEliminar);
				if (r == 1)
				{
					articuloDTOEliminado.Mensaje = "Articulo eliminado";
					return articuloDTOEliminado;
				}
				else
				{
					articuloDTOEliminado.Mensaje = "No se pudo eliminar el articulo";
					return articuloDTOEliminado;
				}
			}
			catch (Exception ex)
			{
				articuloDTOEliminado.HuboError = true;
				articuloDTOEliminado.Mensaje = $"Hubo una excepción eliminando el articulo: {ex.Message}";
				return articuloDTOEliminado;
			}

		}



	}

}
