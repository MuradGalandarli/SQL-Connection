using InfoEntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
namespace DataAccessLayer
{
    public class AplicationContext : DbContext
    {
        readonly string _connectionString;


        *//*public AplicationContext(string connectionString)
        {
            _connectionString = connectionString;
        }*//*

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MSI1S2I;database=Agile_Task;Integrated Security=true");
        }

        public DbSet<InfoData> InfoDatas { get; set; }

    }
}
*/

using Microsoft.EntityFrameworkCore;
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
           
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<InfoData> InfoDatas { get; set; }
    }
}


