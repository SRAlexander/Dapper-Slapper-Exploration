using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;
using DAL.Models;

namespace DAL
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<LogEntry> ActionLog { get; set; }
    }

}