using Entities.Entitities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions<ContextBase>options): base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer(GetStringConnectionConfig());
                base.OnConfiguring(optionBuilder);
            }
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "Data Source=RODRIGO;Initial Catalog=DDD_ECOMMERCE;Integrated Security=False;User ID=admin; password=0Scur@93; Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }
    }
}
