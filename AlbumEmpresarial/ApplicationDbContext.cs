using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace AlbumEmpresarial
{
    public class ApplicationDbContext : DbContext
    {
        

        private const string connection = @"Database=adminimagenes;Data Source=127.0.0.1;User Id=root;Password=";
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public ApplicationDbContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(connection);
            }
        }
        public DbSet<Fotos> Fotos { get; set; }
    }
}
