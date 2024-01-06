using InfoEntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace DataAccessLayer
{
    public class AplicationContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public AplicationContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<InfoData> InfoDatas { get; set; }
        public DbSet<InfoData> InfoDatasa { get; set; }
    }
}


