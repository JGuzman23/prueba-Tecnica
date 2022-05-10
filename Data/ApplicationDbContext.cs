﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ordenes.Models;
using Ordenes.ViewModels;

namespace Ordenes.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        public DbSet<Orden> Ordenes { get; set; }

        public DbSet<Productos> Productos { get; set; }

        public DbSet<Ordenes.ViewModels.OrdenesViewModel> OrdenesViewModel { get; set; }
    }
}
