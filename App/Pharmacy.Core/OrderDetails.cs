using Pharmacy.Contracts.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Core
{
    public class OrderDetails : IDbEntity
    {
        public int OrderId { get; set; }
        public int MedicamentId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Medicament Medicament { get; set; }
    }
}
