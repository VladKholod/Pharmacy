using Pharmacy.Core;
using Pharmacy.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Medicament> Medicines{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetailses { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<MedicamentPriceHistory> MedcinePriceHistories { get; set; }
        public DbSet<Core.Pharmacy> Pharmacies { get; set; }

        public DataContext()
            : base("PharmacyDb")
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StorageMap());
            modelBuilder.Configurations.Add(new MedicamentMap());
            modelBuilder.Configurations.Add(new MedicamentPriceHistoryMap());
            modelBuilder.Configurations.Add(new OrderDetailsMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new PharmacyMap());
        }
    }
}
