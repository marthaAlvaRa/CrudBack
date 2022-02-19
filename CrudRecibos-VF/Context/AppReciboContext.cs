using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudRecibos_VF.Models;
using Microsoft.EntityFrameworkCore;



namespace CrudRecibos_VF.Context
{
    public class AppReciboContext : DbContext
    {
        public AppReciboContext(DbContextOptions<AppReciboContext> options) : base(options)
        {

        }

        public DbSet<Recibos> Recibos { get; set; }
    }
}
