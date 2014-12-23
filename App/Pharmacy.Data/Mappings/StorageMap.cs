﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pharmacy.Core;

namespace Pharmacy.Data.Mappings
{
    public class StorageMap : EntityTypeConfiguration<Storage>
    {
        public StorageMap()
        {
            this.HasKey(s => new {PharmacyId = s.PharmacyId, MedicamentId = s.MedicamentId});

            this.Property(s => s.PharmacyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(s => s.MedicamentId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            this.Property(s => s.Quantity)
                .IsRequired();

            this.HasRequired<Core.Pharmacy>(s => s.Pharmacy)
                .WithMany(p => p.Storages)
                .HasForeignKey(s => s.PharmacyId)
                .WillCascadeOnDelete(false);

            this.HasRequired<Medicament>(s => s.Medicament)
                .WithMany(m => m.Storages)
                .HasForeignKey(s => s.MedicamentId)
                .WillCascadeOnDelete(false);

            this.ToTable("Storage");
        }
    }
}
