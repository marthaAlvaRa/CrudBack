using CrudRecibos_VF.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace CrudRecibos_VF.Context
{
    public class AppUsuarioContext : DbContext
    {
            public AppUsuarioContext(DbContextOptions<AppUsuarioContext> options) : base(options)
            {

            }

            public DbSet<Usuarios> Usuario { get; set; }
        }
    }

