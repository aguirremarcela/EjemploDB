using EntityFrameworkDB.Data.Models;
using EntityFrameworkDB.Data.Seeds;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EntityFrameworkDB.Data
{
    public  class DataDBContext :DbContext
    {
       
        //Constructor
       
        DbSet<Persons> Persons { get; set; }
        DbSet<Receipts> Receipts { get; set; }

        DbSet<Aliquots> Aliquots { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //aca puedo ingresar el nombre con que quiero crear las tablas y en la tabla Aliquots le di precision
            modelBuilder.Entity<Persons>().ToTable("Person");
            modelBuilder.Entity<Receipts>().ToTable("Receipt");
            modelBuilder.Entity<Aliquots>().ToTable("Aliquot").Property(b => b.Percentaje).HasPrecision(9,4);
            // aca se puede agregar datos iniciales 
            modelBuilder.ApplyConfiguration(new PersonsSeed());
        }

        //Ahora nos queda configurar la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-BQRSV0H;Database=DBEjemplo;user=sa; password=Antonieta12; TrustServerCertificate=True;");
        }
 
        
    }
}
