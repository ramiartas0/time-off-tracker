using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time_Off_Tracker.Entity.Concrete;

namespace Time_Off_Tracker.DAL.Concrete
{
    public class ApiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EIUMLNI\\SQLEXPRESS;Database=db_TimeOffTracker;TrustServerCertificate=True;  Integrated Security = True;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
    }
}
