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
	public class DepositoServices
	{
		private DepositoRepository depositoRepository = new DepositoRepository();
		List<DepositoDTO> depositoDTOs = new List<DepositoDTO>();
		DepositoDTO deposito = new DepositoDTO();
		public DepositoDTO AgregarDeposito(DepositoDTO depositoDTOAAgregar)
		{
			try
			{
				Deposito deposito = depositoDTOAAgregar.GetDeposito(depositoDTOAAgregar);

				int r = depositoRepository.AddDeposito(deposito);

				if (r == 1)
				{
					depositoDTOAAgregar.Mensaje = "Deposito Agregado";
					return depositoDTOAAgregar;
				}
				else
				{
					depositoDTOAAgregar.Mensaje = "No se pudo agregar el deposito";
					return depositoDTOAAgregar;
				}
			}
			catch (Exception ex)
			{
				depositoDTOAAgregar.HuboError = true;
				depositoDTOAAgregar.Mensaje = $"Hubo un excepción dando de alta el deposito: {ex.Message}";
				return depositoDTOAAgregar;
			}

		}

		public List<DepositoDTO> TodosLosDepositos()
		{
			try
			{
				List<Deposito> depositos = depositoRepository.GetTodosLosDepositos();
				foreach (var deposito in depositos)
				{
					DepositoDTO depositoDTO = new DepositoDTO();
					depositoDTO.GetDeposito(depositoDTO);
				}
			}
			catch (Exception ex)
			{
				depositoDTOs = new List<DepositoDTO>()
				{
					new DepositoDTO()
					{
						HuboError = true,
						Mensaje = $"Hubo un error al mostrar los depositos {ex.Message}"
					}
				};
			}
			return depositoDTOs;
		}

		public DepositoDTO depositoPorId(int idDepositoDTO)
		{
			try
			{
				Deposito depositoEncontrado = depositoRepository.GetDepositoPorId(idDepositoDTO);

				if (depositoEncontrado !=null)
				{
					int idDeposito = depositoEncontrado.Id;
					deposito.Mensaje = "Mostrar deposito";
					return deposito;
				}
				else
				{
					deposito.Mensaje = "No se pudo mostrar el deposito";
					return deposito;
				}

			}
			catch (Exception ex)
			{
				deposito.HuboError = true;
				deposito.Mensaje = $"Hubo una excepción al mostrar el deposito: {ex.Message}";
				return deposito;
			}
		}
		
		public DepositoDTO ModificarDeposito(DepositoDTO depositoDTOAModificar)
		{
			try
			{
				Deposito depositoAuxiliar = depositoDTOAModificar.GetDeposito(depositoDTOAModificar);
				int r = depositoRepository.UpdateDeposito(depositoAuxiliar);

				if (r == 1)
				{
					depositoDTOAModificar.Mensaje = "Deposito Modificado";
					return depositoDTOAModificar;
				}
				else
				{
					depositoDTOAModificar.Mensaje = "No se pudo modificar el Deposito";
					return depositoDTOAModificar;
				}

			}
			catch (Exception ex)
			{
				depositoDTOAModificar.HuboError = true;
				depositoDTOAModificar.Mensaje = $"Hubo una excepción modificando el deposito: {ex.Message}";
				return depositoDTOAModificar;
			}
		}

		public string EliminarDepositoSeleccionado(int depositoAEliminar)
		{
			int r = depositoRepository.EliminarDeposito(depositoAEliminar);

			if (r == 1)
			{
				return "Deposito eliminado";
			}
			else
			{
				return "No se pudo eliminar el deposito";
			}
		}


	}
}
