using entidades;
using entidades.Vistas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class ProductosDao
    {
        private readonly DbContext _dbContext;

        public ProductosDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public void InsertarProducto(Productos Producto)
        {
            _dbContext.Set<Productos>().Add(Producto);
            _dbContext.SaveChanges();
        }

        public void EliminarProducto(Productos idProducto)
        {
            var producto = _dbContext.Set<Productos>().Find(idProducto.idProducto);
            if (producto != null)
            {
                _dbContext.Set<Productos>().Remove(producto);
                _dbContext.SaveChanges();
            }
        }

        public void ActualizarProducto(Productos producto)
        {
            var productoexistente = _dbContext.Set<Productos>().Find(producto.idProducto);

            if (productoexistente != null)
                {
                   productoexistente.nomProducto = producto.nomProducto;
                   productoexistente.precio = producto.precio;
                   productoexistente.stock = producto.stock;

                   _dbContext.SaveChanges();
                }
        }

        public List<ListaProductos> ObtenerProductos()
        {
            var prod = (from e in _dbContext.Set<Productos>()
                        select new ListaProductos
                        {
                            CODIGO = e.idProducto,
                            PRODUCTO = e.nomProducto,
                            PRECIO =Convert.ToDecimal( e.precio.ToString("0.00")),
                            STOCK = e.stock
                        }).ToList();

            return prod;
        }

        public List<ListaProductos> BuscarProdNombre(string nombre)
        {

            var ProductoList = (from p in _dbContext.Set<Productos>()
                                 where p.nomProducto.StartsWith(nombre)
                                 select new ListaProductos
                                 {
                                     CODIGO = p.idProducto,
                                     NOMBRE = p.nomProducto,
                                     PRECIO = Convert.ToDecimal(p.precio.ToString("0.00")),
                                     STOCK = p.stock
                                 }).ToList();

            return ProductoList;
        }
    }
}
