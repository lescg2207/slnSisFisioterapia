using capaDatos;
using entidades;
using entidades.Vistas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class ProductosBll
    {
        private readonly string _providerName;
        private readonly string _connectionString;
        private readonly ProductosDao _productosDao;

        public ProductosBll(string providerName, string connectionString)
        {
            _providerName = providerName;
            _connectionString = connectionString;
            _productosDao = new ProductosDao(CreateDbContext());
        }
        private DbContext CreateDbContext()
        {
            DbContextOptionsBuilder<ConexionBd> optionsBuilder = new DbContextOptionsBuilder<ConexionBd>();

            switch (_providerName)
            {
                case "SqlServer":
                    optionsBuilder.UseSqlServer(_connectionString);
                    break;
                case "MySql":
                    optionsBuilder.UseMySql(_connectionString, new MySqlServerVersion(new Version(8, 0, 32)));
                    break;
                default:
                    break;
            }

            return new ConexionBd(optionsBuilder.Options, _providerName, _connectionString);
        }

        public void InsertarProducto(Productos nuevoProducto)
        {
            _productosDao.InsertarProducto(nuevoProducto);
        }

        public void ActualizarProducto(Productos updateProducto)
        {
            _productosDao.ActualizarProducto(updateProducto);
        }

        public List<ListaProductos> ObtenerProductos()
        {
            return _productosDao.ObtenerProductos();
        }

        public void EliminarProducto(Productos idProducto)
        {
            _productosDao.EliminarProducto(idProducto);
        }

        public List<ListaProductos> BuscarProdNombre(string nombre)
        {
            return _productosDao.BuscarProdNombre(nombre);
        }
    }
}
