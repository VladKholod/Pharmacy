using Pharmacy.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Core
{
    public class Storage : IDbEntity
    {
        public int MedicamentId { get; set; }
        public int PharmacyId { get; set; }
        public int Quantity { get; set; }

        public virtual Pharmacy Pharmacy { get; set; }
        public virtual Medicament Medicament { get; set; }
    }
}
