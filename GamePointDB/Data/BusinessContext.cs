using GamePointDB.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePointDB.Data
{
    public class BusinessContext : DbContext, IBusinessContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SQL6033.site4now.net;Initial Catalog=db_ab245f_miguelmatos001;User Id=db_ab245f_miguelmatos001_admin;Password=G4m3p01nt");
        }
    }

}
