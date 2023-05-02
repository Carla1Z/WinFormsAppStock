using CodigoComun.Datos;
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


        //public List<Articulo> GetTodosLosArticulos()
        //{
        //    try
        //    {
        //        string select = $"select * from Articulos ";
        //        SqlCommand command = new SqlCommand(select);
        //        DataTable dt = ac.execDT(command);

        //        if (dt.Rows.Count <= 0)
        //        {
        //            return null;
        //        }

        //        List<Articulo> articulosADevolverConDatosDeLaBD = new List<Articulo>();
        //        foreach (DataRow dr in dt.Rows)
        //        {
        //            Articulo ArticuloAuxiliar = new Articulo();
        //            ArticuloAuxiliar.Id = Convert.ToInt32(dr["Id"]);
        //            ArticuloAuxiliar.Nombre = dr["Nombre"].ToString();
        //            ArticuloAuxiliar.Marca = dr["Marca"].ToString();
        //            ArticuloAuxiliar.MinimoStock = Convert.ToDecimal(dr["MinimoStock"]);
        //            ArticuloAuxiliar.Proveedor = dr["Proveedor"].ToString();
        //            ArticuloAuxiliar.Precio = (float)Convert.ToDecimal(dr["Precio"]);
        //            ArticuloAuxiliar.Codigo = dr["Codigo"].ToString();
        //            //agrego a la lista
        //            articulosADevolverConDatosDeLaBD.Add(ArticuloAuxiliar);
        //        }

        //        return articulosADevolverConDatosDeLaBD;
        //    }
        //    catch (Exception ex)
        //    {

        //        return null;
        //    }
        //    finally
        //    {
        //        ac.DesConectar();
        //    }
        //}




    }
}
