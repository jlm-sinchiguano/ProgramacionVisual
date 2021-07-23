using System;
using System.Collections.Generic;
using System.Text;
using JennySinchiguanoExamenWeb.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JennySinchiguanoExamenWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            public DbSet<Estudiante> Estudiantes { get; set; }
            public DbSet<Pareja> Parejas { get; set; }
    
    }
}
