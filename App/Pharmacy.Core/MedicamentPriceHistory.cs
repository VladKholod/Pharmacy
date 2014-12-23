using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Core
{
    public class MedicamentPriceHistory : BaseEntity
    {
        public decimal Price { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int MedicamentId { get; set; }

        public virtual Medicament Medicament { get; set; }
    }
}
