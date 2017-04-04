using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WorkLibrary
{
    class WorkDbContext : DbContext
    {
        public DbSet<WorkDay> WorkDayTable { get; set; }
        public DbSet<StockTask> StockItemTable { get; set; }

        public DbSet<Product> ProductTabel { get; set; }
    }
}
