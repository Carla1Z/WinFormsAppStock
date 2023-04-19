using CodigoComun.Modelos;
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
        public string AgregarArticulo(Articulo articuloAAgregar)
        {
            ArticuloRepository articuloRepository = new ArticuloRepository();

            //verifico antes de agregar articulo
            Articulo articuloAuxiliar = articuloRepository.GetArticuloPorCodigo(articuloAAgregar.Codigo);

            if (articuloAuxiliar != null)
            {
                return $"Ya existe un articulo con el codigo {articuloAAgregar.Codigo}";
            }



            int r = articuloRepository.AddArticuloDB(articuloAAgregar);

            if (r == 1)
            {
                return "Articulo Agregado";
            }
            else
            {
                return "No se pudo agregar el articulo";
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
