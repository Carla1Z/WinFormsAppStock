﻿using CodigoComun.Datos;
using CodigoComun.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoComun.Repository
{
    public class ArticuloRepository
    {
        private AccesoDatos ac = new AccesoDatos();

        public int AddArticuloDB(Articulo articuloAAgregar)
        {
            string query = $"insert into Articulos (Nombre, Marca, MinimoStock, Proveedor, Precio, Codigo)";
            query += $"values('{articuloAAgregar.Nombre}', '{articuloAAgregar.Marca}', '{articuloAAgregar.MinimoStock}', '{articuloAAgregar.Proveedor}', '{articuloAAgregar.Precio}', '{articuloAAgregar.Codigo}') ";
            try
            {
                SqlCommand command = new SqlCommand(query);
                int r = ac.ejecQueryDevuelveInt(command);
                return r;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                ac.DesConectar();
            }
        }

        public Articulo GetArticuloPorCodigo(string articuloABuscar)
        {
            try
            {
                string select = $"select * from Articulos where Codigo={articuloABuscar}";
                SqlCommand command = new SqlCommand(select);
                DataTable dt = ac.execDT(command);


                if (dt.Rows.Count <= 0)
                {
                    return null;
                }

                Articulo articuloADevolverConDatosDeLaBD = new Articulo();
                foreach (DataRow dr in dt.Rows)
                {
                    articuloADevolverConDatosDeLaBD.Id = Convert.ToInt32(dr["Id"]);
                    articuloADevolverConDatosDeLaBD.Nombre = dr["Nombre"].ToString();
                    articuloADevolverConDatosDeLaBD.Marca = dr["Marca"].ToString();
                    articuloADevolverConDatosDeLaBD.MinimoStock = Convert.ToDecimal(dr["MinimoStock"]);
                    articuloADevolverConDatosDeLaBD.Proveedor = dr["Proveedor"].ToString();
                    articuloADevolverConDatosDeLaBD.Precio = (float)Convert.ToDecimal(dr["Precio"]);
                    articuloADevolverConDatosDeLaBD.Codigo = dr["Codigo"].ToString();
                }

                return articuloADevolverConDatosDeLaBD;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                ac.DesConectar();
            }
        }


        public int UpdateArticuloDB(Articulo articuloAActualizar)
        {
            string minStockComaPorPunto = articuloAActualizar.MinimoStock.ToString();
            minStockComaPorPunto = minStockComaPorPunto.Replace(",", ".");

            string precioComaPorPunto = articuloAActualizar.Precio.ToString();
            precioComaPorPunto = precioComaPorPunto.Replace(",", ".");


            string query = $"update Articulos set Nombre = '{articuloAActualizar.Nombre}', " +
                $"Marca =' {articuloAActualizar.Marca}', " +
                $"MinimoStock = '{minStockComaPorPunto}', " +
                $"Proveedor = '{articuloAActualizar.Proveedor}', " +
                $"Precio = '{precioComaPorPunto}'," +
                $"Codigo = {articuloAActualizar.Codigo} " +
                $"where id = {articuloAActualizar.Id}";
            try
            {
                SqlCommand command = new SqlCommand(query);
                int r = ac.ejecQueryDevuelveInt(command);
                return r;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                ac.DesConectar();
            }
        }


        public int DeleteArticuloDB(Articulo articuloAEliminar)
        {
            string query = $"delete Articulos where id={articuloAEliminar.Id}";
            try
            {
                SqlCommand command = new SqlCommand(query);
                int r = ac.ejecQueryDevuelveInt(command);
                return r;
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                ac.DesConectar();
            }
        }

    }
}
