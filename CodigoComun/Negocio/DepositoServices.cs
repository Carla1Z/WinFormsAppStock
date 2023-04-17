using CodigoComun.Entities;
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

        public string AgregarDeposito(Deposito depositoAAgregar)
        {
            int r = depositoRepository.AddDeposito(depositoAAgregar);

            if (r == 1)
            {
                return "Deposito Agregado";
            }
            else
            {
                return "No se pudo agregar el deposito";
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


        public string EliminarDepositoSeleccionado(Deposito depositoAEliminar)
        {
            int r = depositoRepository.EliminarDeposito(depositoAEliminar.Id);

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
