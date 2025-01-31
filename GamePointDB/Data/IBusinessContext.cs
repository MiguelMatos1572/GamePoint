using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamePointDB.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamePointDB.Data
{
    public interface IBusinessContext
    {
        public DbSet<Product> Products { get; set; }
    }
}
