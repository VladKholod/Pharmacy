using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Data.Mappings
{
    public class PharmacyMap : EntityTypeConfiguration<Core.Pharmacy>
    {
        public PharmacyMap()
        {
            this.HasKey(p => p.Id);

            this.Property(p => p.Address)
                .IsRequired();
            this.Property(p => p.Number)
                .IsRequired();
            this.Property(p => p.Phone)
                .IsRequired();
            this.Property(p => p.OpenDate)
                .IsRequired();

            this.ToTable("Pharmacy");
        }
    }
}
