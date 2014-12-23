using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Core;

namespace Pharmacy.Data.Mappings
{
    public class MedicamentPriceHistoryMap : EntityTypeConfiguration<MedicamentPriceHistory>
    {
        public MedicamentPriceHistoryMap()
        {
            this.HasKey(mph => mph.Id);

            this.Property(mph => mph.Price)
                .IsRequired();
            this.Property(mph => mph.ModifiedDate)
                .IsRequired();
            this.Property(mph => mph.MedicamentId)
                .IsRequired();

            this.HasRequired<Medicament>(mph=>mph.Medicament)
                .WithMany(m=>m.MedicinePriceHistories)
                .HasForeignKey(mph=>mph.MedicamentId)
                .WillCascadeOnDelete(true);

            this.ToTable("MedicamentPriceHistory");
        }
    }
}
