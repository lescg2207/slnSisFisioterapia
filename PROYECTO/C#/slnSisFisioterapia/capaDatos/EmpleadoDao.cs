using entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaDatos
{
    public class EmpleadoDao
    {
        private readonly DbContext _dbContext;

        public EmpleadoDao(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Empleado> ObtenerEmpleado()
        {
            var empleados = _dbContext.Set<Empleado>()
        .Select(e => new Empleado
        {
            IdEmpleado = e.IdEmpleado,
            Nombres = e.Nombres + " " + e.Apellidos
        })
        .ToList();

            return empleados;
        }

        public List<ListaEmpleadoCargo> ListaEmpleadoCargo()
        {
           
            var EmpleadoCargo = (from e in _dbContext.Set<Empleado>()join c in _dbContext.Set<Cargo>() on e.IdCargo equals c.idCargo select new ListaEmpleadoCargo { 
                CODIGO=e.IdEmpleado,
                NOMBRE= e.Nombres,
                APELLIDOS=e.Apellidos,
                USUARIO=e.Usuario,
                CARGO=c.cargo,
                IDCARGO=e.IdCargo,
                CONTRASEÑA=e.Contraseña,
            }).ToList();

            return EmpleadoCargo;
        }

        public List<Cargo> ObtenerEmpleadoCargo()
        {
            var cargo = _dbContext.Set<Cargo>()
        .Select(e => new Cargo
        {
            idCargo=e.idCargo,
            cargo=e.cargo,
        })
        .ToList();

            return cargo;
        }

        public void InsertarEmpleado(Empleado Emple)
        {

            _dbContext.Set<Empleado>().Add(Emple);
            _dbContext.SaveChanges();
        }

        public void ActualizarEmpleado(Empleado emple)
        {

            var empleadoExistente = _dbContext.Set<Empleado>().Find(emple.IdEmpleado);

            if (empleadoExistente != null)
            {

                empleadoExistente.Nombres = emple.Nombres;
                empleadoExistente.Apellidos = emple.Apellidos;
                empleadoExistente.Usuario = emple.Usuario;
                empleadoExistente.Contraseña = emple.Contraseña;
                empleadoExistente.IdCargo = emple.IdCargo;

                _dbContext.SaveChanges();
            }
        }

        public List<ListaEmpleadoCargo> BuscarEmpleadoCargo(string cargo)
        {

            var EmpleadoCargo = (from e in _dbContext.Set<Empleado>()
                                 join c in _dbContext.Set<Cargo>() on e.IdCargo equals c.idCargo
                                 where c.cargo.StartsWith(cargo)
                                 select new ListaEmpleadoCargo
                                 {
                                     CODIGO = e.IdEmpleado,
                                     NOMBRE = e.Nombres,
                                     APELLIDOS = e.Apellidos,
                                     USUARIO = e.Usuario,
                                     CARGO = c.cargo,
                                     IDCARGO = e.IdCargo,
                                     CONTRASEÑA = e.Contraseña,
                                 }).ToList();

            return EmpleadoCargo;
        }
        public List<ListaEmpleadoCargo> BuscarEmpleadoNombre(string nombre)
        {

            var EmpleadoCargo = (from e in _dbContext.Set<Empleado>()
                                 join c in _dbContext.Set<Cargo>() on e.IdCargo equals c.idCargo
                                 where e.Nombres.StartsWith(nombre)
                                 select new ListaEmpleadoCargo
                                 {
                                     CODIGO = e.IdEmpleado,
                                     NOMBRE = e.Nombres,
                                     APELLIDOS = e.Apellidos,
                                     USUARIO = e.Usuario,
                                     CARGO = c.cargo,
                                     IDCARGO = e.IdCargo,
                                     CONTRASEÑA = e.Contraseña,
                                 }).ToList();

            return EmpleadoCargo;
        }

    }
}
