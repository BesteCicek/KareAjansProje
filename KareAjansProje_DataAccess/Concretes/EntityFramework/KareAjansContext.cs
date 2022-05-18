using KareAjansProje_Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjansProje_DataAccess.Concretes.EntityFramework
{
    public class KareAjansContext : DbContext
    {
        public DbSet<Manken> Mankens { get; set; }
        public DbSet<Kategori> Kategoris { get; set; }
        public DbSet<Organizasyon> Organizasyons { get; set; }
        [Key]
        public DbSet<OrganizasyonManken> OrganizasyonMankens { get; set; }
        public DbSet<Sehir> Sehirs { get; set; }
        public DbSet<AyakkabiNo> AyakkabiNos { get; set; }
        public DbSet<GozRengi> GozRengis { get; set; }
        public DbSet<SacRengi> SacRengis { get; set; }
        public DbSet<Beden> Bedens { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<KareAjansContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}
