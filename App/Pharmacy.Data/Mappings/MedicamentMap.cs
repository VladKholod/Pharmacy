using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Core;

namespace Pharmacy.Data.Mappings
{
    public class MedicamentMap : EntityTypeConfiguration<Medicament>
    {
        public MedicamentMap()
        {
            this.HasKey(m => m.Id);

            this.Property(m => m.Name)
                .IsRequired();
            this.Property(m => m.SerialNumber)
                .IsRequired();
            this.Property(m => m.Description)
                .IsRequired();
            this.Property(m => m.Price)
                .IsOptional();
            this.Property(m => m.ModifiedDate)
                .IsOptional();

            this.ToTable("Medicament");
        }
    }
}
