using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyDBProject.Models
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions Option) : base(Option)
        {

        }
        public DbSet<Bank> Banks { get; set; }
    }
}
