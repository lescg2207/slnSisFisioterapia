﻿using capaDatos;
using entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaNegocios
{
    public class DetalleCitaBll
    {
        private readonly string _providerName;
        private readonly string _connectionString;
        private readonly DetalleCitaDao _detalleDao;

        public DetalleCitaBll(string providerName, string connectionString)
        {
            _providerName = providerName;
            _connectionString = connectionString;
            _detalleDao = new DetalleCitaDao(CreateDbContext());
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

        public void InsertarDetalle(DetalleCita detCita)
        {
            _detalleDao.InsertarDetalle(detCita);
        }

    }
}
