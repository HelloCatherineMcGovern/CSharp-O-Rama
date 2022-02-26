using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using homework2patient.Models;
using homework2DbContext.Models;

namespace homework2DbContext.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
                    }
        public DbSet<Patient> Patients { get; set; }
    }
}