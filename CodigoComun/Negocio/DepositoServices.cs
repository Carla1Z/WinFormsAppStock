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

        public List<Deposito> TodosLosDepositos()
        {
            return depositoRepository.GetTodosLosDepositos();
        }

        public Deposito depositoPorId(int idDeposito)
        {
            DepositoRepository repository = new DepositoRepository();
            Deposito depositoEnDB = repository.GetDepositoPorId(idDeposito);
            return depositoEnDB;
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


        public string ModificarDeposito(Deposito depositoAModificar)
        {
            DepositoRepository repository = new DepositoRepository();

            int r = repository.UpdateDeposito(depositoAModificar);

            if (r == 1)
            {
                return "Deposito Modificado";
            }
            else
            {
                return "No se pudo modificar el Deposito";
            }

        }

    }
}
