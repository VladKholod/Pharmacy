using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Core;

namespace Pharmacy.Data.Mappings
{
    public class OrderDetailsMap :EntityTypeConfiguration<OrderDetails>
    {
        public OrderDetailsMap()
        {
            this.HasKey(od => new {OrderId = od.OrderId, MedicamentId = od.MedicamentId});

            this.Property(od => od.OrderId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(od => od.MedicamentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(od => od.Quantity)
                .IsRequired();
            this.Property(od => od.Price)
                .IsRequired();

            this.HasRequired<Order>(od=>od.Order)
                .WithMany(o=>o.OrderDetailses)
                .HasForeignKey(od=>od.OrderId)
                .WillCascadeOnDelete(false);
            this.HasRequired<Medicament>(od => od.Medicament)
                .WithMany(m => m.OrderDetailses)
                .HasForeignKey(od => od.MedicamentId)
                .WillCascadeOnDelete(false);

            this.ToTable("OrderDetails");
        }
    }
}
